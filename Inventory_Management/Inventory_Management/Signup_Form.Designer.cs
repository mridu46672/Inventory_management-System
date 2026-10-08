namespace Inventory_management
{
    partial class Signup_Form
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
            SignupBtn1 = new Button();
            BackBtn = new Button();
            PassText1 = new TextBox();
            SignupId = new TextBox();
            PassText3 = new TextBox();
            SignupName = new Label();
            signup_userid = new Label();
            signupPassword = new Label();
            SignupStatus = new Label();
            rdBtn3 = new RadioButton();
            rdBtn4 = new RadioButton();
            SuspendLayout();
            // 
            // SignupBtn1
            // 
            SignupBtn1.BackColor = SystemColors.ActiveCaption;
            SignupBtn1.DialogResult = DialogResult.OK;
            SignupBtn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignupBtn1.ForeColor = SystemColors.ActiveCaptionText;
            SignupBtn1.Location = new Point(3, 394);
            SignupBtn1.Name = "SignupBtn1";
            SignupBtn1.Size = new Size(798, 44);
            SignupBtn1.TabIndex = 3;
            SignupBtn1.Text = "Signup";
            SignupBtn1.UseVisualStyleBackColor = false;
            SignupBtn1.Click += SignupBtn1_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = SystemColors.ActiveCaption;
            BackBtn.DialogResult = DialogResult.OK;
            BackBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackBtn.ForeColor = SystemColors.ActiveCaptionText;
            BackBtn.Location = new Point(3, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(62, 26);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // PassText1
            // 
            PassText1.Location = new Point(213, 93);
            PassText1.Name = "PassText1";
            PassText1.Size = new Size(197, 27);
            PassText1.TabIndex = 5;
            // 
            // SignupId
            // 
            SignupId.Location = new Point(213, 149);
            SignupId.Name = "SignupId";
            SignupId.Size = new Size(197, 27);
            SignupId.TabIndex = 6;
            // 
            // PassText3
            // 
            PassText3.Location = new Point(213, 208);
            PassText3.Name = "PassText3";
            PassText3.Size = new Size(197, 27);
            PassText3.TabIndex = 7;
            PassText3.TextChanged += textBox3_TextChanged;
            // 
            // SignupName
            // 
            SignupName.AutoSize = true;
            SignupName.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignupName.Location = new Point(115, 96);
            SignupName.Name = "SignupName";
            SignupName.Size = new Size(54, 24);
            SignupName.TabIndex = 8;
            SignupName.Text = "Name";
            // 
            // signup_userid
            // 
            signup_userid.AutoSize = true;
            signup_userid.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_userid.Location = new Point(112, 149);
            signup_userid.Name = "signup_userid";
            signup_userid.Size = new Size(65, 24);
            signup_userid.TabIndex = 9;
            signup_userid.Text = "UserId:";
            // 
            // signupPassword
            // 
            signupPassword.AutoSize = true;
            signupPassword.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupPassword.Location = new Point(112, 211);
            signupPassword.Name = "signupPassword";
            signupPassword.Size = new Size(92, 24);
            signupPassword.TabIndex = 10;
            signupPassword.Text = "Password:";
            // 
            // SignupStatus
            // 
            SignupStatus.AutoSize = true;
            SignupStatus.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignupStatus.Location = new Point(115, 271);
            SignupStatus.Name = "SignupStatus";
            SignupStatus.Size = new Size(64, 24);
            SignupStatus.TabIndex = 11;
            SignupStatus.Text = "Status:";
            SignupStatus.Click += Status_Click;
            // 
            // rdBtn3
            // 
            rdBtn3.AutoSize = true;
            rdBtn3.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdBtn3.Location = new Point(210, 268);
            rdBtn3.Name = "rdBtn3";
            rdBtn3.Size = new Size(88, 24);
            rdBtn3.TabIndex = 12;
            rdBtn3.TabStop = true;
            rdBtn3.Text = "Admin";
            rdBtn3.UseVisualStyleBackColor = true;
            // 
            // rdBtn4
            // 
            rdBtn4.AutoSize = true;
            rdBtn4.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdBtn4.Location = new Point(321, 271);
            rdBtn4.Name = "rdBtn4";
            rdBtn4.Size = new Size(101, 21);
            rdBtn4.TabIndex = 13;
            rdBtn4.TabStop = true;
            rdBtn4.Text = "Employee";
            rdBtn4.UseVisualStyleBackColor = true;
            // 
            // Signup_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rdBtn4);
            Controls.Add(rdBtn3);
            Controls.Add(SignupStatus);
            Controls.Add(signupPassword);
            Controls.Add(signup_userid);
            Controls.Add(SignupName);
            Controls.Add(PassText3);
            Controls.Add(SignupId);
            Controls.Add(PassText1);
            Controls.Add(BackBtn);
            Controls.Add(SignupBtn1);
            Name = "Signup_Form";
            Text = "Signup Form";
            Load += Signup_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignupBtn1;
        private Button BackBtn;
        private TextBox PassText1;
        private TextBox SignupId;
        private TextBox PassText3;
        private Label SignupName;
        private Label signup_userid;
        private Label signupPassword;
        private Label SignupStatus;
        private RadioButton rdBtn3;
        private RadioButton rdBtn4;
    }
}