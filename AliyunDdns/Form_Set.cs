﻿using CCWin;
using Microsoft.Win32;
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
    public partial class Form_Set : CCSkinMain
    {
        private string path = Application.ExecutablePath;

        public Form_Set()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_accessKeyId.Text))
            {
                MessageBox.Show("请输入你的AccessKeyId！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(tb_accessKeySecret.Text))
            {
                MessageBox.Show("请输入你的AccessKeySecret！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //设置开机启动
            RunWhenStart(ckb_startWithSystem.Checked, "Geeiot AliyunDdns Tools", path);
            Config.StartWithSystem = ckb_startWithSystem.Checked;

            Config.AccessKeyId = tb_accessKeyId.Text;
            Config.AccessKeySecret = tb_accessKeySecret.Text;
            Config.StartDdhsWithProgram = ckb_autoStartDdns.Checked;
            if (Config.SaveConfig())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("设置保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_Set_Load(object sender, EventArgs e)
        {
            tb_accessKeyId.Text = Config.AccessKeyId;
            tb_accessKeySecret.Text = Config.AccessKeySecret;
            ckb_startWithSystem.Checked = Config.StartWithSystem;
            ckb_autoStartDdns.Checked = Config.StartDdhsWithProgram;
        }

        private void ckb_startWithSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_startWithSystem.Checked)
            {
                ckb_autoStartDdns.Checked = true;
            }
        }

        /// <summary> 
        /// 开机启动项 
        /// </summary> 
        /// <param name=\"Started\">是否启动</param> 
        /// <param name=\"name\">启动值的名称</param> 
        /// <param name=\"path\">启动程序的路径，推荐Application.ExecutablePath</param> 
        private static void RunWhenStart(bool Started, string name, string path)
        {
            try
            {
                RegistryKey HKLM = Registry.LocalMachine;
                RegistryKey Run = HKLM.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\");
                if (Started == true)
                {
                    try
                    {
                        Run.SetValue(name, path);
                        HKLM.Close();
                    }
                    catch (Exception Err)
                    {
                        MessageBox.Show(Err.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        Run.DeleteValue(name);
                        HKLM.Close();
                    }
                    catch (Exception)
                    {
                        // 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误:" + ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
