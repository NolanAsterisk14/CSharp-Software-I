using System.ComponentModel;

namespace InventoryApp
{
    public partial class mainForm : Form
    {
        private Inventory inventory = new Inventory();
        private BindingList<Part> filteredPartsList = new BindingList<Part>();
        private BindingList<Product> filteredProductsList = new BindingList<Product>();
        public mainForm()
        {
            InitializeComponent();
            InitializePartsList();
            InitializeProductsList();
        }

        private void InitializePartsList()
        {
            inventory.AddPart(new Inhouse(0, "Wheel", 12.11m, 15, 5, 25, 212));
            inventory.AddPart(new Inhouse(1, "Pedal", 8.22m, 11, 5, 25, 213));
            inventory.AddPart(new Inhouse(2, "Chain", 8.33m, 12, 5, 25, 213));
            inventory.AddPart(new Inhouse(3, "Seat", 4.55m, 8, 2, 15, 214));
            partsDataGridView.DataSource = inventory.AllParts;
        }
        private void InitializeProductsList()
        {
            inventory.AddProduct(new Product(new BindingList<Part>(), 0, "Red Bicycle", 11.44m, 15, 1, 25));
            inventory.AddProduct(new Product(new BindingList<Part>(), 1, "Yellow Bicycle", 9.66m, 19, 1, 20));
            inventory.AddProduct(new Product(new BindingList<Part>(), 2, "Blue Bicycle", 12.77m, 5, 1, 25));
            productsDataGridView.DataSource = inventory.Products;
        }

        //Search generic method
        public void Search<T>(string searchString, BindingList<T> sourceList, BindingList<T> filteredList, DataGridView dataGridView) where T : class
        {
            var filterQuery =
                from item in sourceList
                where item.GetType().GetProperty("Name").GetValue(item, null).ToString().ToLower().Contains(searchString)
                select item;
            if (string.IsNullOrEmpty(searchString))
            {
                filteredList.Clear();
                dataGridView.DataSource = sourceList;
            }
            else
            {
                filteredList.Clear();
                foreach (var item in filterQuery)
                {
                    filteredList.Add(item);
                }
                dataGridView.DataSource = filteredList;
            }
        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            string searchString = partsTextBox.Text;
            Search(searchString, inventory.AllParts, filteredPartsList, partsDataGridView);
        }
        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            string searchString = productsTextBox.Text;
            Search(searchString, inventory.Products, filteredProductsList, productsDataGridView);
        }
        //Open add part form
        private void partsAddButton_Click(object sender, EventArgs e)
        {
            addPartForm addPartForm = new addPartForm(this);
            addPartForm.ShowDialog();
        }
        //Open modify part form
        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            if (partsDataGridView.SelectedRows.Count > 0)
            {
                modifyPartForm modifyPartForm = new modifyPartForm(this);
                Part selectedPart = inventory.LookupPart((int)partsDataGridView.SelectedRows[0].Cells[0].Value);
                modifyPartForm.PopulateFields(selectedPart);
                modifyPartForm.ShowDialog();
            }
        }
        //Open part delete confirmation dialog, assuming the part isn't associated with a product
        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            if (partsDataGridView.SelectedRows.Count > 0)
            {
                bool partAssociated = false;
                foreach (Product product in inventory.Products)
                {
                    foreach (Part part in product.AssociatedParts)
                    {
                        if (part.PartID == (int)partsDataGridView.SelectedRows[0].Cells[0].Value)
                        {
                            partAssociated = true;
                        }
                    }
                }
                if (partAssociated)
                {
                    MessageBox.Show("This part is associated with a product and cannot be deleted.", "Error");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Part selectedPart = inventory.LookupPart((int)partsDataGridView.SelectedRows[0].Cells[0].Value);
                        inventory.DeletePart(selectedPart);
                    }
                }
                
            }

        }
        //Open add product form
        private void productsAddButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(this);
            addProductForm.ShowDialog();
        }
        //Open modify product form
        private void productsModifyButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.SelectedRows.Count > 0)
            {
                ModifyProductForm modifyProductForm = new ModifyProductForm(this);
                Product selectedProduct = inventory.LookupProduct((int)productsDataGridView.SelectedRows[0].Cells[0].Value);
                modifyProductForm.PopulateFields(selectedProduct);
                modifyProductForm.ShowDialog();
            }
        }
        //Open product delete confirmation dialog
        private void productsDeleteButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Product selectedProduct = inventory.LookupProduct((int)productsDataGridView.SelectedRows[0].Cells[0].Value);
                    inventory.RemoveProduct(selectedProduct.ProductID);
                }
            }
        }
        //Exit button functionality
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Save part to inventory (ensuring valid ID), or modify existing part
        public void SaveToInventory(Part part, bool isModifying)
        {
            bool partExists = false;
            bool idReassigned = false;
            List<int> ids = new List<int>();
            if (!isModifying)
            {
                //Check if part ID already exists, while adding IDs to list
                foreach (Part existingPart in inventory.AllParts)
                {
                    if (existingPart.PartID == part.PartID)
                    {
                        partExists = true;
                    }
                    ids.Add(existingPart.PartID);
                }
                //If part ID already exists, reassign ID to next available number
                if (partExists)
                {
                    int counter = 0;
                    do
                    {
                        if (!ids.Contains(counter))
                        {
                            part.PartID = counter;
                            idReassigned = true;
                        }
                        counter++;
                    } while (!idReassigned);
                }
                inventory.AddPart(part);
            }
            else
            {
                inventory.UpdatePart(part.PartID, part);
            }

        }
        public void SaveToInventory(Product product, bool isModifying)
        {
            bool productExists = false;
            bool idReassigned = false;
            List<int> ids = new List<int>();
            if (!isModifying)
            {
                //Check if product ID already exists, while adding IDs to list
                foreach (Product existingProduct in inventory.Products)
                {
                    if (existingProduct.ProductID == product.ProductID)
                    {
                        productExists = true;
                    }
                    ids.Add(existingProduct.ProductID);
                }
                //If product ID already exists, reassign ID to next available number
                if (productExists)
                {
                    int counter = 0;
                    do
                    {
                        if (!ids.Contains(counter))
                        {
                            product.ProductID = counter;
                            idReassigned = true;
                        }
                        counter++;
                    } while (!idReassigned);
                }
                inventory.AddProduct(product);
            }
            else
            {
                inventory.UpdateProduct(product.ProductID, product);
            }
        }
        //Pass a reference of the inventory instance
        public Inventory GetInventory()
        {
            return inventory;
        }


    }
}
