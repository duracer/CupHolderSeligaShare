namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    partial class IPAddressControl
    {
        /// <summary> 
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナで生成されたコード

        /// <summary> 
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.maskedTextBoxIpAddress = new System.Windows.Forms.MaskedTextBox();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.labelPortNo = new System.Windows.Forms.Label();
            this.textBoxPortNo = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxIpAddress
            // 
            this.maskedTextBoxIpAddress.Location = new System.Drawing.Point(25, 0);
            this.maskedTextBoxIpAddress.Mask = "000 . 000 . 000 . 000 ";
            this.maskedTextBoxIpAddress.Name = "maskedTextBoxIpAddress";
            this.maskedTextBoxIpAddress.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBoxIpAddress.TabIndex = 1;
            this.maskedTextBoxIpAddress.Text = "010000000195";
            this.maskedTextBoxIpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxIpAddress.Validating += new System.ComponentModel.CancelEventHandler(this.MaskedTextBoxIpAddressValidating);
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Location = new System.Drawing.Point(6, 4);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(17, 13);
            this.labelIPAddress.TabIndex = 2;
            this.labelIPAddress.Text = "IP";
            // 
            // labelPortNo
            // 
            this.labelPortNo.AutoSize = true;
            this.labelPortNo.Location = new System.Drawing.Point(182, 4);
            this.labelPortNo.Name = "labelPortNo";
            this.labelPortNo.Size = new System.Drawing.Size(40, 13);
            this.labelPortNo.TabIndex = 3;
            this.labelPortNo.Text = "PortNo";
            // 
            // textBoxPortNo
            // 
            this.textBoxPortNo.Location = new System.Drawing.Point(225, 0);
            this.textBoxPortNo.Name = "textBoxPortNo";
            this.textBoxPortNo.Size = new System.Drawing.Size(66, 20);
            this.textBoxPortNo.TabIndex = 4;
            this.textBoxPortNo.Text = "63000";
            this.textBoxPortNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPortNo.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxPortNoValidating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // IPAddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.textBoxPortNo);
            this.Controls.Add(this.labelPortNo);
            this.Controls.Add(this.labelIPAddress);
            this.Controls.Add(this.maskedTextBoxIpAddress);
            this.Name = "IPAddressControl";
            this.Size = new System.Drawing.Size(320, 21);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxIpAddress;
        private System.Windows.Forms.Label labelIPAddress;
        private System.Windows.Forms.Label labelPortNo;
        private System.Windows.Forms.TextBox textBoxPortNo;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
