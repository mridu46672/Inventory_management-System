namespace Inventory_management
{
    partial class DashboardEM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardEM));
            ProfileBtn1 = new Button();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            PassText1 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // ProfileBtn1
            // 
            ProfileBtn1.BackgroundImage = Properties.Resources.Profile;
            ProfileBtn1.BackgroundImageLayout = ImageLayout.Zoom;
            ProfileBtn1.Location = new Point(25, 29);
            ProfileBtn1.Name = "ProfileBtn1";
            ProfileBtn1.Size = new Size(125, 83);
            ProfileBtn1.TabIndex = 3;
            ProfileBtn1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(25, 237);
            button1.Name = "button1";
            button1.Size = new Size(125, 82);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(25, 132);
            button2.Name = "button2";
            button2.Size = new Size(125, 84);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Location = new Point(25, 336);
            button5.Name = "button5";
            button5.Size = new Size(125, 79);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // PassText1
            // 
            PassText1.Location = new Point(362, 85);
            PassText1.Name = "PassText1";
            PassText1.Size = new Size(197, 27);
            PassText1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(362, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(362, 304);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 27);
            textBox3.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 88);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 13;
            label1.Text = "Product Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 196);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 14;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(263, 304);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 15;
            label3.Text = "Quantity ";
            // 
            // button3
            // 
            button3.Location = new Point(511, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 16;
            button3.Text = "Sold";
            button3.UseVisualStyleBackColor = true;
            // 
            // DashboardEM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(PassText1);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ProfileBtn1);
            Name = "DashboardEM";
            Text = "DashboardEM";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ProfileBtn1;
        private Button button1;
        private Button button2;
        private Button button5;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox PassText1;
        private Button button3;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}