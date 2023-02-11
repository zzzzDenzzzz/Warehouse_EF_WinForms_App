namespace Warehouse_EF_WinForms_App
{
    partial class MainForm
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageGoods = new System.Windows.Forms.TabPage();
            this.btnUpdateGood = new System.Windows.Forms.Button();
            this.btnDeleteGood = new System.Windows.Forms.Button();
            this.btnAddGood = new System.Windows.Forms.Button();
            this.gridGoods = new System.Windows.Forms.DataGridView();
            this.tabPageGoodsType = new System.Windows.Forms.TabPage();
            this.btnUpdateGoodType = new System.Windows.Forms.Button();
            this.btnDeleteGoodType = new System.Windows.Forms.Button();
            this.btnAddGoodType = new System.Windows.Forms.Button();
            this.gridGoodsType = new System.Windows.Forms.DataGridView();
            this.tabPageSuppliers = new System.Windows.Forms.TabPage();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.gridSuppliers = new System.Windows.Forms.DataGridView();
            this.tabPageDeliveries = new System.Windows.Forms.TabPage();
            this.btnUpdateDelivery = new System.Windows.Forms.Button();
            this.btnDeleteDelivery = new System.Windows.Forms.Button();
            this.btnAddDelivery = new System.Windows.Forms.Button();
            this.gridDeliveries = new System.Windows.Forms.DataGridView();
            this.tabControlMain.SuspendLayout();
            this.tabPageGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGoods)).BeginInit();
            this.tabPageGoodsType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGoodsType)).BeginInit();
            this.tabPageSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).BeginInit();
            this.tabPageDeliveries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeliveries)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageGoods);
            this.tabControlMain.Controls.Add(this.tabPageGoodsType);
            this.tabControlMain.Controls.Add(this.tabPageSuppliers);
            this.tabControlMain.Controls.Add(this.tabPageDeliveries);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 413);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.TabControlMain_SelectedIndexChanged);
            // 
            // tabPageGoods
            // 
            this.tabPageGoods.Controls.Add(this.btnUpdateGood);
            this.tabPageGoods.Controls.Add(this.btnDeleteGood);
            this.tabPageGoods.Controls.Add(this.btnAddGood);
            this.tabPageGoods.Controls.Add(this.gridGoods);
            this.tabPageGoods.Location = new System.Drawing.Point(4, 22);
            this.tabPageGoods.Name = "tabPageGoods";
            this.tabPageGoods.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGoods.Size = new System.Drawing.Size(768, 387);
            this.tabPageGoods.TabIndex = 0;
            this.tabPageGoods.Text = "Товары";
            this.tabPageGoods.UseVisualStyleBackColor = true;
            // 
            // btnUpdateGood
            // 
            this.btnUpdateGood.Location = new System.Drawing.Point(168, 271);
            this.btnUpdateGood.Name = "btnUpdateGood";
            this.btnUpdateGood.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateGood.TabIndex = 7;
            this.btnUpdateGood.Text = "Изменить";
            this.btnUpdateGood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGood
            // 
            this.btnDeleteGood.Location = new System.Drawing.Point(87, 271);
            this.btnDeleteGood.Name = "btnDeleteGood";
            this.btnDeleteGood.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGood.TabIndex = 6;
            this.btnDeleteGood.Text = "Удалить";
            this.btnDeleteGood.UseVisualStyleBackColor = true;
            // 
            // btnAddGood
            // 
            this.btnAddGood.Location = new System.Drawing.Point(6, 271);
            this.btnAddGood.Name = "btnAddGood";
            this.btnAddGood.Size = new System.Drawing.Size(75, 23);
            this.btnAddGood.TabIndex = 5;
            this.btnAddGood.Text = "Добавить";
            this.btnAddGood.UseVisualStyleBackColor = true;
            // 
            // gridGoods
            // 
            this.gridGoods.AllowUserToAddRows = false;
            this.gridGoods.AllowUserToDeleteRows = false;
            this.gridGoods.AllowUserToResizeColumns = false;
            this.gridGoods.AllowUserToResizeRows = false;
            this.gridGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGoods.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridGoods.Location = new System.Drawing.Point(6, 6);
            this.gridGoods.Name = "gridGoods";
            this.gridGoods.ReadOnly = true;
            this.gridGoods.RowHeadersVisible = false;
            this.gridGoods.RowTemplate.Height = 23;
            this.gridGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGoods.Size = new System.Drawing.Size(514, 259);
            this.gridGoods.TabIndex = 0;
            // 
            // tabPageGoodsType
            // 
            this.tabPageGoodsType.Controls.Add(this.btnUpdateGoodType);
            this.tabPageGoodsType.Controls.Add(this.btnDeleteGoodType);
            this.tabPageGoodsType.Controls.Add(this.btnAddGoodType);
            this.tabPageGoodsType.Controls.Add(this.gridGoodsType);
            this.tabPageGoodsType.Location = new System.Drawing.Point(4, 22);
            this.tabPageGoodsType.Name = "tabPageGoodsType";
            this.tabPageGoodsType.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGoodsType.Size = new System.Drawing.Size(768, 387);
            this.tabPageGoodsType.TabIndex = 1;
            this.tabPageGoodsType.Text = "Типы товаров";
            this.tabPageGoodsType.UseVisualStyleBackColor = true;
            // 
            // btnUpdateGoodType
            // 
            this.btnUpdateGoodType.Location = new System.Drawing.Point(168, 271);
            this.btnUpdateGoodType.Name = "btnUpdateGoodType";
            this.btnUpdateGoodType.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateGoodType.TabIndex = 4;
            this.btnUpdateGoodType.Text = "Изменить";
            this.btnUpdateGoodType.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGoodType
            // 
            this.btnDeleteGoodType.Location = new System.Drawing.Point(87, 271);
            this.btnDeleteGoodType.Name = "btnDeleteGoodType";
            this.btnDeleteGoodType.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGoodType.TabIndex = 3;
            this.btnDeleteGoodType.Text = "Удалить";
            this.btnDeleteGoodType.UseVisualStyleBackColor = true;
            // 
            // btnAddGoodType
            // 
            this.btnAddGoodType.Location = new System.Drawing.Point(6, 271);
            this.btnAddGoodType.Name = "btnAddGoodType";
            this.btnAddGoodType.Size = new System.Drawing.Size(75, 23);
            this.btnAddGoodType.TabIndex = 2;
            this.btnAddGoodType.Text = "Добавить";
            this.btnAddGoodType.UseVisualStyleBackColor = true;
            this.btnAddGoodType.Click += new System.EventHandler(this.BtnAddGoodType_Click);
            // 
            // gridGoodsType
            // 
            this.gridGoodsType.AllowUserToAddRows = false;
            this.gridGoodsType.AllowUserToDeleteRows = false;
            this.gridGoodsType.AllowUserToResizeColumns = false;
            this.gridGoodsType.AllowUserToResizeRows = false;
            this.gridGoodsType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGoodsType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridGoodsType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGoodsType.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridGoodsType.Location = new System.Drawing.Point(6, 6);
            this.gridGoodsType.Name = "gridGoodsType";
            this.gridGoodsType.ReadOnly = true;
            this.gridGoodsType.RowHeadersVisible = false;
            this.gridGoodsType.RowTemplate.Height = 23;
            this.gridGoodsType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGoodsType.Size = new System.Drawing.Size(514, 259);
            this.gridGoodsType.TabIndex = 1;
            // 
            // tabPageSuppliers
            // 
            this.tabPageSuppliers.Controls.Add(this.btnUpdateSupplier);
            this.tabPageSuppliers.Controls.Add(this.btnDeleteSupplier);
            this.tabPageSuppliers.Controls.Add(this.btnSupplier);
            this.tabPageSuppliers.Controls.Add(this.gridSuppliers);
            this.tabPageSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabPageSuppliers.Name = "tabPageSuppliers";
            this.tabPageSuppliers.Size = new System.Drawing.Size(768, 387);
            this.tabPageSuppliers.TabIndex = 2;
            this.tabPageSuppliers.Text = "Поставщики";
            this.tabPageSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.Location = new System.Drawing.Point(168, 271);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSupplier.TabIndex = 8;
            this.btnUpdateSupplier.Text = "Изменить";
            this.btnUpdateSupplier.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(87, 271);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSupplier.TabIndex = 4;
            this.btnDeleteSupplier.Text = "Удалить";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(6, 271);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnSupplier.TabIndex = 3;
            this.btnSupplier.Text = "Добавить";
            this.btnSupplier.UseVisualStyleBackColor = true;
            // 
            // gridSuppliers
            // 
            this.gridSuppliers.AllowUserToAddRows = false;
            this.gridSuppliers.AllowUserToDeleteRows = false;
            this.gridSuppliers.AllowUserToResizeColumns = false;
            this.gridSuppliers.AllowUserToResizeRows = false;
            this.gridSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSuppliers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridSuppliers.Location = new System.Drawing.Point(6, 6);
            this.gridSuppliers.Name = "gridSuppliers";
            this.gridSuppliers.ReadOnly = true;
            this.gridSuppliers.RowHeadersVisible = false;
            this.gridSuppliers.RowTemplate.Height = 23;
            this.gridSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSuppliers.Size = new System.Drawing.Size(514, 259);
            this.gridSuppliers.TabIndex = 2;
            // 
            // tabPageDeliveries
            // 
            this.tabPageDeliveries.Controls.Add(this.btnUpdateDelivery);
            this.tabPageDeliveries.Controls.Add(this.btnDeleteDelivery);
            this.tabPageDeliveries.Controls.Add(this.btnAddDelivery);
            this.tabPageDeliveries.Controls.Add(this.gridDeliveries);
            this.tabPageDeliveries.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeliveries.Name = "tabPageDeliveries";
            this.tabPageDeliveries.Size = new System.Drawing.Size(768, 387);
            this.tabPageDeliveries.TabIndex = 3;
            this.tabPageDeliveries.Text = "Доставка";
            this.tabPageDeliveries.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDelivery
            // 
            this.btnUpdateDelivery.Location = new System.Drawing.Point(168, 271);
            this.btnUpdateDelivery.Name = "btnUpdateDelivery";
            this.btnUpdateDelivery.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDelivery.TabIndex = 9;
            this.btnUpdateDelivery.Text = "Изменить";
            this.btnUpdateDelivery.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDelivery
            // 
            this.btnDeleteDelivery.Location = new System.Drawing.Point(87, 271);
            this.btnDeleteDelivery.Name = "btnDeleteDelivery";
            this.btnDeleteDelivery.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDelivery.TabIndex = 5;
            this.btnDeleteDelivery.Text = "Удалить";
            this.btnDeleteDelivery.UseVisualStyleBackColor = true;
            // 
            // btnAddDelivery
            // 
            this.btnAddDelivery.Location = new System.Drawing.Point(6, 271);
            this.btnAddDelivery.Name = "btnAddDelivery";
            this.btnAddDelivery.Size = new System.Drawing.Size(75, 23);
            this.btnAddDelivery.TabIndex = 4;
            this.btnAddDelivery.Text = "Добавить";
            this.btnAddDelivery.UseVisualStyleBackColor = true;
            // 
            // gridDeliveries
            // 
            this.gridDeliveries.AllowUserToAddRows = false;
            this.gridDeliveries.AllowUserToDeleteRows = false;
            this.gridDeliveries.AllowUserToResizeColumns = false;
            this.gridDeliveries.AllowUserToResizeRows = false;
            this.gridDeliveries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDeliveries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDeliveries.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridDeliveries.Location = new System.Drawing.Point(6, 6);
            this.gridDeliveries.Name = "gridDeliveries";
            this.gridDeliveries.ReadOnly = true;
            this.gridDeliveries.RowHeadersVisible = false;
            this.gridDeliveries.RowTemplate.Height = 23;
            this.gridDeliveries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDeliveries.Size = new System.Drawing.Size(514, 259);
            this.gridDeliveries.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGoods)).EndInit();
            this.tabPageGoodsType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGoodsType)).EndInit();
            this.tabPageSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).EndInit();
            this.tabPageDeliveries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDeliveries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageGoods;
        private TabPage tabPageGoodsType;
        private TabPage tabPageSuppliers;
        private TabPage tabPageDeliveries;
        private DataGridView gridGoods;
        private DataGridView gridGoodsType;
        private DataGridView gridSuppliers;
        private DataGridView gridDeliveries;
        private Button btnUpdateGood;
        private Button btnDeleteGood;
        private Button btnAddGood;
        private Button btnUpdateGoodType;
        private Button btnDeleteGoodType;
        private Button btnAddGoodType;
        private Button btnUpdateSupplier;
        private Button btnDeleteSupplier;
        private Button btnSupplier;
        private Button btnUpdateDelivery;
        private Button btnDeleteDelivery;
        private Button btnAddDelivery;
    }
}