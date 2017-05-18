namespace steganography
{
    partial class Stegano
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
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDst = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSrc = new System.Windows.Forms.TextBox();
            this.tabPageDetection = new System.Windows.Forms.TabPage();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.btnHost = new System.Windows.Forms.Button();
            this.btnSrc = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageHideImg.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(625, 179);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageHideImg
            // 
            this.tabPageHideImg.Controls.Add(this.btnRun);
            this.tabPageHideImg.Controls.Add(this.groupBox2);
            this.tabPageHideImg.Controls.Add(this.groupBox1);
            this.tabPageHideImg.Location = new System.Drawing.Point(4, 22);
            this.tabPageHideImg.Name = "tabPageHideImg";
            this.tabPageHideImg.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageHideImg.Size = new System.Drawing.Size(617, 153);
            this.tabPageHideImg.TabIndex = 0;
            this.tabPageHideImg.Text = "Hide image";
            this.tabPageHideImg.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(10, 120);
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
            this.groupBox2.Controls.Add(this.tbDst);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(10, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 52);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image to hide";
            // 
            // tbDst
            // 
            this.tbDst.Location = new System.Drawing.Point(6, 19);
            this.tbDst.Name = "tbDst";
            this.tbDst.Size = new System.Drawing.Size(485, 20);
            this.tbDst.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHost);
            this.groupBox1.Controls.Add(this.tbSrc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Host image";
            // 
            // tbSrc
            // 
            this.tbSrc.Location = new System.Drawing.Point(6, 19);
            this.tbSrc.Name = "tbSrc";
            this.tbSrc.Size = new System.Drawing.Size(485, 20);
            this.tbSrc.TabIndex = 1;
            // 
            // tabPageDetection
            // 
            this.tabPageDetection.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetection.Name = "tabPageDetection";
            this.tabPageDetection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetection.Size = new System.Drawing.Size(617, 153);
            this.tabPageDetection.TabIndex = 1;
            this.tabPageDetection.Text = "Detection";
            this.tabPageDetection.UseVisualStyleBackColor = true;
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialog1";
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
            // Stegano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 179);
            this.Controls.Add(this.tabControl1);
            this.Name = "Stegano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stegano";
            this.tabControl1.ResumeLayout(false);
            this.tabPageHideImg.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHideImg;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSrc;
        private System.Windows.Forms.TabPage tabPageDetection;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.Button btnHost;
    }
}

