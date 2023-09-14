using Keyence.IV.Sdk.Sample_CSharp.Parts;

namespace Keyence.IV.Sdk.Sample_CSharp
{
    partial class SampleForm
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

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelServer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.visionSensorViewer1 = new Keyence.IV.Sdk.Sample_CSharp.VisionSensorViewer();
            this.plcResultDisplayControl1 = new Keyence.IV.Sdk.Sample_CSharp.Parts.PlcResultDisplayControl();
            this.panelServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "camera_3.png");
            // 
            // panelServer
            // 
            this.panelServer.Controls.Add(this.pictureBox1);
            this.panelServer.Controls.Add(this.btnInfo);
            this.panelServer.Controls.Add(this.visionSensorViewer1);
            this.panelServer.Controls.Add(this.plcResultDisplayControl1);
            this.panelServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelServer.Location = new System.Drawing.Point(0, 0);
            this.panelServer.Margin = new System.Windows.Forms.Padding(4);
            this.panelServer.Name = "panelServer";
            this.panelServer.Size = new System.Drawing.Size(2195, 1242);
            this.panelServer.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1724, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInfo.ImageIndex = 0;
            this.btnInfo.ImageList = this.imageList1;
            this.btnInfo.Location = new System.Drawing.Point(2108, 1166);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(67, 62);
            this.btnInfo.TabIndex = 11;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click_1);
            // 
            // visionSensorViewer1
            // 
            this.visionSensorViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.visionSensorViewer1.Location = new System.Drawing.Point(1106, 853);
            this.visionSensorViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.visionSensorViewer1.Name = "visionSensorViewer1";
            this.visionSensorViewer1.Size = new System.Drawing.Size(974, 375);
            this.visionSensorViewer1.TabIndex = 8;
            this.visionSensorViewer1.Load += new System.EventHandler(this.VisionSensorViewer1_Load_1);
            // 
            // plcResultDisplayControl1
            // 
            this.plcResultDisplayControl1.Location = new System.Drawing.Point(4, 4);
            this.plcResultDisplayControl1.Margin = new System.Windows.Forms.Padding(5);
            this.plcResultDisplayControl1.Name = "plcResultDisplayControl1";
            this.plcResultDisplayControl1.Size = new System.Drawing.Size(1090, 1238);
            this.plcResultDisplayControl1.TabIndex = 9;
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2195, 1242);
            this.Controls.Add(this.panelServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SampleForm";
            this.Text = "K-Viewer v.0.99.9";
            this.Load += new System.EventHandler(this.SampleForm_Load);
            this.panelServer.ResumeLayout(false);
            this.panelServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelServer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInfo;
        private VisionSensorViewer visionSensorViewer1;
        private PlcResultDisplayControl plcResultDisplayControl1;
    }
}

