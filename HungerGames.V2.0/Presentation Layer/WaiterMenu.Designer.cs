
namespace HungerGames.V2._0.Presentation_Layer
{
    partial class WaiterMenu
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
            this.Showbutton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Showbutton
            // 
            this.Showbutton.BackColor = System.Drawing.Color.Azure;
            this.Showbutton.Location = new System.Drawing.Point(60, 460);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(467, 48);
            this.Showbutton.TabIndex = 41;
            this.Showbutton.Text = "Show Menu";
            this.Showbutton.UseVisualStyleBackColor = false;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Azure;
            this.backButton.Location = new System.Drawing.Point(554, 460);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(460, 48);
            this.backButton.TabIndex = 40;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 429);
            this.dataGridView1.TabIndex = 39;
            // 
            // WaiterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 517);
            this.Controls.Add(this.Showbutton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WaiterMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaiterMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WaiterMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Showbutton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}