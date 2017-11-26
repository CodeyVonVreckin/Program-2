namespace UPVApp
{
    partial class LettersForm
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
            this.originComboBox = new System.Windows.Forms.ComboBox();
            this.destinComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.letterOKButtton = new System.Windows.Forms.Button();
            this.letterCancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fixedCostTxtBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // originComboBox
            // 
            this.originComboBox.FormattingEnabled = true;
            this.originComboBox.Location = new System.Drawing.Point(119, 12);
            this.originComboBox.Name = "originComboBox";
            this.originComboBox.Size = new System.Drawing.Size(181, 21);
            this.originComboBox.TabIndex = 0;
            this.originComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.originComboBox_Validating);
            this.originComboBox.Validated += new System.EventHandler(this.originComboBox_Validated);
            // 
            // destinComboBox
            // 
            this.destinComboBox.FormattingEnabled = true;
            this.destinComboBox.Location = new System.Drawing.Point(119, 53);
            this.destinComboBox.Name = "destinComboBox";
            this.destinComboBox.Size = new System.Drawing.Size(181, 21);
            this.destinComboBox.TabIndex = 1;
            this.destinComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.destinComboBox_Validating);
            this.destinComboBox.Validated += new System.EventHandler(this.destinComboBox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destination Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Origin Address";
            // 
            // letterOKButtton
            // 
            this.letterOKButtton.Location = new System.Drawing.Point(119, 154);
            this.letterOKButtton.Name = "letterOKButtton";
            this.letterOKButtton.Size = new System.Drawing.Size(75, 23);
            this.letterOKButtton.TabIndex = 4;
            this.letterOKButtton.Text = "OK";
            this.letterOKButtton.UseVisualStyleBackColor = true;
            this.letterOKButtton.Click += new System.EventHandler(this.letterOKButtton_Click);
            // 
            // letterCancelButton
            // 
            this.letterCancelButton.Location = new System.Drawing.Point(225, 154);
            this.letterCancelButton.Name = "letterCancelButton";
            this.letterCancelButton.Size = new System.Drawing.Size(75, 23);
            this.letterCancelButton.TabIndex = 5;
            this.letterCancelButton.Text = "Cancel";
            this.letterCancelButton.UseVisualStyleBackColor = true;
            this.letterCancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.letterCancelButton_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fixed Cost";
            // 
            // fixedCostTxtBox
            // 
            this.fixedCostTxtBox.Location = new System.Drawing.Point(119, 95);
            this.fixedCostTxtBox.Name = "fixedCostTxtBox";
            this.fixedCostTxtBox.Size = new System.Drawing.Size(165, 20);
            this.fixedCostTxtBox.TabIndex = 7;
            this.fixedCostTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.fixedCostTxtBox_Validating);
            this.fixedCostTxtBox.Validated += new System.EventHandler(this.fixedCostTxtBox_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LettersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 189);
            this.Controls.Add(this.fixedCostTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.letterCancelButton);
            this.Controls.Add(this.letterOKButtton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinComboBox);
            this.Controls.Add(this.originComboBox);
            this.Name = "LettersForm";
            this.Text = "Add Letter";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox destinComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button letterOKButtton;
        private System.Windows.Forms.Button letterCancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fixedCostTxtBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox originComboBox;
    }
}