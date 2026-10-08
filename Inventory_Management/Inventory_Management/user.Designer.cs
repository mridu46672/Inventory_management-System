namespace Inventory_management
{
    partial class user
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
            textBox3 = new TextBox();
            profileUserId = new Label();
            profileName = new Label();
            profilePass = new Label();
            profileStatus = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(464, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // profileUserId
            // 
            profileUserId.AutoSize = true;
            profileUserId.Location = new Point(58, 53);
            profileUserId.Name = "profileUserId";
            profileUserId.Size = new Size(81, 20);
            profileUserId.TabIndex = 3;
            profileUserId.Text = "EmpUserId";
            // 
            // profileName
            // 
            profileName.AutoSize = true;
            profileName.Location = new Point(58, 151);
            profileName.Name = "profileName";
            profileName.Size = new Size(49, 20);
            profileName.TabIndex = 4;
            profileName.Text = "Name";
            // 
            // profilePass
            // 
            profilePass.AutoSize = true;
            profilePass.Location = new Point(58, 99);
            profilePass.Name = "profilePass";
            profilePass.Size = new Size(81, 20);
            profilePass.TabIndex = 5;
            profilePass.Text = "EmpUserId";
            // 
            // profileStatus
            // 
            profileStatus.AutoSize = true;
            profileStatus.Location = new Point(58, 212);
            profileStatus.Name = "profileStatus";
            profileStatus.Size = new Size(81, 20);
            profileStatus.TabIndex = 6;
            profileStatus.Text = "EmpUserId";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 32);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 7;
            label1.Text = "EmpUserId";
            label1.Click += label1_Click;
            // 
            // user
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(profileStatus);
            Controls.Add(profilePass);
            Controls.Add(profileName);
            Controls.Add(profileUserId);
            Controls.Add(textBox3);
            Name = "user";
            Text = "user";
            Load += user_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label profileUserId;
        private Label profileName;
        private Label profilePass;
        private Label profileStatus;
        private Label label1;
    }
}