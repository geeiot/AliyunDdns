using CCWin;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace AliyunDdns
{
    public partial class Form_Main : CCSkinMain
    {

        private DateTime StartTime { get; set; }

        private List<string> CombValue = new List<string>()
        {
            "3","5","10","15","20","30","60","120"
        };

        private Ddns ddns { get; set; }

        public Form_Main()
        {
            InitializeComponent();
        }

        #region Form load and close
        private void Form_Main_Load(object sender, EventArgs e)
        {
            StartTime = DateTime.Now;
            
            //读取配置文件
            if (!Config.ReadConfig())
            {
                if (DialogResult.OK == MessageBox.Show("读取配置文件失败！是否初始化配置文件？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error))
                {
                    Config.SaveConfig();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            //实例化类
            ddns = new Ddns(Config.AccessKeyId, Config.AccessKeySecret);
            ddns.WriteLog += ShowLog;
            ddns.ShowIp += ShowIp;
            //
            comb_time.DataSource = CombValue;
            if (CombValue.Contains(Config.SpanTime.ToString()))
            {
                int index = CombValue.IndexOf(Config.SpanTime.ToString());
                comb_time.SelectedIndex = index;
            }
            else
            {
                comb_time.SelectedIndex = 0;
            }
            tb_domain.Text = Config.Domain;
            //启动计时线程
            StartBackgroundServices();

            //显示日志
            ShowLog("程序已启动！");
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.Domain = tb_domain.Text;
            Config.SpanTime = int.Parse(comb_time.Text);
            Config.SaveConfig();
        }
        #endregion

        #region 运行时间线程

        private void StartBackgroundServices()
        {
            Thread runningTime = new Thread(new ThreadStart(SetRunningTime));
            runningTime.IsBackground = true;
            runningTime.Start();
        }

        private void SetRunningTime()
        {
            while (true)
            {
                Thread.Sleep(1000);
                DateTime endTime = DateTime.Now;              //获取结束时间  
                TimeSpan oTime = endTime.Subtract(StartTime); //求时间差的函数  
                string showTxt = $"{oTime.Hours}小时{oTime.Minutes}分{oTime.Seconds}秒";

                if (lab_runningTime.InvokeRequired)
                {
                    lab_runningTime.Invoke(new Action(()=>
                    {
                        lab_runningTime.Text = showTxt;
                    }));
                }
                else
                {
                    lab_runningTime.Text = showTxt;
                }
            }
        }

        #endregion

        #region Log显示
        private void ShowLog(string log)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]");
            sb.Append(log);
            if (tb_log.InvokeRequired)
            {
                lab_runningTime.Invoke(new Action(()=> {
                    tb_log.Text += sb.ToString() + "\r\n";
                }));
            }
            else
            {
                tb_log.Text += sb.ToString() + "\r\n";
            }
        }

        #endregion

        #region 界面逻辑
        private void btn_start_Click(object sender, EventArgs e)
        {
            if(ddns == null)
            {
                ddns = new Ddns(Config.AccessKeyId, Config.AccessKeySecret);
            }
            if(btn_start.Text == "Start")
            {
                if(tb_domain.Text.Split('.').Length <= 2)
                {
                    MessageBox.Show("域名格式错误，应该输入以下的域名格式：www.geeiot.net/@.geeiot.net！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!CheckIP(tb_ip.Text))
                {
                    MessageBox.Show("IP格式错误，请重新获取IP！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(!ddns.StartDdns(tb_domain.Text, tb_ip.Text))
                {
                    MessageBox.Show("启动解析失败，请重试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tb_domain.Enabled = false;
                comb_time.Enabled = false;
                btn_start.Text = "Stop";
            }
            else if(btn_start.Text == "Stop")
            {
                if (!ddns.StopDns())
                {
                    MessageBox.Show("停止解析失败，请重试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    tb_domain.Enabled = true;
                    comb_time.Enabled = true;
                    btn_start.Text = "Start";
                }
            }
        }

        private bool CheckIP(string ip)
        {
            Regex r = new Regex(@"(?:(?:(?:25[0-5]|2[0-4]\d|(?:(?:1\d{2})|(?:[1-9]?\d)))\.){3}(?:25[0-5]|2[0-4]\d|(?:(?:1\d{2})|(?:[1-9]?\d))))");
            Match m = r.Match(ip);
            if (m.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ShowIp(string ip)
        {
            if (tb_ip.InvokeRequired)
            {
                lab_runningTime.Invoke(new Action(() => {
                    tb_ip.Text = ip;
                }));
            }
            else
            {
                tb_ip.Text = ip;
            }
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btn_start.Text == "Stop")
            {
                MessageBox.Show("请先停止解析才能进行配置！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Form_Set set = new Form_Set();
                set.ShowDialog();
            }
        }

        /// <summary>
        /// 日志的展示和收起
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_showLog_Click(object sender, EventArgs e)
        {
            if (tb_log.Visible)
            {
                btn_showLog.Text = "展开日志↓↓";
                tb_log.Visible = false;
                this.Height = 365;
            }
            else
            {
                btn_showLog.Text = "收起日志↑↑";
                tb_log.Visible = true;
                this.Height = 640;
            }
        }

        #endregion

        private void Form_Main_Shown(object sender, EventArgs e)
        {
            Form_Load load = new Form_Load();
            load.ShowIp += ShowIp;
            load.ShowDialog();
            if (string.IsNullOrEmpty(tb_ip.Text))
            {
                ShowLog($"获取本机外网IP失败，请检查网络设置！");
            }
            else
            {
                btn_start_Click(null, null);
            }
        }
    }
}
