namespace InventoryApp
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            mainLabel = new Label();
            partsLabel = new Label();
            partsSearchButton = new Button();
            partsTextBox = new TextBox();
            partsPanel = new Panel();
            partsDataGridView = new DataGridView();
            mainFormBindingSource = new BindingSource(components);
            partsAddButton = new Button();
            partsModifyButton = new Button();
            partsDeleteButton = new Button();
            productsLabel = new Label();
            productsDataGridView = new DataGridView();
            productsDeleteButton = new Button();
            productsModifyButton = new Button();
            productsAddButton = new Button();
            productsPanel = new Panel();
            productsTextBox = new TextBox();
            productsSearchButton = new Button();
            exitButton = new Button();
            partsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)partsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            productsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainLabel.Location = new Point(12, 9);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(301, 30);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "Inventory Management System";
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partsLabel.Location = new Point(21, 103);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(58, 30);
            partsLabel.TabIndex = 1;
            partsLabel.Text = "Parts";
            // 
            // partsSearchButton
            // 
            partsSearchButton.Location = new Point(338, 100);
            partsSearchButton.Name = "partsSearchButton";
            partsSearchButton.Size = new Size(65, 26);
            partsSearchButton.TabIndex = 2;
            partsSearchButton.Text = "Search";
            partsSearchButton.UseVisualStyleBackColor = true;
            partsSearchButton.Click += partsSearchButton_Click;
            // 
            // partsTextBox
            // 
            partsTextBox.Location = new Point(429, 100);
            partsTextBox.MinimumSize = new Size(0, 30);
            partsTextBox.Name = "partsTextBox";
            partsTextBox.Size = new Size(220, 30);
            partsTextBox.TabIndex = 3;
            // 
            // partsPanel
            // 
            partsPanel.AutoScroll = true;
            partsPanel.BackColor = SystemColors.ControlDark;
            partsPanel.Controls.Add(partsDataGridView);
            partsPanel.Location = new Point(21, 146);
            partsPanel.Name = "partsPanel";
            partsPanel.Size = new Size(628, 289);
            partsPanel.TabIndex = 5;
            // 
            // partsDataGridView
            // 
            partsDataGridView.AllowUserToAddRows = false;
            partsDataGridView.AllowUserToDeleteRows = false;
            partsDataGridView.AllowUserToResizeColumns = false;
            partsDataGridView.AllowUserToResizeRows = false;
            partsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            partsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            partsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            partsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            partsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            partsDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            partsDataGridView.Location = new Point(0, 0);
            partsDataGridView.MultiSelect = false;
            partsDataGridView.Name = "partsDataGridView";
            partsDataGridView.RowHeadersVisible = false;
            partsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Padding = new Padding(0, 10, 0, 10);
            partsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            partsDataGridView.RowTemplate.Height = 60;
            partsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsDataGridView.Size = new Size(628, 286);
            partsDataGridView.TabIndex = 1;
            // 
            // mainFormBindingSource
            // 
            mainFormBindingSource.DataSource = typeof(mainForm);
            // 
            // partsAddButton
            // 
            partsAddButton.Location = new Point(439, 441);
            partsAddButton.Name = "partsAddButton";
            partsAddButton.Size = new Size(66, 38);
            partsAddButton.TabIndex = 7;
            partsAddButton.Text = "Add";
            partsAddButton.UseVisualStyleBackColor = true;
            partsAddButton.Click += partsAddButton_Click;
            // 
            // partsModifyButton
            // 
            partsModifyButton.Location = new Point(511, 441);
            partsModifyButton.Name = "partsModifyButton";
            partsModifyButton.Size = new Size(66, 38);
            partsModifyButton.TabIndex = 8;
            partsModifyButton.Text = "Modify";
            partsModifyButton.UseVisualStyleBackColor = true;
            partsModifyButton.Click += partsModifyButton_Click;
            // 
            // partsDeleteButton
            // 
            partsDeleteButton.Location = new Point(583, 441);
            partsDeleteButton.Name = "partsDeleteButton";
            partsDeleteButton.Size = new Size(66, 38);
            partsDeleteButton.TabIndex = 9;
            partsDeleteButton.Text = "Delete";
            partsDeleteButton.UseVisualStyleBackColor = true;
            partsDeleteButton.Click += partsDeleteButton_Click;
            // 
            // productsLabel
            // 
            productsLabel.AutoSize = true;
            productsLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productsLabel.Location = new Point(670, 103);
            productsLabel.Name = "productsLabel";
            productsLabel.Size = new Size(94, 30);
            productsLabel.TabIndex = 10;
            productsLabel.Text = "Products";
            // 
            // productsDataGridView
            // 
            productsDataGridView.AllowUserToAddRows = false;
            productsDataGridView.AllowUserToDeleteRows = false;
            productsDataGridView.AllowUserToResizeColumns = false;
            productsDataGridView.AllowUserToResizeRows = false;
            productsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            productsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            productsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            productsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            productsDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            productsDataGridView.Location = new Point(0, 0);
            productsDataGridView.MultiSelect = false;
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.RowHeadersVisible = false;
            productsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Padding = new Padding(0, 10, 0, 10);
            productsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            productsDataGridView.RowTemplate.Height = 60;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGridView.Size = new Size(628, 286);
            productsDataGridView.TabIndex = 1;
            // 
            // productsDeleteButton
            // 
            productsDeleteButton.Location = new Point(1232, 441);
            productsDeleteButton.Name = "productsDeleteButton";
            productsDeleteButton.Size = new Size(66, 38);
            productsDeleteButton.TabIndex = 16;
            productsDeleteButton.Text = "Delete";
            productsDeleteButton.UseVisualStyleBackColor = true;
            productsDeleteButton.Click += productsDeleteButton_Click;
            // 
            // productsModifyButton
            // 
            productsModifyButton.Location = new Point(1160, 441);
            productsModifyButton.Name = "productsModifyButton";
            productsModifyButton.Size = new Size(66, 38);
            productsModifyButton.TabIndex = 15;
            productsModifyButton.Text = "Modify";
            productsModifyButton.UseVisualStyleBackColor = true;
            productsModifyButton.Click += productsModifyButton_Click;
            // 
            // productsAddButton
            // 
            productsAddButton.Location = new Point(1088, 441);
            productsAddButton.Name = "productsAddButton";
            productsAddButton.Size = new Size(66, 38);
            productsAddButton.TabIndex = 14;
            productsAddButton.Text = "Add";
            productsAddButton.UseVisualStyleBackColor = true;
            productsAddButton.Click += productsAddButton_Click;
            // 
            // productsPanel
            // 
            productsPanel.AutoScroll = true;
            productsPanel.BackColor = SystemColors.ControlDark;
            productsPanel.Controls.Add(productsDataGridView);
            productsPanel.Location = new Point(670, 146);
            productsPanel.Name = "productsPanel";
            productsPanel.Size = new Size(628, 289);
            productsPanel.TabIndex = 13;
            // 
            // productsTextBox
            // 
            productsTextBox.Location = new Point(1078, 100);
            productsTextBox.MinimumSize = new Size(0, 30);
            productsTextBox.Name = "productsTextBox";
            productsTextBox.Size = new Size(220, 30);
            productsTextBox.TabIndex = 12;
            // 
            // productsSearchButton
            // 
            productsSearchButton.Location = new Point(987, 100);
            productsSearchButton.Name = "productsSearchButton";
            productsSearchButton.Size = new Size(65, 26);
            productsSearchButton.TabIndex = 11;
            productsSearchButton.Text = "Search";
            productsSearchButton.UseVisualStyleBackColor = true;
            productsSearchButton.Click += productsSearchButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(1232, 509);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(66, 38);
            exitButton.TabIndex = 17;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1319, 571);
            Controls.Add(exitButton);
            Controls.Add(productsLabel);
            Controls.Add(productsDeleteButton);
            Controls.Add(productsModifyButton);
            Controls.Add(productsAddButton);
            Controls.Add(productsPanel);
            Controls.Add(productsTextBox);
            Controls.Add(productsSearchButton);
            Controls.Add(partsDeleteButton);
            Controls.Add(partsModifyButton);
            Controls.Add(partsAddButton);
            Controls.Add(partsPanel);
            Controls.Add(partsTextBox);
            Controls.Add(partsSearchButton);
            Controls.Add(partsLabel);
            Controls.Add(mainLabel);
            Name = "mainForm";
            Text = "Main Screen";
            partsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)partsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainFormBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            productsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainLabel;
        private Label partsLabel;
        private Button partsSearchButton;
        private TextBox partsTextBox;
        private Panel partsPanel;
        private DataGridView partsDataGridView;
        private BindingSource mainFormBindingSource;
        private Button partsAddButton;
        private Button partsModifyButton;
        private Button partsDeleteButton;
        private Label productsLabel;
        private DataGridView productsDataGridView;
        private Button productsDeleteButton;
        private Button productsModifyButton;
        private Button productsAddButton;
        private Panel productsPanel;
        private TextBox productsTextBox;
        private Button productsSearchButton;
        private Button exitButton;
    }
}
