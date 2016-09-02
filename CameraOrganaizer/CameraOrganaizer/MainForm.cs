using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CameraOrganaizer {
    public partial class MainForm : Form {
        private string folderName = string.Empty;
        private const String _START_LABEL_TEXT_ = "Start";
        private const String _COMPLETE_TEXT_ = "Complete";

        public MainForm() {
            InitializeComponent();
        }

        #region btnStart_Click
        private void btnStart_Click(object sender, EventArgs e) {
            try {
                this.btnStart.Enabled = false;

                String fileNameTemplate = this.txtTpl.Text.Trim();

                if (String.IsNullOrEmpty(folderName)) {
                    MessageBox.Show(this, "Directory not selected", "Error", MessageBoxButtons.OK);
                } else if (String.IsNullOrEmpty(fileNameTemplate)) {
                    MessageBox.Show(this, "Filename template is undefined", "Error", MessageBoxButtons.OK);
                } else {
                    DirectoryInfo directoryInfo = new DirectoryInfo(folderName);
                    if (!directoryInfo.Exists) {
                        MessageBox.Show(this, "Directory not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    } else {
                        FileInfo[] files = directoryInfo.GetFiles();
                        if (files == null || files.Length == 0) {
                            MessageBox.Show(this, "Directory is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        } else {
                            new Thread(new ParameterizedThreadStart(invokeRename)).Start(files);
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            } finally {
                this.setProgressText(_START_LABEL_TEXT_);
            }
        }
        #endregion

        #region btnDir_Click
        private void btnDir_Click(object sender, EventArgs e) {
            if (this.fldBrowser.ShowDialog() != DialogResult.OK) {
                return;
            }

            folderName = this.txtDir.Text = this.fldBrowser.SelectedPath;
        }
        #endregion

        #region setProgressText
        private void setProgressText(string txt) {
            if (this.btnStart.InvokeRequired) {
                this.BeginInvoke(new Action<String>(setProgressText), txt);
            } else {
                this.btnStart.Enabled = (txt == _START_LABEL_TEXT_);
                this.btnStart.Text = txt;
            }
        }
        #endregion

        #region setMsgText
        private void setMsgText(string txt) {
            if (this.InvokeRequired) {
                this.BeginInvoke(new Action<String>(setMsgText), (object)txt);
            } else {
                MessageBox.Show(this, txt);
            }
        }
        #endregion

        #region invokeRename
        private void invokeRename(object obj) {
            try {
                DirectoryInfo dir = new DirectoryInfo(folderName);
                FileInfo[] targets = obj as FileInfo[];

                // rename filenames
                foreach (FileInfo f in targets) {
                    string destination = Path.Combine(dir.FullName, Guid.NewGuid().ToString("N") + f.Extension);
                    this.setProgressText(String.Format("Rename {0}", f.Name));
                    File.Move(f.FullName, destination);
                    Thread.Sleep(100);
                }

                FileInfo[] files = dir.GetFiles();
                Array.Sort<FileInfo>(files, (Comparison<FileInfo>)((f1, f2) => f1.GetMinDate().CompareTo(f2.GetMinDate())));
                string template = this.txtTpl.Text.Trim();
                int idx = (int)this.txtStart.Value;

                foreach (FileInfo f in files) {
                    String destination = String.Empty;
                    String targetName = String.Empty;

                    if (f.GetMinDate() != DateTime.MinValue) {
                        targetName = String.Format(template, idx) + f.Extension;
                    } else {
                        targetName = String.Format("invalid_{0}.{1}", Guid.NewGuid().ToString("N"), f.Extension);
                    }

                    destination = Path.Combine(dir.FullName, targetName);
                    File.Move(f.FullName, destination);
                    this.setProgressText(String.Format("Write {0}", targetName));
                    Thread.Sleep(100);

                    idx++;
                } 

                this.setMsgText(_COMPLETE_TEXT_);
            } catch (Exception ex) {
                this.setMsgText(ex.Message);
            } finally {
                this.setProgressText(_START_LABEL_TEXT_);
            }
        }
        #endregion
    }
}
