namespace TruckRental
{
    partial class FormDamage
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
            this.dataGridViewRentals = new System.Windows.Forms.DataGridView();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxDamege = new System.Windows.Forms.TextBox();
            this.labelDamege = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRentals
            // 
            this.dataGridViewRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRentals.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRentals.Name = "dataGridViewRentals";
            this.dataGridViewRentals.RowHeadersWidth = 51;
            this.dataGridViewRentals.Size = new System.Drawing.Size(730, 201);
            this.dataGridViewRentals.TabIndex = 0;
            this.dataGridViewRentals.SelectionChanged += new System.EventHandler(this.dataGridViewRentals_SelectionChanged_1);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(293, 347);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(135, 68);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxDamege
            // 
            this.textBoxDamege.Location = new System.Drawing.Point(12, 280);
            this.textBoxDamege.Name = "textBoxDamege";
            this.textBoxDamege.Size = new System.Drawing.Size(730, 22);
            this.textBoxDamege.TabIndex = 2;
            this.textBoxDamege.TextChanged += new System.EventHandler(this.textBoxDamege_TextChanged);
            // 
            // labelDamege
            // 
            this.labelDamege.AutoSize = true;
            this.labelDamege.Location = new System.Drawing.Point(9, 260);
            this.labelDamege.Name = "labelDamege";
            this.labelDamege.Size = new System.Drawing.Size(288, 17);
            this.labelDamege.TabIndex = 3;
            this.labelDamege.Text = "SELECT RENTAL AND DESCRIBE DAMAGE";
            // 
            // FormDamage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 424);
            this.Controls.Add(this.labelDamege);
            this.Controls.Add(this.textBoxDamege);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.dataGridViewRentals);
            this.Name = "FormDamage";
            this.Text = "Truck rental";
            this.Load += new System.EventHandler(this.FormDamage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRentals;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxDamege;
        private System.Windows.Forms.Label labelDamege;
    }
}