using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace EP3_Agrawala
{
    public partial class frmTrem : Form
    {
        public Socket socket;
        Thread threadServer;

        public frmTrem()
        {
            InitializeComponent();
        }

        private void frmTrem_Load(object sender, EventArgs e)
        {
            socket.Bind(new IPEndPoint(IPAddress.Any, 7000));

            threadServer = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        byte[] buffer = new byte[3];
                        socket.Receive(buffer);
                        Invoke(new Action<byte[]>(Processar), new byte[] { buffer[0], buffer[1] });
                    }
                    catch (SocketException ex)
                    {
                        if (ex.ErrorCode != 10060)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            });

            threadServer.Start();
        }

        private void Processar(byte[] buffer)
        {
            switch (buffer[0])
            {
                case 0:
                    lblStatus.Text = "Parado";
                    lblControlador.Text = "-";
                    break;
                case 1:
                    lblStatus.Text = "Andando";
                    lblControlador.Text = buffer[1].ToString();
                    break;
                case 2:
                    lblStatus.Text = "Pausado";
                    break;
            }
        }

        private void frmTrem_FormClosing(object sender, FormClosingEventArgs e)
        {
            socket.Dispose();
            threadServer.Join();
        }
    }
}
