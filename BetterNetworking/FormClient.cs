using BetterNetworking.Properties;
using IPAddressControlLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterNetworking
{
    public partial class FormClient : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")] //导入user32.dll函数库
        public static extern bool GetCursorPos(out System.Drawing.Point lpPoint);//获取鼠标坐标
        private bool flgMouseDown = false;
        private Point mouseDownLocation;
        private Point currentMouseLocation;
        private Point previousLocation;
        private Point currentLocation = new Point();
        private Form1 parrent;
        public System.Diagnostics.Process p;
        public System.Diagnostics.ProcessStartInfo psi;
        private string strClient;
        public FormClient()
        {
            InitializeComponent();
        }

        public FormClient(Form1 f)
        {
            this.parrent = f;
            InitializeComponent();
            this.Location = parrent.Location;
            this.updateLanguage();
            this.Update();
        }

        public void ShowForm()
        {
            this.Location = parrent.Location;
            this.updateLanguage();
            this.Update();
            this.Show();
        }

        private void updateLanguage()
        {
            bool flg = Settings.Default.IsEnglish;
            labelBandwidth.Text = flg ? "Player Bandwidth" : "玩家带宽";
            labelBandwidthIn.Text = flg ? "In/Download" : "下行/下载";
            labelBandwidthOut.Text = flg ? "Out/Upload" : "上行/上传";
            buttonGenerate.Text = flg ? "Generate and Run" : "生成并运行";
            buttonTest.Text = flg ? "Test Connection" : "测试连接";
            labelInfo.Text = flg ? "1. Contact server host so that he can generate Configure Profile for you. \n2. Once you get the Configure Profile, paste them into the box on the left. DO NOT modify them. \n3. Fill in your network bandwidth. If you dont know, ask your ISP.\r\n4.Click \"Generate and Run\", and wish it will work.\n\nRun PZ Game, fill in server info:\nServer IP:       127.0.0.1\nServer Port is specified by \"listen_port=*****\" line on the left (Default is 16999)\nJoin and Enjoy!\n\nNote for players: You MUST RUN this program,  and click \"Generate and Run\" button, wait for the black CMD window to pop out. Then you can run your game. IF the CMD window won't pop out, there is something wrong with the Configure Profile." : "1. 联系服主，让他给你生成配置模板，发给你。\n2.拿到配置模板后，粘贴到左边文本框里面，不要乱改。\n3.填入你的网络带宽，不知道的话打电话问宽带运行商，谁那里办的宽带就问谁。如果实在问不到，估摸着下行填100M，上传填10M。\n4.点击\"生成并运行\"，能不能成功建立隧道就交给运气吧。\n\n运行游戏，在连接服务器页面填入以下信息：\n服务器IP地址：    127.0.0.1\n服务器端口号就是左边\"listen_port=*****\"那一行里的数字（默认是16999）。\n\n填入其他信息，例如服务器密码等等，应该能连接上了。\n\n玩家需要注意：必须先运行本程序并点击\"生成并运行\"按钮，看到弹出的黑色窗口之后，才能运行游戏，不然连接不成功。游戏过程中，不能关闭本程序和黑色窗口。如果一直不弹出黑色窗口，那大概率是配置模板有错误";
            nudBandwidthIn.Value = Settings.Default.intClientBandWidthIn;
            nudBandwidthOut.Value = Settings.Default.intClientBandWidthOut;
            comboBandwidthInUnit.SelectedIndex = Settings.Default.intClientBandWidthInUnit;
            comboBandwidthOutUnit.SelectedIndex = Settings.Default.intClientBandWidthOutUnit;
            richTextBox1.Text = Settings.Default.strConfClient;

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

        private void button1_Click(object sender, EventArgs e)
        {
            parrent.Location = this.Location;
            parrent.Show();
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.parrent.ExitProgram();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            strClient = richTextBox1.Text + "\r\ninbound_bandwidth=" + Settings.Default.intServerBandWidthIn.ToString() + comboBandwidthInUnit.Text + "\r\noutbound_bandwidth=" + Settings.Default.intServerBandWidthOut.ToString() + comboBandwidthOutUnit.Text; ;
            Directory.CreateDirectory(Application.StartupPath + "\\kcptube");
            string confClientPathName = Application.StartupPath + "\\kcptube\\client.conf";
            File.WriteAllText(confClientPathName, strClient);
            string exePathName = Application.StartupPath + "\\kcptube\\kcptube.exe";
            if (!File.Exists(exePathName))
            {
                MessageBox.Show(Settings.Default.IsEnglish ? "Could not find EXE file:\n\n" + exePathName + "\n\nPlease put kcptube.exe there." : "找不到程序文件:\n\n" + exePathName + "\n\n请把kcptube.exe放到对应位置。");
                return;
            }

            psi = new System.Diagnostics.ProcessStartInfo(exePathName, confClientPathName);
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

        private void comboBandwidthInUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.intClientBandWidthInUnit = comboBandwidthInUnit.SelectedIndex;
            Settings.Default.Save();
            this.updateLanguage();
        }

        private void comboBandwidthOutUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.intClientBandWidthOutUnit = comboBandwidthOutUnit.SelectedIndex;
            Settings.Default.Save();
            this.updateLanguage();
        }

        private void nudBandwidthIn_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.intClientBandWidthIn = (int)nudBandwidthIn.Value;
            Settings.Default.Save();
            this.updateLanguage();
        }

        private void nudBandwidthOut_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.intClientBandWidthOut = (int)nudBandwidthOut.Value;
            Settings.Default.Save();
            this.updateLanguage();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            strClient = richTextBox1.Text + "\r\ninbound_bandwidth=" + Settings.Default.intServerBandWidthIn.ToString() + comboBandwidthInUnit.Text + "\r\noutbound_bandwidth=" + Settings.Default.intServerBandWidthOut.ToString() + comboBandwidthOutUnit.Text; ;
            Directory.CreateDirectory(Application.StartupPath + "\\kcptube");
            string confClientPathName = Application.StartupPath + "\\kcptube\\client.conf";
            File.WriteAllText(confClientPathName, strClient);

            Settings.Default.strConfClient = richTextBox1.Text;
            Settings.Default.Save();

            string exePathName = Application.StartupPath + "\\kcptube\\kcptube.exe";
            string testPathName = Application.StartupPath + "\\kcptube\\test.bat";
            string strTestContent = "\"" + exePathName + "\" \"" +  confClientPathName + "\" --try\r\npause";
            File.WriteAllText(testPathName, strTestContent);
            if (!File.Exists(exePathName))
            {
                MessageBox.Show(Settings.Default.IsEnglish ? "Could not find EXE file:\n\n" + exePathName + "\n\nPlease put kcptube.exe there." : "找不到程序文件:\n\n" + exePathName + "\n\n请把kcptube.exe放到对应位置。");
                return;
            }

            psi = new System.Diagnostics.ProcessStartInfo(testPathName);
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

            //Error Found in Configuration File(s)
            //Failure: NONE
            MessageBox.Show(Settings.Default.IsEnglish ? "Please first CHECK the line:\r\n\tError Found in Configuration File(s):...\r\n\r\nIf it says something other than \"No\", go and check for errors as described by this line, or ask server host to help.\r\nIf  it says \"No\", proceed to CHECK these two lines:\r\n\tSuccess:...\r\n\tFailure:...\r\n\r\nIf \"Success\" is \"NONE\", it means connection failed. This is probably caused by your/Server's NAT type. Maybe you can find someone to help.\r\nIf \"Failure\" is \"NONE\", congratulations!" : "请先检查下面这一行行：\r\n\tError Found in Configuration File(s):...\r\n\r\n如果这一行不是“No”而是现实了具体的内容，说明配置文件有语法错误，请按提示检查你输入的内容，或找服主帮忙检查。\r\n如果这一行是“No”，请继续检查接下来这两行：\r\n\tSuccess:...\r\n\tFailure:...\r\n\r\n如果“Success”是“None”， 这意味着连接失败。这可能是因为你/服务器的 NAT 类型引起的，也可能是服务器忘了做端口映射之类的，网络是一个很复杂的东西，说不好具体是哪里出问题了。也许你可以找懂得配置网络的人帮忙解决。如果你很倒霉，是你的运营商那边对NAT类型做了限制，那基本没办法解决了（在校园网开服特别常见）。\r\n如果“Failure”是“None”，那么恭喜你，连接成功，接下来直接去点击那个运行按钮就好！");

        }

    }
}
