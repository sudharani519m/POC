namespace ListBoxExample
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
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.lstcourses = new System.Windows.Forms.ListBox();
            this.lblSelectedCoursePrompt = new System.Windows.Forms.Label();
            this.lblSelectedCourse = new System.Windows.Forms.Label();
            this.lblSelectedCourseIndexPrompt = new System.Windows.Forms.Label();
            this.lblSelectedCourseIndex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Location = new System.Drawing.Point(99, 53);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(99, 13);
            this.lblSelectCourse.TabIndex = 0;
            this.lblSelectCourse.Text = "Select your Course:";
            // 
            // lstcourses
            // 
            this.lstcourses.FormattingEnabled = true;
            this.lstcourses.Items.AddRange(new object[] {
            "C",
            "C++",
            "Java",
            "Oracle",
            "MS Sql Server",
            "Visual Basic",
            "Visula c++",
            "MS.Net",
            "Testing Tools"});
            this.lstcourses.Location = new System.Drawing.Point(92, 83);
            this.lstcourses.Name = "lstcourses";
            this.lstcourses.Size = new System.Drawing.Size(120, 95);
            this.lstcourses.TabIndex = 1;
            this.lstcourses.SelectedIndexChanged += new System.EventHandler(this.lstcourses_SelectedIndexChanged);
            // 
            // lblSelectedCoursePrompt
            // 
            this.lblSelectedCoursePrompt.AutoSize = true;
            this.lblSelectedCoursePrompt.Location = new System.Drawing.Point(332, 99);
            this.lblSelectedCoursePrompt.Name = "lblSelectedCoursePrompt";
            this.lblSelectedCoursePrompt.Size = new System.Drawing.Size(88, 13);
            this.lblSelectedCoursePrompt.TabIndex = 2;
            this.lblSelectedCoursePrompt.Text = "Selected Course:";
            // 
            // lblSelectedCourse
            // 
            this.lblSelectedCourse.AutoSize = true;
            this.lblSelectedCourse.Location = new System.Drawing.Point(426, 99);
            this.lblSelectedCourse.Name = "lblSelectedCourse";
            this.lblSelectedCourse.Size = new System.Drawing.Size(111, 13);
            this.lblSelectedCourse.TabIndex = 3;
            this.lblSelectedCourse.Text = "Selected Course Here";
            // 
            // lblSelectedCourseIndexPrompt
            // 
            this.lblSelectedCourseIndexPrompt.AutoSize = true;
            this.lblSelectedCourseIndexPrompt.Location = new System.Drawing.Point(322, 149);
            this.lblSelectedCourseIndexPrompt.Name = "lblSelectedCourseIndexPrompt";
            this.lblSelectedCourseIndexPrompt.Size = new System.Drawing.Size(117, 13);
            this.lblSelectedCourseIndexPrompt.TabIndex = 4;
            this.lblSelectedCourseIndexPrompt.Text = "Selected Course Index:";
            // 
            // lblSelectedCourseIndex
            // 
            this.lblSelectedCourseIndex.AutoSize = true;
            this.lblSelectedCourseIndex.Location = new System.Drawing.Point(445, 149);
            this.lblSelectedCourseIndex.Name = "lblSelectedCourseIndex";
            this.lblSelectedCourseIndex.Size = new System.Drawing.Size(140, 13);
            this.lblSelectedCourseIndex.TabIndex = 5;
            this.lblSelectedCourseIndex.Text = "Selected Course Index Here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelectedCourseIndex);
            this.Controls.Add(this.lblSelectedCourseIndexPrompt);
            this.Controls.Add(this.lblSelectedCourse);
            this.Controls.Add(this.lblSelectedCoursePrompt);
            this.Controls.Add(this.lstcourses);
            this.Controls.Add(this.lblSelectCourse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.ListBox lstcourses;
        private System.Windows.Forms.Label lblSelectedCoursePrompt;
        private System.Windows.Forms.Label lblSelectedCourse;
        private System.Windows.Forms.Label lblSelectedCourseIndexPrompt;
        private System.Windows.Forms.Label lblSelectedCourseIndex;
    }
}

