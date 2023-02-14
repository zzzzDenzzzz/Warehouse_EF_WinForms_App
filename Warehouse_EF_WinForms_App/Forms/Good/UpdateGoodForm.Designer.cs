namespace Warehouse_EF_WinForms_App.Forms.Good
{
    partial class UpdateGoodForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelGoodType = new System.Windows.Forms.Label();
            this.txtUpdateGoodName = new System.Windows.Forms.TextBox();
            this.numericUpdateGoodCost = new System.Windows.Forms.NumericUpDown();
            this.comboBoxUpdateGoodType = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCost = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGoodType = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateGoodCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGoodType)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(41, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(62, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название :";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(12, 43);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(91, 13);
            this.labelCost.TabIndex = 1;
            this.labelCost.Text = "Себестоимость :";
            // 
            // labelGoodType
            // 
            this.labelGoodType.AutoSize = true;
            this.labelGoodType.Location = new System.Drawing.Point(32, 80);
            this.labelGoodType.Name = "labelGoodType";
            this.labelGoodType.Size = new System.Drawing.Size(71, 13);
            this.labelGoodType.TabIndex = 2;
            this.labelGoodType.Text = "Тип товара :";
            // 
            // txtUpdateGoodName
            // 
            this.txtUpdateGoodName.Location = new System.Drawing.Point(109, 6);
            this.txtUpdateGoodName.Name = "txtUpdateGoodName";
            this.txtUpdateGoodName.Size = new System.Drawing.Size(213, 21);
            this.txtUpdateGoodName.TabIndex = 3;
            this.txtUpdateGoodName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUpdateGoodName_Validating);
            // 
            // numericUpdateGoodCost
            // 
            this.numericUpdateGoodCost.DecimalPlaces = 2;
            this.numericUpdateGoodCost.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpdateGoodCost.Location = new System.Drawing.Point(109, 41);
            this.numericUpdateGoodCost.Name = "numericUpdateGoodCost";
            this.numericUpdateGoodCost.Size = new System.Drawing.Size(213, 21);
            this.numericUpdateGoodCost.TabIndex = 4;
            this.numericUpdateGoodCost.Validating += new System.ComponentModel.CancelEventHandler(this.NumericUpdateGoodCost_Validating);
            // 
            // comboBoxUpdateGoodType
            // 
            this.comboBoxUpdateGoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpdateGoodType.FormattingEnabled = true;
            this.comboBoxUpdateGoodType.Location = new System.Drawing.Point(109, 77);
            this.comboBoxUpdateGoodType.Name = "comboBoxUpdateGoodType";
            this.comboBoxUpdateGoodType.Size = new System.Drawing.Size(213, 21);
            this.comboBoxUpdateGoodType.TabIndex = 5;
            this.comboBoxUpdateGoodType.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxUpdateGoodType_Validating);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(109, 113);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(227, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // errorCost
            // 
            this.errorCost.ContainerControl = this;
            // 
            // errorGoodType
            // 
            this.errorGoodType.ContainerControl = this;
            // 
            // UpdateGoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 148);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboBoxUpdateGoodType);
            this.Controls.Add(this.numericUpdateGoodCost);
            this.Controls.Add(this.txtUpdateGoodName);
            this.Controls.Add(this.labelGoodType);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelName);
            this.Name = "UpdateGoodForm";
            this.Text = "Изменить товар";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateGoodCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGoodType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelName;
        private Label labelCost;
        private Label labelGoodType;
        private TextBox txtUpdateGoodName;
        private NumericUpDown numericUpdateGoodCost;
        private ComboBox comboBoxUpdateGoodType;
        private Button btnUpdate;
        private Button btnCancel;
        private ErrorProvider nameError;
        private ErrorProvider errorCost;
        private ErrorProvider errorGoodType;
    }
}