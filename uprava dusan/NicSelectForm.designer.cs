namespace Keyence.IV.Sdk.Sample_CSharp
{
    partial class NicSelectForm
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
            this.labelNics = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.comboBoxEnableIPAddress = new System.Windows.Forms.ComboBox();
            this.labelClientIPAddress = new System.Windows.Forms.Label();
            this.labelClientIPAddressTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNics
            // 
            this.labelNics.AutoSize = true;
            this.labelNics.Location = new System.Drawing.Point(8, 36);
            this.labelNics.Name = "labelNics";
            this.labelNics.Size = new System.Drawing.Size(142, 12);
            this.labelNics.TabIndex = 9;
            this.labelNics.Text = "Available Network Adapter";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(196, 48);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 8;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.ButtonChangeClick);
            // 
            // comboBoxEnableIPAddress
            // 
            this.comboBoxEnableIPAddress.FormattingEnabled = true;
            this.comboBoxEnableIPAddress.Location = new System.Drawing.Point(23, 51);
            this.comboBoxEnableIPAddress.Name = "comboBoxEnableIPAddress";
            this.comboBoxEnableIPAddress.Size = new System.Drawing.Size(167, 20);
            this.comboBoxEnableIPAddress.TabIndex = 7;
            // 
            // labelClientIPAddress
            // 
            this.labelClientIPAddress.AutoSize = true;
            this.labelClientIPAddress.Location = new System.Drawing.Point(74, 9);
            this.labelClientIPAddress.Name = "labelClientIPAddress";
            this.labelClientIPAddress.Size = new System.Drawing.Size(17, 12);
            this.labelClientIPAddress.TabIndex = 6;
            this.labelClientIPAddress.Text = "--";
            // 
            // labelClientIPAddressTitle
            // 
            this.labelClientIPAddressTitle.AutoSize = true;
            this.labelClientIPAddressTitle.Location = new System.Drawing.Point(8, 9);
            this.labelClientIPAddressTitle.Name = "labelClientIPAddressTitle";
            this.labelClientIPAddressTitle.Size = new System.Drawing.Size(49, 12);
            this.labelClientIPAddressTitle.TabIndex = 5;
            this.labelClientIPAddressTitle.Text = "Client IP";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(196, 71);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // NicSelectForm
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(278, 100);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelNics);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.comboBoxEnableIPAddress);
            this.Controls.Add(this.labelClientIPAddress);
            this.Controls.Add(this.labelClientIPAddressTitle);
            this.MaximizeBox = false;
            this.Name = "NicSelectForm";
            this.Text = "NicSelectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNics;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.ComboBox comboBoxEnableIPAddress;
        private System.Windows.Forms.Label labelClientIPAddress;
        private System.Windows.Forms.Label labelClientIPAddressTitle;
        private System.Windows.Forms.Button buttonClose;

    }
}