namespace User_interface
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.labelFullName = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.labelUserType = new System.Windows.Forms.Label();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.listBoxUserType = new System.Windows.Forms.ListBox();
            this.textBoxContactNumber = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.BackColor = System.Drawing.Color.Transparent;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(286, 149);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(130, 29);
            this.labelFullName.TabIndex = 35;
            this.labelFullName.Text = "Full Name:";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.Location = new System.Drawing.Point(485, 143);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(203, 35);
            this.textBoxFullName.TabIndex = 34;
            this.textBoxFullName.TextChanged += new System.EventHandler(this.validateTextCharacter);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Red;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(738, 200);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(150, 81);
            this.buttonBack.TabIndex = 33;
            this.buttonBack.Text = "Exit";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.BackColor = System.Drawing.Color.White;
            this.buttonEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditUser.Location = new System.Drawing.Point(738, 87);
            this.buttonEditUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(150, 85);
            this.buttonEditUser.TabIndex = 32;
            this.buttonEditUser.Text = "Edit User";
            this.buttonEditUser.UseVisualStyleBackColor = false;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // labelUserType
            // 
            this.labelUserType.AutoSize = true;
            this.labelUserType.BackColor = System.Drawing.Color.Transparent;
            this.labelUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserType.Location = new System.Drawing.Point(286, 301);
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(131, 29);
            this.labelUserType.TabIndex = 31;
            this.labelUserType.Text = "User Type:";
            // 
            // labelContactNumber
            // 
            this.labelContactNumber.AutoSize = true;
            this.labelContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactNumber.Location = new System.Drawing.Point(286, 252);
            this.labelContactNumber.Name = "labelContactNumber";
            this.labelContactNumber.Size = new System.Drawing.Size(193, 29);
            this.labelContactNumber.TabIndex = 30;
            this.labelContactNumber.Text = "Contact Number:";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassword.Location = new System.Drawing.Point(286, 201);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(120, 29);
            this.labelNewPassword.TabIndex = 29;
            this.labelNewPassword.Text = "Password";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.BackColor = System.Drawing.Color.Transparent;
            this.labelUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(286, 87);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(99, 29);
            this.labelUserID.TabIndex = 28;
            this.labelUserID.Text = "User ID:";
            // 
            // listBoxUserType
            // 
            this.listBoxUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUserType.FormattingEnabled = true;
            this.listBoxUserType.ItemHeight = 29;
            this.listBoxUserType.Items.AddRange(new object[] {
            "Floor Manager",
            "Operator",
            "Stock Manager"});
            this.listBoxUserType.Location = new System.Drawing.Point(485, 301);
            this.listBoxUserType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxUserType.Name = "listBoxUserType";
            this.listBoxUserType.Size = new System.Drawing.Size(203, 120);
            this.listBoxUserType.TabIndex = 27;
            // 
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContactNumber.Location = new System.Drawing.Point(485, 255);
            this.textBoxContactNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.Size = new System.Drawing.Size(203, 35);
            this.textBoxContactNumber.TabIndex = 26;
            this.textBoxContactNumber.TextChanged += new System.EventHandler(this.validateTextInteger);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.Location = new System.Drawing.Point(485, 201);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(203, 35);
            this.textBoxNewPassword.TabIndex = 25;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserID.Location = new System.Drawing.Point(485, 87);
            this.textBoxUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.ReadOnly = true;
            this.textBoxUserID.Size = new System.Drawing.Size(203, 35);
            this.textBoxUserID.TabIndex = 24;
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 29;
            this.listBoxUsers.Location = new System.Drawing.Point(29, 87);
            this.listBoxUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(188, 410);
            this.listBoxUsers.TabIndex = 37;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 596);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.labelUserType);
            this.Controls.Add(this.labelContactNumber);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.listBoxUserType);
            this.Controls.Add(this.textBoxContactNumber);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxUserID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditUser";
            this.ShowIcon = false;
            this.Text = "Edit User";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Label labelUserType;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.ListBox listBoxUserType;
        private System.Windows.Forms.TextBox textBoxContactNumber;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.ListBox listBoxUsers;
    }
}