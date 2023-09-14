namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    partial class ErrorStatusDisplayControl
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
            this.panelErrorStatus = new System.Windows.Forms.Panel();
            this.listBoxClearableErrors = new System.Windows.Forms.ListBox();
            this.buttonErrorClear = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelErrorStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelErrorStatus
            // 
            this.panelErrorStatus.Controls.Add(this.listBoxClearableErrors);
            this.panelErrorStatus.Controls.Add(this.buttonErrorClear);
            this.panelErrorStatus.Controls.Add(this.labelTitle);
            this.panelErrorStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelErrorStatus.Location = new System.Drawing.Point(0, 0);
            this.panelErrorStatus.Name = "panelErrorStatus";
            this.panelErrorStatus.Size = new System.Drawing.Size(320, 72);
            this.panelErrorStatus.TabIndex = 7;
            // 
            // listBoxClearableErrors
            // 
            this.listBoxClearableErrors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxClearableErrors.FormattingEnabled = true;
            this.listBoxClearableErrors.Location = new System.Drawing.Point(11, 13);
            this.listBoxClearableErrors.Name = "listBoxClearableErrors";
            this.listBoxClearableErrors.Size = new System.Drawing.Size(223, 43);
            this.listBoxClearableErrors.TabIndex = 5;
            // 
            // buttonErrorClear
            // 
            this.buttonErrorClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonErrorClear.Location = new System.Drawing.Point(245, 22);
            this.buttonErrorClear.Name = "buttonErrorClear";
            this.buttonErrorClear.Size = new System.Drawing.Size(55, 25);
            this.buttonErrorClear.TabIndex = 4;
            this.buttonErrorClear.Text = "Clear";
            this.buttonErrorClear.UseVisualStyleBackColor = true;
            this.buttonErrorClear.Click += new System.EventHandler(this.ButtonErrorClearClick);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 12);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Error";
            // 
            // ErrorStatusDisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelErrorStatus);
            this.Name = "ErrorStatusDisplayControl";
            this.Size = new System.Drawing.Size(320, 72);
            this.panelErrorStatus.ResumeLayout(false);
            this.panelErrorStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelErrorStatus;
        private System.Windows.Forms.ListBox listBoxClearableErrors;
        private System.Windows.Forms.Button buttonErrorClear;
        private System.Windows.Forms.Label labelTitle;

    }
}
