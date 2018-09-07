using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliyunDdns
{
    public partial class Form_Load : Form
    {
        public delegate void DdnsTextEventHandler(string log);
        public event DdnsTextEventHandler ShowIp;

        public Form_Load()
        {
            InitializeComponent();
        }

        private void Form_Load_Shown(object sender, EventArgs e)
        {
            string ip = "";
            try
            {
                ip = ExtenalIp.Value;
            }
            catch { }
            ShowIp?.Invoke(ip);
            this.Close();
        }
    }
}
