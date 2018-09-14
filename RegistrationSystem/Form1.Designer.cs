namespace RegistrationSystem
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
            this.AddressBtnClicked = new System.Windows.Forms.Button();
            this.CourseBtnClicked = new System.Windows.Forms.Button();
            this.SectionBtnClicked = new System.Windows.Forms.Button();
            this.PersonBtnClicked = new System.Windows.Forms.Button();
            this.StudentBtnClicked = new System.Windows.Forms.Button();
            this.InstructorBtnClicked = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddressBtnClicked
            // 
            this.AddressBtnClicked.AutoSize = true;
            this.AddressBtnClicked.Location = new System.Drawing.Point(102, 44);
            this.AddressBtnClicked.Name = "AddressBtnClicked";
            this.AddressBtnClicked.Size = new System.Drawing.Size(79, 23);
            this.AddressBtnClicked.TabIndex = 0;
            this.AddressBtnClicked.Text = "Test Address";
            this.AddressBtnClicked.UseVisualStyleBackColor = true;
            this.AddressBtnClicked.Click += new System.EventHandler(this.AddressBtnClicked_Click);
            // 
            // CourseBtnClicked
            // 
            this.CourseBtnClicked.AutoSize = true;
            this.CourseBtnClicked.Location = new System.Drawing.Point(187, 44);
            this.CourseBtnClicked.Name = "CourseBtnClicked";
            this.CourseBtnClicked.Size = new System.Drawing.Size(75, 23);
            this.CourseBtnClicked.TabIndex = 1;
            this.CourseBtnClicked.Text = "Test Course";
            this.CourseBtnClicked.UseVisualStyleBackColor = true;
            this.CourseBtnClicked.Click += new System.EventHandler(this.CourseBtnClicked_Click);
            // 
            // SectionBtnClicked
            // 
            this.SectionBtnClicked.AutoSize = true;
            this.SectionBtnClicked.Location = new System.Drawing.Point(268, 44);
            this.SectionBtnClicked.Name = "SectionBtnClicked";
            this.SectionBtnClicked.Size = new System.Drawing.Size(77, 23);
            this.SectionBtnClicked.TabIndex = 2;
            this.SectionBtnClicked.Text = "Test Section";
            this.SectionBtnClicked.UseVisualStyleBackColor = true;
            this.SectionBtnClicked.Click += new System.EventHandler(this.SectionBtnClicked_Click);
            // 
            // PersonBtnClicked
            // 
            this.PersonBtnClicked.AutoSize = true;
            this.PersonBtnClicked.Location = new System.Drawing.Point(349, 44);
            this.PersonBtnClicked.Name = "PersonBtnClicked";
            this.PersonBtnClicked.Size = new System.Drawing.Size(75, 23);
            this.PersonBtnClicked.TabIndex = 3;
            this.PersonBtnClicked.Text = "Test Person";
            this.PersonBtnClicked.UseVisualStyleBackColor = true;
            this.PersonBtnClicked.Click += new System.EventHandler(this.PersonBtnClicked_Click);
            // 
            // StudentBtnClicked
            // 
            this.StudentBtnClicked.AutoSize = true;
            this.StudentBtnClicked.Location = new System.Drawing.Point(430, 44);
            this.StudentBtnClicked.Name = "StudentBtnClicked";
            this.StudentBtnClicked.Size = new System.Drawing.Size(78, 23);
            this.StudentBtnClicked.TabIndex = 4;
            this.StudentBtnClicked.Text = "Test Student";
            this.StudentBtnClicked.UseVisualStyleBackColor = true;
            this.StudentBtnClicked.Click += new System.EventHandler(this.StudentBtnClicked_Click);
            // 
            // InstructorBtnClicked
            // 
            this.InstructorBtnClicked.AutoSize = true;
            this.InstructorBtnClicked.Location = new System.Drawing.Point(102, 73);
            this.InstructorBtnClicked.Name = "InstructorBtnClicked";
            this.InstructorBtnClicked.Size = new System.Drawing.Size(85, 23);
            this.InstructorBtnClicked.TabIndex = 5;
            this.InstructorBtnClicked.Text = "Test Instructor";
            this.InstructorBtnClicked.UseVisualStyleBackColor = true;
            this.InstructorBtnClicked.Click += new System.EventHandler(this.InstructorBtnClicked_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 187);
            this.Controls.Add(this.InstructorBtnClicked);
            this.Controls.Add(this.StudentBtnClicked);
            this.Controls.Add(this.PersonBtnClicked);
            this.Controls.Add(this.SectionBtnClicked);
            this.Controls.Add(this.CourseBtnClicked);
            this.Controls.Add(this.AddressBtnClicked);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bussiness Object Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddressBtnClicked;
        private System.Windows.Forms.Button CourseBtnClicked;
        private System.Windows.Forms.Button SectionBtnClicked;
        private System.Windows.Forms.Button PersonBtnClicked;
        private System.Windows.Forms.Button StudentBtnClicked;
        private System.Windows.Forms.Button InstructorBtnClicked;
    }
}

