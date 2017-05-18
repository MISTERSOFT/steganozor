namespace steganography
{
    partial class Steganozor
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHideImg = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.tbSaveDst = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSrc = new System.Windows.Forms.Button();
            this.tbSrc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHost = new System.Windows.Forms.Button();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tabPageDetection = new System.Windows.Forms.TabPage();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogDst = new System.Windows.Forms.FolderBrowserDialog();
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trackBarShiftLevel = new System.Windows.Forms.TrackBar();
            this.tabControl1.SuspendLayout();
            this.tabPageHideImg.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShiftLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHideImg);
            this.tabControl1.Controls.Add(this.tabPageDetection);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageHideImg
            // 
            this.tabPageHideImg.Controls.Add(this.groupBox4);
            this.tabPageHideImg.Controls.Add(this.groupBox3);
            this.tabPageHideImg.Controls.Add(this.btnRun);
            this.tabPageHideImg.Controls.Add(this.groupBox2);
            this.tabPageHideImg.Controls.Add(this.groupBox1);
            this.tabPageHideImg.Location = new System.Drawing.Point(4, 22);
            this.tabPageHideImg.Name = "tabPageHideImg";
            this.tabPageHideImg.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageHideImg.Size = new System.Drawing.Size(617, 385);
            this.tabPageHideImg.TabIndex = 0;
            this.tabPageHideImg.Text = "Hide image";
            this.tabPageHideImg.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbFilename);
            this.groupBox3.Controls.Add(this.btnSelectPath);
            this.groupBox3.Controls.Add(this.tbSaveDst);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(10, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(597, 73);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Save destination*";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(497, 17);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(94, 23);
            this.btnSelectPath.TabIndex = 2;
            this.btnSelectPath.Text = "Select path...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // tbSaveDst
            // 
            this.tbSaveDst.Enabled = false;
            this.tbSaveDst.Location = new System.Drawing.Point(6, 19);
            this.tbSaveDst.Name = "tbSaveDst";
            this.tbSaveDst.Size = new System.Drawing.Size(485, 20);
            this.tbSaveDst.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(10, 352);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(597, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSrc);
            this.groupBox2.Controls.Add(this.tbSrc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(10, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 52);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image to hide*";
            // 
            // btnSrc
            // 
            this.btnSrc.Location = new System.Drawing.Point(497, 17);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(94, 23);
            this.btnSrc.TabIndex = 2;
            this.btnSrc.Text = "Select image...";
            this.btnSrc.UseVisualStyleBackColor = true;
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // tbSrc
            // 
            this.tbSrc.Location = new System.Drawing.Point(6, 19);
            this.tbSrc.Name = "tbSrc";
            this.tbSrc.Size = new System.Drawing.Size(485, 20);
            this.tbSrc.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHost);
            this.groupBox1.Controls.Add(this.tbHost);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Host image*";
            // 
            // btnHost
            // 
            this.btnHost.Location = new System.Drawing.Point(497, 17);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(94, 23);
            this.btnHost.TabIndex = 2;
            this.btnHost.Text = "Select image...";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(6, 19);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(485, 20);
            this.tbHost.TabIndex = 1;
            // 
            // tabPageDetection
            // 
            this.tabPageDetection.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetection.Name = "tabPageDetection";
            this.tabPageDetection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetection.Size = new System.Drawing.Size(617, 227);
            this.tabPageDetection.TabIndex = 1;
            this.tabPageDetection.Text = "Detection";
            this.tabPageDetection.UseVisualStyleBackColor = true;
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialog1";
            // 
            // tbFilename
            // 
            this.tbFilename.Location = new System.Drawing.Point(162, 45);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(429, 20);
            this.tbFilename.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Give a name to the result file : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trackBarShiftLevel);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(10, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(597, 73);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Shift level";
            // 
            // trackBarShiftLevel
            // 
            this.trackBarShiftLevel.Location = new System.Drawing.Point(6, 22);
            this.trackBarShiftLevel.Name = "trackBarShiftLevel";
            this.trackBarShiftLevel.Size = new System.Drawing.Size(585, 45);
            this.trackBarShiftLevel.TabIndex = 0;
            // 
            // Steganozor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 411);
            this.Controls.Add(this.tabControl1);
            this.Name = "Steganozor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stegano";
            this.tabControl1.ResumeLayout(false);
            this.tabPageHideImg.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShiftLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHideImg;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbSrc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TabPage tabPageDetection;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.Button btnHost;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox tbSaveDst;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilename;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBarShiftLevel;
    }
}

