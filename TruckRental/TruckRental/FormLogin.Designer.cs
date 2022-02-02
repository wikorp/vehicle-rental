namespace TruckRental
{
    partial class FormLogin
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreetNumber = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.labelStreetNumber = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(39, 73);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(188, 22);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(39, 153);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(188, 22);
            this.textBoxSurname.TabIndex = 1;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Location = new System.Drawing.Point(39, 235);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(188, 22);
            this.textBoxAccount.TabIndex = 2;
            this.textBoxAccount.TextChanged += new System.EventHandler(this.textBoxAccount_TextChanged);
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(281, 73);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(191, 22);
            this.textBoxStreet.TabIndex = 3;
            this.textBoxStreet.TextChanged += new System.EventHandler(this.textBoxStreet_TextChanged);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(281, 235);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(191, 22);
            this.textBoxCity.TabIndex = 4;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            // 
            // textBoxStreetNumber
            // 
            this.textBoxStreetNumber.Location = new System.Drawing.Point(281, 153);
            this.textBoxStreetNumber.Name = "textBoxStreetNumber";
            this.textBoxStreetNumber.Size = new System.Drawing.Size(191, 22);
            this.textBoxStreetNumber.TabIndex = 5;
            this.textBoxStreetNumber.TextChanged += new System.EventHandler(this.textBoxStreetNumber_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(36, 53);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(36, 133);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(65, 17);
            this.labelSurname.TabIndex = 7;
            this.labelSurname.Text = "Surname";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(36, 215);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(111, 17);
            this.labelAccount.TabIndex = 8;
            this.labelAccount.Text = "Account number";
            // 
            // labelStreetNumber
            // 
            this.labelStreetNumber.AutoSize = true;
            this.labelStreetNumber.Location = new System.Drawing.Point(278, 133);
            this.labelStreetNumber.Name = "labelStreetNumber";
            this.labelStreetNumber.Size = new System.Drawing.Size(98, 17);
            this.labelStreetNumber.TabIndex = 9;
            this.labelStreetNumber.Text = "Street number";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(287, 215);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(31, 17);
            this.labelCity.TabIndex = 10;
            this.labelCity.Text = "City";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(178, 19);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(140, 17);
            this.labelData.TabIndex = 11;
            this.labelData.Text = "ENTER YOUR DATA";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(278, 53);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(46, 17);
            this.labelStreet.TabIndex = 12;
            this.labelStreet.Text = "Street";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(181, 290);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(116, 58);
            this.buttonOk.TabIndex = 13;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 369);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelStreetNumber);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxStreetNumber);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxAccount);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormLogin";
            this.Text = "Truck rental";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxStreetNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Label labelStreetNumber;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Button buttonOk;
    }
}