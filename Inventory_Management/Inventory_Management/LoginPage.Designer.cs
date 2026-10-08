namespace Inventory_management
{
    partial class LoginPage
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
            BackBtn1 = new Button();
            LoginBtn1 = new Button();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            LoginStatus = new Label();
            LoginPassword = new Label();
            PassText3 = new TextBox();
            loginuserid = new Label();
            nameText2 = new TextBox();
            SuspendLayout();
            // 
            // BackBtn1
            // 
            BackBtn1.BackColor = SystemColors.ActiveCaption;
            BackBtn1.DialogResult = DialogResult.OK;
            BackBtn1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackBtn1.ForeColor = SystemColors.ActiveCaptionText;
            BackBtn1.Location = new Point(14, 12);
            BackBtn1.Name = "BackBtn1";
            BackBtn1.Size = new Size(62, 26);
            BackBtn1.TabIndex = 33;
            BackBtn1.Text = "Back";
            BackBtn1.UseVisualStyleBackColor = false;
            BackBtn1.Click += BackBtn1_Click;
            // 
            // LoginBtn1
            // 
            LoginBtn1.BackColor = SystemColors.ActiveCaption;
            LoginBtn1.DialogResult = DialogResult.OK;
            LoginBtn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn1.ForeColor = SystemColors.ActiveCaptionText;
            LoginBtn1.Location = new Point(1, 394);
            LoginBtn1.Name = "LoginBtn1";
            LoginBtn1.Size = new Size(798, 44);
            LoginBtn1.TabIndex = 32;
            LoginBtn1.Text = "Login";
            LoginBtn1.UseVisualStyleBackColor = false;
            LoginBtn1.Click += LoginBtn1_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton4.Location = new Point(336, 232);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(101, 21);
            radioButton4.TabIndex = 31;
            radioButton4.TabStop = true;
            radioButton4.Text = "Employee";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(226, 230);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(88, 24);
            radioButton3.TabIndex = 30;
            radioButton3.TabStop = true;
            radioButton3.Text = "Admin";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // LoginStatus
            // 
            LoginStatus.AutoSize = true;
            LoginStatus.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginStatus.Location = new Point(142, 230);
            LoginStatus.Name = "LoginStatus";
            LoginStatus.Size = new Size(64, 24);
            LoginStatus.TabIndex = 29;
            LoginStatus.Text = "Status:";
            // 
            // LoginPassword
            // 
            LoginPassword.AutoSize = true;
            LoginPassword.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginPassword.Location = new Point(142, 161);
            LoginPassword.Name = "LoginPassword";
            LoginPassword.Size = new Size(92, 24);
            LoginPassword.TabIndex = 28;
            LoginPassword.Text = "Password:";
            // 
            // PassText3
            // 
            PassText3.Location = new Point(240, 158);
            PassText3.Name = "PassText3";
            PassText3.Size = new Size(197, 27);
            PassText3.TabIndex = 27;
            // 
            // loginuserid
            // 
            loginuserid.AutoSize = true;
            loginuserid.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginuserid.Location = new Point(139, 96);
            loginuserid.Name = "loginuserid";
            loginuserid.Size = new Size(65, 24);
            loginuserid.TabIndex = 26;
            loginuserid.Text = "UserId:";
            loginuserid.Click += loginusername_Click;
            // 
            // nameText2
            // 
            nameText2.Location = new Point(240, 96);
            nameText2.Name = "nameText2";
            nameText2.Size = new Size(197, 27);
            nameText2.TabIndex = 25;
            nameText2.TextChanged += PassText2_TextChanged;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackBtn1);
            Controls.Add(LoginBtn1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(LoginStatus);
            Controls.Add(LoginPassword);
            Controls.Add(PassText3);
            Controls.Add(loginuserid);
            Controls.Add(nameText2);
            Name = "LoginPage";
            Text = "LoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn1;
        private Button LoginBtn1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label LoginStatus;
        private Label LoginPassword;
        private TextBox PassText3;
        private Label loginuserid;
        private TextBox nameText2;
    }
}