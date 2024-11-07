namespace InventoryApp
{
    partial class ModifyProductForm
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
            modifyProductCandPanel = new Panel();
            modifyProductCandDataGridView = new DataGridView();
            modifyProductCandLabel = new Label();
            modifyProductCandAddButton = new Button();
            modifyProductCandTextBox = new TextBox();
            modifyProductCandSearchButton = new Button();
            modifyProductLabel = new Label();
            modifyProductAssPanel = new Panel();
            modifyProductAssDataGridView = new DataGridView();
            modifyProductAssLabel = new Label();
            modifyProductAssDeleteButton = new Button();
            modifyProductCancelButton = new Button();
            modifyProductSaveButton = new Button();
            modifyProductPriceTextBox = new TextBox();
            modifyProductInventoryTextBox = new TextBox();
            modifyProductNameTextBox = new TextBox();
            modifyProductIDTextBox = new TextBox();
            modifyProductMaxLabel = new Label();
            modifyProductMinLabel = new Label();
            modifyProductPriceLabel = new Label();
            modifyProductInventoryLabel = new Label();
            modifyProductNameLabel = new Label();
            modifyProductIDLabel = new Label();
            modifyProductMaxTextBox = new TextBox();
            modifyProductMinTextBox = new TextBox();
            modifyProductErrorProvider = new ErrorProvider(components);
            modifyProductCandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)modifyProductCandDataGridView).BeginInit();
            modifyProductAssPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)modifyProductAssDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modifyProductErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // modifyProductCandPanel
            // 
            modifyProductCandPanel.AutoScroll = true;
            modifyProductCandPanel.BackColor = SystemColors.ControlDark;
            modifyProductCandPanel.Controls.Add(modifyProductCandDataGridView);
            modifyProductCandPanel.Location = new Point(506, 100);
            modifyProductCandPanel.Name = "modifyProductCandPanel";
            modifyProductCandPanel.Size = new Size(668, 289);
            modifyProductCandPanel.TabIndex = 18;
            // 
            // modifyProductCandDataGridView
            // 
            modifyProductCandDataGridView.AllowUserToAddRows = false;
            modifyProductCandDataGridView.AllowUserToDeleteRows = false;
            modifyProductCandDataGridView.AllowUserToResizeColumns = false;
            modifyProductCandDataGridView.AllowUserToResizeRows = false;
            modifyProductCandDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            modifyProductCandDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            modifyProductCandDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            modifyProductCandDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            modifyProductCandDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            modifyProductCandDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            modifyProductCandDataGridView.Location = new Point(0, 0);
            modifyProductCandDataGridView.MultiSelect = false;
            modifyProductCandDataGridView.Name = "modifyProductCandDataGridView";
            modifyProductCandDataGridView.RowHeadersVisible = false;
            modifyProductCandDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Padding = new Padding(0, 10, 0, 10);
            modifyProductCandDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            modifyProductCandDataGridView.RowTemplate.Height = 60;
            modifyProductCandDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modifyProductCandDataGridView.Size = new Size(668, 286);
            modifyProductCandDataGridView.TabIndex = 1;
            // 
            // modifyProductCandLabel
            // 
            modifyProductCandLabel.AutoSize = true;
            modifyProductCandLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyProductCandLabel.Location = new Point(506, 63);
            modifyProductCandLabel.Name = "modifyProductCandLabel";
            modifyProductCandLabel.Size = new Size(137, 21);
            modifyProductCandLabel.TabIndex = 15;
            modifyProductCandLabel.Text = "All candidate Parts";
            // 
            // modifyProductCandAddButton
            // 
            modifyProductCandAddButton.Location = new Point(1079, 408);
            modifyProductCandAddButton.Name = "modifyProductCandAddButton";
            modifyProductCandAddButton.Size = new Size(66, 38);
            modifyProductCandAddButton.TabIndex = 19;
            modifyProductCandAddButton.Text = "Add";
            modifyProductCandAddButton.UseVisualStyleBackColor = true;
            modifyProductCandAddButton.Click += modifyProductCandAddButton_Click;
            // 
            // modifyProductCandTextBox
            // 
            modifyProductCandTextBox.Location = new Point(891, 54);
            modifyProductCandTextBox.MinimumSize = new Size(0, 30);
            modifyProductCandTextBox.Name = "modifyProductCandTextBox";
            modifyProductCandTextBox.Size = new Size(283, 30);
            modifyProductCandTextBox.TabIndex = 17;
            // 
            // modifyProductCandSearchButton
            // 
            modifyProductCandSearchButton.Location = new Point(782, 54);
            modifyProductCandSearchButton.Name = "modifyProductCandSearchButton";
            modifyProductCandSearchButton.Size = new Size(65, 26);
            modifyProductCandSearchButton.TabIndex = 16;
            modifyProductCandSearchButton.Text = "Search";
            modifyProductCandSearchButton.UseVisualStyleBackColor = true;
            modifyProductCandSearchButton.Click += modifyProductCandSearchButton_Click;
            // 
            // modifyProductLabel
            // 
            modifyProductLabel.AutoSize = true;
            modifyProductLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyProductLabel.Location = new Point(34, 40);
            modifyProductLabel.Name = "modifyProductLabel";
            modifyProductLabel.Size = new Size(129, 30);
            modifyProductLabel.TabIndex = 20;
            modifyProductLabel.Text = "Add Product";
            // 
            // modifyProductAssPanel
            // 
            modifyProductAssPanel.AutoScroll = true;
            modifyProductAssPanel.BackColor = SystemColors.ControlDark;
            modifyProductAssPanel.Controls.Add(modifyProductAssDataGridView);
            modifyProductAssPanel.Location = new Point(506, 490);
            modifyProductAssPanel.Name = "modifyProductAssPanel";
            modifyProductAssPanel.Size = new Size(668, 289);
            modifyProductAssPanel.TabIndex = 21;
            // 
            // modifyProductAssDataGridView
            // 
            modifyProductAssDataGridView.AllowUserToAddRows = false;
            modifyProductAssDataGridView.AllowUserToDeleteRows = false;
            modifyProductAssDataGridView.AllowUserToResizeColumns = false;
            modifyProductAssDataGridView.AllowUserToResizeRows = false;
            modifyProductAssDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            modifyProductAssDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            modifyProductAssDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            modifyProductAssDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            modifyProductAssDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            modifyProductAssDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            modifyProductAssDataGridView.Location = new Point(0, 0);
            modifyProductAssDataGridView.MultiSelect = false;
            modifyProductAssDataGridView.Name = "modifyProductAssDataGridView";
            modifyProductAssDataGridView.RowHeadersVisible = false;
            modifyProductAssDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Padding = new Padding(0, 10, 0, 10);
            modifyProductAssDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            modifyProductAssDataGridView.RowTemplate.Height = 60;
            modifyProductAssDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modifyProductAssDataGridView.Size = new Size(668, 286);
            modifyProductAssDataGridView.TabIndex = 1;
            // 
            // modifyProductAssLabel
            // 
            modifyProductAssLabel.AutoSize = true;
            modifyProductAssLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyProductAssLabel.Location = new Point(506, 453);
            modifyProductAssLabel.Name = "modifyProductAssLabel";
            modifyProductAssLabel.Size = new Size(243, 21);
            modifyProductAssLabel.TabIndex = 20;
            modifyProductAssLabel.Text = "Parts Associated with this Product";
            // 
            // modifyProductAssDeleteButton
            // 
            modifyProductAssDeleteButton.Location = new Point(1079, 798);
            modifyProductAssDeleteButton.Name = "modifyProductAssDeleteButton";
            modifyProductAssDeleteButton.Size = new Size(66, 38);
            modifyProductAssDeleteButton.TabIndex = 22;
            modifyProductAssDeleteButton.Text = "Delete";
            modifyProductAssDeleteButton.UseVisualStyleBackColor = true;
            modifyProductAssDeleteButton.Click += modifyProductAssDeleteButton_Click;
            // 
            // modifyProductCancelButton
            // 
            modifyProductCancelButton.Location = new Point(1079, 870);
            modifyProductCancelButton.Name = "modifyProductCancelButton";
            modifyProductCancelButton.Size = new Size(66, 38);
            modifyProductCancelButton.TabIndex = 23;
            modifyProductCancelButton.Text = "Cancel";
            modifyProductCancelButton.UseVisualStyleBackColor = true;
            modifyProductCancelButton.Click += modifyProductCancelButton_Click;
            // 
            // modifyProductSaveButton
            // 
            modifyProductSaveButton.Enabled = false;
            modifyProductSaveButton.Location = new Point(980, 870);
            modifyProductSaveButton.Name = "modifyProductSaveButton";
            modifyProductSaveButton.Size = new Size(66, 38);
            modifyProductSaveButton.TabIndex = 24;
            modifyProductSaveButton.Text = "Save";
            modifyProductSaveButton.UseVisualStyleBackColor = true;
            modifyProductSaveButton.Click += modifyProductSaveButton_Click;
            // 
            // modifyProductPriceTextBox
            // 
            modifyProductPriceTextBox.Location = new Point(161, 392);
            modifyProductPriceTextBox.MinimumSize = new Size(0, 28);
            modifyProductPriceTextBox.Name = "modifyProductPriceTextBox";
            modifyProductPriceTextBox.Size = new Size(171, 28);
            modifyProductPriceTextBox.TabIndex = 34;
            modifyProductPriceTextBox.TextChanged += modifyProductPriceTextBox_TextChanged_1;
            // 
            // modifyProductInventoryTextBox
            // 
            modifyProductInventoryTextBox.Location = new Point(161, 346);
            modifyProductInventoryTextBox.MinimumSize = new Size(0, 28);
            modifyProductInventoryTextBox.Name = "modifyProductInventoryTextBox";
            modifyProductInventoryTextBox.Size = new Size(172, 28);
            modifyProductInventoryTextBox.TabIndex = 33;
            modifyProductInventoryTextBox.TextChanged += modifyProductInventoryTextBox_TextChanged;
            // 
            // modifyProductNameTextBox
            // 
            modifyProductNameTextBox.Location = new Point(161, 300);
            modifyProductNameTextBox.MinimumSize = new Size(0, 28);
            modifyProductNameTextBox.Name = "modifyProductNameTextBox";
            modifyProductNameTextBox.Size = new Size(172, 28);
            modifyProductNameTextBox.TabIndex = 32;
            modifyProductNameTextBox.TextChanged += modifyProductNameTextBox_TextChanged;
            // 
            // modifyProductIDTextBox
            // 
            modifyProductIDTextBox.Enabled = false;
            modifyProductIDTextBox.Location = new Point(161, 254);
            modifyProductIDTextBox.MinimumSize = new Size(0, 28);
            modifyProductIDTextBox.Name = "modifyProductIDTextBox";
            modifyProductIDTextBox.Size = new Size(172, 28);
            modifyProductIDTextBox.TabIndex = 31;
            // 
            // modifyProductMaxLabel
            // 
            modifyProductMaxLabel.AutoSize = true;
            modifyProductMaxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyProductMaxLabel.Location = new Point(28, 439);
            modifyProductMaxLabel.Name = "modifyProductMaxLabel";
            modifyProductMaxLabel.Size = new Size(39, 21);
            modifyProductMaxLabel.TabIndex = 30;
            modifyProductMaxLabel.Text = "Max";
            // 
            // modifyProductMinLabel
            // 
            modifyProductMinLabel.AutoSize = true;
            modifyProductMinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyProductMinLabel.Location = new Point(251, 439);
            modifyProductMinLabel.Name = "modifyProductMinLabel";
            modifyProductMinLabel.Size = new Size(37, 21);
            modifyProductMinLabel.TabIndex = 29;
            modifyProductMinLabel.Text = "Min";
            // 
            // modifyProductPriceLabel
            // 
            modifyProductPriceLabel.AutoSize = true;
            modifyProductPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyProductPriceLabel.Location = new Point(28, 392);
            modifyProductPriceLabel.Name = "modifyProductPriceLabel";
            modifyProductPriceLabel.Size = new Size(44, 21);
            modifyProductPriceLabel.TabIndex = 28;
            modifyProductPriceLabel.Text = "Price";
            // 
            // modifyProductInventoryLabel
            // 
            modifyProductInventoryLabel.AutoSize = true;
            modifyProductInventoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyProductInventoryLabel.Location = new Point(28, 346);
            modifyProductInventoryLabel.Name = "modifyProductInventoryLabel";
            modifyProductInventoryLabel.Size = new Size(76, 21);
            modifyProductInventoryLabel.TabIndex = 27;
            modifyProductInventoryLabel.Text = "Inventory";
            // 
            // modifyProductNameLabel
            // 
            modifyProductNameLabel.AutoSize = true;
            modifyProductNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyProductNameLabel.Location = new Point(28, 300);
            modifyProductNameLabel.Name = "modifyProductNameLabel";
            modifyProductNameLabel.Size = new Size(52, 21);
            modifyProductNameLabel.TabIndex = 26;
            modifyProductNameLabel.Text = "Name";
            // 
            // modifyProductIDLabel
            // 
            modifyProductIDLabel.AutoSize = true;
            modifyProductIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifyProductIDLabel.Location = new Point(28, 254);
            modifyProductIDLabel.Name = "modifyProductIDLabel";
            modifyProductIDLabel.Size = new Size(25, 21);
            modifyProductIDLabel.TabIndex = 25;
            modifyProductIDLabel.Text = "ID";
            // 
            // modifyProductMaxTextBox
            // 
            modifyProductMaxTextBox.Location = new Point(107, 439);
            modifyProductMaxTextBox.MinimumSize = new Size(0, 28);
            modifyProductMaxTextBox.Name = "modifyProductMaxTextBox";
            modifyProductMaxTextBox.Size = new Size(116, 28);
            modifyProductMaxTextBox.TabIndex = 35;
            modifyProductMaxTextBox.TextChanged += modifyProductMaxTextBox_TextChanged;
            // 
            // modifyProductMinTextBox
            // 
            modifyProductMinTextBox.Location = new Point(319, 439);
            modifyProductMinTextBox.MinimumSize = new Size(0, 28);
            modifyProductMinTextBox.Name = "modifyProductMinTextBox";
            modifyProductMinTextBox.Size = new Size(116, 28);
            modifyProductMinTextBox.TabIndex = 36;
            modifyProductMinTextBox.TextChanged += modifyProductMinTextBox_TextChanged;
            // 
            // modifyProductErrorProvider
            // 
            modifyProductErrorProvider.ContainerControl = this;
            // 
            // ModifyProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1269, 925);
            Controls.Add(modifyProductMinTextBox);
            Controls.Add(modifyProductMaxTextBox);
            Controls.Add(modifyProductPriceTextBox);
            Controls.Add(modifyProductInventoryTextBox);
            Controls.Add(modifyProductNameTextBox);
            Controls.Add(modifyProductIDTextBox);
            Controls.Add(modifyProductMaxLabel);
            Controls.Add(modifyProductMinLabel);
            Controls.Add(modifyProductPriceLabel);
            Controls.Add(modifyProductInventoryLabel);
            Controls.Add(modifyProductNameLabel);
            Controls.Add(modifyProductIDLabel);
            Controls.Add(modifyProductSaveButton);
            Controls.Add(modifyProductCancelButton);
            Controls.Add(modifyProductAssPanel);
            Controls.Add(modifyProductAssLabel);
            Controls.Add(modifyProductLabel);
            Controls.Add(modifyProductAssDeleteButton);
            Controls.Add(modifyProductCandPanel);
            Controls.Add(modifyProductCandLabel);
            Controls.Add(modifyProductCandAddButton);
            Controls.Add(modifyProductCandTextBox);
            Controls.Add(modifyProductCandSearchButton);
            Name = "ModifyProductForm";
            Text = "Product";
            modifyProductCandPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)modifyProductCandDataGridView).EndInit();
            modifyProductAssPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)modifyProductAssDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)modifyProductErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel modifyProductCandPanel;
        private DataGridView modifyProductCandDataGridView;
        private Label modifyProductCandLabel;
        private Button modifyProductCandAddButton;
        private TextBox modifyProductCandTextBox;
        private Button modifyProductCandSearchButton;
        private Label modifyProductLabel;
        private Panel modifyProductAssPanel;
        private DataGridView modifyProductAssDataGridView;
        private Label modifyProductAssLabel;
        private Button modifyProductAssDeleteButton;
        private Button modifyProductCancelButton;
        private Button modifyProductSaveButton;
        private TextBox modifyProductMinTextBox;
        private TextBox modifyProductMaxTextBox;
        private TextBox modifyProductPriceTextBox;
        private TextBox modifyProductInventoryTextBox;
        private TextBox modifyProductNameTextBox;
        private TextBox modifyProductIDTextBox;
        private Label modifyProductMaxLabel;
        private Label modifyProductMinLabel;
        private Label modifyProductPriceLabel;
        private Label modifyProductInventoryLabel;
        private Label modifyProductNameLabel;
        private Label modifyProductIDLabel;
        private ErrorProvider modifyProductErrorProvider;
    }
}