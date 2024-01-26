namespace AdoNetDemo
{
    partial class Form1
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
            dgwProducts = new DataGridView();
            gbxAdd = new GroupBox();
            btnAdd = new Button();
            tbxStockAmount = new TextBox();
            tbxUnitPrice = new TextBox();
            tbxName = new TextBox();
            lblStockAmountAdd = new Label();
            lblUnitPriceAdd = new Label();
            lblNameAdd = new Label();
            gbxUpdate = new GroupBox();
            btnEdit = new Button();
            tbxStockAmountUpdate = new TextBox();
            tbxUnitPriceUpdate = new TextBox();
            tbxNameUpdate = new TextBox();
            lblStockAmountUpdate = new Label();
            lblUnitPriceUpdate = new Label();
            lblNameUpdate = new Label();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            gbxAdd.SuspendLayout();
            gbxUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProducts
            // 
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(77, 62);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowHeadersWidth = 51;
            dgwProducts.Size = new Size(669, 258);
            dgwProducts.TabIndex = 0;
            dgwProducts.CellClick += dgwProducts_CellClick;
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(tbxStockAmount);
            gbxAdd.Controls.Add(tbxUnitPrice);
            gbxAdd.Controls.Add(tbxName);
            gbxAdd.Controls.Add(lblStockAmountAdd);
            gbxAdd.Controls.Add(lblUnitPriceAdd);
            gbxAdd.Controls.Add(lblNameAdd);
            gbxAdd.Location = new Point(77, 326);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(250, 188);
            gbxAdd.TabIndex = 1;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Add a product";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(95, 159);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxStockAmount
            // 
            tbxStockAmount.Location = new Point(111, 111);
            tbxStockAmount.Name = "tbxStockAmount";
            tbxStockAmount.Size = new Size(125, 27);
            tbxStockAmount.TabIndex = 5;
            // 
            // tbxUnitPrice
            // 
            tbxUnitPrice.Location = new Point(111, 69);
            tbxUnitPrice.Name = "tbxUnitPrice";
            tbxUnitPrice.Size = new Size(125, 27);
            tbxUnitPrice.TabIndex = 4;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(111, 26);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(125, 27);
            tbxName.TabIndex = 3;
            // 
            // lblStockAmountAdd
            // 
            lblStockAmountAdd.AutoSize = true;
            lblStockAmountAdd.Location = new Point(3, 111);
            lblStockAmountAdd.Name = "lblStockAmountAdd";
            lblStockAmountAdd.Size = new Size(102, 20);
            lblStockAmountAdd.TabIndex = 2;
            lblStockAmountAdd.Text = "Stock Amount";
            // 
            // lblUnitPriceAdd
            // 
            lblUnitPriceAdd.AutoSize = true;
            lblUnitPriceAdd.Location = new Point(3, 69);
            lblUnitPriceAdd.Name = "lblUnitPriceAdd";
            lblUnitPriceAdd.Size = new Size(72, 20);
            lblUnitPriceAdd.TabIndex = 1;
            lblUnitPriceAdd.Text = "Unit Price";
            // 
            // lblNameAdd
            // 
            lblNameAdd.AutoSize = true;
            lblNameAdd.Location = new Point(3, 26);
            lblNameAdd.Name = "lblNameAdd";
            lblNameAdd.Size = new Size(49, 20);
            lblNameAdd.TabIndex = 0;
            lblNameAdd.Text = "Name";
            // 
            // gbxUpdate
            // 
            gbxUpdate.Controls.Add(btnEdit);
            gbxUpdate.Controls.Add(tbxStockAmountUpdate);
            gbxUpdate.Controls.Add(tbxUnitPriceUpdate);
            gbxUpdate.Controls.Add(tbxNameUpdate);
            gbxUpdate.Controls.Add(lblStockAmountUpdate);
            gbxUpdate.Controls.Add(lblUnitPriceUpdate);
            gbxUpdate.Controls.Add(lblNameUpdate);
            gbxUpdate.Location = new Point(433, 326);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(250, 188);
            gbxUpdate.TabIndex = 2;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "Edit a product";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(95, 159);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // tbxStockAmountUpdate
            // 
            tbxStockAmountUpdate.Location = new Point(111, 111);
            tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            tbxStockAmountUpdate.Size = new Size(125, 27);
            tbxStockAmountUpdate.TabIndex = 5;
            // 
            // tbxUnitPriceUpdate
            // 
            tbxUnitPriceUpdate.Location = new Point(111, 69);
            tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            tbxUnitPriceUpdate.Size = new Size(125, 27);
            tbxUnitPriceUpdate.TabIndex = 4;
            // 
            // tbxNameUpdate
            // 
            tbxNameUpdate.Location = new Point(111, 26);
            tbxNameUpdate.Name = "tbxNameUpdate";
            tbxNameUpdate.Size = new Size(125, 27);
            tbxNameUpdate.TabIndex = 3;
            // 
            // lblStockAmountUpdate
            // 
            lblStockAmountUpdate.AutoSize = true;
            lblStockAmountUpdate.Location = new Point(3, 111);
            lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            lblStockAmountUpdate.Size = new Size(102, 20);
            lblStockAmountUpdate.TabIndex = 2;
            lblStockAmountUpdate.Text = "Stock Amount";
            // 
            // lblUnitPriceUpdate
            // 
            lblUnitPriceUpdate.AutoSize = true;
            lblUnitPriceUpdate.Location = new Point(3, 69);
            lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            lblUnitPriceUpdate.Size = new Size(72, 20);
            lblUnitPriceUpdate.TabIndex = 1;
            lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // lblNameUpdate
            // 
            lblNameUpdate.AutoSize = true;
            lblNameUpdate.Location = new Point(3, 26);
            lblNameUpdate.Name = "lblNameUpdate";
            lblNameUpdate.Size = new Size(49, 20);
            lblNameUpdate.TabIndex = 0;
            lblNameUpdate.Text = "Name";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(528, 12);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(125, 34);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 556);
            Controls.Add(btnRemove);
            Controls.Add(gbxUpdate);
            Controls.Add(gbxAdd);
            Controls.Add(dgwProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            gbxUpdate.ResumeLayout(false);
            gbxUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProducts;
        private GroupBox gbxAdd;
        private TextBox tbxStockAmount;
        private TextBox tbxUnitPrice;
        private TextBox tbxName;
        private Label lblStockAmountAdd;
        private Label lblUnitPriceAdd;
        private Label lblNameAdd;
        private Button btnAdd;
        private GroupBox gbxUpdate;
        private Button btnEdit;
        private TextBox tbxStockAmountUpdate;
        private TextBox tbxUnitPriceUpdate;
        private TextBox tbxNameUpdate;
        private Label lblStockAmountUpdate;
        private Label lblUnitPriceUpdate;
        private Label lblNameUpdate;
        private Button btnRemove;
    }
}
