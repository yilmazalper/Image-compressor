namespace ImageCompressor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnSouceBrowse = new System.Windows.Forms.Button();
            this.btnDestFolder = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnCompress = new System.Windows.Forms.Button();
            this.cmbQuality = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(126, 29);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(416, 20);
            this.txtSource.TabIndex = 0;
            // 
            // btnSouceBrowse
            // 
            this.btnSouceBrowse.Location = new System.Drawing.Point(549, 27);
            this.btnSouceBrowse.Name = "btnSouceBrowse";
            this.btnSouceBrowse.Size = new System.Drawing.Size(113, 23);
            this.btnSouceBrowse.TabIndex = 1;
            this.btnSouceBrowse.Text = "Gözat";
            this.btnSouceBrowse.UseVisualStyleBackColor = true;
            this.btnSouceBrowse.Click += new System.EventHandler(this.btnSouceBrowse_Click);
            // 
            // btnDestFolder
            // 
            this.btnDestFolder.Location = new System.Drawing.Point(549, 64);
            this.btnDestFolder.Name = "btnDestFolder";
            this.btnDestFolder.Size = new System.Drawing.Size(113, 23);
            this.btnDestFolder.TabIndex = 3;
            this.btnDestFolder.Text = "Gözat";
            this.btnDestFolder.UseVisualStyleBackColor = true;
            this.btnDestFolder.Click += new System.EventHandler(this.btnDestFolder_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(126, 66);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(416, 20);
            this.txtDestination.TabIndex = 2;
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(373, 101);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(119, 40);
            this.btnCompress.TabIndex = 4;
            this.btnCompress.Text = "Sıkıştır";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // cmbQuality
            // 
            this.cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuality.FormattingEnabled = true;
            this.cmbQuality.Location = new System.Drawing.Point(127, 113);
            this.cmbQuality.Name = "cmbQuality";
            this.cmbQuality.Size = new System.Drawing.Size(159, 21);
            this.cmbQuality.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hedef Dosya";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kaynak Dosya";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sıkıştırma Kalitesi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 168);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbQuality);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.btnDestFolder);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.btnSouceBrowse);
            this.Controls.Add(this.txtSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Compressor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnSouceBrowse;
        private System.Windows.Forms.Button btnDestFolder;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.ComboBox cmbQuality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

