namespace CST_117_Milestone_4
{
    partial class inventoryManagerForm
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
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightOutput = new System.Windows.Forms.Label();
            this.priceOutput = new System.Windows.Forms.Label();
            this.quantityOutput = new System.Windows.Forms.Label();
            this.descOutput = new System.Windows.Forms.Label();
            this.nameOutput = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.restockButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.Location = new System.Drawing.Point(12, 45);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(179, 160);
            this.inventoryListBox.TabIndex = 0;
            this.inventoryListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(232, 53);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(232, 90);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(232, 140);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Quantity";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(232, 172);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(37, 13);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price: ";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(232, 206);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(47, 13);
            this.weightLabel.TabIndex = 5;
            this.weightLabel.Text = "Weight: ";
            // 
            // weightOutput
            // 
            this.weightOutput.AutoSize = true;
            this.weightOutput.Location = new System.Drawing.Point(318, 206);
            this.weightOutput.Name = "weightOutput";
            this.weightOutput.Size = new System.Drawing.Size(0, 13);
            this.weightOutput.TabIndex = 10;
            // 
            // priceOutput
            // 
            this.priceOutput.AutoSize = true;
            this.priceOutput.Location = new System.Drawing.Point(318, 172);
            this.priceOutput.Name = "priceOutput";
            this.priceOutput.Size = new System.Drawing.Size(0, 13);
            this.priceOutput.TabIndex = 9;
            // 
            // quantityOutput
            // 
            this.quantityOutput.AutoSize = true;
            this.quantityOutput.Location = new System.Drawing.Point(318, 140);
            this.quantityOutput.Name = "quantityOutput";
            this.quantityOutput.Size = new System.Drawing.Size(0, 13);
            this.quantityOutput.TabIndex = 8;
            // 
            // descOutput
            // 
            this.descOutput.AutoSize = true;
            this.descOutput.Location = new System.Drawing.Point(318, 90);
            this.descOutput.Name = "descOutput";
            this.descOutput.Size = new System.Drawing.Size(0, 13);
            this.descOutput.TabIndex = 7;
            // 
            // nameOutput
            // 
            this.nameOutput.AutoSize = true;
            this.nameOutput.Location = new System.Drawing.Point(318, 53);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(0, 13);
            this.nameOutput.TabIndex = 6;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(12, 227);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(95, 23);
            this.addItemButton.TabIndex = 11;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(13, 256);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(94, 23);
            this.removeButton.TabIndex = 12;
            this.removeButton.Text = "Remove Item";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // restockButton
            // 
            this.restockButton.Enabled = false;
            this.restockButton.Location = new System.Drawing.Point(12, 285);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(94, 23);
            this.restockButton.TabIndex = 13;
            this.restockButton.Text = "Restock Item";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.RestockButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(59, 16);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(469, 20);
            this.SearchTextBox.TabIndex = 14;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 19);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(41, 13);
            this.searchLabel.TabIndex = 15;
            this.searchLabel.Text = "Search";
            // 
            // inventoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.restockButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.weightOutput);
            this.Controls.Add(this.priceOutput);
            this.Controls.Add(this.quantityOutput);
            this.Controls.Add(this.descOutput);
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.inventoryListBox);
            this.Name = "inventoryManagerForm";
            this.Text = "Ray Programming Inventory Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label weightOutput;
        private System.Windows.Forms.Label priceOutput;
        private System.Windows.Forms.Label quantityOutput;
        private System.Windows.Forms.Label descOutput;
        private System.Windows.Forms.Label nameOutput;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label searchLabel;
    }
}

