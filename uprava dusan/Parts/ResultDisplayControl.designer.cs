namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    partial class ResultDisplayControl
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
			this.labelTimeTitle = new System.Windows.Forms.Label();
			this.labelTriggerCountTitle = new System.Windows.Forms.Label();
			this.labelTime = new System.Windows.Forms.Label();
			this.labelTotal = new System.Windows.Forms.Label();
			this.labelTrigger = new System.Windows.Forms.Label();
			this.panelTotalResult = new System.Windows.Forms.Panel();
			this.labelResult = new System.Windows.Forms.Label();
			this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.panelTotalResult.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTimeTitle
			// 
			this.labelTimeTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelTimeTitle.AutoSize = true;
			this.labelTimeTitle.Location = new System.Drawing.Point(176, 28);
			this.labelTimeTitle.Name = "labelTimeTitle";
			this.labelTimeTitle.Size = new System.Drawing.Size(30, 13);
			this.labelTimeTitle.TabIndex = 30;
			this.labelTimeTitle.Text = "Time";
			this.labelTimeTitle.Click += new System.EventHandler(this.labelTimeTitle_Click);
			// 
			// labelTriggerCountTitle
			// 
			this.labelTriggerCountTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelTriggerCountTitle.AutoSize = true;
			this.labelTriggerCountTitle.Location = new System.Drawing.Point(135, 12);
			this.labelTriggerCountTitle.Name = "labelTriggerCountTitle";
			this.labelTriggerCountTitle.Size = new System.Drawing.Size(68, 13);
			this.labelTriggerCountTitle.TabIndex = 29;
			this.labelTriggerCountTitle.Text = "TriggerCount";
			this.labelTriggerCountTitle.Click += new System.EventHandler(this.labelTriggerCountTitle_Click);
			// 
			// labelTime
			// 
			this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelTime.AutoSize = true;
			this.labelTime.Location = new System.Drawing.Point(220, 28);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(13, 13);
			this.labelTime.TabIndex = 28;
			this.labelTime.Text = "--";
			this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
			// 
			// labelTotal
			// 
			this.labelTotal.AutoSize = true;
			this.labelTotal.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelTotal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelTotal.Location = new System.Drawing.Point(19, 5);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(70, 48);
			this.labelTotal.TabIndex = 26;
			this.labelTotal.Text = "--";
			this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
			// 
			// labelTrigger
			// 
			this.labelTrigger.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelTrigger.AutoSize = true;
			this.labelTrigger.Location = new System.Drawing.Point(220, 12);
			this.labelTrigger.Name = "labelTrigger";
			this.labelTrigger.Size = new System.Drawing.Size(13, 13);
			this.labelTrigger.TabIndex = 27;
			this.labelTrigger.Text = "--";
			this.labelTrigger.Click += new System.EventHandler(this.labelTrigger_Click);
			// 
			// panelTotalResult
			// 
			this.panelTotalResult.Controls.Add(this.labelResult);
			this.panelTotalResult.Controls.Add(this.labelTotal);
			this.panelTotalResult.Controls.Add(this.labelTimeTitle);
			this.panelTotalResult.Controls.Add(this.labelTrigger);
			this.panelTotalResult.Controls.Add(this.labelTriggerCountTitle);
			this.panelTotalResult.Controls.Add(this.labelTime);
			this.panelTotalResult.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTotalResult.Location = new System.Drawing.Point(0, 0);
			this.panelTotalResult.Name = "panelTotalResult";
			this.panelTotalResult.Size = new System.Drawing.Size(320, 59);
			this.panelTotalResult.TabIndex = 32;
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelResult.Location = new System.Drawing.Point(-2, 0);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(44, 12);
			this.labelResult.TabIndex = 3;
			this.labelResult.Text = "Result";
			this.labelResult.Visible = false;
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.AutoScroll = true;
			this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel.Location = new System.Drawing.Point(0, 59);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Size = new System.Drawing.Size(320, 34);
			this.flowLayoutPanel.TabIndex = 33;
			// 
			// ResultDisplayControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.flowLayoutPanel);
			this.Controls.Add(this.panelTotalResult);
			this.Name = "ResultDisplayControl";
			this.Size = new System.Drawing.Size(320, 93);
			this.panelTotalResult.ResumeLayout(false);
			this.panelTotalResult.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTimeTitle;
        private System.Windows.Forms.Label labelTriggerCountTitle;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTrigger;
        private System.Windows.Forms.Panel panelTotalResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;

    }
}
