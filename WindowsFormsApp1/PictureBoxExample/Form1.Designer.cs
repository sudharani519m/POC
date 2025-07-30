namespace PictureBoxExample
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
            this.components = new System.ComponentModel.Container();
            this.lblEnterImagePath = new System.Windows.Forms.Label();
            this.txtimagePath = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.lblSizeMode = new System.Windows.Forms.Label();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbStretch = new System.Windows.Forms.RadioButton();
            this.rbAutoSize = new System.Windows.Forms.RadioButton();
            this.rbCenter = new System.Windows.Forms.RadioButton();
            this.rbZoom = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterImagePath
            // 
            this.lblEnterImagePath.AutoSize = true;
            this.lblEnterImagePath.Location = new System.Drawing.Point(126, 62);
            this.lblEnterImagePath.Name = "lblEnterImagePath";
            this.lblEnterImagePath.Size = new System.Drawing.Size(90, 13);
            this.lblEnterImagePath.TabIndex = 0;
            this.lblEnterImagePath.Text = "Enter image path:";
            // 
            // txtimagePath
            // 
            this.txtimagePath.Location = new System.Drawing.Point(232, 55);
            this.txtimagePath.Name = "txtimagePath";
            this.txtimagePath.Size = new System.Drawing.Size(288, 20);
            this.txtimagePath.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(545, 57);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClearImage
            // 
            this.btnClearImage.Location = new System.Drawing.Point(310, 356);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(75, 23);
            this.btnClearImage.TabIndex = 4;
            this.btnClearImage.Text = "clear Image";
            this.btnClearImage.UseVisualStyleBackColor = true;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            // 
            // lblSizeMode
            // 
            this.lblSizeMode.AutoSize = true;
            this.lblSizeMode.ForeColor = System.Drawing.Color.Red;
            this.lblSizeMode.Location = new System.Drawing.Point(126, 393);
            this.lblSizeMode.Name = "lblSizeMode";
            this.lblSizeMode.Size = new System.Drawing.Size(60, 13);
            this.lblSizeMode.TabIndex = 5;
            this.lblSizeMode.Text = "Size Mode:";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(195, 391);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 6;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // rbStretch
            // 
            this.rbStretch.AutoSize = true;
            this.rbStretch.Location = new System.Drawing.Point(310, 391);
            this.rbStretch.Name = "rbStretch";
            this.rbStretch.Size = new System.Drawing.Size(59, 17);
            this.rbStretch.TabIndex = 7;
            this.rbStretch.TabStop = true;
            this.rbStretch.Text = "Stretch";
            this.rbStretch.UseVisualStyleBackColor = true;
            this.rbStretch.CheckedChanged += new System.EventHandler(this.rbStretch_CheckedChanged);
            // 
            // rbAutoSize
            // 
            this.rbAutoSize.AutoSize = true;
            this.rbAutoSize.Location = new System.Drawing.Point(412, 391);
            this.rbAutoSize.Name = "rbAutoSize";
            this.rbAutoSize.Size = new System.Drawing.Size(70, 17);
            this.rbAutoSize.TabIndex = 8;
            this.rbAutoSize.TabStop = true;
            this.rbAutoSize.Text = "Auto Size";
            this.rbAutoSize.UseVisualStyleBackColor = true;
            this.rbAutoSize.CheckedChanged += new System.EventHandler(this.rbAutoSize_CheckedChanged);
            // 
            // rbCenter
            // 
            this.rbCenter.AutoSize = true;
            this.rbCenter.Location = new System.Drawing.Point(545, 391);
            this.rbCenter.Name = "rbCenter";
            this.rbCenter.Size = new System.Drawing.Size(56, 17);
            this.rbCenter.TabIndex = 9;
            this.rbCenter.TabStop = true;
            this.rbCenter.Text = "Center";
            this.rbCenter.UseVisualStyleBackColor = true;
            this.rbCenter.CheckedChanged += new System.EventHandler(this.rbCenter_CheckedChanged);
            // 
            // rbZoom
            // 
            this.rbZoom.AutoSize = true;
            this.rbZoom.Location = new System.Drawing.Point(671, 391);
            this.rbZoom.Name = "rbZoom";
            this.rbZoom.Size = new System.Drawing.Size(52, 17);
            this.rbZoom.TabIndex = 10;
            this.rbZoom.TabStop = true;
            this.rbZoom.Text = "Zoom";
            this.rbZoom.UseVisualStyleBackColor = true;
            this.rbZoom.CheckedChanged += new System.EventHandler(this.rbZoom_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picBoxImage
            // 
            this.picBoxImage.Location = new System.Drawing.Point(129, 107);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(539, 243);
            this.picBoxImage.TabIndex = 11;
            this.picBoxImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBoxImage);
            this.Controls.Add(this.rbZoom);
            this.Controls.Add(this.rbCenter);
            this.Controls.Add(this.rbAutoSize);
            this.Controls.Add(this.rbStretch);
            this.Controls.Add(this.rbNormal);
            this.Controls.Add(this.lblSizeMode);
            this.Controls.Add(this.btnClearImage);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtimagePath);
            this.Controls.Add(this.lblEnterImagePath);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterImagePath;
        private System.Windows.Forms.TextBox txtimagePath;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.Label lblSizeMode;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbStretch;
        private System.Windows.Forms.RadioButton rbAutoSize;
        private System.Windows.Forms.RadioButton rbCenter;
        private System.Windows.Forms.RadioButton rbZoom;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox picBoxImage;
    }
}

