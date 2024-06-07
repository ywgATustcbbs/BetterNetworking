namespace BetterNetworking
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.label3 = new System.Windows.Forms.Label();
            this.comboBandwidthInUnit = new System.Windows.Forms.ComboBox();
            this.nudBandwidthIn = new System.Windows.Forms.NumericUpDown();
            this.nudBandwidthOut = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBandwidthOutUnit = new System.Windows.Forms.ComboBox();
            this.labelBandwidthIn = new System.Windows.Forms.Label();
            this.labelBandwidthOut = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelBandwidth = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudBandwidthIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBandwidthOut)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(218, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "bps";
            // 
            // comboBandwidthInUnit
            // 
            this.comboBandwidthInUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBandwidthInUnit.FormattingEnabled = true;
            this.comboBandwidthInUnit.Items.AddRange(new object[] {
            "K",
            "M",
            "G"});
            this.comboBandwidthInUnit.Location = new System.Drawing.Point(175, 3);
            this.comboBandwidthInUnit.Name = "comboBandwidthInUnit";
            this.comboBandwidthInUnit.Size = new System.Drawing.Size(37, 29);
            this.comboBandwidthInUnit.TabIndex = 2;
            this.comboBandwidthInUnit.SelectedIndexChanged += new System.EventHandler(this.comboBandwidthInUnit_SelectedIndexChanged);
            // 
            // nudBandwidthIn
            // 
            this.nudBandwidthIn.Location = new System.Drawing.Point(111, 3);
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
            this.nudBandwidthIn.Size = new System.Drawing.Size(58, 29);
            this.nudBandwidthIn.TabIndex = 4;
            this.nudBandwidthIn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBandwidthIn.ValueChanged += new System.EventHandler(this.nudBandwidthIn_ValueChanged);
            // 
            // nudBandwidthOut
            // 
            this.nudBandwidthOut.Location = new System.Drawing.Point(111, 32);
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
            this.nudBandwidthOut.Size = new System.Drawing.Size(58, 29);
            this.nudBandwidthOut.TabIndex = 5;
            this.nudBandwidthOut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBandwidthOut.ValueChanged += new System.EventHandler(this.nudBandwidthOut_ValueChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.comboBandwidthInUnit, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBandwidthOutUnit, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.nudBandwidthIn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.nudBandwidthOut, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelBandwidthIn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelBandwidthOut, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(166, 8);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(267, 59);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(218, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "bps";
            // 
            // comboBandwidthOutUnit
            // 
            this.comboBandwidthOutUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBandwidthOutUnit.FormattingEnabled = true;
            this.comboBandwidthOutUnit.Items.AddRange(new object[] {
            "K",
            "M",
            "G"});
            this.comboBandwidthOutUnit.Location = new System.Drawing.Point(175, 32);
            this.comboBandwidthOutUnit.Name = "comboBandwidthOutUnit";
            this.comboBandwidthOutUnit.Size = new System.Drawing.Size(37, 29);
            this.comboBandwidthOutUnit.TabIndex = 3;
            this.comboBandwidthOutUnit.SelectedIndexChanged += new System.EventHandler(this.comboBandwidthOutUnit_SelectedIndexChanged);
            // 
            // labelBandwidthIn
            // 
            this.labelBandwidthIn.AutoSize = true;
            this.labelBandwidthIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelBandwidthIn.Location = new System.Drawing.Point(3, 0);
            this.labelBandwidthIn.Name = "labelBandwidthIn";
            this.labelBandwidthIn.Size = new System.Drawing.Size(55, 21);
            this.labelBandwidthIn.TabIndex = 6;
            this.labelBandwidthIn.Text = "label4";
            // 
            // labelBandwidthOut
            // 
            this.labelBandwidthOut.AutoSize = true;
            this.labelBandwidthOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelBandwidthOut.Location = new System.Drawing.Point(3, 29);
            this.labelBandwidthOut.Name = "labelBandwidthOut";
            this.labelBandwidthOut.Size = new System.Drawing.Size(55, 21);
            this.labelBandwidthOut.TabIndex = 7;
            this.labelBandwidthOut.Text = "label1";
            // 
            // buttonGenerate
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonGenerate, 7);
            this.buttonGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGenerate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGenerate.Location = new System.Drawing.Point(155, 483);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(150, 3, 150, 3);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(482, 44);
            this.buttonGenerate.TabIndex = 10;
            this.buttonGenerate.Text = "button2";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // richTextBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBox1, 6);
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.tableLayoutPanel1.SetRowSpan(this.richTextBox1, 8);
            this.richTextBox1.Size = new System.Drawing.Size(430, 384);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // labelBandwidth
            // 
            this.labelBandwidth.AutoSize = true;
            this.labelBandwidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBandwidth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelBandwidth.Location = new System.Drawing.Point(8, 5);
            this.labelBandwidth.Name = "labelBandwidth";
            this.tableLayoutPanel1.SetRowSpan(this.labelBandwidth, 3);
            this.labelBandwidth.Size = new System.Drawing.Size(147, 65);
            this.labelBandwidth.TabIndex = 13;
            this.labelBandwidth.Text = "label1";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInfo.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labelInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelInfo.Location = new System.Drawing.Point(444, 5);
            this.labelInfo.Name = "labelInfo";
            this.tableLayoutPanel1.SetRowSpan(this.labelInfo, 11);
            this.labelInfo.Size = new System.Drawing.Size(340, 455);
            this.labelInfo.TabIndex = 9;
            this.labelInfo.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Controls.Add(this.labelInfo, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonGenerate, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelBandwidth, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 550);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackgroundImage = global::BetterNetworking.Properties.Resources.back;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClose.BackgroundImage = global::BetterNetworking.Properties.Resources.close;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClose.Location = new System.Drawing.Point(758, 8);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(34, 34);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonClose, 5, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 50);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseDown);
            this.tableLayoutPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseMove);
            this.tableLayoutPanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseUp);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tableLayoutPanel2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(10);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 50);
            this.panelTop.TabIndex = 3;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormClient";
            ((System.ComponentModel.ISupportInitialize)(this.nudBandwidthIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBandwidthOut)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBandwidthInUnit;
        private System.Windows.Forms.NumericUpDown nudBandwidthIn;
        private System.Windows.Forms.NumericUpDown nudBandwidthOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelBandwidth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBandwidthOutUnit;
        private System.Windows.Forms.Label labelBandwidthIn;
        private System.Windows.Forms.Label labelBandwidthOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelTop;
    }
}