namespace StudentsAndMarks
{
    partial class JournalForm
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
            this.LB_Students = new System.Windows.Forms.ListBox();
            this.LB_Subjects = new System.Windows.Forms.ListBox();
            this.L_Students = new System.Windows.Forms.Label();
            this.L_Subjects = new System.Windows.Forms.Label();
            this.TB_Mark = new System.Windows.Forms.TextBox();
            this.L_Mark = new System.Windows.Forms.Label();
            this.B_AddMark = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.TB_StudName = new System.Windows.Forms.TextBox();
            this.TB_SubName = new System.Windows.Forms.TextBox();
            this.L_StudName = new System.Windows.Forms.Label();
            this.L_SubName = new System.Windows.Forms.Label();
            this.B_AddStudent = new System.Windows.Forms.Button();
            this.B_AddSubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Students
            // 
            this.LB_Students.DisplayMember = "Name";
            this.LB_Students.FormattingEnabled = true;
            this.LB_Students.Location = new System.Drawing.Point(15, 36);
            this.LB_Students.Name = "LB_Students";
            this.LB_Students.Size = new System.Drawing.Size(256, 342);
            this.LB_Students.TabIndex = 0;
            this.LB_Students.SelectedIndexChanged += new System.EventHandler(this.LB_Students_SelectedIndexChanged);
            this.LB_Students.DoubleClick += new System.EventHandler(this.LB_Students_DoubleClick);
            // 
            // LB_Subjects
            // 
            this.LB_Subjects.DisplayMember = "Name";
            this.LB_Subjects.FormattingEnabled = true;
            this.LB_Subjects.Location = new System.Drawing.Point(325, 36);
            this.LB_Subjects.Name = "LB_Subjects";
            this.LB_Subjects.Size = new System.Drawing.Size(256, 342);
            this.LB_Subjects.TabIndex = 1;
            this.LB_Subjects.SelectedIndexChanged += new System.EventHandler(this.LB_Subjects_SelectedIndexChanged);
            this.LB_Subjects.DoubleClick += new System.EventHandler(this.LB_Subjects_DoubleClick);
            // 
            // L_Students
            // 
            this.L_Students.AutoSize = true;
            this.L_Students.Location = new System.Drawing.Point(12, 9);
            this.L_Students.Name = "L_Students";
            this.L_Students.Size = new System.Drawing.Size(49, 13);
            this.L_Students.TabIndex = 2;
            this.L_Students.Text = "Students";
            // 
            // L_Subjects
            // 
            this.L_Subjects.AutoSize = true;
            this.L_Subjects.Location = new System.Drawing.Point(322, 9);
            this.L_Subjects.Name = "L_Subjects";
            this.L_Subjects.Size = new System.Drawing.Size(48, 13);
            this.L_Subjects.TabIndex = 3;
            this.L_Subjects.Text = "Subjects";
            // 
            // TB_Mark
            // 
            this.TB_Mark.Location = new System.Drawing.Point(659, 184);
            this.TB_Mark.Name = "TB_Mark";
            this.TB_Mark.Size = new System.Drawing.Size(118, 20);
            this.TB_Mark.TabIndex = 4;
            // 
            // L_Mark
            // 
            this.L_Mark.AutoSize = true;
            this.L_Mark.Location = new System.Drawing.Point(622, 187);
            this.L_Mark.Name = "L_Mark";
            this.L_Mark.Size = new System.Drawing.Size(31, 13);
            this.L_Mark.TabIndex = 5;
            this.L_Mark.Text = "Mark";
            // 
            // B_AddMark
            // 
            this.B_AddMark.Location = new System.Drawing.Point(672, 210);
            this.B_AddMark.Name = "B_AddMark";
            this.B_AddMark.Size = new System.Drawing.Size(79, 27);
            this.B_AddMark.TabIndex = 6;
            this.B_AddMark.Text = "Add";
            this.B_AddMark.UseVisualStyleBackColor = true;
            this.B_AddMark.Click += new System.EventHandler(this.B_AddMark_Click);
            // 
            // B_Cancel
            // 
            this.B_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_Cancel.Location = new System.Drawing.Point(672, 444);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(79, 27);
            this.B_Cancel.TabIndex = 7;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.UseVisualStyleBackColor = true;
            // 
            // TB_StudName
            // 
            this.TB_StudName.Location = new System.Drawing.Point(52, 418);
            this.TB_StudName.Name = "TB_StudName";
            this.TB_StudName.Size = new System.Drawing.Size(118, 20);
            this.TB_StudName.TabIndex = 8;
            // 
            // TB_SubName
            // 
            this.TB_SubName.Location = new System.Drawing.Point(360, 415);
            this.TB_SubName.Name = "TB_SubName";
            this.TB_SubName.Size = new System.Drawing.Size(118, 20);
            this.TB_SubName.TabIndex = 9;
            // 
            // L_StudName
            // 
            this.L_StudName.AutoSize = true;
            this.L_StudName.Location = new System.Drawing.Point(11, 418);
            this.L_StudName.Name = "L_StudName";
            this.L_StudName.Size = new System.Drawing.Size(35, 13);
            this.L_StudName.TabIndex = 10;
            this.L_StudName.Text = "Name";
            // 
            // L_SubName
            // 
            this.L_SubName.AutoSize = true;
            this.L_SubName.Location = new System.Drawing.Point(319, 418);
            this.L_SubName.Name = "L_SubName";
            this.L_SubName.Size = new System.Drawing.Size(35, 13);
            this.L_SubName.TabIndex = 11;
            this.L_SubName.Text = "Name";
            // 
            // B_AddStudent
            // 
            this.B_AddStudent.Location = new System.Drawing.Point(67, 444);
            this.B_AddStudent.Name = "B_AddStudent";
            this.B_AddStudent.Size = new System.Drawing.Size(79, 27);
            this.B_AddStudent.TabIndex = 12;
            this.B_AddStudent.Text = "Add";
            this.B_AddStudent.UseVisualStyleBackColor = true;
            this.B_AddStudent.Click += new System.EventHandler(this.B_AddStudent_Click);
            // 
            // B_AddSubject
            // 
            this.B_AddSubject.Location = new System.Drawing.Point(378, 444);
            this.B_AddSubject.Name = "B_AddSubject";
            this.B_AddSubject.Size = new System.Drawing.Size(79, 27);
            this.B_AddSubject.TabIndex = 13;
            this.B_AddSubject.Text = "Add";
            this.B_AddSubject.UseVisualStyleBackColor = true;
            this.B_AddSubject.Click += new System.EventHandler(this.B_AddSubject_Click);
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 514);
            this.Controls.Add(this.B_AddSubject);
            this.Controls.Add(this.B_AddStudent);
            this.Controls.Add(this.L_SubName);
            this.Controls.Add(this.L_StudName);
            this.Controls.Add(this.TB_SubName);
            this.Controls.Add(this.TB_StudName);
            this.Controls.Add(this.B_Cancel);
            this.Controls.Add(this.B_AddMark);
            this.Controls.Add(this.L_Mark);
            this.Controls.Add(this.TB_Mark);
            this.Controls.Add(this.L_Subjects);
            this.Controls.Add(this.L_Students);
            this.Controls.Add(this.LB_Subjects);
            this.Controls.Add(this.LB_Students);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JournalForm";
            this.Text = "JournalForm";
            this.Load += new System.EventHandler(this.JournalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Students;
        private System.Windows.Forms.ListBox LB_Subjects;
        private System.Windows.Forms.Label L_Students;
        private System.Windows.Forms.Label L_Subjects;
        private System.Windows.Forms.TextBox TB_Mark;
        private System.Windows.Forms.Label L_Mark;
        private System.Windows.Forms.Button B_AddMark;
        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.TextBox TB_StudName;
        private System.Windows.Forms.TextBox TB_SubName;
        private System.Windows.Forms.Label L_StudName;
        private System.Windows.Forms.Label L_SubName;
        private System.Windows.Forms.Button B_AddStudent;
        private System.Windows.Forms.Button B_AddSubject;
    }
}