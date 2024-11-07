namespace InventoryApp
{
    partial class modifyPartForm
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
            modifyPartLabel = new Label();
            modifyPartRadioInHouseButton = new RadioButton();
            modifyPartRadioOutsourcedButton = new RadioButton();
            modifyPartIDLabel = new Label();
            modifyPartNameLabel = new Label();
            modifyPartInventoryLabel = new Label();
            modifyPartPriceLabel = new Label();
            modifyPartMinLabel = new Label();
            modifyPartMaxLabel = new Label();
            modifyPartSubtypeLabel = new Label();
            modifyPartSaveButton = new Button();
            modifyPartCancelButton = new Button();
            modifyPartIDTextBox = new TextBox();
            modifyPartNameTextBox = new TextBox();
            modifyPartInventoryTextBox = new TextBox();
            modifyPartPriceTextBox = new TextBox();
            modifyPartMaxTextBox = new TextBox();
            modifyPartMinTextBox = new TextBox();
            modifyPartSubtypeTextBox = new TextBox();
            modifyPartErrorProvider = new ErrorProvider(components);
            modifyPartFormBindingSource = new BindingSource(components);
            mainFormBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)modifyPartErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modifyPartFormBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource).BeginInit();
            SuspendLayout();
            // 
            // modifyPartLabel
            // 
            modifyPartLabel.AutoSize = true;
            modifyPartLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyPartLabel.Location = new Point(16, 18);
            modifyPartLabel.Name = "modifyPartLabel";
            modifyPartLabel.Size = new Size(120, 30);
            modifyPartLabel.TabIndex = 0;
            modifyPartLabel.Text = "Modify Part";
            // 
            // modifyPartRadioInHouseButton
            // 
            modifyPartRadioInHouseButton.AutoSize = true;
            modifyPartRadioInHouseButton.Checked = true;
            modifyPartRadioInHouseButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyPartRadioInHouseButton.Location = new Point(170, 23);
            modifyPartRadioInHouseButton.Name = "modifyPartRadioInHouseButton";
            modifyPartRadioInHouseButton.Size = new Size(91, 25);
            modifyPartRadioInHouseButton.TabIndex = 1;
            modifyPartRadioInHouseButton.TabStop = true;
            modifyPartRadioInHouseButton.Text = "In-House";
            modifyPartRadioInHouseButton.UseVisualStyleBackColor = true;
            modifyPartRadioInHouseButton.CheckedChanged += modifyPartRadioInHouseButton_CheckedChanged;
            // 
            // modifyPartRadioOutsourcedButton
            // 
            modifyPartRadioOutsourcedButton.AutoSize = true;
            modifyPartRadioOutsourcedButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyPartRadioOutsourcedButton.Location = new Point(305, 23);
            modifyPartRadioOutsourcedButton.Name = "modifyPartRadioOutsourcedButton";
            modifyPartRadioOutsourcedButton.Size = new Size(109, 25);
            modifyPartRadioOutsourcedButton.TabIndex = 2;
            modifyPartRadioOutsourcedButton.Text = "Outsourced";
            modifyPartRadioOutsourcedButton.UseVisualStyleBackColor = true;
            modifyPartRadioOutsourcedButton.CheckedChanged += modifyPartRadioOutsourcedButton_CheckedChanged;
            // 
            // modifyPartIDLabel
            // 
            modifyPartIDLabel.AutoSize = true;
            modifyPartIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyPartIDLabel.Location = new Point(141, 107);
            modifyPartIDLabel.Name = "modifyPartIDLabel";
            modifyPartIDLabel.Size = new Size(25, 21);
            modifyPartIDLabel.TabIndex = 3;
            modifyPartIDLabel.Text = "ID";
            // 
            // modifyPartNameLabel
            // 
            modifyPartNameLabel.AutoSize = true;
            modifyPartNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyPartNameLabel.Location = new Point(114, 153);
            modifyPartNameLabel.Name = "modifyPartNameLabel";
            modifyPartNameLabel.Size = new Size(52, 21);
            modifyPartNameLabel.TabIndex = 4;
            modifyPartNameLabel.Text = "Name";
            // 
            // modifyPartInventoryLabel
            // 
            modifyPartInventoryLabel.AutoSize = true;
            modifyPartInventoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyPartInventoryLabel.Location = new Point(90, 199);
            modifyPartInventoryLabel.Name = "modifyPartInventoryLabel";
            modifyPartInventoryLabel.Size = new Size(76, 21);
            modifyPartInventoryLabel.TabIndex = 5;
            modifyPartInventoryLabel.Text = "Inventory";
            // 
            // modifyPartPriceLabel
            // 
            modifyPartPriceLabel.AutoSize = true;
            modifyPartPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyPartPriceLabel.Location = new Point(77, 245);
            modifyPartPriceLabel.Name = "modifyPartPriceLabel";
            modifyPartPriceLabel.Size = new Size(89, 21);
            modifyPartPriceLabel.TabIndex = 6;
            modifyPartPriceLabel.Text = "Price / Cost";
            // 
            // modifyPartMinLabel
            // 
            modifyPartMinLabel.AutoSize = true;
            modifyPartMinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyPartMinLabel.Location = new Point(316, 292);
            modifyPartMinLabel.Name = "modifyPartMinLabel";
            modifyPartMinLabel.Size = new Size(37, 21);
            modifyPartMinLabel.TabIndex = 7;
            modifyPartMinLabel.Text = "Min";
            // 
            // modifyPartMaxLabel
            // 
            modifyPartMaxLabel.AutoSize = true;
            modifyPartMaxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyPartMaxLabel.Location = new Point(127, 292);
            modifyPartMaxLabel.Name = "modifyPartMaxLabel";
            modifyPartMaxLabel.Size = new Size(39, 21);
            modifyPartMaxLabel.TabIndex = 8;
            modifyPartMaxLabel.Text = "Max";
            // 
            // modifyPartSubtypeLabel
            // 
            modifyPartSubtypeLabel.AutoSize = true;
            modifyPartSubtypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyPartSubtypeLabel.Location = new Point(43, 340);
            modifyPartSubtypeLabel.Name = "modifyPartSubtypeLabel";
            modifyPartSubtypeLabel.Size = new Size(88, 21);
            modifyPartSubtypeLabel.TabIndex = 9;
            modifyPartSubtypeLabel.Text = "Machine ID";
            // 
            // modifyPartSaveButton
            // 
            modifyPartSaveButton.Location = new Point(338, 390);
            modifyPartSaveButton.Name = "modifyPartSaveButton";
            modifyPartSaveButton.Size = new Size(60, 34);
            modifyPartSaveButton.TabIndex = 10;
            modifyPartSaveButton.Text = "Save";
            modifyPartSaveButton.UseVisualStyleBackColor = true;
            modifyPartSaveButton.Click += modifyPartSaveButton_Click;
            // 
            // modifyPartCancelButton
            // 
            modifyPartCancelButton.Location = new Point(422, 390);
            modifyPartCancelButton.Name = "modifyPartCancelButton";
            modifyPartCancelButton.Size = new Size(60, 34);
            modifyPartCancelButton.TabIndex = 11;
            modifyPartCancelButton.Text = "Cancel";
            modifyPartCancelButton.UseVisualStyleBackColor = true;
            modifyPartCancelButton.Click += modifyPartCancelButton_Click;
            // 
            // modifyPartIDTextBox
            // 
            modifyPartIDTextBox.Enabled = false;
            modifyPartIDTextBox.Location = new Point(209, 107);
            modifyPartIDTextBox.MinimumSize = new Size(0, 28);
            modifyPartIDTextBox.Name = "modifyPartIDTextBox";
            modifyPartIDTextBox.Size = new Size(144, 28);
            modifyPartIDTextBox.TabIndex = 12;
            // 
            // modifyPartNameTextBox
            // 
            modifyPartNameTextBox.Location = new Point(209, 153);
            modifyPartNameTextBox.MinimumSize = new Size(0, 28);
            modifyPartNameTextBox.Name = "modifyPartNameTextBox";
            modifyPartNameTextBox.Size = new Size(144, 28);
            modifyPartNameTextBox.TabIndex = 13;
            modifyPartNameTextBox.TextChanged += modifyPartNameTextBox_TextChanged;
            // 
            // modifyPartInventoryTextBox
            // 
            modifyPartInventoryTextBox.Location = new Point(209, 199);
            modifyPartInventoryTextBox.MinimumSize = new Size(0, 28);
            modifyPartInventoryTextBox.Name = "modifyPartInventoryTextBox";
            modifyPartInventoryTextBox.Size = new Size(144, 28);
            modifyPartInventoryTextBox.TabIndex = 14;
            modifyPartInventoryTextBox.TextChanged += modifyPartInventoryTextBox_TextChanged;
            // 
            // modifyPartPriceTextBox
            // 
            modifyPartPriceTextBox.Location = new Point(209, 245);
            modifyPartPriceTextBox.MinimumSize = new Size(0, 28);
            modifyPartPriceTextBox.Name = "modifyPartPriceTextBox";
            modifyPartPriceTextBox.Size = new Size(144, 28);
            modifyPartPriceTextBox.TabIndex = 15;
            modifyPartPriceTextBox.TextChanged += modifyPartPriceTextBox_TextChanged;
            // 
            // modifyPartMaxTextBox
            // 
            modifyPartMaxTextBox.Location = new Point(209, 292);
            modifyPartMaxTextBox.MinimumSize = new Size(0, 28);
            modifyPartMaxTextBox.Name = "modifyPartMaxTextBox";
            modifyPartMaxTextBox.Size = new Size(75, 28);
            modifyPartMaxTextBox.TabIndex = 16;
            modifyPartMaxTextBox.TextChanged += modifyPartMaxTextBox_TextChanged;
            // 
            // modifyPartMinTextBox
            // 
            modifyPartMinTextBox.Location = new Point(390, 292);
            modifyPartMinTextBox.MinimumSize = new Size(0, 28);
            modifyPartMinTextBox.Name = "modifyPartMinTextBox";
            modifyPartMinTextBox.Size = new Size(75, 28);
            modifyPartMinTextBox.TabIndex = 17;
            modifyPartMinTextBox.TextChanged += modifyPartMinTextBox_TextChanged;
            // 
            // modifyPartSubtypeTextBox
            // 
            modifyPartSubtypeTextBox.Location = new Point(209, 340);
            modifyPartSubtypeTextBox.MinimumSize = new Size(0, 28);
            modifyPartSubtypeTextBox.Name = "modifyPartSubtypeTextBox";
            modifyPartSubtypeTextBox.Size = new Size(144, 28);
            modifyPartSubtypeTextBox.TabIndex = 18;
            modifyPartSubtypeTextBox.TextChanged += modifyPartSubtypeTextBox_TextChanged;
            // 
            // modifyPartErrorProvider
            // 
            modifyPartErrorProvider.ContainerControl = this;
            modifyPartErrorProvider.DataSource = modifyPartFormBindingSource;
            // 
            // modifyPartFormBindingSource
            // 
            modifyPartFormBindingSource.DataSource = typeof(modifyPartForm);
            // 
            // mainFormBindingSource
            // 
            mainFormBindingSource.DataSource = typeof(mainForm);
            // 
            // modifyPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(567, 450);
            Controls.Add(modifyPartSubtypeTextBox);
            Controls.Add(modifyPartMinTextBox);
            Controls.Add(modifyPartMaxTextBox);
            Controls.Add(modifyPartPriceTextBox);
            Controls.Add(modifyPartInventoryTextBox);
            Controls.Add(modifyPartNameTextBox);
            Controls.Add(modifyPartIDTextBox);
            Controls.Add(modifyPartCancelButton);
            Controls.Add(modifyPartSaveButton);
            Controls.Add(modifyPartSubtypeLabel);
            Controls.Add(modifyPartMaxLabel);
            Controls.Add(modifyPartMinLabel);
            Controls.Add(modifyPartPriceLabel);
            Controls.Add(modifyPartInventoryLabel);
            Controls.Add(modifyPartNameLabel);
            Controls.Add(modifyPartIDLabel);
            Controls.Add(modifyPartRadioOutsourcedButton);
            Controls.Add(modifyPartRadioInHouseButton);
            Controls.Add(modifyPartLabel);
            Name = "modifyPartForm";
            Text = "Part";
            ((System.ComponentModel.ISupportInitialize)modifyPartErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)modifyPartFormBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label modifyPartLabel;
        private RadioButton modifyPartRadioInHouseButton;
        private RadioButton modifyPartRadioOutsourcedButton;
        private Label modifyPartIDLabel;
        private Label modifyPartNameLabel;
        private Label modifyPartInventoryLabel;
        private Label modifyPartPriceLabel;
        private Label modifyPartMinLabel;
        private Label modifyPartMaxLabel;
        private Label modifyPartSubtypeLabel;
        private Button modifyPartSaveButton;
        private Button modifyPartCancelButton;
        private TextBox modifyPartIDTextBox;
        private TextBox modifyPartNameTextBox;
        private TextBox modifyPartInventoryTextBox;
        private TextBox modifyPartPriceTextBox;
        private TextBox modifyPartMaxTextBox;
        private TextBox modifyPartMinTextBox;
        private TextBox modifyPartSubtypeTextBox;
        private ErrorProvider modifyPartErrorProvider;
        private BindingSource modifyPartFormBindingSource;
        private BindingSource mainFormBindingSource;
    }
}