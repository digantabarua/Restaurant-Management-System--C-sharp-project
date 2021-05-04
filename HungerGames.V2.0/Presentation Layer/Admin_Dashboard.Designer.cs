
namespace HungerGames.V2._0.Presentation_Layer
{
    partial class Admin_Dashboard
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
            this.OrderHistorybutton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.StorageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrderHistorybutton
            // 
            this.OrderHistorybutton.BackColor = System.Drawing.Color.Transparent;
            this.OrderHistorybutton.Location = new System.Drawing.Point(851, 306);
            this.OrderHistorybutton.Name = "OrderHistorybutton";
            this.OrderHistorybutton.Size = new System.Drawing.Size(177, 69);
            this.OrderHistorybutton.TabIndex = 44;
            this.OrderHistorybutton.Text = "Order History";
            this.OrderHistorybutton.UseVisualStyleBackColor = false;
            this.OrderHistorybutton.Click += new System.EventHandler(this.OrderHistorybutton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.Location = new System.Drawing.Point(851, 428);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(177, 49);
            this.LogOutButton.TabIndex = 43;
            this.LogOutButton.Text = "Logout";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuButton.Location = new System.Drawing.Point(851, 154);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(177, 70);
            this.MenuButton.TabIndex = 42;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.BackColor = System.Drawing.Color.Transparent;
            this.EmployeesButton.Location = new System.Drawing.Point(851, 78);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(177, 70);
            this.EmployeesButton.TabIndex = 41;
            this.EmployeesButton.Text = "Employees Edit";
            this.EmployeesButton.UseVisualStyleBackColor = false;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // StorageButton
            // 
            this.StorageButton.BackColor = System.Drawing.Color.Transparent;
            this.StorageButton.Location = new System.Drawing.Point(851, 230);
            this.StorageButton.Name = "StorageButton";
            this.StorageButton.Size = new System.Drawing.Size(177, 70);
            this.StorageButton.TabIndex = 40;
            this.StorageButton.Text = "Show Storage";
            this.StorageButton.UseVisualStyleBackColor = false;
            this.StorageButton.Click += new System.EventHandler(this.StorageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(169, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 43);
            this.label1.TabIndex = 39;
            this.label1.Text = "Hunger Games Admin DashBord";
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 486);
            this.Controls.Add(this.OrderHistorybutton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.EmployeesButton);
            this.Controls.Add(this.StorageButton);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrderHistorybutton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button StorageButton;
        private System.Windows.Forms.Label label1;
    }
}