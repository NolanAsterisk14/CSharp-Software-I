namespace InventoryApp
{
    partial class AddProductForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            addProductCandPanel = new Panel();
            addProductCandDataGridView = new DataGridView();
            addProductCandLabel = new Label();
            addProductCandAddButton = new Button();
            addProductCandTextBox = new TextBox();
            addProductCandSearchButton = new Button();
            addProductLabel = new Label();
            addProductAssPanel = new Panel();
            addProductAssDataGridView = new DataGridView();
            addProductAssLabel = new Label();
            addProductAssDeleteButton = new Button();
            addProductCancelButton = new Button();
            addProductSaveButton = new Button();
            addProductPriceTextBox = new TextBox();
            addProductInventoryTextBox = new TextBox();
            addProductNameTextBox = new TextBox();
            addProductIDTextBox = new TextBox();
            addProductMaxLabel = new Label();
            addProductMinLabel = new Label();
            addProductPriceLabel = new Label();
            addProductInventoryLabel = new Label();
            addProductNameLabel = new Label();
            addProductIDLabel = new Label();
            addProductMaxTextBox = new TextBox();
            addProductMinTextBox = new TextBox();
            addProductErrorProvider = new ErrorProvider(components);
            addProductCandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addProductCandDataGridView).BeginInit();
            addProductAssPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addProductAssDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addProductErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // addProductCandPanel
            // 
            addProductCandPanel.AutoScroll = true;
            addProductCandPanel.BackColor = SystemColors.ControlDark;
            addProductCandPanel.Controls.Add(addProductCandDataGridView);
            addProductCandPanel.Location = new Point(506, 100);
            addProductCandPanel.Name = "addProductCandPanel";
            addProductCandPanel.Size = new Size(668, 289);
            addProductCandPanel.TabIndex = 18;
            // 
            // addProductCandDataGridView
            // 
            addProductCandDataGridView.AllowUserToAddRows = false;
            addProductCandDataGridView.AllowUserToDeleteRows = false;
            addProductCandDataGridView.AllowUserToResizeColumns = false;
            addProductCandDataGridView.AllowUserToResizeRows = false;
            addProductCandDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            addProductCandDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            addProductCandDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            addProductCandDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            addProductCandDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            addProductCandDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            addProductCandDataGridView.Location = new Point(0, 0);
            addProductCandDataGridView.MultiSelect = false;
            addProductCandDataGridView.Name = "addProductCandDataGridView";
            addProductCandDataGridView.RowHeadersVisible = false;
            addProductCandDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Padding = new Padding(0, 10, 0, 10);
            addProductCandDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            addProductCandDataGridView.RowTemplate.Height = 60;
            addProductCandDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addProductCandDataGridView.Size = new Size(668, 286);
            addProductCandDataGridView.TabIndex = 1;
            // 
            // addProductCandLabel
            // 
            addProductCandLabel.AutoSize = true;
            addProductCandLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductCandLabel.Location = new Point(506, 63);
            addProductCandLabel.Name = "addProductCandLabel";
            addProductCandLabel.Size = new Size(137, 21);
            addProductCandLabel.TabIndex = 15;
            addProductCandLabel.Text = "All candidate Parts";
            // 
            // addProductCandAddButton
            // 
            addProductCandAddButton.Location = new Point(1079, 408);
            addProductCandAddButton.Name = "addProductCandAddButton";
            addProductCandAddButton.Size = new Size(66, 38);
            addProductCandAddButton.TabIndex = 19;
            addProductCandAddButton.Text = "Add";
            addProductCandAddButton.UseVisualStyleBackColor = true;
            addProductCandAddButton.Click += addProductCandAddButton_Click;
            // 
            // addProductCandTextBox
            // 
            addProductCandTextBox.Location = new Point(891, 54);
            addProductCandTextBox.MinimumSize = new Size(0, 30);
            addProductCandTextBox.Name = "addProductCandTextBox";
            addProductCandTextBox.Size = new Size(283, 30);
            addProductCandTextBox.TabIndex = 17;
            // 
            // addProductCandSearchButton
            // 
            addProductCandSearchButton.Location = new Point(782, 54);
            addProductCandSearchButton.Name = "addProductCandSearchButton";
            addProductCandSearchButton.Size = new Size(65, 26);
            addProductCandSearchButton.TabIndex = 16;
            addProductCandSearchButton.Text = "Search";
            addProductCandSearchButton.UseVisualStyleBackColor = true;
            addProductCandSearchButton.Click += addProductCandSearchButton_Click;
            // 
            // addProductLabel
            // 
            addProductLabel.AutoSize = true;
            addProductLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductLabel.Location = new Point(34, 40);
            addProductLabel.Name = "addProductLabel";
            addProductLabel.Size = new Size(129, 30);
            addProductLabel.TabIndex = 20;
            addProductLabel.Text = "Add Product";
            // 
            // addProductAssPanel
            // 
            addProductAssPanel.AutoScroll = true;
            addProductAssPanel.BackColor = SystemColors.ControlDark;
            addProductAssPanel.Controls.Add(addProductAssDataGridView);
            addProductAssPanel.Location = new Point(506, 490);
            addProductAssPanel.Name = "addProductAssPanel";
            addProductAssPanel.Size = new Size(668, 289);
            addProductAssPanel.TabIndex = 21;
            // 
            // addProductAssDataGridView
            // 
            addProductAssDataGridView.AllowUserToAddRows = false;
            addProductAssDataGridView.AllowUserToDeleteRows = false;
            addProductAssDataGridView.AllowUserToResizeColumns = false;
            addProductAssDataGridView.AllowUserToResizeRows = false;
            addProductAssDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            addProductAssDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            addProductAssDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            addProductAssDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            addProductAssDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            addProductAssDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            addProductAssDataGridView.Location = new Point(0, 0);
            addProductAssDataGridView.MultiSelect = false;
            addProductAssDataGridView.Name = "addProductAssDataGridView";
            addProductAssDataGridView.RowHeadersVisible = false;
            addProductAssDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Padding = new Padding(0, 10, 0, 10);
            addProductAssDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            addProductAssDataGridView.RowTemplate.Height = 60;
            addProductAssDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addProductAssDataGridView.Size = new Size(668, 286);
            addProductAssDataGridView.TabIndex = 1;
            // 
            // addProductAssLabel
            // 
            addProductAssLabel.AutoSize = true;
            addProductAssLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductAssLabel.Location = new Point(506, 453);
            addProductAssLabel.Name = "addProductAssLabel";
            addProductAssLabel.Size = new Size(243, 21);
            addProductAssLabel.TabIndex = 20;
            addProductAssLabel.Text = "Parts Associated with this Product";
            // 
            // addProductAssDeleteButton
            // 
            addProductAssDeleteButton.Location = new Point(1079, 798);
            addProductAssDeleteButton.Name = "addProductAssDeleteButton";
            addProductAssDeleteButton.Size = new Size(66, 38);
            addProductAssDeleteButton.TabIndex = 22;
            addProductAssDeleteButton.Text = "Delete";
            addProductAssDeleteButton.UseVisualStyleBackColor = true;
            addProductAssDeleteButton.Click += addProductAssDeleteButton_Click;
            // 
            // addProductCancelButton
            // 
            addProductCancelButton.Location = new Point(1079, 870);
            addProductCancelButton.Name = "addProductCancelButton";
            addProductCancelButton.Size = new Size(66, 38);
            addProductCancelButton.TabIndex = 23;
            addProductCancelButton.Text = "Cancel";
            addProductCancelButton.UseVisualStyleBackColor = true;
            addProductCancelButton.Click += addProductCancelButton_Click;
            // 
            // addProductSaveButton
            // 
            addProductSaveButton.Enabled = false;
            addProductSaveButton.Location = new Point(980, 870);
            addProductSaveButton.Name = "addProductSaveButton";
            addProductSaveButton.Size = new Size(66, 38);
            addProductSaveButton.TabIndex = 24;
            addProductSaveButton.Text = "Save";
            addProductSaveButton.UseVisualStyleBackColor = true;
            addProductSaveButton.Click += addProductSaveButton_Click;
            // 
            // addProductPriceTextBox
            // 
            addProductPriceTextBox.Location = new Point(161, 392);
            addProductPriceTextBox.MinimumSize = new Size(0, 28);
            addProductPriceTextBox.Name = "addProductPriceTextBox";
            addProductPriceTextBox.Size = new Size(171, 28);
            addProductPriceTextBox.TabIndex = 34;
            addProductPriceTextBox.TextChanged += addProductPriceTextBox_TextChanged_1;
            // 
            // addProductInventoryTextBox
            // 
            addProductInventoryTextBox.Location = new Point(161, 346);
            addProductInventoryTextBox.MinimumSize = new Size(0, 28);
            addProductInventoryTextBox.Name = "addProductInventoryTextBox";
            addProductInventoryTextBox.Size = new Size(172, 28);
            addProductInventoryTextBox.TabIndex = 33;
            addProductInventoryTextBox.TextChanged += addProductInventoryTextBox_TextChanged;
            // 
            // addProductNameTextBox
            // 
            addProductNameTextBox.Location = new Point(161, 300);
            addProductNameTextBox.MinimumSize = new Size(0, 28);
            addProductNameTextBox.Name = "addProductNameTextBox";
            addProductNameTextBox.Size = new Size(172, 28);
            addProductNameTextBox.TabIndex = 32;
            addProductNameTextBox.TextChanged += addProductNameTextBox_TextChanged;
            // 
            // addProductIDTextBox
            // 
            addProductIDTextBox.Enabled = false;
            addProductIDTextBox.Location = new Point(161, 254);
            addProductIDTextBox.MinimumSize = new Size(0, 28);
            addProductIDTextBox.Name = "addProductIDTextBox";
            addProductIDTextBox.Size = new Size(172, 28);
            addProductIDTextBox.TabIndex = 31;
            // 
            // addProductMaxLabel
            // 
            addProductMaxLabel.AutoSize = true;
            addProductMaxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductMaxLabel.Location = new Point(28, 439);
            addProductMaxLabel.Name = "addProductMaxLabel";
            addProductMaxLabel.Size = new Size(39, 21);
            addProductMaxLabel.TabIndex = 30;
            addProductMaxLabel.Text = "Max";
            // 
            // addProductMinLabel
            // 
            addProductMinLabel.AutoSize = true;
            addProductMinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductMinLabel.Location = new Point(251, 439);
            addProductMinLabel.Name = "addProductMinLabel";
            addProductMinLabel.Size = new Size(37, 21);
            addProductMinLabel.TabIndex = 29;
            addProductMinLabel.Text = "Min";
            // 
            // addProductPriceLabel
            // 
            addProductPriceLabel.AutoSize = true;
            addProductPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductPriceLabel.Location = new Point(28, 392);
            addProductPriceLabel.Name = "addProductPriceLabel";
            addProductPriceLabel.Size = new Size(44, 21);
            addProductPriceLabel.TabIndex = 28;
            addProductPriceLabel.Text = "Price";
            // 
            // addProductInventoryLabel
            // 
            addProductInventoryLabel.AutoSize = true;
            addProductInventoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductInventoryLabel.Location = new Point(28, 346);
            addProductInventoryLabel.Name = "addProductInventoryLabel";
            addProductInventoryLabel.Size = new Size(76, 21);
            addProductInventoryLabel.TabIndex = 27;
            addProductInventoryLabel.Text = "Inventory";
            // 
            // addProductNameLabel
            // 
            addProductNameLabel.AutoSize = true;
            addProductNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductNameLabel.Location = new Point(28, 300);
            addProductNameLabel.Name = "addProductNameLabel";
            addProductNameLabel.Size = new Size(52, 21);
            addProductNameLabel.TabIndex = 26;
            addProductNameLabel.Text = "Name";
            // 
            // addProductIDLabel
            // 
            addProductIDLabel.AutoSize = true;
            addProductIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductIDLabel.Location = new Point(28, 254);
            addProductIDLabel.Name = "addProductIDLabel";
            addProductIDLabel.Size = new Size(25, 21);
            addProductIDLabel.TabIndex = 25;
            addProductIDLabel.Text = "ID";
            // 
            // addProductMaxTextBox
            // 
            addProductMaxTextBox.Location = new Point(107, 439);
            addProductMaxTextBox.MinimumSize = new Size(0, 28);
            addProductMaxTextBox.Name = "addProductMaxTextBox";
            addProductMaxTextBox.Size = new Size(116, 28);
            addProductMaxTextBox.TabIndex = 35;
            addProductMaxTextBox.TextChanged += addProductMaxTextBox_TextChanged;
            // 
            // addProductMinTextBox
            // 
            addProductMinTextBox.Location = new Point(319, 439);
            addProductMinTextBox.MinimumSize = new Size(0, 28);
            addProductMinTextBox.Name = "addProductMinTextBox";
            addProductMinTextBox.Size = new Size(116, 28);
            addProductMinTextBox.TabIndex = 36;
            addProductMinTextBox.TextChanged += addProductMinTextBox_TextChanged;
            // 
            // addProductErrorProvider
            // 
            addProductErrorProvider.ContainerControl = this;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1269, 925);
            Controls.Add(addProductMinTextBox);
            Controls.Add(addProductMaxTextBox);
            Controls.Add(addProductPriceTextBox);
            Controls.Add(addProductInventoryTextBox);
            Controls.Add(addProductNameTextBox);
            Controls.Add(addProductIDTextBox);
            Controls.Add(addProductMaxLabel);
            Controls.Add(addProductMinLabel);
            Controls.Add(addProductPriceLabel);
            Controls.Add(addProductInventoryLabel);
            Controls.Add(addProductNameLabel);
            Controls.Add(addProductIDLabel);
            Controls.Add(addProductSaveButton);
            Controls.Add(addProductCancelButton);
            Controls.Add(addProductAssPanel);
            Controls.Add(addProductAssLabel);
            Controls.Add(addProductLabel);
            Controls.Add(addProductAssDeleteButton);
            Controls.Add(addProductCandPanel);
            Controls.Add(addProductCandLabel);
            Controls.Add(addProductCandAddButton);
            Controls.Add(addProductCandTextBox);
            Controls.Add(addProductCandSearchButton);
            Name = "AddProductForm";
            Text = "Product";
            addProductCandPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addProductCandDataGridView).EndInit();
            addProductAssPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addProductAssDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)addProductErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel addProductCandPanel;
        private DataGridView addProductCandDataGridView;
        private Label addProductCandLabel;
        private Button addProductCandAddButton;
        private TextBox addProductCandTextBox;
        private Button addProductCandSearchButton;
        private Label addProductLabel;
        private Panel addProductAssPanel;
        private DataGridView addProductAssDataGridView;
        private Label addProductAssLabel;
        private Button addProductAssDeleteButton;
        private Button addProductCancelButton;
        private Button addProductSaveButton;
        private TextBox addProductMinTextBox;
        private TextBox addProductMaxTextBox;
        private TextBox addProductPriceTextBox;
        private TextBox addProductInventoryTextBox;
        private TextBox addProductNameTextBox;
        private TextBox addProductIDTextBox;
        private Label addProductMaxLabel;
        private Label addProductMinLabel;
        private Label addProductPriceLabel;
        private Label addProductInventoryLabel;
        private Label addProductNameLabel;
        private Label addProductIDLabel;
        private ErrorProvider addProductErrorProvider;
    }
}