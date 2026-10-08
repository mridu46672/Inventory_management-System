namespace Inventory_management
{
    partial class DashboardA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardA));
            ProfileBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // ProfileBtn
            // 
            ProfileBtn.BackgroundImage = Properties.Resources.Profile;
            ProfileBtn.BackgroundImageLayout = ImageLayout.Zoom;
            ProfileBtn.Location = new Point(68, 96);
            ProfileBtn.Name = "ProfileBtn";
            ProfileBtn.Size = new Size(116, 83);
            ProfileBtn.TabIndex = 2;
            ProfileBtn.UseVisualStyleBackColor = true;
            ProfileBtn.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(220, 95);
            button1.Name = "button1";
            button1.Size = new Size(154, 84);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(417, 95);
            button2.Name = "button2";
            button2.Size = new Size(109, 84);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(68, 237);
            button3.Name = "button3";
            button3.Size = new Size(110, 77);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(220, 237);
            button4.Name = "button4";
            button4.Size = new Size(154, 77);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Location = new Point(397, 237);
            button5.Name = "button5";
            button5.Size = new Size(129, 77);
            button5.TabIndex = 7;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // DashboardA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ProfileBtn);
            Name = "DashboardA";
            Text = "DashboardA";
            ResumeLayout(false);
        }

        #endregion
        private Button ProfileBtn;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}