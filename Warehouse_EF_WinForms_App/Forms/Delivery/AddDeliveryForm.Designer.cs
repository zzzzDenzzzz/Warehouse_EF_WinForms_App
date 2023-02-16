namespace Warehouse_EF_WinForms_App.Forms.Delivery
{
    partial class AddDeliveryForm
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
            this.components = new System.ComponentModel.Container();
            this.labelAmount = new System.Windows.Forms.Label();
            this.numericAddAmount = new System.Windows.Forms.NumericUpDown();
            this.labelGood = new System.Windows.Forms.Label();
            this.comboBoxGood = new System.Windows.Forms.ComboBox();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDelivery = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorAmount = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGood = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSupplier = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericAddAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(12, 9);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(74, 13);
            this.labelAmount.TabIndex = 0;
            this.labelAmount.Text = "Количество :";
            // 
            // numericAddAmount
            // 
            this.numericAddAmount.Location = new System.Drawing.Point(92, 7);
            this.numericAddAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericAddAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAddAmount.Name = "numericAddAmount";
            this.numericAddAmount.Size = new System.Drawing.Size(166, 21);
            this.numericAddAmount.TabIndex = 1;
            this.numericAddAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAddAmount.Validating += new System.ComponentModel.CancelEventHandler(this.NumericAddAmount_Validating);
            // 
            // labelGood
            // 
            this.labelGood.AutoSize = true;
            this.labelGood.Location = new System.Drawing.Point(42, 47);
            this.labelGood.Name = "labelGood";
            this.labelGood.Size = new System.Drawing.Size(44, 13);
            this.labelGood.TabIndex = 2;
            this.labelGood.Text = "Товар :";
            // 
            // comboBoxGood
            // 
            this.comboBoxGood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGood.FormattingEnabled = true;
            this.comboBoxGood.Location = new System.Drawing.Point(92, 44);
            this.comboBoxGood.Name = "comboBoxGood";
            this.comboBoxGood.Size = new System.Drawing.Size(166, 21);
            this.comboBoxGood.TabIndex = 3;
            this.comboBoxGood.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxGood_Validating);
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Location = new System.Drawing.Point(15, 88);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(71, 13);
            this.labelSupplier.TabIndex = 4;
            this.labelSupplier.Text = "Поставщик :";
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(92, 85);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(166, 21);
            this.comboBoxSupplier.TabIndex = 5;
            this.comboBoxSupplier.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxSupplier_Validating);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(46, 130);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(40, 13);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Дата :";
            // 
            // dateTimePickerDelivery
            // 
            this.dateTimePickerDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDelivery.Location = new System.Drawing.Point(92, 124);
            this.dateTimePickerDelivery.MaxDate = new System.DateTime(2023, 2, 16, 0, 0, 0, 0);
            this.dateTimePickerDelivery.MinDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDelivery.Name = "dateTimePickerDelivery";
            this.dateTimePickerDelivery.Size = new System.Drawing.Size(166, 21);
            this.dateTimePickerDelivery.TabIndex = 7;
            this.dateTimePickerDelivery.Value = new System.DateTime(2023, 2, 16, 0, 0, 0, 0);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(183, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorAmount
            // 
            this.errorAmount.ContainerControl = this;
            // 
            // errorGood
            // 
            this.errorGood.ContainerControl = this;
            // 
            // errorSupplier
            // 
            this.errorSupplier.ContainerControl = this;
            // 
            // AddDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 203);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePickerDelivery);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.comboBoxGood);
            this.Controls.Add(this.labelGood);
            this.Controls.Add(this.numericAddAmount);
            this.Controls.Add(this.labelAmount);
            this.Name = "AddDeliveryForm";
            this.Text = "Добавить поставку";
            ((System.ComponentModel.ISupportInitialize)(this.numericAddAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAmount;
        private NumericUpDown numericAddAmount;
        private Label labelGood;
        private ComboBox comboBoxGood;
        private Label labelSupplier;
        private ComboBox comboBoxSupplier;
        private Label labelDate;
        private DateTimePicker dateTimePickerDelivery;
        private Button btnAdd;
        private Button btnCancel;
        private ErrorProvider errorAmount;
        private ErrorProvider errorGood;
        private ErrorProvider errorSupplier;
    }
}