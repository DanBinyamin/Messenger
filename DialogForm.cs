using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;


namespace Massenger
{
    public partial class DialogForm : Form
    {
        private Socket socket = null;
        private EndPoint epLocal, epRemote;

        public DialogForm(EndPoint i_epLocal,EndPoint i_epRemote)
        {
            InitializeComponent();

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            epLocal = i_epLocal;
            epRemote = i_epRemote;

            socket.Bind(epLocal);
            socket.Connect(epRemote);

            byte[] buffer = new byte[4096];
            socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);
        }

        private void m_Send_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding ascii = new ASCIIEncoding();
                byte[] msg = new byte[4096];
                msg = ascii.GetBytes(textBox1.Text);

                socket.Send(msg);
                listBox1.Items.Add("Me :" + textBox1.Text);
                textBox1.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void messageCallBack(IAsyncResult i_Async)
        {
            try
            {
                int size = socket.EndReceiveFrom(i_Async,ref epRemote);
                if(size>0)
                {
                    byte[] reciveData = new byte[4096];
                    reciveData = (byte[])i_Async.AsyncState;

                    ASCIIEncoding aSCII = new ASCIIEncoding();
                    string recivemsg = aSCII.GetString(reciveData);

                    listBox1.Items.Add("Friend :"+ recivemsg);
                }

                byte[] buffer = new byte[4096];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
