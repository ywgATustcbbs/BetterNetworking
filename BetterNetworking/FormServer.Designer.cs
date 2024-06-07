namespace BetterNetworking
{
    partial class FormServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServer));
            this.panelTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelPZPort = new System.Windows.Forms.Label();
            this.labelKCPPort = new System.Windows.Forms.Label();
            this.labelStun = new System.Windows.Forms.Label();
            this.ipAddressControl1 = new IPAddressControlLib.IPAddressControl();
            this.buttonTestIP = new System.Windows.Forms.Button();
            this.nudPZPort = new System.Windows.Forms.NumericUpDown();
            this.nudKCPPort = new System.Windows.Forms.NumericUpDown();
            this.comboStun = new System.Windows.Forms.ComboBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.labelBandwidth = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBandwidthInUnit = new System.Windows.Forms.ComboBox();
            this.comboBandwidthOutUnit = new System.Windows.Forms.ComboBox();
            this.nudBandwidthIn = new System.Windows.Forms.NumericUpDown();
            this.nudBandwidthOut = new System.Windows.Forms.NumericUpDown();
            this.labelBandwidthIn = new System.Windows.Forms.Label();
            this.labelBandwidthOut = new System.Windows.Forms.Label();
            this.labelConfInfo = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPZPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKCPPort)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBandwidthIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBandwidthOut)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.panelTop, "panelTop");
            this.panelTop.Name = "panelTop";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonClose, 5, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseDown);
            this.tableLayoutPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseMove);
            this.tableLayoutPanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseUp);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackgroundImage = global::BetterNetworking.Properties.Resources.back;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // buttonClose
            // 
            resources.ApplyResources(this.buttonClose, "buttonClose");
            this.buttonClose.BackgroundImage = global::BetterNetworking.Properties.Resources.close;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.labelIP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPZPort, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelKCPPort, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelStun, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.ipAddressControl1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonTestIP, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudPZPort, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.nudKCPPort, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboStun, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelInfo, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonGenerate, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.buttonCopy, 4, 15);
            this.tableLayoutPanel1.Controls.Add(this.labelBandwidth, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelConfInfo, 4, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // labelIP
            // 
            resources.ApplyResources(this.labelIP, "labelIP");
            this.labelIP.Name = "labelIP";
            // 
            // labelPZPort
            // 
            resources.ApplyResources(this.labelPZPort, "labelPZPort");
            this.labelPZPort.Name = "labelPZPort";
            // 
            // labelKCPPort
            // 
            resources.ApplyResources(this.labelKCPPort, "labelKCPPort");
            this.labelKCPPort.Name = "labelKCPPort";
            // 
            // labelStun
            // 
            resources.ApplyResources(this.labelStun, "labelStun");
            this.labelStun.Name = "labelStun";
            // 
            // ipAddressControl1
            // 
            this.ipAddressControl1.AllowInternalTab = false;
            this.ipAddressControl1.AutoHeight = true;
            this.ipAddressControl1.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.ipAddressControl1, 2);
            this.ipAddressControl1.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.ipAddressControl1, "ipAddressControl1");
            this.ipAddressControl1.Name = "ipAddressControl1";
            this.ipAddressControl1.ReadOnly = false;
            this.ipAddressControl1.Validated += new System.EventHandler(this.ipAddressControl1_Validated);
            // 
            // buttonTestIP
            // 
            resources.ApplyResources(this.buttonTestIP, "buttonTestIP");
            this.buttonTestIP.Name = "buttonTestIP";
            this.buttonTestIP.UseVisualStyleBackColor = true;
            this.buttonTestIP.Click += new System.EventHandler(this.buttonTestIP_Click);
            // 
            // nudPZPort
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.nudPZPort, 4);
            resources.ApplyResources(this.nudPZPort, "nudPZPort");
            this.nudPZPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPZPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPZPort.Name = "nudPZPort";
            this.nudPZPort.Value = new decimal(new int[] {
            16261,
            0,
            0,
            0});
            this.nudPZPort.ValueChanged += new System.EventHandler(this.nudPZPort_ValueChanged);
            // 
            // nudKCPPort
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.nudKCPPort, 4);
            resources.ApplyResources(this.nudKCPPort, "nudKCPPort");
            this.nudKCPPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudKCPPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKCPPort.Name = "nudKCPPort";
            this.nudKCPPort.Value = new decimal(new int[] {
            16666,
            0,
            0,
            0});
            this.nudKCPPort.ValueChanged += new System.EventHandler(this.nudKCPPort_ValueChanged);
            // 
            // comboStun
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.comboStun, 4);
            this.comboStun.DisplayMember = "0";
            resources.ApplyResources(this.comboStun, "comboStun");
            this.comboStun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStun.FormattingEnabled = true;
            this.comboStun.Items.AddRange(new object[] {
            resources.GetString("comboStun.Items"),
            resources.GetString("comboStun.Items1"),
            resources.GetString("comboStun.Items2"),
            resources.GetString("comboStun.Items3"),
            resources.GetString("comboStun.Items4"),
            resources.GetString("comboStun.Items5"),
            resources.GetString("comboStun.Items6"),
            resources.GetString("comboStun.Items7"),
            resources.GetString("comboStun.Items8"),
            resources.GetString("comboStun.Items9"),
            resources.GetString("comboStun.Items10"),
            resources.GetString("comboStun.Items11"),
            resources.GetString("comboStun.Items12"),
            resources.GetString("comboStun.Items13"),
            resources.GetString("comboStun.Items14"),
            resources.GetString("comboStun.Items15")});
            this.comboStun.Name = "comboStun";
            this.comboStun.UseWaitCursor = true;
            this.comboStun.SelectedIndexChanged += new System.EventHandler(this.comboStun_SelectedIndexChanged);
            // 
            // labelInfo
            // 
            resources.ApplyResources(this.labelInfo, "labelInfo");
            this.labelInfo.Name = "labelInfo";
            this.tableLayoutPanel1.SetRowSpan(this.labelInfo, 11);
            // 
            // buttonGenerate
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonGenerate, 8);
            resources.ApplyResources(this.buttonGenerate, "buttonGenerate");
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // richTextBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBox1, 3);
            this.richTextBox1.DetectUrls = false;
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.richTextBox1, 2);
            // 
            // buttonCopy
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonCopy, 5);
            resources.ApplyResources(this.buttonCopy, "buttonCopy");
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // labelBandwidth
            // 
            resources.ApplyResources(this.labelBandwidth, "labelBandwidth");
            this.labelBandwidth.Name = "labelBandwidth";
            this.tableLayoutPanel1.SetRowSpan(this.labelBandwidth, 3);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 4);
            this.tableLayoutPanel3.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.comboBandwidthInUnit, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBandwidthOutUnit, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.nudBandwidthIn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.nudBandwidthOut, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelBandwidthIn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelBandwidthOut, 0, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel3, 3);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // comboBandwidthInUnit
            // 
            this.comboBandwidthInUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBandwidthInUnit.FormattingEnabled = true;
            this.comboBandwidthInUnit.Items.AddRange(new object[] {
            resources.GetString("comboBandwidthInUnit.Items"),
            resources.GetString("comboBandwidthInUnit.Items1"),
            resources.GetString("comboBandwidthInUnit.Items2")});
            resources.ApplyResources(this.comboBandwidthInUnit, "comboBandwidthInUnit");
            this.comboBandwidthInUnit.Name = "comboBandwidthInUnit";
            this.comboBandwidthInUnit.SelectedIndexChanged += new System.EventHandler(this.comboBandwidthInUnit_SelectedIndexChanged);
            // 
            // comboBandwidthOutUnit
            // 
            this.comboBandwidthOutUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBandwidthOutUnit.FormattingEnabled = true;
            this.comboBandwidthOutUnit.Items.AddRange(new object[] {
            resources.GetString("comboBandwidthOutUnit.Items"),
            resources.GetString("comboBandwidthOutUnit.Items1"),
            resources.GetString("comboBandwidthOutUnit.Items2")});
            resources.ApplyResources(this.comboBandwidthOutUnit, "comboBandwidthOutUnit");
            this.comboBandwidthOutUnit.Name = "comboBandwidthOutUnit";
            this.comboBandwidthOutUnit.SelectedIndexChanged += new System.EventHandler(this.comboBandwidthOutUnit_SelectedIndexChanged);
            // 
            // nudBandwidthIn
            // 
            resources.ApplyResources(this.nudBandwidthIn, "nudBandwidthIn");
            this.nudBandwidthIn.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudBandwidthIn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBandwidthIn.Name = "nudBandwidthIn";
            this.nudBandwidthIn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBandwidthIn.ValueChanged += new System.EventHandler(this.nudBandwidthIn_ValueChanged);
            // 
            // nudBandwidthOut
            // 
            resources.ApplyResources(this.nudBandwidthOut, "nudBandwidthOut");
            this.nudBandwidthOut.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudBandwidthOut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBandwidthOut.Name = "nudBandwidthOut";
            this.nudBandwidthOut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBandwidthOut.ValueChanged += new System.EventHandler(this.nudBandwidthOut_ValueChanged);
            // 
            // labelBandwidthIn
            // 
            resources.ApplyResources(this.labelBandwidthIn, "labelBandwidthIn");
            this.labelBandwidthIn.Name = "labelBandwidthIn";
            // 
            // labelBandwidthOut
            // 
            resources.ApplyResources(this.labelBandwidthOut, "labelBandwidthOut");
            this.labelBandwidthOut.Name = "labelBandwidthOut";
            // 
            // labelConfInfo
            // 
            resources.ApplyResources(this.labelConfInfo, "labelConfInfo");
            this.tableLayoutPanel1.SetColumnSpan(this.labelConfInfo, 5);
            this.labelConfInfo.Name = "labelConfInfo";
            // 
            // FormServer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormServer";
            this.panelTop.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPZPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKCPPort)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBandwidthIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBandwidthOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelPZPort;
        private System.Windows.Forms.Label labelKCPPort;
        private System.Windows.Forms.Label labelStun;
        private IPAddressControlLib.IPAddressControl ipAddressControl1;
        private System.Windows.Forms.Button buttonTestIP;
        private System.Windows.Forms.NumericUpDown nudPZPort;
        private System.Windows.Forms.NumericUpDown nudKCPPort;
        private System.Windows.Forms.ComboBox comboStun;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label labelBandwidth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBandwidthInUnit;
        private System.Windows.Forms.ComboBox comboBandwidthOutUnit;
        private System.Windows.Forms.NumericUpDown nudBandwidthIn;
        private System.Windows.Forms.NumericUpDown nudBandwidthOut;
        private System.Windows.Forms.Label labelBandwidthIn;
        private System.Windows.Forms.Label labelBandwidthOut;
        private System.Windows.Forms.Label labelConfInfo;
    }
}