namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    partial class ProgramListDisplayControl
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
            this.panelProgramSwitch = new System.Windows.Forms.Panel();
            this.buttonTrigger = new System.Windows.Forms.Button();
            this.buttonSwitchProgram = new System.Windows.Forms.Button();
            this.listBoxPrograms = new System.Windows.Forms.ListBox();
            this.labelLockState = new System.Windows.Forms.Label();
            this.buttonLock = new System.Windows.Forms.Button();
            this.buttonUnLock = new System.Windows.Forms.Button();
            this.labelProgramSwitch = new System.Windows.Forms.Label();
            this.panelProgramSwitch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProgramSwitch
            // 
            this.panelProgramSwitch.Controls.Add(this.buttonTrigger);
            this.panelProgramSwitch.Controls.Add(this.buttonSwitchProgram);
            this.panelProgramSwitch.Controls.Add(this.listBoxPrograms);
            this.panelProgramSwitch.Controls.Add(this.labelLockState);
            this.panelProgramSwitch.Controls.Add(this.buttonLock);
            this.panelProgramSwitch.Controls.Add(this.buttonUnLock);
            this.panelProgramSwitch.Controls.Add(this.labelProgramSwitch);
            this.panelProgramSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProgramSwitch.Location = new System.Drawing.Point(0, 0);
            this.panelProgramSwitch.Name = "panelProgramSwitch";
            this.panelProgramSwitch.Size = new System.Drawing.Size(320, 134);
            this.panelProgramSwitch.TabIndex = 5;
            // 
            // buttonTrigger
            // 
            this.buttonTrigger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTrigger.Location = new System.Drawing.Point(242, 31);
            this.buttonTrigger.Name = "buttonTrigger";
            this.buttonTrigger.Size = new System.Drawing.Size(75, 23);
            this.buttonTrigger.TabIndex = 6;
            this.buttonTrigger.Text = "Trigger";
            this.buttonTrigger.UseVisualStyleBackColor = true;
            this.buttonTrigger.Click += new System.EventHandler(this.ButtonTriggerClick);
            // 
            // buttonSwitchProgram
            // 
            this.buttonSwitchProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSwitchProgram.Location = new System.Drawing.Point(242, 8);
            this.buttonSwitchProgram.Name = "buttonSwitchProgram";
            this.buttonSwitchProgram.Size = new System.Drawing.Size(75, 23);
            this.buttonSwitchProgram.TabIndex = 10;
            this.buttonSwitchProgram.Text = "Switch";
            this.buttonSwitchProgram.UseVisualStyleBackColor = true;
            this.buttonSwitchProgram.Click += new System.EventHandler(this.ButtonSwitchProgramClick);
            // 
            // listBoxPrograms
            // 
            this.listBoxPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPrograms.FormattingEnabled = true;
            this.listBoxPrograms.ItemHeight = 12;
            this.listBoxPrograms.Location = new System.Drawing.Point(11, 17);
            this.listBoxPrograms.Name = "listBoxPrograms";
            this.listBoxPrograms.Size = new System.Drawing.Size(220, 112);
            this.listBoxPrograms.TabIndex = 7;
            // 
            // labelLockState
            // 
            this.labelLockState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLockState.AutoSize = true;
            this.labelLockState.Location = new System.Drawing.Point(260, 92);
            this.labelLockState.Name = "labelLockState";
            this.labelLockState.Size = new System.Drawing.Size(17, 12);
            this.labelLockState.TabIndex = 5;
            this.labelLockState.Text = "--";
            this.labelLockState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonLock
            // 
            this.buttonLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLock.Location = new System.Drawing.Point(242, 106);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(75, 23);
            this.buttonLock.TabIndex = 4;
            this.buttonLock.Text = "Lock";
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.ButtonLogoutClick);
            // 
            // buttonUnLock
            // 
            this.buttonUnLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUnLock.Location = new System.Drawing.Point(242, 66);
            this.buttonUnLock.Name = "buttonUnLock";
            this.buttonUnLock.Size = new System.Drawing.Size(75, 23);
            this.buttonUnLock.TabIndex = 3;
            this.buttonUnLock.Text = "Unlock";
            this.buttonUnLock.UseVisualStyleBackColor = true;
            this.buttonUnLock.Click += new System.EventHandler(this.ButtonLoginClick);
            // 
            // labelProgramSwitch
            // 
            this.labelProgramSwitch.AutoSize = true;
            this.labelProgramSwitch.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelProgramSwitch.Location = new System.Drawing.Point(0, 0);
            this.labelProgramSwitch.Name = "labelProgramSwitch";
            this.labelProgramSwitch.Size = new System.Drawing.Size(94, 12);
            this.labelProgramSwitch.TabIndex = 2;
            this.labelProgramSwitch.Text = "ProgramSwitch";
            // 
            // ProgramListDisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelProgramSwitch);
            this.Name = "ProgramListDisplayControl";
            this.Size = new System.Drawing.Size(320, 134);
            this.panelProgramSwitch.ResumeLayout(false);
            this.panelProgramSwitch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProgramSwitch;
        private System.Windows.Forms.Button buttonSwitchProgram;
        private System.Windows.Forms.ListBox listBoxPrograms;
        private System.Windows.Forms.Label labelLockState;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Button buttonUnLock;
        private System.Windows.Forms.Label labelProgramSwitch;
        private System.Windows.Forms.Button buttonTrigger;
    }
}
