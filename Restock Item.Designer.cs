
namespace InventoryTracker
{
    partial class Restock_Item
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
            this.restockButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.restockQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemToRestockLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currentQuantityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // restockButton
            // 
            this.restockButton.Location = new System.Drawing.Point(20, 149);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(75, 23);
            this.restockButton.TabIndex = 0;
            this.restockButton.Text = "Restock";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(132, 149);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Canel";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity Change:";
            // 
            // restockQuantity
            // 
            this.restockQuantity.Location = new System.Drawing.Point(132, 109);
            this.restockQuantity.Name = "restockQuantity";
            this.restockQuantity.Size = new System.Drawing.Size(75, 20);
            this.restockQuantity.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Restock Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Restocking:";
            // 
            // itemToRestockLabel
            // 
            this.itemToRestockLabel.AutoSize = true;
            this.itemToRestockLabel.Location = new System.Drawing.Point(17, 68);
            this.itemToRestockLabel.Name = "itemToRestockLabel";
            this.itemToRestockLabel.Size = new System.Drawing.Size(0, 13);
            this.itemToRestockLabel.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Current Quantity";
            // 
            // currentQuantityLabel
            // 
            this.currentQuantityLabel.AutoSize = true;
            this.currentQuantityLabel.Location = new System.Drawing.Point(143, 68);
            this.currentQuantityLabel.Name = "currentQuantityLabel";
            this.currentQuantityLabel.Size = new System.Drawing.Size(0, 13);
            this.currentQuantityLabel.TabIndex = 18;
            // 
            // Restock_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 207);
            this.Controls.Add(this.currentQuantityLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemToRestockLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.restockQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.restockButton);
            this.Name = "Restock_Item";
            this.Text = "Restock_Item";
            this.Load += new System.EventHandler(this.Restock_Item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button restockButton;
        public System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox restockQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label itemToRestockLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currentQuantityLabel;
    }
}