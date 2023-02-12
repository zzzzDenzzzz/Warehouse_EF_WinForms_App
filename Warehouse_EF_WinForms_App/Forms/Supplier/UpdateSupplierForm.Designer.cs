namespace Warehouse_EF_WinForms_App.Forms.Supplier
{
    partial class UpdateSupplierForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUpdateSupplierName = new System.Windows.Forms.TextBox();
            this.labeName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(237, 37);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 27);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtUpdateSupplierName
            // 
            this.txtUpdateSupplierName.Location = new System.Drawing.Point(86, 6);
            this.txtUpdateSupplierName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUpdateSupplierName.Name = "txtUpdateSupplierName";
            this.txtUpdateSupplierName.Size = new System.Drawing.Size(290, 23);
            this.txtUpdateSupplierName.TabIndex = 10;
            // 
            // labeName
            // 
            this.labeName.AutoSize = true;
            this.labeName.Location = new System.Drawing.Point(13, 9);
            this.labeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeName.Name = "labeName";
            this.labeName.Size = new System.Drawing.Size(65, 15);
            this.labeName.TabIndex = 9;
            this.labeName.Text = "Название :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(86, 37);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 27);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // UpdateSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 81);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtUpdateSupplierName);
            this.Controls.Add(this.labeName);
            this.Controls.Add(this.btnUpdate);
            this.Name = "UpdateSupplierForm";
            this.Text = "UpdateSupplierForm";
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private TextBox txtUpdateSupplierName;
        private Label labeName;
        private Button btnUpdate;
        private ErrorProvider nameError;
    }
}