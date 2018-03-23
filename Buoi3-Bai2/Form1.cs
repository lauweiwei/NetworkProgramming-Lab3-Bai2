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

namespace Buoi3_Bai2
{
    public partial class Form1 : Form
    {
        byte[] data = new byte[1024];
        IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
        Socket server = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);
        IPEndPoint sender = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
        EndPoint Remote;
        string input;

        public Form1()
        {
            InitializeComponent();
            string welcome = "Hello!";
            data = Encoding.ASCII.GetBytes(welcome);
            server.SendTo(data, data.Length, SocketFlags.None, ipep);
            Remote = (EndPoint)sender;
            data = new byte[1024];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btn_Scissors_Click(object sender, EventArgs e)
        {
            txtChoice.Text = "Scissors";
            input = "2";
            server.SendTo(Encoding.ASCII.GetBytes(input), Remote);
            data = new byte[1024];
            int recv = server.ReceiveFrom(data, ref Remote);
            string k = Encoding.ASCII.GetString(data, 0, recv);
            result(input, k);
        }

        private void btn_Rock_Click(object sender, EventArgs e)
        {
            txtChoice.Text = "Rock";
            input = "1";
            server.SendTo(Encoding.ASCII.GetBytes(input), Remote);
            data = new byte[1024];
            int recv = server.ReceiveFrom(data, ref Remote);
            string k = Encoding.ASCII.GetString(data, 0, recv);
            result(input, k);
        }

        private void btn_Paper_Click(object sender, EventArgs e)
        {
            txtChoice.Text = "Paper";
            input = "3";
            server.SendTo(Encoding.ASCII.GetBytes(input), Remote);
            data = new byte[1024];
            int recv = server.ReceiveFrom(data, ref Remote);
            string k = Encoding.ASCII.GetString(data, 0, recv);
            result(input, k);
        }
        public void result(string input, string k)
        {
            if (input == "1")
            {
                if (k == "1")
                {
                    txtSC.Text = "Rock";
                    txtResult.Text = "Draw";
                }
                if (k == "2")
                {
                    txtSC.Text = "Scissors";
                    txtResult.Text = "Win";
                }
                if (k == "3")
                {
                    txtSC.Text = "Paper";
                    txtResult.Text = "Lose";
                }
            }
            if (input == "2")
            {
                if (k == "1")
                {
                    txtSC.Text = "Rock";
                    txtResult.Text = "Lose";
                }
                if (k == "2")
                {
                    txtSC.Text = "Scissors";
                    txtResult.Text = "Draw";
                }
                if (k == "3")
                {
                    txtSC.Text = "Paper";
                    txtResult.Text = "Win";
                }
            }
            if (input == "3")
            {
                if (k == "1")
                {
                    txtSC.Text = "Rock";
                    txtResult.Text = "Win";
                }
                if (k == "2")
                {
                    txtSC.Text = "Scissors";
                    txtResult.Text = "Lose";
                }
                if (k == "3")
                {
                    txtSC.Text = "Paper";
                    txtResult.Text = "Draw";
                }
            }
        }

    }
}
