namespace InventoryApp
{
    partial class addPartForm
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
            components = new System.ComponentModel.Container();
            addPartLabel = new Label();
            addPartRadioInHouseButton = new RadioButton();
            addPartRadioOutsourcedButton = new RadioButton();
            addPartIDLabel = new Label();
            addPartNameLabel = new Label();
            addPartInventoryLabel = new Label();
            addPartPriceLabel = new Label();
            addPartMinLabel = new Label();
            addPartMaxLabel = new Label();
            addPartSubtypeLabel = new Label();
            addPartSaveButton = new Button();
            addPartCancelButton = new Button();
            addPartIDTextBox = new TextBox();
            addPartNameTextBox = new TextBox();
            addPartInventoryTextBox = new TextBox();
            addPartPriceTextBox = new TextBox();
            addPartMaxTextBox = new TextBox();
            addPartMinTextBox = new TextBox();
            addPartSubtypeTextBox = new TextBox();
            addPartErrorProvider = new ErrorProvider(components);
            addPartFormBindingSource = new BindingSource(components);
            mainFormBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)addPartErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addPartFormBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource).BeginInit();
            SuspendLayout();
            // 
            // addPartLabel
            // 
            addPartLabel.AutoSize = true;
            addPartLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPartLabel.Location = new Point(12, 18);
            addPartLabel.Name = "addPartLabel";
            addPartLabel.Size = new Size(93, 30);
            addPartLabel.TabIndex = 0;
            addPartLabel.Text = "Add Part";
            // 
            // addPartRadioInHouseButton
            // 
            addPartRadioInHouseButton.AutoSize = true;
            addPartRadioInHouseButton.Checked = true;
            addPartRadioInHouseButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPartRadioInHouseButton.Location = new Point(166, 23);
            addPartRadioInHouseButton.Name = "addPartRadioInHouseButton";
            addPartRadioInHouseButton.Size = new Size(91, 25);
            addPartRadioInHouseButton.TabIndex = 1;
            addPartRadioInHouseButton.TabStop = true;
            addPartRadioInHouseButton.Text = "In-House";
            addPartRadioInHouseButton.UseVisualStyleBackColor = true;
            addPartRadioInHouseButton.CheckedChanged += addPartRadioInHouseButton_CheckedChanged;
            // 
            // addPartRadioOutsourcedButton
            // 
            addPartRadioOutsourcedButton.AutoSize = true;
            addPartRadioOutsourcedButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPartRadioOutsourcedButton.Location = new Point(301, 23);
            addPartRadioOutsourcedButton.Name = "addPartRadioOutsourcedButton";
            addPartRadioOutsourcedButton.Size = new Size(109, 25);
            addPartRadioOutsourcedButton.TabIndex = 2;
            addPartRadioOutsourcedButton.Text = "Outsourced";
            addPartRadioOutsourcedButton.UseVisualStyleBackColor = true;
            addPartRadioOutsourcedButton.CheckedChanged += addPartRadioOutsourcedButton_CheckedChanged;
            // 
            // addPartIDLabel
            // 
            addPartIDLabel.AutoSize = true;
            addPartIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPartIDLabel.Location = new Point(137, 107);
            addPartIDLabel.Name = "addPartIDLabel";
            addPartIDLabel.Size = new Size(25, 21);
            addPartIDLabel.TabIndex = 3;
            addPartIDLabel.Text = "ID";
            // 
            // addPartNameLabel
            // 
            addPartNameLabel.AutoSize = true;
            addPartNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPartNameLabel.Location = new Point(110, 153);
            addPartNameLabel.Name = "addPartNameLabel";
            addPartNameLabel.Size = new Size(52, 21);
            addPartNameLabel.TabIndex = 4;
            addPartNameLabel.Text = "Name";
            // 
            // addPartInventoryLabel
            // 
            addPartInventoryLabel.AutoSize = true;
            addPartInventoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPartInventoryLabel.Location = new Point(86, 199);
            addPartInventoryLabel.Name = "addPartInventoryLabel";
            addPartInventoryLabel.Size = new Size(76, 21);
            addPartInventoryLabel.TabIndex = 5;
            addPartInventoryLabel.Text = "Inventory";
            // 
            // addPartPriceLabel
            // 
            addPartPriceLabel.AutoSize = true;
            addPartPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPartPriceLabel.Location = new Point(73, 245);
            addPartPriceLabel.Name = "addPartPriceLabel";
            addPartPriceLabel.Size = new Size(89, 21);
            addPartPriceLabel.TabIndex = 6;
            addPartPriceLabel.Text = "Price / Cost";
            // 
            // addPartMinLabel
            // 
            addPartMinLabel.AutoSize = true;
            addPartMinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPartMinLabel.Location = new Point(312, 292);
            addPartMinLabel.Name = "addPartMinLabel";
            addPartMinLabel.Size = new Size(37, 21);
            addPartMinLabel.TabIndex = 7;
            addPartMinLabel.Text = "Min";
            // 
            // addPartMaxLabel
            // 
            addPartMaxLabel.AutoSize = true;
            addPartMaxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPartMaxLabel.Location = new Point(123, 292);
            addPartMaxLabel.Name = "addPartMaxLabel";
            addPartMaxLabel.Size = new Size(39, 21);
            addPartMaxLabel.TabIndex = 8;
            addPartMaxLabel.Text = "Max";
            // 
            // addPartSubtypeLabel
            // 
            addPartSubtypeLabel.AutoSize = true;
            addPartSubtypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPartSubtypeLabel.Location = new Point(39, 340);
            addPartSubtypeLabel.Name = "addPartSubtypeLabel";
            addPartSubtypeLabel.Size = new Size(88, 21);
            addPartSubtypeLabel.TabIndex = 9;
            addPartSubtypeLabel.Text = "Machine ID";
            // 
            // addPartSaveButton
            // 
            addPartSaveButton.Enabled = false;
            addPartSaveButton.Location = new Point(334, 390);
            addPartSaveButton.Name = "addPartSaveButton";
            addPartSaveButton.Size = new Size(60, 34);
            addPartSaveButton.TabIndex = 10;
            addPartSaveButton.Text = "Save";
            addPartSaveButton.UseVisualStyleBackColor = true;
            addPartSaveButton.Click += addPartSaveButton_Click;
            // 
            // addPartCancelButton
            // 
            addPartCancelButton.Location = new Point(418, 390);
            addPartCancelButton.Name = "addPartCancelButton";
            addPartCancelButton.Size = new Size(60, 34);
            addPartCancelButton.TabIndex = 11;
            addPartCancelButton.Text = "Cancel";
            addPartCancelButton.UseVisualStyleBackColor = true;
            addPartCancelButton.Click += addPartCancelButton_Click;
            // 
            // addPartIDTextBox
            // 
            addPartIDTextBox.Enabled = false;
            addPartIDTextBox.Location = new Point(205, 107);
            addPartIDTextBox.MinimumSize = new Size(0, 28);
            addPartIDTextBox.Name = "addPartIDTextBox";
            addPartIDTextBox.Size = new Size(144, 28);
            addPartIDTextBox.TabIndex = 12;
            // 
            // addPartNameTextBox
            // 
            addPartNameTextBox.Location = new Point(205, 153);
            addPartNameTextBox.MinimumSize = new Size(0, 28);
            addPartNameTextBox.Name = "addPartNameTextBox";
            addPartNameTextBox.Size = new Size(144, 28);
            addPartNameTextBox.TabIndex = 13;
            addPartNameTextBox.TextChanged += addPartNameTextBox_TextChanged;
            // 
            // addPartInventoryTextBox
            // 
            addPartInventoryTextBox.Location = new Point(205, 199);
            addPartInventoryTextBox.MinimumSize = new Size(0, 28);
            addPartInventoryTextBox.Name = "addPartInventoryTextBox";
            addPartInventoryTextBox.Size = new Size(144, 28);
            addPartInventoryTextBox.TabIndex = 14;
            addPartInventoryTextBox.TextChanged += addPartInventoryTextBox_TextChanged;
            // 
            // addPartPriceTextBox
            // 
            addPartPriceTextBox.Location = new Point(205, 245);
            addPartPriceTextBox.MinimumSize = new Size(0, 28);
            addPartPriceTextBox.Name = "addPartPriceTextBox";
            addPartPriceTextBox.Size = new Size(144, 28);
            addPartPriceTextBox.TabIndex = 15;
            addPartPriceTextBox.TextChanged += addPartPriceTextBox_TextChanged;
            // 
            // addPartMaxTextBox
            // 
            addPartMaxTextBox.Location = new Point(205, 292);
            addPartMaxTextBox.MinimumSize = new Size(0, 28);
            addPartMaxTextBox.Name = "addPartMaxTextBox";
            addPartMaxTextBox.Size = new Size(75, 28);
            addPartMaxTextBox.TabIndex = 16;
            addPartMaxTextBox.TextChanged += addPartMaxTextBox_TextChanged;
            // 
            // addPartMinTextBox
            // 
            addPartMinTextBox.Location = new Point(386, 292);
            addPartMinTextBox.MinimumSize = new Size(0, 28);
            addPartMinTextBox.Name = "addPartMinTextBox";
            addPartMinTextBox.Size = new Size(75, 28);
            addPartMinTextBox.TabIndex = 17;
            addPartMinTextBox.TextChanged += addPartMinTextBox_TextChanged;
            // 
            // addPartSubtypeTextBox
            // 
            addPartSubtypeTextBox.Location = new Point(205, 340);
            addPartSubtypeTextBox.MinimumSize = new Size(0, 28);
            addPartSubtypeTextBox.Name = "addPartSubtypeTextBox";
            addPartSubtypeTextBox.Size = new Size(144, 28);
            addPartSubtypeTextBox.TabIndex = 18;
            addPartSubtypeTextBox.TextChanged += addPartSubtypeTextBox_TextChanged;
            // 
            // addPartErrorProvider
            // 
            addPartErrorProvider.ContainerControl = this;
            addPartErrorProvider.DataSource = addPartFormBindingSource;
            // 
            // addPartFormBindingSource
            // 
            addPartFormBindingSource.DataSource = typeof(addPartForm);
            // 
            // mainFormBindingSource
            // 
            mainFormBindingSource.DataSource = typeof(mainForm);
            // 
            // addPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(567, 450);
            Controls.Add(addPartSubtypeTextBox);
            Controls.Add(addPartMinTextBox);
            Controls.Add(addPartMaxTextBox);
            Controls.Add(addPartPriceTextBox);
            Controls.Add(addPartInventoryTextBox);
            Controls.Add(addPartNameTextBox);
            Controls.Add(addPartIDTextBox);
            Controls.Add(addPartCancelButton);
            Controls.Add(addPartSaveButton);
            Controls.Add(addPartSubtypeLabel);
            Controls.Add(addPartMaxLabel);
            Controls.Add(addPartMinLabel);
            Controls.Add(addPartPriceLabel);
            Controls.Add(addPartInventoryLabel);
            Controls.Add(addPartNameLabel);
            Controls.Add(addPartIDLabel);
            Controls.Add(addPartRadioOutsourcedButton);
            Controls.Add(addPartRadioInHouseButton);
            Controls.Add(addPartLabel);
            Name = "addPartForm";
            Text = "Part";
            ((System.ComponentModel.ISupportInitialize)addPartErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)addPartFormBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addPartLabel;
        private RadioButton addPartRadioInHouseButton;
        private RadioButton addPartRadioOutsourcedButton;
        private Label addPartIDLabel;
        private Label addPartNameLabel;
        private Label addPartInventoryLabel;
        private Label addPartPriceLabel;
        private Label addPartMinLabel;
        private Label addPartMaxLabel;
        private Label addPartSubtypeLabel;
        private Button addPartSaveButton;
        private Button addPartCancelButton;
        private TextBox addPartIDTextBox;
        private TextBox addPartNameTextBox;
        private TextBox addPartInventoryTextBox;
        private TextBox addPartPriceTextBox;
        private TextBox addPartMaxTextBox;
        private TextBox addPartMinTextBox;
        private TextBox addPartSubtypeTextBox;
        private ErrorProvider addPartErrorProvider;
        private BindingSource addPartFormBindingSource;
        private BindingSource mainFormBindingSource;
    }
}