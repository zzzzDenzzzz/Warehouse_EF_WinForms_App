namespace Warehouse_EF_WinForms_App.Forms.Good
{
    partial class SetGoodTypeQueryGoodForm
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
            this.comboBoxGoodType = new System.Windows.Forms.ComboBox();
            this.labelGoodType = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorGoodType = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorGoodType)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGoodType
            // 
            this.comboBoxGoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGoodType.FormattingEnabled = true;
            this.comboBoxGoodType.Location = new System.Drawing.Point(82, 6);
            this.comboBoxGoodType.Name = "comboBoxGoodType";
            this.comboBoxGoodType.Size = new System.Drawing.Size(162, 21);
            this.comboBoxGoodType.TabIndex = 0;
            this.comboBoxGoodType.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxGoodType_Validating);
            // 
            // labelGoodType
            // 
            this.labelGoodType.AutoSize = true;
            this.labelGoodType.Location = new System.Drawing.Point(12, 9);
            this.labelGoodType.Name = "labelGoodType";
            this.labelGoodType.Size = new System.Drawing.Size(64, 13);
            this.labelGoodType.TabIndex = 1;
            this.labelGoodType.Text = "Тип товара";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(82, 44);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Выбрать";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(169, 44);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorGoodType
            // 
            this.errorGoodType.ContainerControl = this;
            // 
            // SetGoodTypeQueryGoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 79);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelGoodType);
            this.Controls.Add(this.comboBoxGoodType);
            this.Name = "SetGoodTypeQueryGoodForm";
            this.Text = "Выбрать тип товара";
            ((System.ComponentModel.ISupportInitialize)(this.errorGoodType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxGoodType;
        private Label labelGoodType;
        private Button btnOk;
        private Button btnCancel;
        private ErrorProvider errorGoodType;
    }
}