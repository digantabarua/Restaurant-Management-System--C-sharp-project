
namespace HungerGames.V2._0.Presentation_Layer
{
    partial class Employee_Dashboard
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
            this.ShowUserbutton = new System.Windows.Forms.Button();
            this.storagebutton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowUserbutton
            // 
            this.ShowUserbutton.BackColor = System.Drawing.Color.Honeydew;
            this.ShowUserbutton.Location = new System.Drawing.Point(245, 163);
            this.ShowUserbutton.Name = "ShowUserbutton";
            this.ShowUserbutton.Size = new System.Drawing.Size(146, 37);
            this.ShowUserbutton.TabIndex = 39;
            this.ShowUserbutton.Text = "Show Information";
            this.ShowUserbutton.UseVisualStyleBackColor = false;
            this.ShowUserbutton.Click += new System.EventHandler(this.ShowUserbutton_Click);
            // 
            // storagebutton
            // 
            this.storagebutton.BackColor = System.Drawing.Color.Honeydew;
            this.storagebutton.Location = new System.Drawing.Point(462, 239);
            this.storagebutton.Name = "storagebutton";
            this.storagebutton.Size = new System.Drawing.Size(146, 37);
            this.storagebutton.TabIndex = 38;
            this.storagebutton.Text = "Show Storage";
            this.storagebutton.UseVisualStyleBackColor = false;
            this.storagebutton.Click += new System.EventHandler(this.storagebutton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Honeydew;
            this.LogOutButton.Location = new System.Drawing.Point(353, 321);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(146, 37);
            this.LogOutButton.TabIndex = 37;
            this.LogOutButton.Text = "Logout";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Honeydew;
            this.MenuButton.Location = new System.Drawing.Point(245, 239);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(146, 37);
            this.MenuButton.TabIndex = 36;
            this.MenuButton.Text = "Show Menu";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.Honeydew;
            this.OrderButton.Location = new System.Drawing.Point(462, 163);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(146, 37);
            this.OrderButton.TabIndex = 35;
            this.OrderButton.Text = "Place an order";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 35);
            this.label1.TabIndex = 34;
            this.label1.Text = "Welcome to Hunger Games System DashBord";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Employee_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowUserbutton);
            this.Controls.Add(this.storagebutton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.label1);
            this.Name = "Employee_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowUserbutton;
        private System.Windows.Forms.Button storagebutton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Label label1;
    }
}