using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace EP3_Agrawala
{
    public partial class frmConfig : Form
    {
        Config configurador = new Config();

        public frmConfig()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int id;            

            if (int.TryParse(ddlNumProcesso.Text, out id))
            {
                switch (id)
                {
                    case 1:
                        frmProcesso frmProcesso1 = configurador.Configurar(new frmProcesso(), id);
                        frmProcesso1.Show();
                        break;
                    case 2:
                        frmProcesso frmProcesso2 = configurador.Configurar(new frmProcesso(), id);
                        frmProcesso2.Show();
                        break;
                    case 3:
                        frmProcesso frmProcesso3 = configurador.Configurar(new frmProcesso(), id);
                        frmProcesso3.Show();
                        break;
                }

                ddlNumProcesso.Items.Remove(ddlNumProcesso.SelectedItem);
                if (ddlNumProcesso.Items.Count == 0)
                    this.Hide();
            }
            else
                MessageBox.Show("Escolha um valor para o processo!");
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            frmTrem trem = new frmTrem();
            trem.socket = configurador.Socket;
            trem.Show();
        }
    }

    public class Config
    {
        private string _Ip;
        private Socket _Socket;
        public Socket Socket
        {
            get
            {
                this._Socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                this._Socket.SendTimeout = 8000;
                this._Socket.ReceiveTimeout = 8000;
                return this._Socket;
            }
            set
            {
                this._Socket = value;
            }
        }
        public string Ip
        {
            get { return "127.0.0.1"; }
            set { this._Ip = value; }
        }

        public frmProcesso Configurar(frmProcesso form, int id)
        {
            int[] portaExt =
                id == 1 ?
                new int[2] { 7002, 7003 } :
                id == 2 ?
                new int[2] { 7001, 7003 } :
                new int[2] { 7001, 7002 };

            form.numProcesso = 7000 + id;
            form.ip = this.Ip;
            form.Text = String.Format("Processo #{0}", id);
            form.id = (byte)id;
            form.socket = this.Socket;
            form.endpointRemetente = new IPEndPoint(IPAddress.Any, form.numProcesso);
            form.endpointDestino1 = new IPEndPoint(IPAddress.Parse(this.Ip), portaExt[0]);
            form.endpointDestino2 = new IPEndPoint(IPAddress.Parse(this.Ip), portaExt[1]);
            form.socket = this.Socket;

            return form;
        }
        public Config()
        {
        }
    }
}
