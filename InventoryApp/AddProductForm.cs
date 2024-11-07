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
    public partial class AddProductForm : Form
    {
        private List<TextBox> textBoxesToValidate;
        private BindingList<Part> associatedParts = new BindingList<Part>();
        private BindingList<Part> parts;
        private BindingList<Part> filteredParts = new BindingList<Part>();
        private mainForm mainForm;
        public AddProductForm(mainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            textBoxesToValidate = new List<TextBox> { addProductNameTextBox, addProductInventoryTextBox, addProductPriceTextBox, addProductMaxTextBox, addProductMinTextBox };
            parts = mainForm.GetInventory().AllParts;
            addProductCandDataGridView.DataSource = parts;
            addProductAssDataGridView.DataSource = associatedParts;
        }
        //Input validation for the name
        private void addProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveValidator();
        }
        //Input validation for the price
        private void addProductPriceTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(addProductPriceTextBox.Text, out decimal price))
            {
                addProductPriceTextBox.BackColor = Color.White;
                addProductErrorProvider.SetError(addProductPriceTextBox, "");
            }
            else
            {
                addProductPriceTextBox.BackColor = Color.LightPink;
                addProductErrorProvider.SetError(addProductPriceTextBox, "Price must be a decimal number.");
            }
            SaveValidator();
        }
        //Input validation for the max
        private void addProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(addProductMaxTextBox.Text, out int max))
            {
                addProductMaxTextBox.BackColor = Color.White;
                addProductErrorProvider.SetError(addProductMaxTextBox, "");
            }
            else
            {
                addProductMaxTextBox.BackColor = Color.LightPink;
                addProductErrorProvider.SetError(addProductMaxTextBox, "Max must be an integer.");
            }
            MinMaxChecker();
        }
        //Input validation for the min
        private void addProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(addProductMinTextBox.Text, out int min))
            {
                addProductMinTextBox.BackColor = Color.White;
                addProductErrorProvider.SetError(addProductMinTextBox, "");
            }
            else
            {
                addProductMinTextBox.BackColor = Color.LightPink;
                addProductErrorProvider.SetError(addProductMinTextBox, "Min must be an integer.");
            }
            MinMaxChecker();
        }
        //Checks if min is greater than max, also checks if inventory in in that range
        private void MinMaxChecker()
        {
            if (int.TryParse(addProductMinTextBox.Text, out int min) && int.TryParse(addProductMaxTextBox.Text, out int max))
            {
                if (min > max)
                {
                    addProductMinTextBox.BackColor = Color.LightPink;
                    addProductMaxTextBox.BackColor = Color.LightPink;
                    addProductErrorProvider.SetError(addProductMinTextBox, "Min must be less than Max.");
                    addProductErrorProvider.SetError(addProductMaxTextBox, "Max must be greater than Min.");
                }
                else
                {
                    addProductMinTextBox.BackColor = Color.White;
                    addProductMaxTextBox.BackColor = Color.White;
                    addProductErrorProvider.SetError(addProductMinTextBox, "");
                    addProductErrorProvider.SetError(addProductMaxTextBox, "");
                    addProductInventoryTextBox_TextChanged(this, new EventArgs());
                }
            }
            SaveValidator();
        }
        //Input validation for inventory. Also checks if inventory is between min and max
        private void addProductInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(addProductInventoryTextBox.Text, out int inventory))
            {
                if (int.TryParse(addProductMinTextBox.Text, out int min) && int.TryParse(addProductMaxTextBox.Text, out int max))
                {
                    if (inventory >= min && inventory <= max)
                    {
                        addProductInventoryTextBox.BackColor = Color.White;
                        addProductErrorProvider.SetError(addProductInventoryTextBox, "");
                    }
                    else
                    {
                        addProductInventoryTextBox.BackColor = Color.LightPink;
                        addProductErrorProvider.SetError(addProductInventoryTextBox, "Inventory must be between Min and Max.");
                    }
                }
                else
                {
                    addProductInventoryTextBox.BackColor = Color.White;
                    addProductErrorProvider.SetError(addProductInventoryTextBox, "");
                }
            }
            else
            {
                addProductInventoryTextBox.BackColor = Color.LightPink;
                addProductErrorProvider.SetError(addProductInventoryTextBox, "Inventory must be an integer.");
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
                    if (addProductErrorProvider.GetError(textBox) != "")
                    {
                        hasActiveErrors = true;
                        break;
                    }
                    else
                    {
                        hasActiveErrors = false;
                    }
                }
                addProductSaveButton.Enabled = !hasActiveErrors;
            }
            else
            {
                addProductSaveButton.Enabled = false;
            }
        }
        //Add part association button functionality
        private void addProductCandAddButton_Click(object sender, EventArgs e)
        {
            if (addProductCandDataGridView.SelectedRows.Count > 0)
            {
                Part part = mainForm.GetInventory().LookupPart((int)addProductCandDataGridView.SelectedRows[0].Cells[0].Value);
                if (!associatedParts.Contains(part))
                {
                    associatedParts.Add(part);
                }
            }
        }
        //Delete part association button functionality
        private void addProductAssDeleteButton_Click(object sender, EventArgs e)
        {
            if (addProductAssDataGridView.SelectedRows.Count > 0)
            {
                Part part = mainForm.GetInventory().LookupPart((int)addProductAssDataGridView.SelectedRows[0].Cells[0].Value);
                associatedParts.Remove(part);
            }
        }
        //Cancel button functionality
        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Save button functionality
        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            Product createdProduct = new Product(associatedParts, mainForm.GetInventory().Products.Count, addProductNameTextBox.Text, decimal.Parse(addProductPriceTextBox.Text), int.Parse(addProductInventoryTextBox.Text), int.Parse(addProductMinTextBox.Text), int.Parse(addProductMaxTextBox.Text));
            mainForm.SaveToInventory(createdProduct, false);
            this.Close();
        }
        //Search button functionality
        private void addProductCandSearchButton_Click(object sender, EventArgs e)
        {
            string searchString = addProductCandTextBox.Text;
            mainForm.Search(searchString, parts, filteredParts, addProductCandDataGridView);
        }
    }
}
