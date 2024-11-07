using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
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
    public partial class addPartForm : Form
    {
        private List<TextBox> textBoxesToValidate;
        private mainForm mainForm;
        public addPartForm(mainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            textBoxesToValidate = new List<TextBox> { addPartNameTextBox, addPartInventoryTextBox, addPartPriceTextBox, addPartMaxTextBox, addPartMinTextBox, addPartSubtypeTextBox };
        }
        //Input validation for the name
        private void addPartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveValidator();
        }
        //Input validation for the price
        private void addPartPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(addPartPriceTextBox.Text, out decimal price))
            {
                addPartPriceTextBox.BackColor = Color.White;
                addPartErrorProvider.SetError(addPartPriceTextBox, "");
            }
            else
            {
                addPartPriceTextBox.BackColor = Color.LightPink;
                addPartErrorProvider.SetError(addPartPriceTextBox, "Price must be a decimal number.");
            }
            SaveValidator();
        }
        //Input validation for the max
        private void addPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(addPartMaxTextBox.Text, out int max))
            {
                addPartMaxTextBox.BackColor = Color.White;
                addPartErrorProvider.SetError(addPartMaxTextBox, "");
            }
            else
            {
                addPartMaxTextBox.BackColor = Color.LightPink;
                addPartErrorProvider.SetError(addPartMaxTextBox, "Max must be an integer.");
            }
            MinMaxChecker();
        }
        //Input validation for the min
        private void addPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(addPartMinTextBox.Text, out int min))
            {
                addPartMinTextBox.BackColor = Color.White;
                addPartErrorProvider.SetError(addPartMinTextBox, "");
            }
            else
            {
                addPartMinTextBox.BackColor = Color.LightPink;
                addPartErrorProvider.SetError(addPartMinTextBox, "Min must be an integer.");
            }
            MinMaxChecker();
        }
        //Checks if min is greater than max
        private void MinMaxChecker()
        {
            if (int.TryParse(addPartMinTextBox.Text, out int min) && int.TryParse(addPartMaxTextBox.Text, out int max))
            {
                if (min > max)
                {
                    addPartMinTextBox.BackColor = Color.LightPink;
                    addPartMaxTextBox.BackColor = Color.LightPink;
                    addPartErrorProvider.SetError(addPartMinTextBox, "Min must be less than Max.");
                    addPartErrorProvider.SetError(addPartMaxTextBox, "Max must be greater than Min.");
                }
                else
                {
                    addPartMinTextBox.BackColor = Color.White;
                    addPartMaxTextBox.BackColor = Color.White;
                    addPartErrorProvider.SetError(addPartMinTextBox, "");
                    addPartErrorProvider.SetError(addPartMaxTextBox, "");
                    addPartInventoryTextBox_TextChanged(this, new EventArgs());
                }
            }
            SaveValidator();
        }
        //Input validation for inventory. Also checks if inventory is between min and max
        private void addPartInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(addPartInventoryTextBox.Text, out int inventory))
            {
                if (int.TryParse(addPartMinTextBox.Text, out int min) && int.TryParse(addPartMaxTextBox.Text, out int max))
                {
                    if (inventory >= min && inventory <= max)
                    {
                        addPartInventoryTextBox.BackColor = Color.White;
                        addPartErrorProvider.SetError(addPartInventoryTextBox, "");
                    }
                    else
                    {
                        addPartInventoryTextBox.BackColor = Color.LightPink;
                        addPartErrorProvider.SetError(addPartInventoryTextBox, "Inventory must be between Min and Max.");
                    }
                }
                else
                {
                    addPartInventoryTextBox.BackColor = Color.White;
                    addPartErrorProvider.SetError(addPartInventoryTextBox, "");
                }
            }
            else
            {
                addPartInventoryTextBox.BackColor = Color.LightPink;
                addPartErrorProvider.SetError(addPartInventoryTextBox, "Inventory must be an integer.");
            }
            SaveValidator();
        }
        //Input validation for subtype textbox
        private void addPartSubtypeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addPartSubtypeLabel.Text == "Machine ID")
            {
                if (int.TryParse(addPartSubtypeTextBox.Text, out int machineID))
                {
                    addPartSubtypeTextBox.BackColor = Color.White;
                    addPartErrorProvider.SetError(addPartSubtypeTextBox, "");
                }
                else
                {
                    addPartSubtypeTextBox.BackColor = Color.LightPink;
                    addPartErrorProvider.SetError(addPartSubtypeTextBox, "Machine ID must be an integer.");
                }
            }
            SaveValidator();
        }

        //Inhouse toggle functionality
        private void addPartRadioInHouseButton_CheckedChanged(object sender, EventArgs e)
        {
            addPartSubtypeLabel.Text = "Machine ID";
        }
        //Outsourced toggle functionality
        private void addPartRadioOutsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            addPartSubtypeLabel.Text = "Company Name";
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
                    if (addPartErrorProvider.GetError(textBox) != "")
                    {
                        hasActiveErrors = true;
                        break;
                    }
                    else
                    {
                        hasActiveErrors = false;
                    }
                }
                addPartSaveButton.Enabled = !hasActiveErrors;
            }
            else
            {
                addPartSaveButton.Enabled = false;
            }
        }

        //Cancel button functionality
        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Save button functionality
        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            if (addPartRadioInHouseButton.Checked)
            {
                Inhouse createdPart = new Inhouse(mainForm.GetInventory().AllParts.Count, addPartNameTextBox.Text, decimal.Parse(addPartPriceTextBox.Text), int.Parse(addPartInventoryTextBox.Text), int.Parse(addPartMinTextBox.Text), int.Parse(addPartMaxTextBox.Text), int.Parse(addPartSubtypeTextBox.Text));
                mainForm.SaveToInventory(createdPart, false);
            }
            else
            {
                Outsourced createdPart = new Outsourced(mainForm.GetInventory().AllParts.Count, addPartNameTextBox.Text, decimal.Parse(addPartPriceTextBox.Text), int.Parse(addPartInventoryTextBox.Text), int.Parse(addPartMinTextBox.Text), int.Parse(addPartMaxTextBox.Text), addPartSubtypeTextBox.Text);
                mainForm.SaveToInventory(createdPart, false);
            }
            this.Close();
        }
    }
}
