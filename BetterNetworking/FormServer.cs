using BetterNetworking.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterNetworking
{
    public partial class FormServer : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")] //导入user32.dll函数库
        public static extern bool GetCursorPos(out System.Drawing.Point lpPoint);//获取鼠标坐标
        private bool flgMouseDown = false;
        private Point mouseDownLocation;
        private Point currentMouseLocation;
        private Point previousLocation;
        private Point currentLocation = new Point();
        private Form1 parrent;
        private string strServer;
        private string strClient;
        public System.Diagnostics.Process p;
        public System.Diagnostics.ProcessStartInfo psi;
        public FormServer()
        {
            InitializeComponent();
        }
        public FormServer(Form1 f)
        {
            this.parrent = f;
            InitializeComponent();
            this.Location = parrent.Location;
            this.updateLanguage();
            this.Update();
        }

        public void ShowForm()
        {
            this.updateLanguage();
            this.Update();
            this.Show();
        }

        private void updateLanguage()
        {
            var flg = Settings.Default.IsEnglish;
            labelIP.Text = flg ? "PZ Server Public IP" : "PZ服务器公网IP";
            labelPZPort.Text = flg ? "PZ Server Port" : "PZ服务器监听端口";
            labelKCPPort.Text = flg ? "KCP Port" : "KCP监听端口";
            buttonTestIP.Text = flg ? "Test IP" : "自动检测";
            labelStun.Text = flg ? "UDP Stun Server" : "UDP穿透服务器";
            buttonCopy.Text = flg ? "Copy Configure" : "复制配置";
            labelBandwidth.Text = flg ? "Server Bandwidth" : "服务器带宽";
            labelBandwidthIn.Text = flg ? "In/Download" : "下行/下载";
            labelBandwidthOut.Text = flg ? "Out/Upload" : "上行/上传";
            buttonGenerate.Text = flg ? "Generate and Run" : "生成并运行";
            labelInfo.Text = flg ? "1. If you know nothing about networking, do NOT touch them, just click \"Test IP\" and then click \"Generate and Run\". And wish it will work. \n2. The two port numbers should be DIFFERENT from each other. \n3. If you don't know what Stun is, just choose one EXCEPT \"None\"" : "1. 如果你是网络小白，先点\"自动检测\"，然后点\"生成并运行\"。之后就交给运气吧。\n2.如果你要自己配置端口，注意两个端口不能相同。\n3.如果你不懂Stun是什么玩意，随便选一个，别选\"不使用\"就好。";
            labelConfInfo.Text = flg ? "Please COPY all the texts on the left and send them to players (who wants to use KCP Tube to connect to your server).\r\nA player has to subscribe this mod and run this program for easy configuring. Or he needs to learn manual configuring.\r\n A palyer needs paste these lines into the program and generate their configure files.\r\nThis is only a helper for beginners. You are encouraged to try advanced options and fine tune KCP Tube.\nNote for server hosts: You MUST RUN this program,  and click \"Generate and Run\" button, wait for the black CMD window to pop out. Then you can run your PZ Server. IF the CMD window won't pop out, there is something wrong with the Configure Profile." : "复制左边的代码，发送给玩家。\n玩家同样需要订阅本模组并运行这个软件才能快速配置，不然就自学手动配置流程。\n这就是个为新手小白准备的简易配置工具，很多配置都简化了，如果想要深度优化网络表现，需要自己去手工配置。\n\n服主需要注意：必须先运行本程序，切换到服主页面，并点击\"生成并运行\"按钮，看到弹出的黑色窗口之后，才能运行PZ服务器。PZ服务器必须和本软件在同一台电脑上运行，不然连接不成功。服务器运行过程中，不能关闭本程序和黑色窗口。如果一直不弹出黑色窗口，那大概率是你填的信息有问题";
            ipAddressControl1.Text = Settings.Default.strIPAddress;
            nudPZPort.Value = Settings.Default.intPZPort;
            nudKCPPort.Value = Settings.Default.intKCPPort;
            comboStun.SelectedIndex = Settings.Default.intStun;
            nudBandwidthIn.Value = Settings.Default.intServerBandWidthIn;
            nudBandwidthOut.Value = Settings.Default.intServerBandWidthOut;
            comboBandwidthInUnit.SelectedIndex = Settings.Default.intServerBandWidthInUnit;
            comboBandwidthOutUnit.SelectedIndex = Settings.Default.intServerBandWidthOutUnit;
        }

        private void tableLayoutPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            flgMouseDown = true;
            GetCursorPos(out mouseDownLocation);
            previousLocation = this.Location;
        }

        private void tableLayoutPanel2_MouseUp(object sender, MouseEventArgs e)
        {
            flgMouseDown = false;
        }

        private void tableLayoutPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (flgMouseDown)
            {
                GetCursorPos(out currentMouseLocation);
                currentLocation.X = previousLocation.X + currentMouseLocation.X - mouseDownLocation.X;
                currentLocation.Y = previousLocation.Y + currentMouseLocation.Y - mouseDownLocation.Y;
                this.Location = currentLocation;
                this.Update();
            }
            else
            {
                return;
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            parrent.Location = this.Location;
            parrent.Show();
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.parrent.ExitProgram();
        }

        private void buttonTestIP_Click(object sender, EventArgs e)
        {
            Encoding encode = System.Text.Encoding.GetEncoding("gb2312");
            WebClient MyWebClient = new WebClient();
            MyWebClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.84 Safari/537.36");
            MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
            try
            {
                Byte[] pageData = MyWebClient.DownloadData("http://202.38.64.10/cgi-bin/myip");
                string pageHtml = encode.GetString(pageData);
                Match m = Regex.Match(pageHtml, @"\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}");
                if (m.Success)
                {
                    Settings.Default.strIPAddress = m.Value;
                    Settings.Default.Save();
                    this.updateLanguage();
                }
                else
                {
                    MessageBox.Show(Settings.Default.IsEnglish ? "Error getting IP address!\nYou need to manually input the IP address." : "获取IP地址失败，请手动输入。");
                }
                return;
            }
            catch
            {
                MessageBox.Show(Settings.Default.IsEnglish ? "Error getting IP address!\nYou need to manually input the IP address." : "获取IP地址失败，请手动输入。");
            }
            return;
        }

        private void ipAddressControl1_Validated(object sender, EventArgs e)
        {
            Settings.Default.strIPAddress = ipAddressControl1.Text;
            Settings.Default.Save();
            this.updateLanguage();
        }

        private void nudPZPort_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.intPZPort = (int)nudPZPort.Value;
            Settings.Default.Save();
            this.updateLanguage();
        }

        private void nudKCPPort_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.intKCPPort = (int)nudKCPPort.Value;
            Settings.Default.Save();
            this.updateLanguage();
        }

        private void comboStun_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.intStun = comboStun.SelectedIndex;
            Settings.Default.Save();
            this.updateLanguage();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            strServer = "mode=server\r\nkcp=fast2\r\nlisten_port=" + Settings.Default.intKCPPort.ToString() + "\r\ndestination_port=" + Settings.Default.intPZPort.ToString() + "\r\ndestination_address=127.0.0.1\r\nencryption_algorithm=none\r\nipv4_only=true\r\nblast=1\r\nfec=1:1\r\ninbound_bandwidth=" + Settings.Default.intServerBandWidthIn.ToString() + comboBandwidthInUnit.Text + "\r\noutbound_bandwidth=" + Settings.Default.intServerBandWidthOut.ToString() + comboBandwidthOutUnit.Text;
            strClient = "mode=client\r\nkcp=fast2\r\nlisten_port=16999\r\ndestination_port=" + Settings.Default.intKCPPort.ToString() + "\r\ndestination_address=" + Settings.Default.strIPAddress + "\r\nencryption_algorithm=none\r\nipv4_only=true\r\nblast=1\r\nfec=1:1";
            if (comboStun.SelectedIndex != 0)
            {
                strServer += "\r\nstun_server=" + comboStun.SelectedItem.ToString();
                strClient += "\r\nstun_server=" + comboStun.SelectedItem.ToString();
            }
            richTextBox1.Text = strClient;
            Directory.CreateDirectory(Application.StartupPath + "\\kcptube");
            string confServerPathName = Application.StartupPath + "\\kcptube\\server.conf";
            string confClientPathName = Application.StartupPath + "\\kcptube\\client.conf";
            File.WriteAllText(confServerPathName, strServer);
            //File.WriteAllText(confClientPathName, strClient);
            string exePathName = Application.StartupPath + "\\kcptube\\kcptube.exe";
            if (!File.Exists(exePathName))
            {
                MessageBox.Show(Settings.Default.IsEnglish ? "Could not find EXE file:\n\n" + exePathName + "\n\nPlease put kcptube.exe there." : "找不到程序文件:\n\n" + exePathName + "\n\n请把kcptube.exe放到对应位置。");
                return;
            }

            psi = new System.Diagnostics.ProcessStartInfo(exePathName, confServerPathName);
            if (p == null)
            {
                p = new System.Diagnostics.Process();
            }
            else
            {
                if (!p.HasExited)
                {
                    p.Kill();
                }
            }
            p.StartInfo = psi;
            p.Start();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void comboBandwidthInUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.intServerBandWidthInUnit = comboBandwidthInUnit.SelectedIndex;
            Settings.Default.Save();
            this.updateLanguage();
        }

        private void comboBandwidthOutUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.intServerBandWidthOutUnit = comboBandwidthOutUnit.SelectedIndex;
            Settings.Default.Save();
            this.updateLanguage();
        }

        private void nudBandwidthIn_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.intServerBandWidthIn = (int)nudBandwidthIn.Value;
            Settings.Default.Save();
            this.updateLanguage();
        }

        private void nudBandwidthOut_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.intServerBandWidthOut = (int)nudBandwidthOut.Value;
            Settings.Default.Save();
            this.updateLanguage();
        }
    }
}
