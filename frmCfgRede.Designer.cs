namespace Infrarizer
{
    partial class frmCfgRede
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCentralRede = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.rbtnDefaultAdress = new System.Windows.Forms.RadioButton();
            this.rbtnUserAdress = new System.Windows.Forms.RadioButton();
            this.txbPinger = new System.Windows.Forms.TextBox();
            this.btnAlteraIP = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.txbMask = new System.Windows.Forms.TextBox();
            this.txbGateway = new System.Windows.Forms.TextBox();
            this.txbDns2 = new System.Windows.Forms.TextBox();
            this.txbDns1 = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblMask = new System.Windows.Forms.Label();
            this.lblDns1 = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.lblDns2 = new System.Windows.Forms.Label();
            this.btnAutoIp = new System.Windows.Forms.Button();
            this.gpboxAlteraIP = new System.Windows.Forms.GroupBox();
            this.txbPinggl = new System.Windows.Forms.TextBox();
            this.gpboxPing = new System.Windows.Forms.GroupBox();
            this.btnIpConfig = new System.Windows.Forms.Button();
            this.rctxtIpShow = new System.Windows.Forms.RichTextBox();
            this.gpboxAlteraIP.SuspendLayout();
            this.gpboxPing.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Voltar ao inicio";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCentralRede
            // 
            this.btnCentralRede.Location = new System.Drawing.Point(12, 3);
            this.btnCentralRede.Name = "btnCentralRede";
            this.btnCentralRede.Size = new System.Drawing.Size(123, 23);
            this.btnCentralRede.TabIndex = 1;
            this.btnCentralRede.Text = "Abrir central de rede";
            this.btnCentralRede.UseVisualStyleBackColor = true;
            this.btnCentralRede.Click += new System.EventHandler(this.BtnCentralRede_Click);
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(53, 19);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(192, 23);
            this.btnPing.TabIndex = 2;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.BtnPing_Click);
            // 
            // rbtnDefaultAdress
            // 
            this.rbtnDefaultAdress.AutoSize = true;
            this.rbtnDefaultAdress.Checked = true;
            this.rbtnDefaultAdress.Location = new System.Drawing.Point(54, 48);
            this.rbtnDefaultAdress.Name = "rbtnDefaultAdress";
            this.rbtnDefaultAdress.Size = new System.Drawing.Size(14, 13);
            this.rbtnDefaultAdress.TabIndex = 3;
            this.rbtnDefaultAdress.TabStop = true;
            this.rbtnDefaultAdress.UseVisualStyleBackColor = true;
            // 
            // rbtnUserAdress
            // 
            this.rbtnUserAdress.AutoSize = true;
            this.rbtnUserAdress.Location = new System.Drawing.Point(154, 49);
            this.rbtnUserAdress.Name = "rbtnUserAdress";
            this.rbtnUserAdress.Size = new System.Drawing.Size(14, 13);
            this.rbtnUserAdress.TabIndex = 4;
            this.rbtnUserAdress.UseVisualStyleBackColor = true;
            // 
            // txbPinger
            // 
            this.txbPinger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txbPinger.Location = new System.Drawing.Point(172, 45);
            this.txbPinger.Name = "txbPinger";
            this.txbPinger.Size = new System.Drawing.Size(73, 20);
            this.txbPinger.TabIndex = 5;
            this.txbPinger.Text = "192.168.1.25";
            this.txbPinger.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btnAlteraIP
            // 
            this.btnAlteraIP.Location = new System.Drawing.Point(59, 34);
            this.btnAlteraIP.Name = "btnAlteraIP";
            this.btnAlteraIP.Size = new System.Drawing.Size(124, 23);
            this.btnAlteraIP.TabIndex = 6;
            this.btnAlteraIP.Text = "Alterar IP";
            this.btnAlteraIP.UseVisualStyleBackColor = true;
            this.btnAlteraIP.Click += new System.EventHandler(this.BtnAlteraIP_Click);
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(59, 63);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(123, 20);
            this.txbIP.TabIndex = 7;
            this.txbIP.Text = "192.168.1.25";
            // 
            // txbMask
            // 
            this.txbMask.Location = new System.Drawing.Point(59, 89);
            this.txbMask.Name = "txbMask";
            this.txbMask.Size = new System.Drawing.Size(123, 20);
            this.txbMask.TabIndex = 8;
            this.txbMask.Text = "255.255.255.0";
            // 
            // txbGateway
            // 
            this.txbGateway.Location = new System.Drawing.Point(59, 115);
            this.txbGateway.Name = "txbGateway";
            this.txbGateway.Size = new System.Drawing.Size(123, 20);
            this.txbGateway.TabIndex = 9;
            this.txbGateway.Text = "192.168.1.1";
            // 
            // txbDns2
            // 
            this.txbDns2.Location = new System.Drawing.Point(59, 167);
            this.txbDns2.Name = "txbDns2";
            this.txbDns2.Size = new System.Drawing.Size(123, 20);
            this.txbDns2.TabIndex = 10;
            this.txbDns2.Text = "192.168.1.224";
            // 
            // txbDns1
            // 
            this.txbDns1.Location = new System.Drawing.Point(59, 141);
            this.txbDns1.Name = "txbDns1";
            this.txbDns1.Size = new System.Drawing.Size(123, 20);
            this.txbDns1.TabIndex = 11;
            this.txbDns1.Text = "192.168.1.4";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(3, 66);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(17, 13);
            this.lblIP.TabIndex = 13;
            this.lblIP.Text = "IP";
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Location = new System.Drawing.Point(3, 92);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(33, 13);
            this.lblMask.TabIndex = 14;
            this.lblMask.Text = "Mask";
            // 
            // lblDns1
            // 
            this.lblDns1.AutoSize = true;
            this.lblDns1.Location = new System.Drawing.Point(3, 144);
            this.lblDns1.Name = "lblDns1";
            this.lblDns1.Size = new System.Drawing.Size(36, 13);
            this.lblDns1.TabIndex = 16;
            this.lblDns1.Text = "DNS1";
            this.lblDns1.Click += new System.EventHandler(this.Label4_Click);
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Location = new System.Drawing.Point(3, 118);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(49, 13);
            this.lblGateway.TabIndex = 15;
            this.lblGateway.Text = "Gateway";
            // 
            // lblDns2
            // 
            this.lblDns2.AutoSize = true;
            this.lblDns2.Location = new System.Drawing.Point(3, 170);
            this.lblDns2.Name = "lblDns2";
            this.lblDns2.Size = new System.Drawing.Size(36, 13);
            this.lblDns2.TabIndex = 17;
            this.lblDns2.Text = "DNS2";
            // 
            // btnAutoIp
            // 
            this.btnAutoIp.Location = new System.Drawing.Point(184, 34);
            this.btnAutoIp.Name = "btnAutoIp";
            this.btnAutoIp.Size = new System.Drawing.Size(124, 23);
            this.btnAutoIp.TabIndex = 18;
            this.btnAutoIp.Text = "Definir IP automático";
            this.btnAutoIp.UseVisualStyleBackColor = true;
            this.btnAutoIp.Click += new System.EventHandler(this.BtnAutoIp_Click);
            // 
            // gpboxAlteraIP
            // 
            this.gpboxAlteraIP.BackColor = System.Drawing.Color.Transparent;
            this.gpboxAlteraIP.Controls.Add(this.btnAlteraIP);
            this.gpboxAlteraIP.Controls.Add(this.btnAutoIp);
            this.gpboxAlteraIP.Controls.Add(this.txbIP);
            this.gpboxAlteraIP.Controls.Add(this.lblDns2);
            this.gpboxAlteraIP.Controls.Add(this.txbMask);
            this.gpboxAlteraIP.Controls.Add(this.lblDns1);
            this.gpboxAlteraIP.Controls.Add(this.txbGateway);
            this.gpboxAlteraIP.Controls.Add(this.lblGateway);
            this.gpboxAlteraIP.Controls.Add(this.txbDns2);
            this.gpboxAlteraIP.Controls.Add(this.lblMask);
            this.gpboxAlteraIP.Controls.Add(this.txbDns1);
            this.gpboxAlteraIP.Controls.Add(this.lblIP);
            this.gpboxAlteraIP.Location = new System.Drawing.Point(12, 101);
            this.gpboxAlteraIP.Name = "gpboxAlteraIP";
            this.gpboxAlteraIP.Size = new System.Drawing.Size(322, 253);
            this.gpboxAlteraIP.TabIndex = 19;
            this.gpboxAlteraIP.TabStop = false;
            // 
            // txbPinggl
            // 
            this.txbPinggl.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txbPinggl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txbPinggl.Location = new System.Drawing.Point(72, 45);
            this.txbPinggl.Name = "txbPinggl";
            this.txbPinggl.ReadOnly = true;
            this.txbPinggl.Size = new System.Drawing.Size(73, 20);
            this.txbPinggl.TabIndex = 20;
            this.txbPinggl.Text = "8.8.8.8";
            // 
            // gpboxPing
            // 
            this.gpboxPing.BackColor = System.Drawing.Color.Transparent;
            this.gpboxPing.Controls.Add(this.btnPing);
            this.gpboxPing.Controls.Add(this.txbPinggl);
            this.gpboxPing.Controls.Add(this.rbtnDefaultAdress);
            this.gpboxPing.Controls.Add(this.rbtnUserAdress);
            this.gpboxPing.Controls.Add(this.txbPinger);
            this.gpboxPing.Location = new System.Drawing.Point(12, 32);
            this.gpboxPing.Name = "gpboxPing";
            this.gpboxPing.Size = new System.Drawing.Size(322, 74);
            this.gpboxPing.TabIndex = 21;
            this.gpboxPing.TabStop = false;
            // 
            // btnIpConfig
            // 
            this.btnIpConfig.Location = new System.Drawing.Point(142, 3);
            this.btnIpConfig.Name = "btnIpConfig";
            this.btnIpConfig.Size = new System.Drawing.Size(138, 23);
            this.btnIpConfig.TabIndex = 22;
            this.btnIpConfig.Text = "Exibir detalhes de rede";
            this.btnIpConfig.UseVisualStyleBackColor = true;
            this.btnIpConfig.Click += new System.EventHandler(this.BtnIpConfig_Click);
            // 
            // rctxtIpShow
            // 
            this.rctxtIpShow.Location = new System.Drawing.Point(340, 3);
            this.rctxtIpShow.Name = "rctxtIpShow";
            this.rctxtIpShow.ReadOnly = true;
            this.rctxtIpShow.Size = new System.Drawing.Size(462, 351);
            this.rctxtIpShow.TabIndex = 23;
            this.rctxtIpShow.Text = "";
            this.rctxtIpShow.TextChanged += new System.EventHandler(this.RctxtIpShow_TextChanged);
            // 
            // frmCfgRede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 461);
            this.Controls.Add(this.rctxtIpShow);
            this.Controls.Add(this.btnIpConfig);
            this.Controls.Add(this.gpboxPing);
            this.Controls.Add(this.gpboxAlteraIP);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCentralRede);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCfgRede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações de rede";
            this.gpboxAlteraIP.ResumeLayout(false);
            this.gpboxAlteraIP.PerformLayout();
            this.gpboxPing.ResumeLayout(false);
            this.gpboxPing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCentralRede;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.RadioButton rbtnDefaultAdress;
        private System.Windows.Forms.RadioButton rbtnUserAdress;
        private System.Windows.Forms.TextBox txbPinger;
        private System.Windows.Forms.Button btnAlteraIP;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.TextBox txbMask;
        private System.Windows.Forms.TextBox txbGateway;
        private System.Windows.Forms.TextBox txbDns2;
        private System.Windows.Forms.TextBox txbDns1;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.Label lblDns1;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblDns2;
        private System.Windows.Forms.Button btnAutoIp;
        private System.Windows.Forms.GroupBox gpboxAlteraIP;
        private System.Windows.Forms.TextBox txbPinggl;
        private System.Windows.Forms.GroupBox gpboxPing;
        private System.Windows.Forms.Button btnIpConfig;
        private System.Windows.Forms.RichTextBox rctxtIpShow;
    }
}