namespace Warehouse_EF_WinForms_App.Forms.Good
{
    partial class SetDateDeliveryQueryGoodForm
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
            this.labelAmountDays = new System.Windows.Forms.Label();
            this.numericAmountDays = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmountDays)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAmountDays
            // 
            this.labelAmountDays.AutoSize = true;
            this.labelAmountDays.Location = new System.Drawing.Point(12, 9);
            this.labelAmountDays.Name = "labelAmountDays";
            this.labelAmountDays.Size = new System.Drawing.Size(107, 15);
            this.labelAmountDays.TabIndex = 0;
            this.labelAmountDays.Text = "Количество дней :";
            // 
            // numericAmountDays
            // 
            this.numericAmountDays.Location = new System.Drawing.Point(125, 7);
            this.numericAmountDays.Name = "numericAmountDays";
            this.numericAmountDays.Size = new System.Drawing.Size(161, 23);
            this.numericAmountDays.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(125, 36);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Задать";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(211, 36);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SetDataDeliveryQueryGoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 69);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numericAmountDays);
            this.Controls.Add(this.labelAmountDays);
            this.Name = "SetDataDeliveryQueryGoodForm";
            this.Text = "Задать количество дней";
            ((System.ComponentModel.ISupportInitialize)(this.numericAmountDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAmountDays;
        private NumericUpDown numericAmountDays;
        private Button btnOk;
        private Button btnCancel;
    }
}