namespace Warehouse_EF_WinForms_App.Forms.Supplier
{
    partial class AddSupplierForm
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
            this.txtAddSupplierName = new System.Windows.Forms.TextBox();
            this.labeName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(243, 37);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 27);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtAddSupplierName
            // 
            this.txtAddSupplierName.Location = new System.Drawing.Point(92, 6);
            this.txtAddSupplierName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddSupplierName.Name = "txtAddSupplierName";
            this.txtAddSupplierName.Size = new System.Drawing.Size(290, 23);
            this.txtAddSupplierName.TabIndex = 6;
            this.txtAddSupplierName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAddSupplierName_Validating);
            // 
            // labeName
            // 
            this.labeName.AutoSize = true;
            this.labeName.Location = new System.Drawing.Point(13, 9);
            this.labeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeName.Name = "labeName";
            this.labeName.Size = new System.Drawing.Size(65, 15);
            this.labeName.TabIndex = 5;
            this.labeName.Text = "Название :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 37);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // AddSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 81);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAddSupplierName);
            this.Controls.Add(this.labeName);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddSupplierForm";
            this.Text = "SupplierForm";
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private TextBox txtAddSupplierName;
        private Label labeName;
        private Button btnAdd;
        private ErrorProvider nameError;
    }
}