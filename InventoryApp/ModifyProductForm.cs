using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    /*Note for evaluator(s) and possible future employers looking at this code:
     *I know that using generic functions for the input validation would make it easier to change or add behaviors to
     *the various forms that validate input fields. I arrived at that conclusion once I was nearly done with the project,
     *and opted not to spend extra time refactoring all the forms to use generic functions.
    */
    public partial class ModifyProductForm : Form
    {
        private List<TextBox> textBoxesToValidate;
        private BindingList<Part> associatedParts = new BindingList<Part>();
        private BindingList<Part> parts;
        private BindingList<Part> filteredParts = new BindingList<Part>();
        private mainForm mainForm;
        public ModifyProductForm(mainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            textBoxesToValidate = new List<TextBox> { modifyProductNameTextBox, modifyProductInventoryTextBox, modifyProductPriceTextBox, modifyProductMaxTextBox, modifyProductMinTextBox };
            parts = mainForm.GetInventory().AllParts;
            modifyProductCandDataGridView.DataSource = parts;
            modifyProductAssDataGridView.DataSource = associatedParts;
        }
        public void PopulateFields(Product product)
        {
            modifyProductIDTextBox.Text = product.ProductID.ToString();
            modifyProductNameTextBox.Text = product.Name;
            modifyProductInventoryTextBox.Text = product.InStock.ToString();
            modifyProductPriceTextBox.Text = product.Price.ToString();
            modifyProductMaxTextBox.Text = product.Max.ToString();
            modifyProductMinTextBox.Text = product.Min.ToString();
            associatedParts = product.AssociatedParts;
            modifyProductAssDataGridView.DataSource = associatedParts;
        }
        //Input validation for the name
        private void modifyProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveValidator();
        }
        //Input validation for the price
        private void modifyProductPriceTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(modifyProductPriceTextBox.Text, out decimal price))
            {
                modifyProductPriceTextBox.BackColor = Color.White;
                modifyProductErrorProvider.SetError(modifyProductPriceTextBox, "");
            }
            else
            {
                modifyProductPriceTextBox.BackColor = Color.LightPink;
                modifyProductErrorProvider.SetError(modifyProductPriceTextBox, "Price must be a decimal number.");
            }
            SaveValidator();
        }
        //Input validation for the max
        private void modifyProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(modifyProductMaxTextBox.Text, out int max))
            {
                modifyProductMaxTextBox.BackColor = Color.White;
                modifyProductErrorProvider.SetError(modifyProductMaxTextBox, "");
            }
            else
            {
                modifyProductMaxTextBox.BackColor = Color.LightPink;
                modifyProductErrorProvider.SetError(modifyProductMaxTextBox, "Max must be an integer.");
            }
            MinMaxChecker();
        }
        //Input validation for the min
        private void modifyProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(modifyProductMinTextBox.Text, out int min))
            {
                modifyProductMinTextBox.BackColor = Color.White;
                modifyProductErrorProvider.SetError(modifyProductMinTextBox, "");
            }
            else
            {
                modifyProductMinTextBox.BackColor = Color.LightPink;
                modifyProductErrorProvider.SetError(modifyProductMinTextBox, "Min must be an integer.");
            }
            MinMaxChecker();
        }
        //Checks if min is greater than max, also checks if inventory in in that range
        private void MinMaxChecker()
        {
            if (int.TryParse(modifyProductMinTextBox.Text, out int min) && int.TryParse(modifyProductMaxTextBox.Text, out int max))
            {
                if (min > max)
                {
                    modifyProductMinTextBox.BackColor = Color.LightPink;
                    modifyProductMaxTextBox.BackColor = Color.LightPink;
                    modifyProductErrorProvider.SetError(modifyProductMinTextBox, "Min must be less than Max.");
                    modifyProductErrorProvider.SetError(modifyProductMaxTextBox, "Max must be greater than Min.");
                }
                else
                {
                    modifyProductMinTextBox.BackColor = Color.White;
                    modifyProductMaxTextBox.BackColor = Color.White;
                    modifyProductErrorProvider.SetError(modifyProductMinTextBox, "");
                    modifyProductErrorProvider.SetError(modifyProductMaxTextBox, "");
                    modifyProductInventoryTextBox_TextChanged(this, new EventArgs());
                }
            }
            SaveValidator();
        }
        //Input validation for inventory. Also checks if inventory is between min and max
        private void modifyProductInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(modifyProductInventoryTextBox.Text, out int inventory))
            {
                if (int.TryParse(modifyProductMinTextBox.Text, out int min) && int.TryParse(modifyProductMaxTextBox.Text, out int max))
                {
                    if (inventory >= min && inventory <= max)
                    {
                        modifyProductInventoryTextBox.BackColor = Color.White;
                        modifyProductErrorProvider.SetError(modifyProductInventoryTextBox, "");
                    }
                    else
                    {
                        modifyProductInventoryTextBox.BackColor = Color.LightPink;
                        modifyProductErrorProvider.SetError(modifyProductInventoryTextBox, "Inventory must be between Min and Max.");
                    }
                }
                else
                {
                    modifyProductInventoryTextBox.BackColor = Color.White;
                    modifyProductErrorProvider.SetError(modifyProductInventoryTextBox, "");
                }
            }
            else
            {
                modifyProductInventoryTextBox.BackColor = Color.LightPink;
                modifyProductErrorProvider.SetError(modifyProductInventoryTextBox, "Inventory must be an integer.");
            }
            SaveValidator();
        }

        //Validates that all fields are filled and contain valid data, then toggles the save button accordingly
        private void SaveValidator()
        {
            bool isEmpty = true;
            bool hasActiveErrors = true;
            //Determine if any textboxes are empty
            foreach (TextBox textBox in textBoxesToValidate)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    isEmpty = true;
                    break;
                }
                else
                {
                    isEmpty = false;
                }
            }
            //If no textboxes are empty, check for active errors
            if (!isEmpty)
            {
                foreach (TextBox textBox in textBoxesToValidate)
                {
                    if (modifyProductErrorProvider.GetError(textBox) != "")
                    {
                        hasActiveErrors = true;
                        break;
                    }
                    else
                    {
                        hasActiveErrors = false;
                    }
                }
                modifyProductSaveButton.Enabled = !hasActiveErrors;
            }
            else
            {
                modifyProductSaveButton.Enabled = false;
            }
        }
        //Add part association button functionality
        private void modifyProductCandAddButton_Click(object sender, EventArgs e)
        {
            if (modifyProductCandDataGridView.SelectedRows.Count > 0)
            {
                Part part = mainForm.GetInventory().LookupPart((int)modifyProductCandDataGridView.SelectedRows[0].Cells[0].Value);
                if (!associatedParts.Contains(part))
                {
                    associatedParts.Add(part);
                }
            }
        }
        //Delete part association button functionality
        private void modifyProductAssDeleteButton_Click(object sender, EventArgs e)
        {
            if (modifyProductAssDataGridView.SelectedRows.Count > 0)
            {
                Part part = mainForm.GetInventory().LookupPart((int)modifyProductAssDataGridView.SelectedRows[0].Cells[0].Value);
                associatedParts.Remove(part);
            }
        }
        //Cancel button functionality
        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Save button functionality
        private void modifyProductSaveButton_Click(object sender, EventArgs e)
        {
            Product createdProduct = new Product(associatedParts, int.Parse(modifyProductIDTextBox.Text), modifyProductNameTextBox.Text, decimal.Parse(modifyProductPriceTextBox.Text), int.Parse(modifyProductInventoryTextBox.Text), int.Parse(modifyProductMinTextBox.Text), int.Parse(modifyProductMaxTextBox.Text));
            mainForm.SaveToInventory(createdProduct, true);
            this.Close();
        }
        //Search button functionality
        private void modifyProductCandSearchButton_Click(object sender, EventArgs e)
        {
            string searchString = modifyProductCandTextBox.Text;
            mainForm.Search(searchString, parts, filteredParts, modifyProductCandDataGridView);
        }
    }
}
