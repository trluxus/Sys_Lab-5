namespace StudentsAndMarks
{
    partial class EditItem
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
            this.B_OK = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.B_Delete = new System.Windows.Forms.Button();
            this.lProposeName = new System.Windows.Forms.Label();
            this.tbProposeName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Location = new System.Drawing.Point(14, 13);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(35, 13);
            this.L_Name.TabIndex = 0;
            this.L_Name.Text = "Name";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(96, 11);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.ReadOnly = true;
            this.TB_Name.Size = new System.Drawing.Size(189, 20);
            this.TB_Name.TabIndex = 1;
            // 
            // B_OK
            // 
            this.B_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.B_OK.Location = new System.Drawing.Point(12, 102);
            this.B_OK.Name = "B_OK";
            this.B_OK.Size = new System.Drawing.Size(74, 35);
            this.B_OK.TabIndex = 2;
            this.B_OK.Text = "Change name";
            this.B_OK.UseVisualStyleBackColor = true;
            // 
            // B_Cancel
            // 
            this.B_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_Cancel.Location = new System.Drawing.Point(211, 102);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(74, 35);
            this.B_Cancel.TabIndex = 3;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.UseVisualStyleBackColor = true;
            // 
            // B_Delete
            // 
            this.B_Delete.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.B_Delete.Location = new System.Drawing.Point(104, 102);
            this.B_Delete.Name = "B_Delete";
            this.B_Delete.Size = new System.Drawing.Size(88, 35);
            this.B_Delete.TabIndex = 4;
            this.B_Delete.Text = "Delete";
            this.B_Delete.UseVisualStyleBackColor = true;
            // 
            // lProposeName
            // 
            this.lProposeName.AutoSize = true;
            this.lProposeName.Location = new System.Drawing.Point(14, 38);
            this.lProposeName.Name = "lProposeName";
            this.lProposeName.Size = new System.Drawing.Size(77, 13);
            this.lProposeName.TabIndex = 5;
            this.lProposeName.Text = "Propose Name";
            // 
            // tbProposeName
            // 
            this.tbProposeName.Location = new System.Drawing.Point(95, 35);
            this.tbProposeName.Name = "tbProposeName";
            this.tbProposeName.Size = new System.Drawing.Size(189, 20);
            this.tbProposeName.TabIndex = 6;
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 147);
            this.Controls.Add(this.tbProposeName);
            this.Controls.Add(this.lProposeName);
            this.Controls.Add(this.B_Delete);
            this.Controls.Add(this.B_Cancel);
            this.Controls.Add(this.B_OK);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.L_Name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditItem";
            this.Text = "EditStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.Button B_OK;
        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.Button B_Delete;
        public System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label lProposeName;
        public System.Windows.Forms.TextBox tbProposeName;
    }
}