
namespace SWORLD开发助手.ToolsOwn
{
    partial class UC_Tools_TTS
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Tbx_TransformationWords = new System.Windows.Forms.TextBox();
            this.Lab_TransformationWords = new System.Windows.Forms.Label();
            this.Cbx_TransformationEngine = new System.Windows.Forms.ComboBox();
            this.Btn_Speak = new System.Windows.Forms.Button();
            this.Btn_SaveToLocal = new System.Windows.Forms.Button();
            this.Lab_TransformationEngine = new System.Windows.Forms.Label();
            this.Lab_SaveFormat = new System.Windows.Forms.Label();
            this.Cbx_SaveFormat = new System.Windows.Forms.ComboBox();
            this.Tkb_Volume = new System.Windows.Forms.TrackBar();
            this.Tkb_Rate = new System.Windows.Forms.TrackBar();
            this.Lab_Speed = new System.Windows.Forms.Label();
            this.Lab_Volume = new System.Windows.Forms.Label();
            this.Lab_VolumeValue = new System.Windows.Forms.Label();
            this.Lab_SpeedValue = new System.Windows.Forms.Label();
            this.Sfd_Speech = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Tkb_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tkb_Rate)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbx_TransformationWords
            // 
            this.Tbx_TransformationWords.Location = new System.Drawing.Point(3, 29);
            this.Tbx_TransformationWords.Multiline = true;
            this.Tbx_TransformationWords.Name = "Tbx_TransformationWords";
            this.Tbx_TransformationWords.Size = new System.Drawing.Size(470, 386);
            this.Tbx_TransformationWords.TabIndex = 0;
            this.Tbx_TransformationWords.Text = "您正在使用SWORLD开发助手";
            // 
            // Lab_TransformationWords
            // 
            this.Lab_TransformationWords.AutoSize = true;
            this.Lab_TransformationWords.Location = new System.Drawing.Point(3, 9);
            this.Lab_TransformationWords.Name = "Lab_TransformationWords";
            this.Lab_TransformationWords.Size = new System.Drawing.Size(68, 17);
            this.Lab_TransformationWords.TabIndex = 1;
            this.Lab_TransformationWords.Text = "转换文字：";
            // 
            // Cbx_TransformationEngine
            // 
            this.Cbx_TransformationEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_TransformationEngine.Enabled = false;
            this.Cbx_TransformationEngine.FormattingEnabled = true;
            this.Cbx_TransformationEngine.Items.AddRange(new object[] {
            "本地引擎",
            "科大讯飞",
            "百度",
            "阿里"});
            this.Cbx_TransformationEngine.Location = new System.Drawing.Point(66, 476);
            this.Cbx_TransformationEngine.Name = "Cbx_TransformationEngine";
            this.Cbx_TransformationEngine.Size = new System.Drawing.Size(112, 25);
            this.Cbx_TransformationEngine.TabIndex = 2;
            // 
            // Btn_Speak
            // 
            this.Btn_Speak.Location = new System.Drawing.Point(184, 472);
            this.Btn_Speak.Name = "Btn_Speak";
            this.Btn_Speak.Size = new System.Drawing.Size(70, 33);
            this.Btn_Speak.TabIndex = 3;
            this.Btn_Speak.Text = "点击播放";
            this.Btn_Speak.UseVisualStyleBackColor = true;
            this.Btn_Speak.Click += new System.EventHandler(this.Btn_Speak_Click);
            // 
            // Btn_SaveToLocal
            // 
            this.Btn_SaveToLocal.Location = new System.Drawing.Point(403, 472);
            this.Btn_SaveToLocal.Name = "Btn_SaveToLocal";
            this.Btn_SaveToLocal.Size = new System.Drawing.Size(70, 33);
            this.Btn_SaveToLocal.TabIndex = 4;
            this.Btn_SaveToLocal.Text = "保存";
            this.Btn_SaveToLocal.UseVisualStyleBackColor = true;
            this.Btn_SaveToLocal.Click += new System.EventHandler(this.Btn_SaveToLocal_Click);
            // 
            // Lab_TransformationEngine
            // 
            this.Lab_TransformationEngine.AutoSize = true;
            this.Lab_TransformationEngine.Location = new System.Drawing.Point(3, 480);
            this.Lab_TransformationEngine.Name = "Lab_TransformationEngine";
            this.Lab_TransformationEngine.Size = new System.Drawing.Size(68, 17);
            this.Lab_TransformationEngine.TabIndex = 5;
            this.Lab_TransformationEngine.Text = "转换引擎：";
            // 
            // Lab_SaveFormat
            // 
            this.Lab_SaveFormat.AutoSize = true;
            this.Lab_SaveFormat.Location = new System.Drawing.Point(274, 480);
            this.Lab_SaveFormat.Name = "Lab_SaveFormat";
            this.Lab_SaveFormat.Size = new System.Drawing.Size(44, 17);
            this.Lab_SaveFormat.TabIndex = 6;
            this.Lab_SaveFormat.Text = "格式：";
            // 
            // Cbx_SaveFormat
            // 
            this.Cbx_SaveFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_SaveFormat.Enabled = false;
            this.Cbx_SaveFormat.FormattingEnabled = true;
            this.Cbx_SaveFormat.Items.AddRange(new object[] {
            "WAV",
            "MP4"});
            this.Cbx_SaveFormat.Location = new System.Drawing.Point(315, 476);
            this.Cbx_SaveFormat.Name = "Cbx_SaveFormat";
            this.Cbx_SaveFormat.Size = new System.Drawing.Size(82, 25);
            this.Cbx_SaveFormat.TabIndex = 7;
            // 
            // Tkb_Volume
            // 
            this.Tkb_Volume.Location = new System.Drawing.Point(53, 421);
            this.Tkb_Volume.Maximum = 100;
            this.Tkb_Volume.Name = "Tkb_Volume";
            this.Tkb_Volume.Size = new System.Drawing.Size(201, 45);
            this.Tkb_Volume.TabIndex = 8;
            this.Tkb_Volume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Tkb_Volume.Value = 50;
            this.Tkb_Volume.Scroll += new System.EventHandler(this.Tkb_Volume_Scroll);
            // 
            // Tkb_Rate
            // 
            this.Tkb_Rate.Location = new System.Drawing.Point(315, 421);
            this.Tkb_Rate.Minimum = -10;
            this.Tkb_Rate.Name = "Tkb_Rate";
            this.Tkb_Rate.Size = new System.Drawing.Size(158, 45);
            this.Tkb_Rate.TabIndex = 8;
            this.Tkb_Rate.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Tkb_Rate.Scroll += new System.EventHandler(this.Tkb_Rate_Scroll);
            // 
            // Lab_Speed
            // 
            this.Lab_Speed.AutoSize = true;
            this.Lab_Speed.Location = new System.Drawing.Point(274, 422);
            this.Lab_Speed.Name = "Lab_Speed";
            this.Lab_Speed.Size = new System.Drawing.Size(44, 17);
            this.Lab_Speed.TabIndex = 9;
            this.Lab_Speed.Text = "语速：";
            // 
            // Lab_Volume
            // 
            this.Lab_Volume.AutoSize = true;
            this.Lab_Volume.Location = new System.Drawing.Point(3, 422);
            this.Lab_Volume.Name = "Lab_Volume";
            this.Lab_Volume.Size = new System.Drawing.Size(44, 17);
            this.Lab_Volume.TabIndex = 10;
            this.Lab_Volume.Text = "音量：";
            // 
            // Lab_VolumeValue
            // 
            this.Lab_VolumeValue.AutoSize = true;
            this.Lab_VolumeValue.Location = new System.Drawing.Point(3, 446);
            this.Lab_VolumeValue.Name = "Lab_VolumeValue";
            this.Lab_VolumeValue.Size = new System.Drawing.Size(33, 17);
            this.Lab_VolumeValue.TabIndex = 50;
            this.Lab_VolumeValue.Text = "50%";
            // 
            // Lab_SpeedValue
            // 
            this.Lab_SpeedValue.AutoSize = true;
            this.Lab_SpeedValue.Location = new System.Drawing.Point(274, 446);
            this.Lab_SpeedValue.Name = "Lab_SpeedValue";
            this.Lab_SpeedValue.Size = new System.Drawing.Size(15, 17);
            this.Lab_SpeedValue.TabIndex = 50;
            this.Lab_SpeedValue.Text = "0";
            // 
            // Sfd_Speech
            // 
            this.Sfd_Speech.DefaultExt = "wav";
            this.Sfd_Speech.Filter = "wav文件|*.wav";
            // 
            // UC_Tools_TTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lab_SpeedValue);
            this.Controls.Add(this.Lab_VolumeValue);
            this.Controls.Add(this.Lab_Volume);
            this.Controls.Add(this.Lab_Speed);
            this.Controls.Add(this.Tkb_Rate);
            this.Controls.Add(this.Tkb_Volume);
            this.Controls.Add(this.Cbx_SaveFormat);
            this.Controls.Add(this.Lab_SaveFormat);
            this.Controls.Add(this.Btn_SaveToLocal);
            this.Controls.Add(this.Btn_Speak);
            this.Controls.Add(this.Cbx_TransformationEngine);
            this.Controls.Add(this.Lab_TransformationWords);
            this.Controls.Add(this.Tbx_TransformationWords);
            this.Controls.Add(this.Lab_TransformationEngine);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(476, 507);
            this.MinimumSize = new System.Drawing.Size(476, 507);
            this.Name = "UC_Tools_TTS";
            this.Size = new System.Drawing.Size(476, 507);
            this.Load += new System.EventHandler(this.UC_Tools_TTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tkb_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tkb_Rate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbx_TransformationWords;
        private System.Windows.Forms.Label Lab_TransformationWords;
        private System.Windows.Forms.ComboBox Cbx_TransformationEngine;
        private System.Windows.Forms.Button Btn_Speak;
        private System.Windows.Forms.Button Btn_SaveToLocal;
        private System.Windows.Forms.Label Lab_TransformationEngine;
        private System.Windows.Forms.Label Lab_SaveFormat;
        private System.Windows.Forms.ComboBox Cbx_SaveFormat;
        private System.Windows.Forms.TrackBar Tkb_Volume;
        private System.Windows.Forms.TrackBar Tkb_Rate;
        private System.Windows.Forms.Label Lab_Speed;
        private System.Windows.Forms.Label Lab_Volume;
        private System.Windows.Forms.Label Lab_VolumeValue;
        private System.Windows.Forms.Label Lab_SpeedValue;
        private System.Windows.Forms.SaveFileDialog Sfd_Speech;
    }
}
