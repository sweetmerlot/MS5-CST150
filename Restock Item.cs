using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTracker
{
    public partial class Restock_Item : Form
    {
        private Form1 parent;
        private InventoryItemEntry itemToRestock;
        public Restock_Item(Form1 parent, InventoryItemEntry itemToRestock)
        {
            this.itemToRestock = itemToRestock;
            this.parent = parent;
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void restockButton_Click(object sender, EventArgs e)
        {                        
            int stockUpdate = int.Parse(restockQuantity.Text.ToString());
            InventoryManager.StockItem(itemToRestock.Item.Sku, stockUpdate);
            //parent.restockSelectedItem(stockUpdate);
            parent.RefreshList();
            this.Close();
        }

        private void Restock_Item_Load(object sender, EventArgs e)
        {
            if(itemToRestock == null)
            {
                MessageBox.Show("Select an item to restock");
                this.Close();
            }
            else
            {
                itemToRestockLabel.Text = itemToRestock.Item.ItemName + ":" + itemToRestock.Item.Sku;
                currentQuantityLabel.Text = itemToRestock.Count.ToString();
                                
            }
            
        }
    }
}
