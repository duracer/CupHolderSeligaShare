namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    partial class SensorIdentificationDisplayControl
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
            this.panelSensor = new System.Windows.Forms.Panel();
            this.labelMachineName = new System.Windows.Forms.Label();
            this.labelSerialNo = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelModelName = new System.Windows.Forms.Label();
            this.labelMachineNameTitle = new System.Windows.Forms.Label();
            this.labelSerialNoTitle = new System.Windows.Forms.Label();
            this.labelVersionTitle = new System.Windows.Forms.Label();
            this.labelModelNameTitle = new System.Windows.Forms.Label();
            this.labelModelInfo = new System.Windows.Forms.Label();
            this.panelSensor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSensor
            // 
            this.panelSensor.Controls.Add(this.labelMachineName);
            this.panelSensor.Controls.Add(this.labelSerialNo);
            this.panelSensor.Controls.Add(this.labelVersion);
            this.panelSensor.Controls.Add(this.labelModelName);
            this.panelSensor.Controls.Add(this.labelMachineNameTitle);
            this.panelSensor.Controls.Add(this.labelSerialNoTitle);
            this.panelSensor.Controls.Add(this.labelVersionTitle);
            this.panelSensor.Controls.Add(this.labelModelNameTitle);
            this.panelSensor.Controls.Add(this.labelModelInfo);
            this.panelSensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSensor.Location = new System.Drawing.Point(0, 0);
            this.panelSensor.Name = "panelSensor";
            this.panelSensor.Size = new System.Drawing.Size(320, 68);
            this.panelSensor.TabIndex = 1;
            // 
            // labelMachineName
            // 
            this.labelMachineName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMachineName.AutoSize = true;
            this.labelMachineName.Location = new System.Drawing.Point(110, 51);
            this.labelMachineName.Name = "labelMachineName";
            this.labelMachineName.Size = new System.Drawing.Size(17, 12);
            this.labelMachineName.TabIndex = 10;
            this.labelMachineName.Text = "--";
            // 
            // labelSerialNo
            // 
            this.labelSerialNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSerialNo.AutoSize = true;
            this.labelSerialNo.Location = new System.Drawing.Point(110, 39);
            this.labelSerialNo.Name = "labelSerialNo";
            this.labelSerialNo.Size = new System.Drawing.Size(17, 12);
            this.labelSerialNo.TabIndex = 9;
            this.labelSerialNo.Text = "--";
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(110, 27);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(17, 12);
            this.labelVersion.TabIndex = 8;
            this.labelVersion.Text = "--";
            // 
            // labelModelName
            // 
            this.labelModelName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelModelName.AutoSize = true;
            this.labelModelName.Location = new System.Drawing.Point(110, 15);
            this.labelModelName.Name = "labelModelName";
            this.labelModelName.Size = new System.Drawing.Size(17, 12);
            this.labelModelName.TabIndex = 7;
            this.labelModelName.Text = "--";
            // 
            // labelMachineNameTitle
            // 
            this.labelMachineNameTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMachineNameTitle.AutoSize = true;
            this.labelMachineNameTitle.Location = new System.Drawing.Point(23, 51);
            this.labelMachineNameTitle.Name = "labelMachineNameTitle";
            this.labelMachineNameTitle.Size = new System.Drawing.Size(69, 12);
            this.labelMachineNameTitle.TabIndex = 6;
            this.labelMachineNameTitle.Text = "DeviceName";
            // 
            // labelSerialNoTitle
            // 
            this.labelSerialNoTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSerialNoTitle.AutoSize = true;
            this.labelSerialNoTitle.Location = new System.Drawing.Point(23, 39);
            this.labelSerialNoTitle.Name = "labelSerialNoTitle";
            this.labelSerialNoTitle.Size = new System.Drawing.Size(54, 12);
            this.labelSerialNoTitle.TabIndex = 5;
            this.labelSerialNoTitle.Text = "Serial No.";
            // 
            // labelVersionTitle
            // 
            this.labelVersionTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelVersionTitle.AutoSize = true;
            this.labelVersionTitle.Location = new System.Drawing.Point(23, 27);
            this.labelVersionTitle.Name = "labelVersionTitle";
            this.labelVersionTitle.Size = new System.Drawing.Size(44, 12);
            this.labelVersionTitle.TabIndex = 4;
            this.labelVersionTitle.Text = "Version";
            // 
            // labelModelNameTitle
            // 
            this.labelModelNameTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelModelNameTitle.AutoSize = true;
            this.labelModelNameTitle.Location = new System.Drawing.Point(23, 15);
            this.labelModelNameTitle.Name = "labelModelNameTitle";
            this.labelModelNameTitle.Size = new System.Drawing.Size(64, 12);
            this.labelModelNameTitle.TabIndex = 3;
            this.labelModelNameTitle.Text = "ModelName";
            // 
            // labelModelInfo
            // 
            this.labelModelInfo.AutoSize = true;
            this.labelModelInfo.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelModelInfo.Location = new System.Drawing.Point(0, -1);
            this.labelModelInfo.Name = "labelModelInfo";
            this.labelModelInfo.Size = new System.Drawing.Size(46, 12);
            this.labelModelInfo.TabIndex = 2;
            this.labelModelInfo.Text = "Sensor";
            // 
            // SensorIdentificationDisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSensor);
            this.Name = "SensorIdentificationDisplayControl";
            this.Size = new System.Drawing.Size(320, 68);
            this.panelSensor.ResumeLayout(false);
            this.panelSensor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSensor;
        private System.Windows.Forms.Label labelMachineName;
        private System.Windows.Forms.Label labelSerialNo;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelModelName;
        private System.Windows.Forms.Label labelMachineNameTitle;
        private System.Windows.Forms.Label labelSerialNoTitle;
        private System.Windows.Forms.Label labelVersionTitle;
        private System.Windows.Forms.Label labelModelNameTitle;
        private System.Windows.Forms.Label labelModelInfo;
    }
}
