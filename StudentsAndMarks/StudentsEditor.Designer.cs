namespace StudentsAndMarks
{
    partial class StudentsEditor
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
            this.L_Name = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.B_Add = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.L_Students = new System.Windows.Forms.Label();
            this.LB_Students = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Location = new System.Drawing.Point(307, 9);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(35, 13);
            this.L_Name.TabIndex = 0;
            this.L_Name.Text = "Name";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(225, 25);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(214, 20);
            this.TB_Name.TabIndex = 1;
            // 
            // B_Add
            // 
            this.B_Add.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.B_Add.Location = new System.Drawing.Point(290, 67);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(75, 23);
            this.B_Add.TabIndex = 2;
            this.B_Add.Text = "Add";
            this.B_Add.UseVisualStyleBackColor = true;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // B_Cancel
            // 
            this.B_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_Cancel.Location = new System.Drawing.Point(199, 315);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(75, 23);
            this.B_Cancel.TabIndex = 3;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // L_Students
            // 
            this.L_Students.AutoSize = true;
            this.L_Students.Location = new System.Drawing.Point(24, 8);
            this.L_Students.Name = "L_Students";
            this.L_Students.Size = new System.Drawing.Size(49, 13);
            this.L_Students.TabIndex = 5;
            this.L_Students.Text = "Students";
            // 
            // LB_Students
            // 
            this.LB_Students.DisplayMember = "Name";
            this.LB_Students.FormattingEnabled = true;
            this.LB_Students.Location = new System.Drawing.Point(12, 24);
            this.LB_Students.Name = "LB_Students";
            this.LB_Students.Size = new System.Drawing.Size(173, 264);
            this.LB_Students.TabIndex = 6;
            this.LB_Students.DoubleClick += new System.EventHandler(this.LB_Students_DoubleClick);
            // 
            // StudentsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 350);
            this.Controls.Add(this.LB_Students);
            this.Controls.Add(this.L_Students);
            this.Controls.Add(this.B_Cancel);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.L_Name);
            this.Name = "StudentsEditor";
            this.Text = "StudentsEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.Button B_Cancel;
        public System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label L_Students;
        private System.Windows.Forms.ListBox LB_Students;
    }
}