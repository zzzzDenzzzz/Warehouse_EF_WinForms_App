namespace Warehouse_EF_WinForms_App.Forms.Good
{
    partial class AddGoodForm
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
            this.labelGoodName = new System.Windows.Forms.Label();
            this.txtAddGoodName = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.numericGoodCost = new System.Windows.Forms.NumericUpDown();
            this.labelGoodType = new System.Windows.Forms.Label();
            this.comboBoxGoodType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericGoodCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGoodName
            // 
            this.labelGoodName.AutoSize = true;
            this.labelGoodName.Location = new System.Drawing.Point(45, 9);
            this.labelGoodName.Name = "labelGoodName";
            this.labelGoodName.Size = new System.Drawing.Size(65, 15);
            this.labelGoodName.TabIndex = 0;
            this.labelGoodName.Text = "Название :";
            // 
            // txtAddGoodName
            // 
            this.txtAddGoodName.Location = new System.Drawing.Point(116, 6);
            this.txtAddGoodName.Name = "txtAddGoodName";
            this.txtAddGoodName.Size = new System.Drawing.Size(272, 23);
            this.txtAddGoodName.TabIndex = 1;
            this.txtAddGoodName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAddGoodName_Validating);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(12, 49);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(98, 15);
            this.labelCost.TabIndex = 2;
            this.labelCost.Text = "Себестоимость :";
            // 
            // numericGoodCost
            // 
            this.numericGoodCost.Location = new System.Drawing.Point(116, 47);
            this.numericGoodCost.Name = "numericGoodCost";
            this.numericGoodCost.Size = new System.Drawing.Size(272, 23);
            this.numericGoodCost.TabIndex = 3;
            // 
            // labelGoodType
            // 
            this.labelGoodType.AutoSize = true;
            this.labelGoodType.Location = new System.Drawing.Point(37, 92);
            this.labelGoodType.Name = "labelGoodType";
            this.labelGoodType.Size = new System.Drawing.Size(73, 15);
            this.labelGoodType.TabIndex = 4;
            this.labelGoodType.Text = "Тип товара :";
            // 
            // comboBoxGoodType
            // 
            this.comboBoxGoodType.FormattingEnabled = true;
            this.comboBoxGoodType.Location = new System.Drawing.Point(116, 89);
            this.comboBoxGoodType.Name = "comboBoxGoodType";
            this.comboBoxGoodType.Size = new System.Drawing.Size(272, 23);
            this.comboBoxGoodType.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(116, 131);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(261, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // AddGoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 173);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBoxGoodType);
            this.Controls.Add(this.labelGoodType);
            this.Controls.Add(this.numericGoodCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.txtAddGoodName);
            this.Controls.Add(this.labelGoodName);
            this.Name = "AddGoodForm";
            this.Text = "GoodForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericGoodCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelGoodName;
        private TextBox txtAddGoodName;
        private Label labelCost;
        private NumericUpDown numericGoodCost;
        private Label labelGoodType;
        private ComboBox comboBoxGoodType;
        private Button btnAdd;
        private Button btnCancel;
        private ErrorProvider nameError;
    }
}