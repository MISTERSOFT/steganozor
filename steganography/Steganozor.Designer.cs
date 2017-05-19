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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarShiftLevel = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilename = new System.Windows.Forms.TextBox();
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
            this.btnRunDetection = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDetectSelectImg = new System.Windows.Forms.Button();
            this.tbDetectImg = new System.Windows.Forms.TextBox();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogDst = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDetectSaveFilename = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSavePathDetect = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarShiftLevelDetect = new System.Windows.Forms.TrackBar();
            this.tabControl1.SuspendLayout();
            this.tabPageHideImg.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShiftLevel)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageDetection.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShiftLevelDetect)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHideImg);
            this.tabControl1.Controls.Add(this.tabPageDetection);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageHideImg
            // 
            this.tabPageHideImg.Controls.Add(this.groupBox4);
            this.tabPageHideImg.Controls.Add(this.groupBox3);
            this.tabPageHideImg.Controls.Add(this.btnRun);
            this.tabPageHideImg.Controls.Add(this.groupBox2);
            this.tabPageHideImg.Controls.Add(this.groupBox1);
            this.tabPageHideImg.Location = new System.Drawing.Point(4, 25);
            this.tabPageHideImg.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageHideImg.Name = "tabPageHideImg";
            this.tabPageHideImg.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageHideImg.Size = new System.Drawing.Size(825, 393);
            this.tabPageHideImg.TabIndex = 0;
            this.tabPageHideImg.Text = "Hide image";
            this.tabPageHideImg.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.trackBarShiftLevel);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(10, 228);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(805, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Shift level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value use to shift bits.";
            // 
            // trackBarShiftLevel
            // 
            this.trackBarShiftLevel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarShiftLevel.Location = new System.Drawing.Point(4, 40);
            this.trackBarShiftLevel.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarShiftLevel.Name = "trackBarShiftLevel";
            this.trackBarShiftLevel.Size = new System.Drawing.Size(797, 56);
            this.trackBarShiftLevel.TabIndex = 0;
            this.trackBarShiftLevel.Scroll += new System.EventHandler(this.trackBarShiftLevel_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbFilename);
            this.groupBox3.Controls.Add(this.btnSelectPath);
            this.groupBox3.Controls.Add(this.tbSaveDst);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 138);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(805, 90);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Save destination*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Give a name to the result file : ";
            // 
            // tbFilename
            // 
            this.tbFilename.Location = new System.Drawing.Point(216, 55);
            this.tbFilename.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(571, 23);
            this.tbFilename.TabIndex = 3;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(663, 21);
            this.btnSelectPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(125, 28);
            this.btnSelectPath.TabIndex = 2;
            this.btnSelectPath.Text = "Select path...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // tbSaveDst
            // 
            this.tbSaveDst.Enabled = false;
            this.tbSaveDst.Location = new System.Drawing.Point(8, 23);
            this.tbSaveDst.Margin = new System.Windows.Forms.Padding(4);
            this.tbSaveDst.Name = "tbSaveDst";
            this.tbSaveDst.Size = new System.Drawing.Size(645, 23);
            this.tbSaveDst.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(10, 346);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(805, 37);
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
            this.groupBox2.Location = new System.Drawing.Point(10, 74);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(805, 64);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image to hide*";
            // 
            // btnSrc
            // 
            this.btnSrc.Location = new System.Drawing.Point(663, 21);
            this.btnSrc.Margin = new System.Windows.Forms.Padding(4);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(125, 28);
            this.btnSrc.TabIndex = 2;
            this.btnSrc.Text = "Select image...";
            this.btnSrc.UseVisualStyleBackColor = true;
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // tbSrc
            // 
            this.tbSrc.Location = new System.Drawing.Point(8, 23);
            this.tbSrc.Margin = new System.Windows.Forms.Padding(4);
            this.tbSrc.Name = "tbSrc";
            this.tbSrc.Size = new System.Drawing.Size(645, 22);
            this.tbSrc.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHost);
            this.groupBox1.Controls.Add(this.tbHost);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(805, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Host image*";
            // 
            // btnHost
            // 
            this.btnHost.Location = new System.Drawing.Point(663, 21);
            this.btnHost.Margin = new System.Windows.Forms.Padding(4);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(125, 28);
            this.btnHost.TabIndex = 2;
            this.btnHost.Text = "Select image...";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(8, 23);
            this.tbHost.Margin = new System.Windows.Forms.Padding(4);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(645, 22);
            this.tbHost.TabIndex = 1;
            // 
            // tabPageDetection
            // 
            this.tabPageDetection.Controls.Add(this.groupBox8);
            this.tabPageDetection.Controls.Add(this.groupBox7);
            this.tabPageDetection.Controls.Add(this.btnRunDetection);
            this.tabPageDetection.Controls.Add(this.groupBox5);
            this.tabPageDetection.Location = new System.Drawing.Point(4, 25);
            this.tabPageDetection.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageDetection.Name = "tabPageDetection";
            this.tabPageDetection.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageDetection.Size = new System.Drawing.Size(825, 393);
            this.tabPageDetection.TabIndex = 1;
            this.tabPageDetection.Text = "Detection";
            this.tabPageDetection.UseVisualStyleBackColor = true;
            // 
            // btnRunDetection
            // 
            this.btnRunDetection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRunDetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunDetection.Location = new System.Drawing.Point(10, 346);
            this.btnRunDetection.Margin = new System.Windows.Forms.Padding(4);
            this.btnRunDetection.Name = "btnRunDetection";
            this.btnRunDetection.Size = new System.Drawing.Size(805, 37);
            this.btnRunDetection.TabIndex = 9;
            this.btnRunDetection.Text = "Detect";
            this.btnRunDetection.UseVisualStyleBackColor = true;
            this.btnRunDetection.Click += new System.EventHandler(this.btnRunDetection_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDetectSelectImg);
            this.groupBox5.Controls.Add(this.tbDetectImg);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(10, 10);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(805, 64);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Image*";
            // 
            // btnDetectSelectImg
            // 
            this.btnDetectSelectImg.Location = new System.Drawing.Point(663, 21);
            this.btnDetectSelectImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetectSelectImg.Name = "btnDetectSelectImg";
            this.btnDetectSelectImg.Size = new System.Drawing.Size(125, 28);
            this.btnDetectSelectImg.TabIndex = 2;
            this.btnDetectSelectImg.Text = "Select image...";
            this.btnDetectSelectImg.UseVisualStyleBackColor = true;
            this.btnDetectSelectImg.Click += new System.EventHandler(this.btnDetectSelectImg_Click);
            // 
            // tbDetectImg
            // 
            this.tbDetectImg.Location = new System.Drawing.Point(8, 23);
            this.tbDetectImg.Margin = new System.Windows.Forms.Padding(4);
            this.tbDetectImg.Name = "tbDetectImg";
            this.tbDetectImg.Size = new System.Drawing.Size(645, 22);
            this.tbDetectImg.TabIndex = 1;
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialog1";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.tbDetectSaveFilename);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.tbSavePathDetect);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(10, 74);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(805, 90);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Save destination*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Give a name to the result file : ";
            // 
            // tbDetectSaveFilename
            // 
            this.tbDetectSaveFilename.Location = new System.Drawing.Point(216, 55);
            this.tbDetectSaveFilename.Margin = new System.Windows.Forms.Padding(4);
            this.tbDetectSaveFilename.Name = "tbDetectSaveFilename";
            this.tbDetectSaveFilename.Size = new System.Drawing.Size(571, 23);
            this.tbDetectSaveFilename.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select path...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // tbSavePathDetect
            // 
            this.tbSavePathDetect.Enabled = false;
            this.tbSavePathDetect.Location = new System.Drawing.Point(8, 23);
            this.tbSavePathDetect.Margin = new System.Windows.Forms.Padding(4);
            this.tbSavePathDetect.Name = "tbSavePathDetect";
            this.tbSavePathDetect.Size = new System.Drawing.Size(645, 23);
            this.tbSavePathDetect.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.trackBarShiftLevelDetect);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(10, 164);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(805, 100);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Shift level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Value use to shift bits.";
            // 
            // trackBarShiftLevelDetect
            // 
            this.trackBarShiftLevelDetect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarShiftLevelDetect.Location = new System.Drawing.Point(4, 40);
            this.trackBarShiftLevelDetect.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarShiftLevelDetect.Name = "trackBarShiftLevelDetect";
            this.trackBarShiftLevelDetect.Size = new System.Drawing.Size(797, 56);
            this.trackBarShiftLevelDetect.TabIndex = 0;
            this.trackBarShiftLevelDetect.Scroll += new System.EventHandler(this.trackBarShiftLevel_Scroll);
            // 
            // Steganozor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 422);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Steganozor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stegano";
            this.tabControl1.ResumeLayout(false);
            this.tabPageHideImg.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShiftLevel)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageDetection.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShiftLevelDetect)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDetectSelectImg;
        private System.Windows.Forms.TextBox tbDetectImg;
        private System.Windows.Forms.Button btnRunDetection;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarShiftLevelDetect;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDetectSaveFilename;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSavePathDetect;
    }
}

