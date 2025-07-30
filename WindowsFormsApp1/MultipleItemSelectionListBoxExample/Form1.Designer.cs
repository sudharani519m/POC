namespace MultipleItemSelectionListBoxExample
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
            this.lblAvailableBooks = new System.Windows.Forms.Label();
            this.lblSelectedBooks = new System.Windows.Forms.Label();
            this.lstAvailableBooks = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstSelectedBooks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblAvailableBooks
            // 
            this.lblAvailableBooks.AutoSize = true;
            this.lblAvailableBooks.Location = new System.Drawing.Point(101, 59);
            this.lblAvailableBooks.Name = "lblAvailableBooks";
            this.lblAvailableBooks.Size = new System.Drawing.Size(83, 13);
            this.lblAvailableBooks.TabIndex = 0;
            this.lblAvailableBooks.Text = "AvailableBooks:";
            // 
            // lblSelectedBooks
            // 
            this.lblSelectedBooks.AutoSize = true;
            this.lblSelectedBooks.Location = new System.Drawing.Point(394, 59);
            this.lblSelectedBooks.Name = "lblSelectedBooks";
            this.lblSelectedBooks.Size = new System.Drawing.Size(82, 13);
            this.lblSelectedBooks.TabIndex = 1;
            this.lblSelectedBooks.Text = "SelectedBooks:";
            // 
            // lstAvailableBooks
            // 
            this.lstAvailableBooks.FormattingEnabled = true;
            this.lstAvailableBooks.Items.AddRange(new object[] {
            "General Knowledge",
            "HTML 4.0",
            "Java Complete Reference",
            "Let Us C",
            "Mastering in VB",
            "Ms Visula Studio 8",
            "PHP in depth"});
            this.lstAvailableBooks.Location = new System.Drawing.Point(104, 98);
            this.lstAvailableBooks.Name = "lstAvailableBooks";
            this.lstAvailableBooks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAvailableBooks.Size = new System.Drawing.Size(120, 95);
            this.lstAvailableBooks.Sorted = true;
            this.lstAvailableBooks.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(258, 129);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = ">";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstSelectedBooks
            // 
            this.lstSelectedBooks.FormattingEnabled = true;
            this.lstSelectedBooks.Location = new System.Drawing.Point(374, 98);
            this.lstSelectedBooks.Name = "lstSelectedBooks";
            this.lstSelectedBooks.Size = new System.Drawing.Size(120, 95);
            this.lstSelectedBooks.Sorted = true;
            this.lstSelectedBooks.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSelectedBooks);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lstAvailableBooks);
            this.Controls.Add(this.lblSelectedBooks);
            this.Controls.Add(this.lblAvailableBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvailableBooks;
        private System.Windows.Forms.Label lblSelectedBooks;
        private System.Windows.Forms.ListBox lstAvailableBooks;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstSelectedBooks;
    }
}

