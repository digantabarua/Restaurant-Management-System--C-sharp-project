
namespace HungerGames.V2._0.Presentation_Layer
{
    partial class Manager_Dashboard
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
            this.button1 = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.StorageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(816, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 76);
            this.button1.TabIndex = 37;
            this.button1.Text = "Show Information";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.LightCyan;
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(816, 425);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(232, 64);
            this.LogOutButton.TabIndex = 36;
            this.LogOutButton.Text = "Logout";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.LightCyan;
            this.MenuButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.Location = new System.Drawing.Point(816, 126);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(232, 76);
            this.MenuButton.TabIndex = 35;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // StorageButton
            // 
            this.StorageButton.BackColor = System.Drawing.Color.LightCyan;
            this.StorageButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorageButton.Location = new System.Drawing.Point(816, 227);
            this.StorageButton.Name = "StorageButton";
            this.StorageButton.Size = new System.Drawing.Size(232, 76);
            this.StorageButton.TabIndex = 34;
            this.StorageButton.Text = "Show Storage";
            this.StorageButton.UseVisualStyleBackColor = false;
            this.StorageButton.Click += new System.EventHandler(this.StorageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(151, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 38);
            this.label1.TabIndex = 33;
            this.label1.Text = "Welcome to Hunger Games System DashBoard";
            // 
            // Manager_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.StorageButton);
            this.Controls.Add(this.label1);
            this.Name = "Manager_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Manager_Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button StorageButton;
        private System.Windows.Forms.Label label1;
    }
}