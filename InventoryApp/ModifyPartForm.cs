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
    public partial class modifyPartForm : Form
    {
        private List<TextBox> textBoxesToValidate;
        private mainForm mainForm;
        public modifyPartForm(mainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            textBoxesToValidate = new List<TextBox> { modifyPartNameTextBox, modifyPartInventoryTextBox, modifyPartPriceTextBox, modifyPartMaxTextBox, modifyPartMinTextBox, modifyPartSubtypeTextBox };
        }
        public void PopulateFields(Part part)
        {
            modifyPartIDTextBox.Text = part.PartID.ToString();
            modifyPartNameTextBox.Text = part.Name;
            modifyPartInventoryTextBox.Text = part.InStock.ToString();
            modifyPartPriceTextBox.Text = part.Price.ToString();
            modifyPartMaxTextBox.Text = part.Max.ToString();
            modifyPartMinTextBox.Text = part.Min.ToString();
            if (part is Inhouse)
            {
                modifyPartSubtypeTextBox.Text = ((Inhouse)part).MachineID.ToString();
            }
            else
            {
                modifyPartSubtypeTextBox.Text = ((Outsourced)part).CompanyName;
            }
        }
        //Input validation for the name
        private void modifyPartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveValidator();
        }
        //Input validation for the price
        private void modifyPartPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(modifyPartPriceTextBox.Text, out decimal price))
            {
                modifyPartPriceTextBox.BackColor = Color.White;
                modifyPartErrorProvider.SetError(modifyPartPriceTextBox, "");
            }
            else
            {
                modifyPartPriceTextBox.BackColor = Color.LightPink;
                modifyPartErrorProvider.SetError(modifyPartPriceTextBox, "Price must be a decimal number.");
            }
            SaveValidator();
        }
        //Input validation for the max
        private void modifyPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(modifyPartMaxTextBox.Text, out int max))
            {
                modifyPartMaxTextBox.BackColor = Color.White;
                modifyPartErrorProvider.SetError(modifyPartMaxTextBox, "");
            }
            else
            {
                modifyPartMaxTextBox.BackColor = Color.LightPink;
                modifyPartErrorProvider.SetError(modifyPartMaxTextBox, "Max must be an integer.");
            }
            MinMaxChecker();
        }
        //Input validation for the min
        private void modifyPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(modifyPartMinTextBox.Text, out int min))
            {
                modifyPartMinTextBox.BackColor = Color.White;
                modifyPartErrorProvider.SetError(modifyPartMinTextBox, "");
            }
            else
            {
                modifyPartMinTextBox.BackColor = Color.LightPink;
                modifyPartErrorProvider.SetError(modifyPartMinTextBox, "Min must be an integer.");
            }
            MinMaxChecker();
        }
        //Checks if min is greater than max
        private void MinMaxChecker()
        {
            if (int.TryParse(modifyPartMinTextBox.Text, out int min) && int.TryParse(modifyPartMaxTextBox.Text, out int max))
            {
                if (min > max)
                {
                    modifyPartMinTextBox.BackColor = Color.LightPink;
                    modifyPartMaxTextBox.BackColor = Color.LightPink;
                    modifyPartErrorProvider.SetError(modifyPartMinTextBox, "Min must be less than Max.");
                    modifyPartErrorProvider.SetError(modifyPartMaxTextBox, "Max must be greater than Min.");
                }
                else
                {
                    modifyPartMinTextBox.BackColor = Color.White;
                    modifyPartMaxTextBox.BackColor = Color.White;
                    modifyPartErrorProvider.SetError(modifyPartMinTextBox, "");
                    modifyPartErrorProvider.SetError(modifyPartMaxTextBox, "");
                    modifyPartInventoryTextBox_TextChanged(this, new EventArgs());
                }
            }
            SaveValidator();
        }
        //Input validation for inventory. Also checks if inventory is between min and max
        private void modifyPartInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(modifyPartInventoryTextBox.Text, out int inventory))
            {
                if (int.TryParse(modifyPartMinTextBox.Text, out int min) && int.TryParse(modifyPartMaxTextBox.Text, out int max))
                {
                    if (inventory >= min && inventory <= max)
                    {
                        modifyPartInventoryTextBox.BackColor = Color.White;
                        modifyPartErrorProvider.SetError(modifyPartInventoryTextBox, "");
                    }
                    else
                    {
                        modifyPartInventoryTextBox.BackColor = Color.LightPink;
                        modifyPartErrorProvider.SetError(modifyPartInventoryTextBox, "Inventory must be between Min and Max.");
                    }
                }
                else
                {
                    modifyPartInventoryTextBox.BackColor = Color.White;
                    modifyPartErrorProvider.SetError(modifyPartInventoryTextBox, "");
                }
            }
            else
            {
                modifyPartInventoryTextBox.BackColor = Color.LightPink;
                modifyPartErrorProvider.SetError(modifyPartInventoryTextBox, "Inventory must be an integer.");
            }
            SaveValidator();
        }
        //Input validation for subtype textbox
        private void modifyPartSubtypeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (modifyPartSubtypeLabel.Text == "Machine ID")
            {
                if (int.TryParse(modifyPartSubtypeTextBox.Text, out int machineID))
                {
                    modifyPartSubtypeTextBox.BackColor = Color.White;
                    modifyPartErrorProvider.SetError(modifyPartSubtypeTextBox, "");
                }
                else
                {
                    modifyPartSubtypeTextBox.BackColor = Color.LightPink;
                    modifyPartErrorProvider.SetError(modifyPartSubtypeTextBox, "Machine ID must be an integer.");
                }
            }
            SaveValidator();
        }

        //Inhouse toggle functionality
        private void modifyPartRadioInHouseButton_CheckedChanged(object sender, EventArgs e)
        {
            modifyPartSubtypeLabel.Text = "Machine ID";
        }
        //Outsourced toggle functionality
        private void modifyPartRadioOutsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            modifyPartSubtypeLabel.Text = "Company Name";
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
                    if (modifyPartErrorProvider.GetError(textBox) != "")
                    {
                        hasActiveErrors = true;
                        break;
                    }
                    else
                    {
                        hasActiveErrors = false;
                    }
                }
                modifyPartSaveButton.Enabled = !hasActiveErrors;
            }
            else
            {
                modifyPartSaveButton.Enabled = false;
            }
        }

        //Cancel button functionality
        private void modifyPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Save button functionality
        private void modifyPartSaveButton_Click(object sender, EventArgs e)
        {
            if (modifyPartRadioInHouseButton.Checked)
            {
                Inhouse createdPart = new Inhouse(int.Parse(modifyPartIDTextBox.Text), modifyPartNameTextBox.Text, decimal.Parse(modifyPartPriceTextBox.Text), int.Parse(modifyPartInventoryTextBox.Text), int.Parse(modifyPartMinTextBox.Text), int.Parse(modifyPartMaxTextBox.Text), int.Parse(modifyPartSubtypeTextBox.Text));
                mainForm.SaveToInventory(createdPart, true);
            }
            else
            {
                Outsourced createdPart = new Outsourced(int.Parse(modifyPartIDTextBox.Text), modifyPartNameTextBox.Text, decimal.Parse(modifyPartPriceTextBox.Text), int.Parse(modifyPartInventoryTextBox.Text), int.Parse(modifyPartMinTextBox.Text), int.Parse(modifyPartMaxTextBox.Text), modifyPartSubtypeTextBox.Text);
                mainForm.SaveToInventory(createdPart, true);
            }
            this.Close();
        }
    }
}
