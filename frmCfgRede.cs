using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;

namespace Infrarizer
{
    public partial class frmCfgRede : Form
    {
        public object RctxtIpShow { get; internal set; }

        public frmCfgRede()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmIndex frmIndex = new frmIndex();
            frmIndex.Show();
            this.Visible = false;
        }

        private void BtnCentralRede_Click(object sender, EventArgs e)
        {
            Process.Start("ncpa.cpl");
        }

        private void BtnPing_Click(object sender, EventArgs e)
        {


            string pingadress;
            if (rbtnDefaultAdress.Checked == true)
            {
                pingadress = " 8.8.8.8";
            }
            else
            {
                pingadress = " " + txbPinger.Text;
            }

            string pinger = @"/C" + "ping" + pingadress;
            Process.Start("CMD.exe", pinger).WaitForExit();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void BtnAlteraIP_Click(object sender, EventArgs e)
        {
            string modIP = txbIP.Text;
            string modMask = txbMask.Text;
            string modGateway = txbGateway.Text;
            string modDns1 = txbDns1.Text;
            string modDns2 = txbDns2.Text;

            string userNetworkCfg = "netsh interface ipv4 set address \"Ethernet\" static";
            string userDnsConfig = "netsh interface ip set DNS \"Ethernet\" static";
            string userDnsSecConfig = "netsh interface ip add dns name=Ethernet";

            string netCommand = @"/C" + " " + userNetworkCfg + " " + modIP + " " + modMask + " " + modGateway;
            string dnsCommand = @"/C" + " " + userDnsConfig + " " + modDns1;
            string dnsSecCommand = @"/C" + " " + userDnsSecConfig + " " + modDns2 + " " + "index=2";

            using (Process alteraIP = new Process())
            {
                Process.Start("CMD.exe", netCommand);
                alteraIP.StartInfo.CreateNoWindow = true;
            }

            using (Process alteraDns1 = new Process())
            {
                Process.Start("CMD.exe", dnsCommand);
                alteraDns1.StartInfo.CreateNoWindow = true;
            }

            using (Process alteraDns2 = new Process())
            {
                Process.Start("CMD.exe", dnsSecCommand);
                alteraDns2.StartInfo.CreateNoWindow = true;
            }

            using (Process ipCfg = new Process())
            {
                Process.Start("CMD.exe", @"/C" + "ipconfig /all > C:/Windows/Temp/infrarizernetcfg.txt").WaitForExit();
                string netadress = File.ReadAllText(@"C:/Windows/Temp/infrarizernetcfg.txt");
                rctxtIpShow.Text = netadress;
                ipCfg.StartInfo.CreateNoWindow = true;
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnAutoIp_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", @"/C" + "netsh interface ip set address \"Ethernet\" dhcp");

            using (Process ipCfg = new Process())
            {
                Process.Start("CMD.exe", @"/C" + "ipconfig /all > C:/Windows/Temp/infrarizernetcfg.txt").WaitForExit();
                string netadress = File.ReadAllText(@"C:/Windows/Temp/infrarizernetcfg.txt");
                rctxtIpShow.Text = netadress;
                ipCfg.StartInfo.CreateNoWindow = true;
            }
        }

        public void BtnIpConfig_Click(object sender, EventArgs e)
        {
            using (Process ipCfg = new Process())
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(@"/C");
                builder.Append("&ipconfig /all > C:/Windows/Temp/infrarizernetcfg.txt");
                Process.Start("CMD.exe", builder.ToString()).WaitForExit();
                // string netadress = ConvertToascii(File.ReadAllText(@"C:/Windows/Temp/infrarizernetcfg.txt", Encoding.ASCII));
                string netadress = ConvertToascii(File.ReadAllText(@"C:/Windows/Temp/infrarizernetcfg.txt", Encoding.Default));
                rctxtIpShow.Text = netadress;
                ipCfg.Dispose();
            }
        }

        private string ConvertToascii(string texto)
        {
            StringBuilder builder = new StringBuilder(texto);
            builder = builder.Replace("‡", "ç");
            builder = builder.Replace("Æ", "ã");
            builder = builder.Replace("¢", "ó");
            builder = builder.Replace("¡", "í");
            builder = builder.Replace("Æ", "ã");
            builder = builder.Replace("Sufixo DNS prim rio .", "Sufixo DNS primário .");
          
            return builder.ToString();
        }

        public void RctxtIpShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbIP_TextChanged(object sender, KeyPressEventArgs e)
        {

        }
    }
}
