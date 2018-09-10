using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliyunDdns
{
    public partial class Form_Load : Form
    {
        public delegate void DdnsTextEventHandler(string log);
        public event DdnsTextEventHandler ShowIp;

        Thread getIp = null;

        public Form_Load()
        {
            InitializeComponent();
        }

        private void Form_Load_Shown(object sender, EventArgs e)
        {
            getIp = new Thread(new ThreadStart(GetExIp));
            getIp.Start();
        }

        private void Form_Load_Load(object sender, EventArgs e)
        {

        }

        private void GetExIp()
        {
            string ip = "";
            try
            {
                ip = ExtenalIp.Value;
            }
            catch { }
            ShowIp?.Invoke(ip);
            
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    this.Close();
                }));
            }
            else
            {
                this.Close();
            }
        }
    }
}
