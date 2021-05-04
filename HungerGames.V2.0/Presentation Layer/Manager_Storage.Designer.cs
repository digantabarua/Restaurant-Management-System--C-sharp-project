
namespace HungerGames.V2._0.Presentation_Layer
{
    partial class Manager_Storage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dproductTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteInventoryButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StorageGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.newstorageButton = new System.Windows.Forms.Button();
            this.ProductNamelabel2 = new System.Windows.Forms.Label();
            this.pNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pQuantityTextBox = new System.Windows.Forms.TextBox();
            this.EditStorageButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StorageComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.ShowStorageButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.StorageGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dproductTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.deleteInventoryButton);
            this.groupBox1.Location = new System.Drawing.Point(450, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 83);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Product :";
            // 
            // dproductTextBox
            // 
            this.dproductTextBox.Location = new System.Drawing.Point(87, 38);
            this.dproductTextBox.Name = "dproductTextBox";
            this.dproductTextBox.Size = new System.Drawing.Size(180, 22);
            this.dproductTextBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Type ID :";
            // 
            // deleteInventoryButton
            // 
            this.deleteInventoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deleteInventoryButton.Location = new System.Drawing.Point(273, 31);
            this.deleteInventoryButton.Name = "deleteInventoryButton";
            this.deleteInventoryButton.Size = new System.Drawing.Size(132, 37);
            this.deleteInventoryButton.TabIndex = 34;
            this.deleteInventoryButton.Text = "Delete Inventory";
            this.deleteInventoryButton.UseVisualStyleBackColor = false;
            this.deleteInventoryButton.Click += new System.EventHandler(this.deleteInventoryButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(439, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(705, 361);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StorageGroupBox
            // 
            this.StorageGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.StorageGroupBox.Controls.Add(this.dateTimePicker1);
            this.StorageGroupBox.Controls.Add(this.label1);
            this.StorageGroupBox.Controls.Add(this.label6);
            this.StorageGroupBox.Controls.Add(this.priceTextBox);
            this.StorageGroupBox.Controls.Add(this.newstorageButton);
            this.StorageGroupBox.Controls.Add(this.ProductNamelabel2);
            this.StorageGroupBox.Controls.Add(this.pNameTextBox);
            this.StorageGroupBox.Controls.Add(this.label2);
            this.StorageGroupBox.Controls.Add(this.pQuantityTextBox);
            this.StorageGroupBox.Controls.Add(this.EditStorageButton);
            this.StorageGroupBox.Location = new System.Drawing.Point(88, 204);
            this.StorageGroupBox.Name = "StorageGroupBox";
            this.StorageGroupBox.Size = new System.Drawing.Size(345, 321);
            this.StorageGroupBox.TabIndex = 41;
            this.StorageGroupBox.TabStop = false;
            this.StorageGroupBox.Text = "Add into Storage";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Storage Month :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(136, 136);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 22);
            this.priceTextBox.TabIndex = 8;
            // 
            // newstorageButton
            // 
            this.newstorageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.newstorageButton.Location = new System.Drawing.Point(136, 193);
            this.newstorageButton.Name = "newstorageButton";
            this.newstorageButton.Size = new System.Drawing.Size(170, 37);
            this.newstorageButton.TabIndex = 5;
            this.newstorageButton.Text = "New Storage";
            this.newstorageButton.UseVisualStyleBackColor = false;
            this.newstorageButton.Click += new System.EventHandler(this.newstorageButton_Click);
            // 
            // ProductNamelabel2
            // 
            this.ProductNamelabel2.AutoSize = true;
            this.ProductNamelabel2.Location = new System.Drawing.Point(23, 28);
            this.ProductNamelabel2.Name = "ProductNamelabel2";
            this.ProductNamelabel2.Size = new System.Drawing.Size(102, 17);
            this.ProductNamelabel2.TabIndex = 1;
            this.ProductNamelabel2.Text = "Product Name:";
            // 
            // pNameTextBox
            // 
            this.pNameTextBox.Location = new System.Drawing.Point(136, 25);
            this.pNameTextBox.Name = "pNameTextBox";
            this.pNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.pNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity :";
            // 
            // pQuantityTextBox
            // 
            this.pQuantityTextBox.Location = new System.Drawing.Point(136, 59);
            this.pQuantityTextBox.Name = "pQuantityTextBox";
            this.pQuantityTextBox.Size = new System.Drawing.Size(200, 22);
            this.pQuantityTextBox.TabIndex = 4;
            // 
            // EditStorageButton
            // 
            this.EditStorageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EditStorageButton.Location = new System.Drawing.Point(136, 249);
            this.EditStorageButton.Name = "EditStorageButton";
            this.EditStorageButton.Size = new System.Drawing.Size(170, 37);
            this.EditStorageButton.TabIndex = 6;
            this.EditStorageButton.Text = "Edit Storage";
            this.EditStorageButton.UseVisualStyleBackColor = false;
            this.EditStorageButton.Click += new System.EventHandler(this.EditStorageButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backButton.Location = new System.Drawing.Point(974, 447);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(170, 34);
            this.backButton.TabIndex = 40;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(19, 28);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(109, 18);
            this.ProductLabel.TabIndex = 1;
            this.ProductLabel.Text = "Product Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Used Amount:";
            // 
            // StorageComboBox
            // 
            this.StorageComboBox.FormattingEnabled = true;
            this.StorageComboBox.Location = new System.Drawing.Point(162, 25);
            this.StorageComboBox.Name = "StorageComboBox";
            this.StorageComboBox.Size = new System.Drawing.Size(170, 24);
            this.StorageComboBox.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.StorageComboBox);
            this.groupBox2.Controls.Add(this.ProductLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.amountTextBox);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(88, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 177);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products Amount";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(136, 59);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(170, 24);
            this.amountTextBox.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addButton.Location = new System.Drawing.Point(136, 106);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(170, 37);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ShowStorageButton
            // 
            this.ShowStorageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ShowStorageButton.Location = new System.Drawing.Point(974, 391);
            this.ShowStorageButton.Name = "ShowStorageButton";
            this.ShowStorageButton.Size = new System.Drawing.Size(170, 37);
            this.ShowStorageButton.TabIndex = 43;
            this.ShowStorageButton.Text = "Show Storage";
            this.ShowStorageButton.UseVisualStyleBackColor = false;
            this.ShowStorageButton.Click += new System.EventHandler(this.ShowStorageButton_Click);
            // 
            // Manager_Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StorageGroupBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ShowStorageButton);
            this.Name = "Manager_Storage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Storage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_Storage_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.StorageGroupBox.ResumeLayout(false);
            this.StorageGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dproductTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteInventoryButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox StorageGroupBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button newstorageButton;
        private System.Windows.Forms.Label ProductNamelabel2;
        private System.Windows.Forms.TextBox pNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pQuantityTextBox;
        private System.Windows.Forms.Button EditStorageButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox StorageComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button ShowStorageButton;
    }
}