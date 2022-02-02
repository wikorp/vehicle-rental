namespace TruckRental
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewVehicles = new System.Windows.Forms.DataGridView();
            this.buttonRent = new System.Windows.Forms.Button();
            this.labelVehicles = new System.Windows.Forms.Label();
            this.labelVehicle = new System.Windows.Forms.Label();
            this.labelIdVehicle = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.buttonDamage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVehicles
            // 
            this.dataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicles.Location = new System.Drawing.Point(1, 33);
            this.dataGridViewVehicles.Name = "dataGridViewVehicles";
            this.dataGridViewVehicles.RowHeadersWidth = 51;
            this.dataGridViewVehicles.RowTemplate.Height = 24;
            this.dataGridViewVehicles.Size = new System.Drawing.Size(797, 214);
            this.dataGridViewVehicles.TabIndex = 0;
            this.dataGridViewVehicles.SelectionChanged += new System.EventHandler(this.dataGridViewVehicles_SelectionChanged_1);
            // 
            // buttonRent
            // 
            this.buttonRent.Location = new System.Drawing.Point(12, 261);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(130, 65);
            this.buttonRent.TabIndex = 1;
            this.buttonRent.Text = "RENT";
            this.buttonRent.UseVisualStyleBackColor = true;
            this.buttonRent.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // labelVehicles
            // 
            this.labelVehicles.AutoSize = true;
            this.labelVehicles.Location = new System.Drawing.Point(366, 9);
            this.labelVehicles.Name = "labelVehicles";
            this.labelVehicles.Size = new System.Drawing.Size(74, 17);
            this.labelVehicles.TabIndex = 2;
            this.labelVehicles.Text = "VEHICLES";
            // 
            // labelVehicle
            // 
            this.labelVehicle.AutoSize = true;
            this.labelVehicle.Location = new System.Drawing.Point(168, 304);
            this.labelVehicle.Name = "labelVehicle";
            this.labelVehicle.Size = new System.Drawing.Size(141, 17);
            this.labelVehicle.TabIndex = 3;
            this.labelVehicle.Text = "SELECTED VEHICLE";
            // 
            // labelIdVehicle
            // 
            this.labelIdVehicle.AutoSize = true;
            this.labelIdVehicle.Location = new System.Drawing.Point(168, 271);
            this.labelIdVehicle.Name = "labelIdVehicle";
            this.labelIdVehicle.Size = new System.Drawing.Size(86, 17);
            this.labelIdVehicle.TabIndex = 4;
            this.labelIdVehicle.Text = "VEHICLE ID:";
            this.labelIdVehicle.Click += new System.EventHandler(this.labelIdVehicle_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(266, 271);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 17);
            this.labelId.TabIndex = 5;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(346, 424);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(127, 17);
            this.labelClient.TabIndex = 10;
            this.labelClient.Text = "CLIENT ACCOUNT";
            // 
            // buttonDamage
            // 
            this.buttonDamage.Location = new System.Drawing.Point(654, 256);
            this.buttonDamage.Name = "buttonDamage";
            this.buttonDamage.Size = new System.Drawing.Size(134, 65);
            this.buttonDamage.TabIndex = 11;
            this.buttonDamage.Text = "VIEW YOUR RENTALS";
            this.buttonDamage.UseVisualStyleBackColor = true;
            this.buttonDamage.Click += new System.EventHandler(this.buttonDamage_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDamage);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelIdVehicle);
            this.Controls.Add(this.labelVehicle);
            this.Controls.Add(this.labelVehicles);
            this.Controls.Add(this.buttonRent);
            this.Controls.Add(this.dataGridViewVehicles);
            this.Name = "FormMain";
            this.Text = "Truck rental";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Disposed += new System.EventHandler(this.FormMain_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVehicles;
        private System.Windows.Forms.Button buttonRent;
        private System.Windows.Forms.Label labelVehicles;
        private System.Windows.Forms.Label labelVehicle;
        private System.Windows.Forms.Label labelIdVehicle;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Button buttonDamage;
    }
}

