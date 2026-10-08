namespace Inventory_management
{
    partial class WellCome_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WellCome_Page));
            label1 = new Label();
            LoginBtn = new Button();
            SignupBtn = new Button();
            TT = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Snow;
            label1.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 61);
            label1.Name = "label1";
            label1.Size = new Size(457, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Inventory Management";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.ActiveCaption;
            LoginBtn.DialogResult = DialogResult.OK;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = SystemColors.ActiveCaptionText;
            LoginBtn.Location = new Point(463, 254);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(94, 44);
            LoginBtn.TabIndex = 1;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // SignupBtn
            // 
            SignupBtn.BackColor = SystemColors.ActiveCaption;
            SignupBtn.DialogResult = DialogResult.OK;
            SignupBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignupBtn.ForeColor = SystemColors.ActiveCaptionText;
            SignupBtn.Location = new Point(224, 254);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(94, 44);
            SignupBtn.TabIndex = 2;
            SignupBtn.Text = "Signup";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // TT
            // 
            TT.AutoSize = true;
            TT.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TT.Location = new Point(128, 228);
            TT.Name = "TT";
            TT.Size = new Size(190, 23);
            TT.TabIndex = 3;
            TT.Text = "Don't have an account?";
            TT.Click += label2_Click;
            // 
            // WellCome_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(TT);
            Controls.Add(SignupBtn);
            Controls.Add(LoginBtn);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "WellCome_Page";
            Text = "Welcome page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button LoginBtn;
        private Button SignupBtn;
        private Label TT;
    }
}
