namespace UPVApp
{
    partial class AddressForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox2 = new System.Windows.Forms.TextBox();
            this.cityTxtBox = new System.Windows.Forms.TextBox();
            this.zipTxtBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.stateBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(40, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(30, 56);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(51, 117);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(43, 152);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 3;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(53, 190);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(25, 13);
            this.zipLabel.TabIndex = 4;
            this.zipLabel.Text = "Zip:";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(84, 18);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 5;
            this.nameTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTxt_Validating);
            this.nameTxtBox.Validated += new System.EventHandler(this.nameTxt_Validated);
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(84, 53);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(100, 20);
            this.addressTxtBox.TabIndex = 6;
            this.addressTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.addressTxt_Validating);
            this.addressTxtBox.Validated += new System.EventHandler(this.addressTxt_Validated);
            // 
            // addressTxtBox2
            // 
            this.addressTxtBox2.Location = new System.Drawing.Point(84, 79);
            this.addressTxtBox2.Name = "addressTxtBox2";
            this.addressTxtBox2.Size = new System.Drawing.Size(100, 20);
            this.addressTxtBox2.TabIndex = 7;
            // 
            // cityTxtBox
            // 
            this.cityTxtBox.Location = new System.Drawing.Point(84, 114);
            this.cityTxtBox.Name = "cityTxtBox";
            this.cityTxtBox.Size = new System.Drawing.Size(100, 20);
            this.cityTxtBox.TabIndex = 8;
            this.cityTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.cityTxt_Validating);
            this.cityTxtBox.Validated += new System.EventHandler(this.cityTxt_Validated);
            // 
            // zipTxtBox
            // 
            this.zipTxtBox.Location = new System.Drawing.Point(84, 187);
            this.zipTxtBox.Name = "zipTxtBox";
            this.zipTxtBox.Size = new System.Drawing.Size(100, 20);
            this.zipTxtBox.TabIndex = 10;
            this.zipTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.zipTxt_Validating);
            this.zipTxtBox.Validated += new System.EventHandler(this.zipTxt_Validated);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 238);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(146, 238);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseDown);
            // 
            // stateBox
            // 
            this.stateBox.FormattingEnabled = true;
            this.stateBox.Location = new System.Drawing.Point(84, 149);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(100, 21);
            this.stateBox.TabIndex = 9;
            this.stateBox.Validating += new System.ComponentModel.CancelEventHandler(this.stateBox_Validating);
            this.stateBox.Validated += new System.EventHandler(this.stateBox_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 273);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.zipTxtBox);
            this.Controls.Add(this.cityTxtBox);
            this.Controls.Add(this.addressTxtBox2);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddressForm";
            this.Text = "Add Address";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.TextBox addressTxtBox2;
        private System.Windows.Forms.TextBox cityTxtBox;
        private System.Windows.Forms.TextBox zipTxtBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox stateBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}