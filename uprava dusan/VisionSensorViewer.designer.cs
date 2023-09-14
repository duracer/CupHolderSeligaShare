namespace Keyence.IV.Sdk.Sample_CSharp
{
    partial class VisionSensorViewer
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
            this.panelDisconnection = new System.Windows.Forms.Panel();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.checkBoxEvent = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tmrReCon = new System.Windows.Forms.Timer(this.components);
            this.lbCisloKam = new System.Windows.Forms.Label();
            this.programSettingsDisplayControl = new Keyence.IV.Sdk.Sample_CSharp.Parts.ProgramSettingsDisplayControl();
            this.errorStatusDisplayControl = new Keyence.IV.Sdk.Sample_CSharp.Parts.ErrorStatusDisplayControl();
            this.resultDisplayControl = new Keyence.IV.Sdk.Sample_CSharp.Parts.ResultDisplayControl();
            this.imageDisplayControl = new Keyence.IV.Sdk.Sample_CSharp.Parts.ImageDisplayControl();
            this.panelDisconnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDisconnection
            // 
            this.panelDisconnection.Controls.Add(this.buttonConnect);
            this.panelDisconnection.Controls.Add(this.buttonDisconnect);
            this.panelDisconnection.Controls.Add(this.checkBoxEvent);
            this.panelDisconnection.Location = new System.Drawing.Point(3, 3);
            this.panelDisconnection.Name = "panelDisconnection";
            this.panelDisconnection.Size = new System.Drawing.Size(101, 90);
            this.panelDisconnection.TabIndex = 3;
            this.panelDisconnection.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDisconnection_Paint);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(3, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 25);
            this.buttonConnect.TabIndex = 8;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnectClick);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(3, 34);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 25);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.Disconnect);
            // 
            // checkBoxEvent
            // 
            this.checkBoxEvent.AutoSize = true;
            this.checkBoxEvent.Enabled = false;
            this.checkBoxEvent.Location = new System.Drawing.Point(3, 65);
            this.checkBoxEvent.Name = "checkBoxEvent";
            this.checkBoxEvent.Size = new System.Drawing.Size(98, 17);
            this.checkBoxEvent.TabIndex = 1;
            this.checkBoxEvent.Text = "camConnected";
            this.checkBoxEvent.UseVisualStyleBackColor = true;
            this.checkBoxEvent.CheckedChanged += new System.EventHandler(this.CheckBoxEventCheckedChanged);
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // tmrReCon
            // 
            this.tmrReCon.Interval = 5000;
            // 
            // lbCisloKam
            // 
            this.lbCisloKam.AutoSize = true;
            this.lbCisloKam.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCisloKam.Location = new System.Drawing.Point(3, 96);
            this.lbCisloKam.Name = "lbCisloKam";
            this.lbCisloKam.Size = new System.Drawing.Size(68, 73);
            this.lbCisloKam.TabIndex = 10;
            this.lbCisloKam.Text = "6";
            // 
            // programSettingsDisplayControl
            // 
            this.programSettingsDisplayControl.Location = new System.Drawing.Point(105, 3);
            this.programSettingsDisplayControl.Name = "programSettingsDisplayControl";
            this.programSettingsDisplayControl.Size = new System.Drawing.Size(205, 234);
            this.programSettingsDisplayControl.TabIndex = 8;
            this.programSettingsDisplayControl.Load += new System.EventHandler(this.programSettingsDisplayControl_Load);
            // 
            // errorStatusDisplayControl
            // 
            this.errorStatusDisplayControl.Location = new System.Drawing.Point(3, 243);
            this.errorStatusDisplayControl.Name = "errorStatusDisplayControl";
            this.errorStatusDisplayControl.Size = new System.Drawing.Size(320, 72);
            this.errorStatusDisplayControl.TabIndex = 7;
            this.errorStatusDisplayControl.Visible = false;
            this.errorStatusDisplayControl.Load += new System.EventHandler(this.errorStatusDisplayControl_Load);
            // 
            // resultDisplayControl
            // 
            this.resultDisplayControl.AutoScroll = true;
            this.resultDisplayControl.BackColor = System.Drawing.SystemColors.Control;
            this.resultDisplayControl.Location = new System.Drawing.Point(642, 0);
            this.resultDisplayControl.Name = "resultDisplayControl";
            this.resultDisplayControl.Size = new System.Drawing.Size(320, 314);
            this.resultDisplayControl.TabIndex = 6;
            this.resultDisplayControl.Load += new System.EventHandler(this.resultDisplayControl_Load);
            // 
            // imageDisplayControl
            // 
            this.imageDisplayControl.Location = new System.Drawing.Point(316, 3);
            this.imageDisplayControl.Name = "imageDisplayControl";
            this.imageDisplayControl.Size = new System.Drawing.Size(320, 220);
            this.imageDisplayControl.TabIndex = 5;
            // 
            // VisionSensorViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDisconnection);
            this.Controls.Add(this.lbCisloKam);
            this.Controls.Add(this.programSettingsDisplayControl);
            this.Controls.Add(this.errorStatusDisplayControl);
            this.Controls.Add(this.resultDisplayControl);
            this.Controls.Add(this.imageDisplayControl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "VisionSensorViewer";
            this.Size = new System.Drawing.Size(965, 304);
            this.Load += new System.EventHandler(this.VisionSensorViewer_Load);
            this.panelDisconnection.ResumeLayout(false);
            this.panelDisconnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelDisconnection;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.CheckBox checkBoxEvent;
        private Parts.ImageDisplayControl imageDisplayControl;
        private Parts.ResultDisplayControl resultDisplayControl;
        private Parts.ErrorStatusDisplayControl errorStatusDisplayControl;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Timer tmrReCon;
        private Parts.ProgramSettingsDisplayControl programSettingsDisplayControl;
        private System.Windows.Forms.Label lbCisloKam;
    }
}
