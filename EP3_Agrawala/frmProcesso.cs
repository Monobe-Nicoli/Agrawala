using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace EP3_Agrawala
{
    public partial class frmProcesso : Form
    {
        public string ip;
        public byte id;
        public int porta,
                   numProcesso,
                   rLocal,
                   rExterno,
                   qtdPendentes;
        public Socket socket;
        public IPEndPoint endpointRemetente,
            endpointDestino1,
            endpointDestino2;
        Thread threadServer,
               threadClient;
        private bool trabalhando,
            requestAcionado,
            esperando;
        private byte[] listaDeferidos;
        private List<bool> listaReplies;
        public bool pausado;

        // buffer[0]: isReply
        // buffer[1]: id
        // buffer[2]: rLocal

        public frmProcesso()
        {
            InitializeComponent();
        }

        private void frmProcesso_Load(object sender, EventArgs e)
        {
            esperando = false;
            listaReplies = new List<bool>();
            listaDeferidos = new byte[3] { 0, 0, 0 };
            requestAcionado = false;
            socket.Bind(endpointRemetente);
            threadServer = new Thread(ThreadServer);
            threadServer.Start();
            threadClient = new Thread(ThreadClient);
            threadClient.Start();
        }

        void ThreadServer()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[3];
                    this.socket.Receive(buffer);

                    if (buffer[0] == 0)
                        Invoke(new Action<byte[]>(Processar), new byte[] { 0, buffer[1], buffer[2] });
                    else
                    {
                        listaReplies.Add(true);
                        qtdPendentes--;

                        if (listaReplies.Count == 2)
                        {
                            esperando = false;
                            trabalhando = true;
                            socket.SendTo(new byte[] { 1, id }, new IPEndPoint(IPAddress.Parse(ip), 7000));
                            listaReplies.Clear();
                        }
                        else
                            trabalhando = false;
                    }
                    Invoke(new Action(() => { AtualizarInterface(); }));
                }
                catch (SocketException ex)
                {
                    if (ex.ErrorCode != 10060)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        void ThreadClient()
        {
            while (true)
            {
                if (requestAcionado)
                {
                    esperando = true;
                    Invoke(new Action<byte[]>(Request), new byte[] { 0, this.id, (byte)rLocal });
                    requestAcionado = false;
                }
            }
        }

        void Processar(byte[] buffer)
        {
            int portaExt = 7000 + buffer[1];

            if (rExterno < buffer[2])
                rExterno = buffer[2];

          
            if (trabalhando || esperando)
                listaDeferidos[buffer[1] - 1] = 1;
            else
                if (!trabalhando)
                {
                    socket.SendTo(new byte[] { 1 }, new IPEndPoint(IPAddress.Parse(ip), portaExt));
                }
                else
                    if (rLocal < buffer[2])
                        listaDeferidos[buffer[1] - 1] = 1;
                    else
                        if (rLocal > buffer[2])
                        {
                            socket.SendTo(new byte[] { 1 }, new IPEndPoint(IPAddress.Parse(ip), portaExt));
                        }
                        else
                            if (numProcesso < buffer[1])
                                listaDeferidos[buffer[1] - 1] = 1;
                            else
                            {
                                socket.SendTo(new byte[] { 1 }, new IPEndPoint(IPAddress.Parse(ip), portaExt));
                            }
        }

        void Request(byte[] buffer)
        {
            int[] portaExt =
                numProcesso == 7001 ?
                new int[2] { 7002, 7003 } :
                numProcesso == 7002 ?
                new int[2] { 7001, 7003 } :
                new int[2] { 7001, 7002 };

            qtdPendentes = 2;

            if (rLocal <= rExterno)
            {
                rLocal = rExterno + 1;
                Invoke(new Action(() => { AtualizarInterface(); }));
            }
            socket.SendTo(new byte[] { 0, id, (byte)rLocal }, new IPEndPoint(IPAddress.Parse(ip), portaExt[0]));
            socket.SendTo(new byte[] { 0, id, (byte)rLocal }, new IPEndPoint(IPAddress.Parse(ip), portaExt[1]));
        }

        private void btnIniciarControle_Click(object sender, EventArgs e)
        {
            if (!esperando)
            {
                requestAcionado = true;
                lblSecao.Text = "Sim";
            }
        }

        private void AtualizarInterface()
        {
            if (trabalhando)
            {
                btnPausarMovimento.Enabled = true;
                btnReiniciarMovimento.Enabled = !true;
                btnIniciarControle.Enabled = false;
                btnLiberarControle.Enabled = true;
            }
            else
            {
                btnPausarMovimento.Enabled = !true;
                btnReiniciarMovimento.Enabled = !true;
                btnIniciarControle.Enabled = !false;
                btnLiberarControle.Enabled = !true;
            }

            if (pausado)
            {
                btnPausarMovimento.Enabled = false;
                btnReiniciarMovimento.Enabled = true;               
            }

            lblRepliesNaoRecebidos.Text = qtdPendentes.ToString();
            lblSeqValor.Text = String.Format("{0}/{1}", rLocal, rExterno);
            lblRepliesDeferidos.Text = String.Format("{0} {1} {2}", listaDeferidos[0], listaDeferidos[1], listaDeferidos[2]);
        }

        private void btnLiberarControle_Click(object sender, EventArgs e)
        {
            pausado = false;

            if (trabalhando)
            {
                socket.SendTo(new byte[] { 0, id }, new IPEndPoint(IPAddress.Parse(ip), 7000));

                for (int i = 0; i < listaDeferidos.Length; i++)
                {
                    if (listaDeferidos[i] == 1)
                    {
                        int porta = 7001 + i;
                        socket.SendTo(new byte[] { 1 }, new IPEndPoint(IPAddress.Parse(ip), porta));
                    }
                }

                esperando = false;
                lblSecao.Text = "Não";
                trabalhando = false;
                listaDeferidos = new byte[3] { 0, 0, 0 };
                AtualizarInterface();                
            }
        }

        private void btnPausarMovimento_Click(object sender, EventArgs e)
        {
            socket.SendTo(new byte[] { 2, id }, new IPEndPoint(IPAddress.Parse(ip), 7000));
            btnPausarMovimento.Enabled = false;
            btnReiniciarMovimento.Enabled = true;
            pausado = true;
        }

        private void btnReiniciarMovimento_Click(object sender, EventArgs e)
        {
            socket.SendTo(new byte[] { 1, id }, new IPEndPoint(IPAddress.Parse(ip), 7000));
            btnReiniciarMovimento.Enabled = false;
            btnPausarMovimento.Enabled = true;
            pausado = false;
        }
    }
}
