﻿namespace SexToyLink
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Play = new System.Windows.Forms.TabPage();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.Open_DOL_button = new System.Windows.Forms.Button();
           // this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.tabPage_settings = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_buttplug_port = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_buttplug_IP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_DOL_cycle = new System.Windows.Forms.TextBox();
            this.textBox_DOL_max_str = new System.Windows.Forms.TextBox();
            this.textBox_DOL_min_str = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_save_Settings = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_WebAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Browse = new System.Windows.Forms.Button();
            this.textBox_Filepath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_Online = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton_offline = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer_DOL_check = new System.Windows.Forms.Timer(this.components);
            this.timer_UI_update_wait = new System.Windows.Forms.Timer(this.components);
            this.timer_DOL_vibrate = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage_Play.SuspendLayout();
            this.tabPage_settings.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Play);
            this.tabControl1.Controls.Add(this.tabPage_settings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 370);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage_Play
            // 
            this.tabPage_Play.Controls.Add(this.button_disconnect);
            this.tabPage_Play.Controls.Add(this.button_Connect);
            this.tabPage_Play.Controls.Add(this.Open_DOL_button);
           // this.tabPage_Play.Controls.Add(this.chromiumWebBrowser1);
            this.tabPage_Play.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Play.Name = "tabPage_Play";
            this.tabPage_Play.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Play.Size = new System.Drawing.Size(670, 344);
            this.tabPage_Play.TabIndex = 1;
            this.tabPage_Play.Text = "Play";
            this.tabPage_Play.UseVisualStyleBackColor = true;
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(3, 61);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(394, 58);
            this.button_disconnect.TabIndex = 5;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(3, 3);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(394, 58);
            this.button_Connect.TabIndex = 4;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // Open_DOL_button
            // 
            this.Open_DOL_button.Location = new System.Drawing.Point(-4, 125);
            this.Open_DOL_button.Name = "Open_DOL_button";
            this.Open_DOL_button.Size = new System.Drawing.Size(394, 58);
            this.Open_DOL_button.TabIndex = 1;
            this.Open_DOL_button.Text = "Open Degrees of Lewdity";
            this.Open_DOL_button.UseVisualStyleBackColor = true;
            this.Open_DOL_button.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // chromiumWebBrowser1
            // 
           // this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
           // this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
           // this.chromiumWebBrowser1.Location = new System.Drawing.Point(3, 3);
           // this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
          //  this.chromiumWebBrowser1.Size = new System.Drawing.Size(664, 338);
          //  this.chromiumWebBrowser1.TabIndex = 3;
            // 
            // tabPage_settings
            // 
            this.tabPage_settings.Controls.Add(this.label11);
            this.tabPage_settings.Controls.Add(this.panel2);
            this.tabPage_settings.Controls.Add(this.button_save_Settings);
            this.tabPage_settings.Controls.Add(this.label7);
            this.tabPage_settings.Controls.Add(this.panel1);
            this.tabPage_settings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_settings.Name = "tabPage_settings";
            this.tabPage_settings.Size = new System.Drawing.Size(670, 344);
            this.tabPage_settings.TabIndex = 2;
            this.tabPage_settings.Text = "Settings";
            this.tabPage_settings.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Buttplug / Intiface Settings";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox_buttplug_port);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox_buttplug_IP);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_DOL_cycle);
            this.panel2.Controls.Add(this.textBox_DOL_max_str);
            this.panel2.Controls.Add(this.textBox_DOL_min_str);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(408, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 218);
            this.panel2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Port:";
            // 
            // textBox_buttplug_port
            // 
            this.textBox_buttplug_port.Location = new System.Drawing.Point(105, 9);
            this.textBox_buttplug_port.Name = "textBox_buttplug_port";
            this.textBox_buttplug_port.Size = new System.Drawing.Size(100, 20);
            this.textBox_buttplug_port.TabIndex = 0;
            this.textBox_buttplug_port.TextChanged += new System.EventHandler(this.textBox_buttplug_port_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Server address:";
            // 
            // textBox_buttplug_IP
            // 
            this.textBox_buttplug_IP.Location = new System.Drawing.Point(105, 39);
            this.textBox_buttplug_IP.Name = "textBox_buttplug_IP";
            this.textBox_buttplug_IP.Size = new System.Drawing.Size(100, 20);
            this.textBox_buttplug_IP.TabIndex = 3;
            this.textBox_buttplug_IP.TextChanged += new System.EventHandler(this.textBox_buttplug_IP_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Min strength:";
            // 
            // textBox_DOL_cycle
            // 
            this.textBox_DOL_cycle.Location = new System.Drawing.Point(105, 133);
            this.textBox_DOL_cycle.Name = "textBox_DOL_cycle";
            this.textBox_DOL_cycle.Size = new System.Drawing.Size(100, 20);
            this.textBox_DOL_cycle.TabIndex = 5;
            this.textBox_DOL_cycle.TextChanged += new System.EventHandler(this.textBox_DOL_cycle_TextChanged);
            // 
            // textBox_DOL_max_str
            // 
            this.textBox_DOL_max_str.Location = new System.Drawing.Point(105, 103);
            this.textBox_DOL_max_str.Name = "textBox_DOL_max_str";
            this.textBox_DOL_max_str.Size = new System.Drawing.Size(100, 20);
            this.textBox_DOL_max_str.TabIndex = 3;
            this.textBox_DOL_max_str.TextChanged += new System.EventHandler(this.textBox_DOL_max_str_TextChanged);
            // 
            // textBox_DOL_min_str
            // 
            this.textBox_DOL_min_str.Location = new System.Drawing.Point(105, 73);
            this.textBox_DOL_min_str.Name = "textBox_DOL_min_str";
            this.textBox_DOL_min_str.Size = new System.Drawing.Size(100, 20);
            this.textBox_DOL_min_str.TabIndex = 0;
            this.textBox_DOL_min_str.TextChanged += new System.EventHandler(this.textBox_DOL_min_str_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Max strength:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cycle duration (ms):";
            // 
            // button_save_Settings
            // 
            this.button_save_Settings.Location = new System.Drawing.Point(8, 247);
            this.button_save_Settings.Name = "button_save_Settings";
            this.button_save_Settings.Size = new System.Drawing.Size(650, 50);
            this.button_save_Settings.TabIndex = 8;
            this.button_save_Settings.Text = "Save Settings";
            this.button_save_Settings.UseVisualStyleBackColor = true;
            this.button_save_Settings.Click += new System.EventHandler(this.button_save_Settings_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "DOL Settings";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.radioButton_Online);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.radioButton_offline);
            this.panel1.Location = new System.Drawing.Point(8, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 218);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox_WebAddress);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(191, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 103);
            this.panel4.TabIndex = 14;
            // 
            // textBox_WebAddress
            // 
            this.textBox_WebAddress.Location = new System.Drawing.Point(11, 34);
            this.textBox_WebAddress.Name = "textBox_WebAddress";
            this.textBox_WebAddress.Size = new System.Drawing.Size(151, 20);
            this.textBox_WebAddress.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Web address:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_Browse);
            this.panel3.Controls.Add(this.textBox_Filepath);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(6, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 103);
            this.panel3.TabIndex = 13;
            // 
            // button_Browse
            // 
            this.button_Browse.Location = new System.Drawing.Point(15, 60);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(145, 28);
            this.button_Browse.TabIndex = 11;
            this.button_Browse.Text = "Browse";
            this.button_Browse.UseVisualStyleBackColor = true;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // textBox_Filepath
            // 
            this.textBox_Filepath.Location = new System.Drawing.Point(15, 34);
            this.textBox_Filepath.Name = "textBox_Filepath";
            this.textBox_Filepath.Size = new System.Drawing.Size(151, 20);
            this.textBox_Filepath.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "File path:";
            // 
            // radioButton_Online
            // 
            this.radioButton_Online.AutoSize = true;
            this.radioButton_Online.Location = new System.Drawing.Point(247, 47);
            this.radioButton_Online.Name = "radioButton_Online";
            this.radioButton_Online.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Online.TabIndex = 12;
            this.radioButton_Online.TabStop = true;
            this.radioButton_Online.Text = "Online";
            this.radioButton_Online.UseVisualStyleBackColor = true;
            this.radioButton_Online.CheckedChanged += new System.EventHandler(this.radioButton_Online_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(102, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Game source:";
            // 
            // radioButton_offline
            // 
            this.radioButton_offline.AutoSize = true;
            this.radioButton_offline.Location = new System.Drawing.Point(59, 47);
            this.radioButton_offline.Name = "radioButton_offline";
            this.radioButton_offline.Size = new System.Drawing.Size(55, 17);
            this.radioButton_offline.TabIndex = 7;
            this.radioButton_offline.TabStop = true;
            this.radioButton_offline.Text = "Offline";
            this.radioButton_offline.UseVisualStyleBackColor = true;
            this.radioButton_offline.CheckedChanged += new System.EventHandler(this.radioButton_offline_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 188);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(226, 126);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // timer_DOL_check
            // 
            this.timer_DOL_check.Interval = 50;
            this.timer_DOL_check.Tick += new System.EventHandler(this.timer_DOL_Tick);
            // 
            // timer_UI_update_wait
            // 
            this.timer_UI_update_wait.Interval = 1000;
            this.timer_UI_update_wait.Tick += new System.EventHandler(this.timer_UI_update_wait_Tick);
            // 
            // timer_DOL_vibrate
            // 
            this.timer_DOL_vibrate.Tick += new System.EventHandler(this.timer_DOL_vibrate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 370);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(299, 398);
            this.Name = "Form1";
            this.Text = "Sex Toy Link (disconnected)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Play.ResumeLayout(false);
            this.tabPage_settings.ResumeLayout(false);
            this.tabPage_settings.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Play;
        private System.Windows.Forms.Button Open_DOL_button;
        //private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer_DOL_check;
        private System.Windows.Forms.Timer timer_UI_update_wait;
        private System.Windows.Forms.TabPage tabPage_settings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_DOL_cycle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_DOL_max_str;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_DOL_min_str;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_save_Settings;
        private System.Windows.Forms.Timer timer_DOL_vibrate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_buttplug_port;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_buttplug_IP;
        private System.Windows.Forms.RadioButton radioButton_Online;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton_offline;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_WebAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.TextBox textBox_Filepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Button button_Connect;
    }
}

