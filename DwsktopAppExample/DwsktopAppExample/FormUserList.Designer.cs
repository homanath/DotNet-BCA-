namespace DwsktopAppExample
{
    partial class FormUserList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DgvUserList = new DataGridView();
            BtnAddUser = new Button();
            BtnEditUser = new Button();
            BtnDeleteUser = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvUserList).BeginInit();
            SuspendLayout();
            // 
            // DgvUserList
            // 
            DgvUserList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvUserList.Location = new Point(0, 0);
            DgvUserList.Name = "DgvUserList";
            DgvUserList.RowHeadersWidth = 51;
            DgvUserList.Size = new Size(788, 310);
            DgvUserList.TabIndex = 0;
            // 
            // BtnAddUser
            // 
            BtnAddUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnAddUser.Location = new Point(14, 328);
            BtnAddUser.Name = "BtnAddUser";
            BtnAddUser.Size = new Size(178, 50);
            BtnAddUser.TabIndex = 1;
            BtnAddUser.Text = "Add USer";
            BtnAddUser.UseVisualStyleBackColor = true;
            // 
            // BtnEditUser
            // 
            BtnEditUser.Anchor = AnchorStyles.Bottom;
            BtnEditUser.Location = new Point(296, 328);
            BtnEditUser.Name = "BtnEditUser";
            BtnEditUser.Size = new Size(178, 50);
            BtnEditUser.TabIndex = 1;
            BtnEditUser.Text = "Edit User";
            BtnEditUser.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteUser
            // 
            BtnDeleteUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnDeleteUser.Location = new Point(583, 328);
            BtnDeleteUser.Name = "BtnDeleteUser";
            BtnDeleteUser.Size = new Size(178, 50);
            BtnDeleteUser.TabIndex = 1;
            BtnDeleteUser.Text = "Delete User";
            BtnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // FormUserList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnDeleteUser);
            Controls.Add(BtnEditUser);
            Controls.Add(BtnAddUser);
            Controls.Add(DgvUserList);
            Name = "FormUserList";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User List";
            Load += FormUsers_Load;
            ((System.ComponentModel.ISupportInitialize)DgvUserList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView DgvUserList;
        private Button BtnAddUser;
        private Button BtnEditUser;
        private Button BtnDeleteUser;
        private Button button2;
    }
}
