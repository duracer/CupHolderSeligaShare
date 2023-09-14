namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    partial class ToolResultDisplayControl
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
            if(panelImage != null){
                panelImage.Dispose();
            }
        }

        #region コンポーネント デザイナで生成されたコード

        /// <summary> 
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelToolName = new System.Windows.Forms.Label();
            this.panelValueGauge = new System.Windows.Forms.Panel();
            this.labelMatchPercent = new System.Windows.Forms.Label();
            this.labelToolType = new System.Windows.Forms.Label();
            this.labelToolNo = new System.Windows.Forms.Label();
            this.labelDot = new System.Windows.Forms.Label();
            this.labelMinValue = new System.Windows.Forms.Label();
            this.labelMaxValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelToolName
            // 
            this.labelToolName.AutoSize = true;
            this.labelToolName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelToolName.Location = new System.Drawing.Point(37, 2);
            this.labelToolName.Name = "labelToolName";
            this.labelToolName.Size = new System.Drawing.Size(82, 16);
            this.labelToolName.TabIndex = 0;
            this.labelToolName.Text = "ToolName";
            this.labelToolName.Click += new System.EventHandler(this.ToolResultDisplayControlClick);
            // 
            // panelValueGauge
            // 
            this.panelValueGauge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelValueGauge.BackColor = System.Drawing.Color.White;
            this.panelValueGauge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelValueGauge.Location = new System.Drawing.Point(9, 24);
            this.panelValueGauge.Name = "panelValueGauge";
            this.panelValueGauge.Size = new System.Drawing.Size(271, 11);
            this.panelValueGauge.TabIndex = 1;
            this.panelValueGauge.Click += new System.EventHandler(this.ToolResultDisplayControlClick);
            // 
            // labelMatchPercent
            // 
            this.labelMatchPercent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMatchPercent.AutoSize = true;
            this.labelMatchPercent.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMatchPercent.Location = new System.Drawing.Point(263, 5);
            this.labelMatchPercent.Name = "labelMatchPercent";
            this.labelMatchPercent.Size = new System.Drawing.Size(26, 16);
            this.labelMatchPercent.TabIndex = 2;
            this.labelMatchPercent.Text = "--";
            this.labelMatchPercent.Click += new System.EventHandler(this.ToolResultDisplayControlClick);
            // 
            // labelToolType
            // 
            this.labelToolType.AutoSize = true;
            this.labelToolType.Location = new System.Drawing.Point(139, 7);
            this.labelToolType.Name = "labelToolType";
            this.labelToolType.Size = new System.Drawing.Size(52, 13);
            this.labelToolType.TabIndex = 3;
            this.labelToolType.Text = "ToolType";
            this.labelToolType.Click += new System.EventHandler(this.ToolResultDisplayControlClick);
            // 
            // labelToolNo
            // 
            this.labelToolNo.AutoSize = true;
            this.labelToolNo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelToolNo.Location = new System.Drawing.Point(6, 2);
            this.labelToolNo.Name = "labelToolNo";
            this.labelToolNo.Size = new System.Drawing.Size(28, 16);
            this.labelToolNo.TabIndex = 4;
            this.labelToolNo.Text = "No";
            this.labelToolNo.Click += new System.EventHandler(this.ToolResultDisplayControlClick);
            // 
            // labelDot
            // 
            this.labelDot.AutoSize = true;
            this.labelDot.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDot.Location = new System.Drawing.Point(28, 2);
            this.labelDot.Name = "labelDot";
            this.labelDot.Size = new System.Drawing.Size(12, 16);
            this.labelDot.TabIndex = 5;
            this.labelDot.Text = ".";
            // 
            // labelMinValue
            // 
            this.labelMinValue.AutoSize = true;
            this.labelMinValue.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMinValue.Location = new System.Drawing.Point(8, 37);
            this.labelMinValue.Name = "labelMinValue";
            this.labelMinValue.Size = new System.Drawing.Size(17, 11);
            this.labelMinValue.TabIndex = 6;
            this.labelMinValue.Text = "--";
            // 
            // labelMaxValue
            // 
            this.labelMaxValue.AutoSize = true;
            this.labelMaxValue.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMaxValue.Location = new System.Drawing.Point(262, 37);
            this.labelMaxValue.Name = "labelMaxValue";
            this.labelMaxValue.Size = new System.Drawing.Size(17, 11);
            this.labelMaxValue.TabIndex = 7;
            this.labelMaxValue.Text = "--";
            // 
            // ToolResultDisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.labelMaxValue);
            this.Controls.Add(this.labelMinValue);
            this.Controls.Add(this.labelDot);
            this.Controls.Add(this.labelToolNo);
            this.Controls.Add(this.labelToolType);
            this.Controls.Add(this.labelMatchPercent);
            this.Controls.Add(this.panelValueGauge);
            this.Controls.Add(this.labelToolName);
            this.Name = "ToolResultDisplayControl";
            this.Size = new System.Drawing.Size(290, 49);
            this.Click += new System.EventHandler(this.ToolResultDisplayControlClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelToolName;
        private System.Windows.Forms.Panel panelValueGauge;
        private System.Windows.Forms.Label labelMatchPercent;
        private System.Windows.Forms.Label labelToolType;
        private System.Windows.Forms.Label labelToolNo;
        private System.Windows.Forms.Label labelDot;
        private System.Windows.Forms.Label labelMinValue;
        private System.Windows.Forms.Label labelMaxValue;
    }
}
