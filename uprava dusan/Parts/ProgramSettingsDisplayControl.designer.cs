namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    partial class ProgramSettingsDisplayControl
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
            if( pictureBoxMasterImage.Image != null){
                pictureBoxMasterImage.Image.Dispose();
            }
        }

        #region コンポーネント デザイナで生成されたコード

        /// <summary> 
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			this.panelProgramSettings = new System.Windows.Forms.Panel();
			this.labelMasterImage = new System.Windows.Forms.Label();
			this.pictureBoxMasterImage = new System.Windows.Forms.PictureBox();
			this.labelTriggerCycleTitle = new System.Windows.Forms.Label();
			this.labelTriggerCycle = new System.Windows.Forms.Label();
			this.labelProgramNo = new System.Windows.Forms.Label();
			this.labelProgramNoTitle = new System.Windows.Forms.Label();
			this.labelExternalTrigger = new System.Windows.Forms.Label();
			this.labelExternalTriggerTitle = new System.Windows.Forms.Label();
			this.labelActiveProgramTitle = new System.Windows.Forms.Label();
			this.labelActiveProgram = new System.Windows.Forms.Label();
			this.labelProgramSettings = new System.Windows.Forms.Label();
			this.panelProgramSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMasterImage)).BeginInit();
			this.SuspendLayout();
			// 
			// panelProgramSettings
			// 
			this.panelProgramSettings.Controls.Add(this.labelMasterImage);
			this.panelProgramSettings.Controls.Add(this.pictureBoxMasterImage);
			this.panelProgramSettings.Controls.Add(this.labelTriggerCycleTitle);
			this.panelProgramSettings.Controls.Add(this.labelTriggerCycle);
			this.panelProgramSettings.Controls.Add(this.labelProgramNo);
			this.panelProgramSettings.Controls.Add(this.labelProgramNoTitle);
			this.panelProgramSettings.Controls.Add(this.labelExternalTrigger);
			this.panelProgramSettings.Controls.Add(this.labelExternalTriggerTitle);
			this.panelProgramSettings.Controls.Add(this.labelActiveProgramTitle);
			this.panelProgramSettings.Controls.Add(this.labelActiveProgram);
			this.panelProgramSettings.Controls.Add(this.labelProgramSettings);
			this.panelProgramSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelProgramSettings.Location = new System.Drawing.Point(0, 0);
			this.panelProgramSettings.Name = "panelProgramSettings";
			this.panelProgramSettings.Size = new System.Drawing.Size(205, 234);
			this.panelProgramSettings.TabIndex = 4;
			this.panelProgramSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProgramSettings_Paint);
			// 
			// labelMasterImage
			// 
			this.labelMasterImage.AutoSize = true;
			this.labelMasterImage.Location = new System.Drawing.Point(28, 80);
			this.labelMasterImage.Name = "labelMasterImage";
			this.labelMasterImage.Size = new System.Drawing.Size(68, 13);
			this.labelMasterImage.TabIndex = 20;
			this.labelMasterImage.Text = "MasterImage";
			// 
			// pictureBoxMasterImage
			// 
			this.pictureBoxMasterImage.BackColor = System.Drawing.Color.Silver;
			this.pictureBoxMasterImage.Location = new System.Drawing.Point(3, 94);
			this.pictureBoxMasterImage.Name = "pictureBoxMasterImage";
			this.pictureBoxMasterImage.Size = new System.Drawing.Size(200, 138);
			this.pictureBoxMasterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxMasterImage.TabIndex = 19;
			this.pictureBoxMasterImage.TabStop = false;
			// 
			// labelTriggerCycleTitle
			// 
			this.labelTriggerCycleTitle.AutoSize = true;
			this.labelTriggerCycleTitle.Location = new System.Drawing.Point(13, 60);
			this.labelTriggerCycleTitle.Name = "labelTriggerCycleTitle";
			this.labelTriggerCycleTitle.Size = new System.Drawing.Size(85, 13);
			this.labelTriggerCycleTitle.TabIndex = 18;
			this.labelTriggerCycleTitle.Text = "TriggerCycle(ms)";
			// 
			// labelTriggerCycle
			// 
			this.labelTriggerCycle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTriggerCycle.AutoSize = true;
			this.labelTriggerCycle.Location = new System.Drawing.Point(108, 62);
			this.labelTriggerCycle.Name = "labelTriggerCycle";
			this.labelTriggerCycle.Size = new System.Drawing.Size(13, 13);
			this.labelTriggerCycle.TabIndex = 17;
			this.labelTriggerCycle.Text = "--";
			// 
			// labelProgramNo
			// 
			this.labelProgramNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelProgramNo.AutoSize = true;
			this.labelProgramNo.Location = new System.Drawing.Point(108, 17);
			this.labelProgramNo.Name = "labelProgramNo";
			this.labelProgramNo.Size = new System.Drawing.Size(13, 13);
			this.labelProgramNo.TabIndex = 16;
			this.labelProgramNo.Text = "--";
			// 
			// labelProgramNoTitle
			// 
			this.labelProgramNoTitle.AutoSize = true;
			this.labelProgramNoTitle.Location = new System.Drawing.Point(13, 15);
			this.labelProgramNoTitle.Name = "labelProgramNoTitle";
			this.labelProgramNoTitle.Size = new System.Drawing.Size(63, 13);
			this.labelProgramNoTitle.TabIndex = 15;
			this.labelProgramNoTitle.Text = "ProgramNo.";
			// 
			// labelExternalTrigger
			// 
			this.labelExternalTrigger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelExternalTrigger.AutoSize = true;
			this.labelExternalTrigger.Location = new System.Drawing.Point(108, 47);
			this.labelExternalTrigger.Name = "labelExternalTrigger";
			this.labelExternalTrigger.Size = new System.Drawing.Size(13, 13);
			this.labelExternalTrigger.TabIndex = 14;
			this.labelExternalTrigger.Text = "--";
			// 
			// labelExternalTriggerTitle
			// 
			this.labelExternalTriggerTitle.AutoSize = true;
			this.labelExternalTriggerTitle.Location = new System.Drawing.Point(13, 45);
			this.labelExternalTriggerTitle.Name = "labelExternalTriggerTitle";
			this.labelExternalTriggerTitle.Size = new System.Drawing.Size(78, 13);
			this.labelExternalTriggerTitle.TabIndex = 13;
			this.labelExternalTriggerTitle.Text = "ExternalTrigger";
			// 
			// labelActiveProgramTitle
			// 
			this.labelActiveProgramTitle.AutoSize = true;
			this.labelActiveProgramTitle.Location = new System.Drawing.Point(13, 30);
			this.labelActiveProgramTitle.Name = "labelActiveProgramTitle";
			this.labelActiveProgramTitle.Size = new System.Drawing.Size(74, 13);
			this.labelActiveProgramTitle.TabIndex = 10;
			this.labelActiveProgramTitle.Text = "ProgramName";
			this.labelActiveProgramTitle.Click += new System.EventHandler(this.labelActiveProgramTitle_Click);
			// 
			// labelActiveProgram
			// 
			this.labelActiveProgram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelActiveProgram.AutoSize = true;
			this.labelActiveProgram.Location = new System.Drawing.Point(108, 32);
			this.labelActiveProgram.Name = "labelActiveProgram";
			this.labelActiveProgram.Size = new System.Drawing.Size(13, 13);
			this.labelActiveProgram.TabIndex = 9;
			this.labelActiveProgram.Text = "--";
			// 
			// labelProgramSettings
			// 
			this.labelProgramSettings.AutoSize = true;
			this.labelProgramSettings.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelProgramSettings.Location = new System.Drawing.Point(0, 0);
			this.labelProgramSettings.Name = "labelProgramSettings";
			this.labelProgramSettings.Size = new System.Drawing.Size(104, 12);
			this.labelProgramSettings.TabIndex = 0;
			this.labelProgramSettings.Text = "ProgramSettings";
			this.labelProgramSettings.Visible = false;
			// 
			// ProgramSettingsDisplayControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelProgramSettings);
			this.Name = "ProgramSettingsDisplayControl";
			this.Size = new System.Drawing.Size(205, 234);
			this.panelProgramSettings.ResumeLayout(false);
			this.panelProgramSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMasterImage)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProgramSettings;
        private System.Windows.Forms.Label labelTriggerCycleTitle;
        private System.Windows.Forms.Label labelTriggerCycle;
        private System.Windows.Forms.Label labelProgramNo;
        private System.Windows.Forms.Label labelProgramNoTitle;
        private System.Windows.Forms.Label labelExternalTriggerTitle;
        private System.Windows.Forms.Label labelActiveProgramTitle;
        private System.Windows.Forms.Label labelActiveProgram;
        private System.Windows.Forms.Label labelProgramSettings;
        private System.Windows.Forms.Label labelExternalTrigger;
        private System.Windows.Forms.PictureBox pictureBoxMasterImage;
        private System.Windows.Forms.Label labelMasterImage;
    }
}
