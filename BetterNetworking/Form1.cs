using BetterNetworking.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BetterNetworking
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")] //导入user32.dll函数库
        public static extern bool GetCursorPos(out System.Drawing.Point lpPoint);//获取鼠标坐标
        private bool flgMouseDown = false;
        private Point mouseDownLocation;
        private Point currentMouseLocation;
        private Point previousLocation;
        private Point currentLocation = new Point();

        private FormServer fserver = null;
        private FormClient fclient = null; 
        public Form1()
        {
            InitializeComponent();
            updateLanguage();
            fserver = new FormServer(this);
            fclient = new FormClient(this); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void updateLanguage()
        {
            this.buttonClient.Text = Settings.Default.IsEnglish ? "I am player" : "我是玩家";
            this.buttonServer.Text = Settings.Default.IsEnglish ? "I am server host" : "我是服主";
            this.buttonLanguage.Text = Settings.Default.IsEnglish ? "切换中文" : "Switch to English";
            this.Update();
        }
        private void buttonLanguage_Click(object sender, EventArgs e)
        {
            Settings.Default.IsEnglish = !Settings.Default.IsEnglish;
            Settings.Default.Save();
            updateLanguage();
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            fserver.Location = this.Location;
            fserver.ShowForm();
            this.Hide();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            fclient.Location = this.Location;
            fclient.ShowForm();
            this.Hide();
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

        public void ExitProgram()
        {
            buttonClose_Click(new object(), new EventArgs());
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (this.fserver.p != null)
            {
                try
                {
                    this.fserver.p.Kill();
                }
                catch { }
            }
            if (this.fclient.p != null)
            {
                try
                {
                    this.fclient.p.Kill();
                }
                catch { }
            }
            Application.Exit();
        }
    }
}
