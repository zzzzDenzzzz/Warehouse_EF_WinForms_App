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
            this.btnAdd = new System.Windows.Forms.Button();
            this.labeName = new System.Windows.Forms.Label();
            this.txtAddGoodTypeName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(80, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // labeName
            // 
            this.labeName.AutoSize = true;
            this.labeName.Location = new System.Drawing.Point(12, 9);
            this.labeName.Name = "labeName";
            this.labeName.Size = new System.Drawing.Size(62, 13);
            this.labeName.TabIndex = 1;
            this.labeName.Text = "Название :";
            // 
            // txtAddGoodTypeName
            // 
            this.txtAddGoodTypeName.Location = new System.Drawing.Point(80, 6);
            this.txtAddGoodTypeName.Name = "txtAddGoodTypeName";
            this.txtAddGoodTypeName.Size = new System.Drawing.Size(249, 21);
            this.txtAddGoodTypeName.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 33);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddGoodType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 67);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAddGoodTypeName);
            this.Controls.Add(this.labeName);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddGoodType";
            this.Text = "Добавить тип товара";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private Label labeName;
        private TextBox txtAddGoodTypeName;
        private Button btnCancel;
    }
}