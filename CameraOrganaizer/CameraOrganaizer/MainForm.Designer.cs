namespace CameraOrganaizer {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFilenameTpl = new System.Windows.Forms.Label();
            this.txtTpl = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.NumericUpDown();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.btnDir = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(652, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.Controls.Add(this.lblFilenameTpl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTpl, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPosition, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtStart, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDir, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDir, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(646, 27);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblFilenameTpl
            // 
            this.lblFilenameTpl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFilenameTpl.AutoSize = true;
            this.lblFilenameTpl.Location = new System.Drawing.Point(3, 7);
            this.lblFilenameTpl.Name = "lblFilenameTpl";
            this.lblFilenameTpl.Size = new System.Drawing.Size(95, 13);
            this.lblFilenameTpl.TabIndex = 0;
            this.lblFilenameTpl.Text = "Filename template:";
            // 
            // txtTpl
            // 
            this.txtTpl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTpl.Location = new System.Drawing.Point(107, 3);
            this.txtTpl.Name = "txtTpl";
            this.txtTpl.Size = new System.Drawing.Size(151, 20);
            this.txtTpl.TabIndex = 1;
            this.txtTpl.Text = "photo_{0}";
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(264, 7);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(71, 13);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Start position:";
            // 
            // txtStart
            // 
            this.txtStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStart.Location = new System.Drawing.Point(358, 3);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(51, 20);
            this.txtStart.TabIndex = 3;
            // 
            // txtDir
            // 
            this.txtDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDir.Location = new System.Drawing.Point(415, 3);
            this.txtDir.Name = "txtDir";
            this.txtDir.ReadOnly = true;
            this.txtDir.Size = new System.Drawing.Size(151, 20);
            this.txtDir.TabIndex = 4;
            // 
            // btnDir
            // 
            this.btnDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDir.Location = new System.Drawing.Point(572, 3);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(71, 21);
            this.btnDir.TabIndex = 5;
            this.btnDir.Text = "Directory";
            this.btnDir.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(3, 36);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(646, 223);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "CameraOrganaizer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblFilenameTpl;
        private System.Windows.Forms.TextBox txtTpl;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.NumericUpDown txtStart;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Button btnStart;
    }
}

