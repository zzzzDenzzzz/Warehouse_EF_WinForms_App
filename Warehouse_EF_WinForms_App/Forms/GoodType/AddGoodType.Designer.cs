namespace Warehouse_EF_WinForms_App.Forms.GoodType
{
    partial class AddGoodType
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.labeName = new System.Windows.Forms.Label();
            this.txtAddGoodTypeName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(93, 38);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 27);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // labeName
            // 
            this.labeName.AutoSize = true;
            this.labeName.Location = new System.Drawing.Point(14, 10);
            this.labeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeName.Name = "labeName";
            this.labeName.Size = new System.Drawing.Size(65, 15);
            this.labeName.TabIndex = 1;
            this.labeName.Text = "Название :";
            // 
            // txtAddGoodTypeName
            // 
            this.txtAddGoodTypeName.Location = new System.Drawing.Point(93, 7);
            this.txtAddGoodTypeName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddGoodTypeName.Name = "txtAddGoodTypeName";
            this.txtAddGoodTypeName.Size = new System.Drawing.Size(290, 23);
            this.txtAddGoodTypeName.TabIndex = 2;
            this.txtAddGoodTypeName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAddGoodTypeName_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(244, 38);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 27);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // AddGoodType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 77);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAddGoodTypeName);
            this.Controls.Add(this.labeName);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddGoodType";
            this.Text = "Добавить тип товара";
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private Label labeName;
        private TextBox txtAddGoodTypeName;
        private Button btnCancel;
        private ErrorProvider nameError;
    }
}