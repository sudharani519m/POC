namespace ButtonExamples
{
    partial class Progressbar
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtopen = new System.Windows.Forms.Button();
            this.prgFile = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tmrFileOpen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(210, 104);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(127, 20);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter File Name:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(376, 101);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(371, 26);
            this.txtFileName.TabIndex = 1;
            // 
            // txtopen
            // 
            this.txtopen.Location = new System.Drawing.Point(753, 92);
            this.txtopen.Name = "txtopen";
            this.txtopen.Size = new System.Drawing.Size(117, 35);
            this.txtopen.TabIndex = 2;
            this.txtopen.Text = "open";
            this.txtopen.UseVisualStyleBackColor = true;
            this.txtopen.Click += new System.EventHandler(this.txtopen_Click);
            // 
            // prgFile
            // 
            this.prgFile.Location = new System.Drawing.Point(339, 186);
            this.prgFile.Name = "prgFile";
            this.prgFile.Size = new System.Drawing.Size(256, 23);
            this.prgFile.TabIndex = 3;
            this.prgFile.Visible = false;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.ForeColor = System.Drawing.Color.Red;
            this.lblLoading.Location = new System.Drawing.Point(214, 188);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(102, 20);
            this.lblLoading.TabIndex = 4;
            this.lblLoading.Text = "Loading.........";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 289);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(439, 230);
            this.textBox1.TabIndex = 5;
            this.textBox1.WordWrap = false;
            // 
            // tmrFileOpen
            // 
            this.tmrFileOpen.Tick += new System.EventHandler(this.tmrFileOpen_Tick);
            // 
            // Progressbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 555);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.prgFile);
            this.Controls.Add(this.txtopen);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblEnter);
            this.Name = "Progressbar";
            this.Text = "Progessbar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button txtopen;
        private System.Windows.Forms.ProgressBar prgFile;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer tmrFileOpen;
    }
}