using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Massenger
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            m_IpBoxClient1.Text = getLocalIP();
        }

        private void m_IPEnter_Click(object sender, EventArgs e)
        {
            bool valueIPClien1 = ipCheck(m_IpBoxClient1.Text);
            bool valueIPClien2 = ipCheck(m_IpBoxClient2.Text);
            bool valuePortClien1 = portCheck(m_PortBoxClient1.Text);
            bool valuePortClien2 = portCheck(m_PortBoxClient2.Text);

            if(valueIPClien1&&valueIPClien2&&valuePortClien1&&valuePortClien2)
            {
                m_IpBoxClient1.Enabled = false;
                m_IpBoxClient2.Enabled = false;
                m_PortBoxClient1.Enabled = false;
                m_PortBoxClient2.Enabled = false;
                m_Connect.Enabled = true;
            }
        }

        private string getLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "127.0.0.1";
        }

        private bool ipCheck(string i_Str)
        {
            string text = i_Str;
            int o_numberfromtherText;

            string[] numberOfIP = text.Split('.');

            if (numberOfIP.Length == 4)
            {
                foreach (string msg in numberOfIP)
                {
                    bool isnumber = false;
                    isnumber = int.TryParse(msg, out o_numberfromtherText);
                    if (isnumber == false)
                    {
                        m_IpBoxClient1.Text = null;
                        return false ;
                    }
                }

                return true;
            }
            else
            {
                m_IpBoxClient1.Text = null;
                return false;
            }
        }

        private bool portCheck(string i_Str)
        {
            string text = i_Str;

            foreach (char charcter in text)
            {
                if (char.IsDigit(charcter) == false)
                {
                    m_PortBoxClient1.Text = null;
                    return false;
                }
            }

            return true;
        }

        private void m_Connect_Click(object sender, EventArgs e)
        {
            try
            { 
                EndPoint epLocal = new IPEndPoint(IPAddress.Parse(m_IpBoxClient1.Text), int.Parse(m_PortBoxClient1.Text));
                EndPoint epRemote = new IPEndPoint(IPAddress.Parse(m_IpBoxClient2.Text), int.Parse(m_PortBoxClient2.Text));
                DialogForm dialog = new DialogForm(epLocal, epRemote);
                Hide();
                dialog.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
    }
}
