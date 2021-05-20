using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWORLD开发助手.ToolsOwn
{
    public partial class UC_Tools_TTS : UserControl
    {
        public UC_Tools_TTS()
        {
            InitializeComponent();
        }
        // 播放线程
        Thread Thread_Speak;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_Tools_TTS_Load(object sender, EventArgs e)
        {
            // 控件选项初始化
            Cbx_TransformationEngine.SelectedIndex = 0;
            Cbx_SaveFormat.SelectedIndex = 0;

            // 语音引擎初始化
            synthesizer.Rate = 0;
            synthesizer.Volume = 50;
            // 播放绑定
            synthesizer.SpeakCompleted += SpeakByLocalEngine_Completed;
            // 保存绑定
            synthesizer_save.SpeakCompleted += SpeakByLocalEngine_SaveCompleted;
        }

        /// <summary>
        /// 点击播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Speak_Click(object sender, EventArgs e)
        {
            if (Btn_Speak.Text == "点击播放"&&(Thread_Speak==null||!Thread_Speak.IsAlive))
            {
                Btn_Speak.Text = "点击停止";
                Cbx_TransformationEngine.Enabled = false;
                Thread_Speak = new Thread(Func_Thread_Speak);
                Thread_Speak.Start(new string[] { this.Tbx_TransformationWords.Text, Cbx_TransformationEngine.SelectedIndex.ToString() });

            }
            else if(Btn_Speak.Text == "点击停止")
            {
                // 取消所有异步播放
                synthesizer.SpeakAsyncCancelAll();
                Thread_Speak.Abort();
                Thread_Speak.Join();
                Thread_Speak = null;
                Btn_Speak.Text = "点击停止";
                Cbx_TransformationEngine.Enabled = false;
            }
        }
        

        /// <summary>
        /// 播放线程
        /// </summary>
        /// <param name="vals"></param>
        private void Func_Thread_Speak(object vals)
        {
            string[] strs = vals as string[];
            try
            {
                switch (strs[1])
                {
                    case "0":// 本地引擎
                        SpeakByLocalEngine(strs[0]);
                        break;
                    case "1":// 科大讯飞
                        break;
                    case "2":// 百度
                        break;
                    case "3":// 阿里
                        break;
                }
            }
            catch(Exception ex)
            {
                this.Invoke(new Action(()=> {
                    MessageBox.Show("错误信息："+ex,"提示");
                }));
            }
        }

        #region 本地引擎
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        SpeechSynthesizer synthesizer_save = new SpeechSynthesizer();
        /// <summary>
        ///  本地引擎播放
        /// </summary>
        /// <param name="val"></param>
        private void SpeakByLocalEngine(string val)
        {
            // 取消所有异步播放
            synthesizer.SpeakAsyncCancelAll();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.SpeakAsync(val);
        }
        /// <summary>
        /// 播放完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpeakByLocalEngine_Completed(object sender, SpeakCompletedEventArgs e)
        {
            this.Invoke(new Action(() => {
                Btn_Speak.Text = "点击播放";
                Cbx_TransformationEngine.Enabled = true;
            }));
        }
        #endregion
        

        /// <summary>
        /// 设置音量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tkb_Volume_Scroll(object sender, EventArgs e)
        {
            synthesizer.Volume = Tkb_Volume.Value;
            Lab_VolumeValue.Text = $"{Tkb_Volume.Value}%";
        }
        /// <summary>
        /// 设置语速
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tkb_Rate_Scroll(object sender, EventArgs e)
        {
            Lab_SpeedValue.Text = $"{Tkb_Rate.Value}";
            synthesizer.Rate = Tkb_Rate.Value;
        }        
        
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SaveToLocal_Click(object sender, EventArgs e)
        {
            // 默认存放桌面
            Sfd_Speech.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Sfd_Speech.FileName = DateTime.Now.ToString("yyyyMMddhhmmss语音.wav");
            if (Sfd_Speech.ShowDialog() == DialogResult.OK)
            {
                // 取消正在播放
                synthesizer_save.SpeakAsyncCancelAll();
                synthesizer_save.Volume = Tkb_Volume.Value;
                synthesizer_save.Rate = Tkb_Rate.Value;
                synthesizer_save.SetOutputToWaveFile(Sfd_Speech.FileName);
                synthesizer_save.SpeakAsync(Tbx_TransformationWords.Text);
            }
        }

        /// <summary>
        /// 播放完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpeakByLocalEngine_SaveCompleted(object sender, SpeakCompletedEventArgs e)
        {
            this.Invoke(new Action(() => {
                MessageBox.Show("保存成功！","提示");
            }));
            synthesizer_save.SetOutputToNull();
        }
    }
}
