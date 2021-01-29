using MicroServiceClienteAPP.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MicroServiceClienteAPP
{
    public partial class frmMicroService : Form
    {
        private bool allowVisible;
        private bool allowClose;

        public frmMicroService()
        {
            InitializeComponent();
            notifyIcon1.Icon = Properties.Resources.logo_preto;            
        }

        #region Eventos
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            allowClose = false;
        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            allowVisible = true;
            Show();
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRequisicao.Text))
            {
                MessageBox.Show("Informar >>> REQUISIÇÃO <<< para consulta.", "A T E N Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRequisicao.Focus();
                return;
            }
            else
                txtStatusConsultar.Text = ConsultarServicePorRequisicao(txtRequisicao.Text);
        }
        private void btnListaEnvios_Click(object sender, EventArgs e)
        {
            txtStatusConsultar.Text = ConsultarServices();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtStatusEnvio.Text += ServicesPost("Hello World");
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTotal.Text = ConsultarServicesTotalEnvios();
        }

        #endregion

        #region Metodos
        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                this.Hide();
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }
        public string ServicesPost(string mensagem)
        {
            string retorno = string.Empty;
            try
            {
                string POST = "/api/Services?value=" + mensagem + "&identificador=" + Properties.Settings.Default.Identificador;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44364" + POST);
                httpWebRequest.Method = "POST";

                var response = (HttpWebResponse)httpWebRequest.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                retorno += "Mensagem enviada com sucesso." + "\r\n";
                retorno += "Requisicao: ";
                retorno += responseString.ToString() + "\r\n\r\n";

                return retorno;
            }
            catch (Exception ex)
            {
                return retorno + ex.Message;
            }
        }
        public string ConsultarServicePorRequisicao(string requisicao)
        {
            string retorno = string.Empty;
            try
            {                
                string GET = "/api/Services?requisicao=" + requisicao;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44364" + GET);
                httpWebRequest.Method = "GET";              

                var response = (HttpWebResponse)httpWebRequest.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                var retornoAPI = JsonConvert.DeserializeObject<JObject>(responseString.ToString());

                foreach (var item in retornoAPI)
                {
                    if (item.Key.ToString() == "mensagem")
                    {
                        retorno += "Mensagem: ";
                        retorno += item.Value.ToString() + "\r\n";
                    }
                    if (item.Key.ToString() == "identificador")
                    {
                        retorno += "Identificador: ";
                        retorno += item.Value.ToString() + "\r\n";
                    }

                    if (item.Key.ToString() == "timestamp")
                    {
                        retorno += "Timestamp: ";
                        DateTime data = Convert.ToDateTime(item.Value.ToString());
                        retorno += data.ToString("dd/MM/yyyy HH:mm:ss") + "\r\n";
                    }
                    if (item.Key.ToString() == "requisicao")
                    {
                        retorno += "Requisicao: ";
                        retorno += item.Value.ToString() + "\r\n";
                    }
                }
                return retorno;
            }
            catch (Exception ex)
            {
                return retorno + ex.Message;
            }
        }
        public string ConsultarServices()
        {
            string retorno = string.Empty;
            try
            {
                string GET = "/api/Services/Envios";
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44364" + GET);
                httpWebRequest.Method = "GET";               

                var response = (HttpWebResponse)httpWebRequest.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                var retornoAPI = JsonConvert.DeserializeObject<List<Send>>(responseString.ToString());

                for (int i = 0; i < retornoAPI.Count; i++)
                {
                    retorno += "Mensagem: ";
                    retorno += retornoAPI[i].mensagem.ToString() + "\r\n";
                    retorno += "Identificador: ";
                    retorno += retornoAPI[i].identificador.ToString() + "\r\n";
                    retorno += "Timestamp: ";
                    DateTime data = Convert.ToDateTime(retornoAPI[i].timestamp.ToString());
                    retorno += data.ToString("dd/MM/yyyy HH:mm:ss") + "\r\n";
                    retorno += "Requisicao: ";
                    retorno += retornoAPI[i].requisicao.ToString() + "\r\n\r\n";
                }
                return retorno;
            }
            catch (Exception ex)
            {
                return retorno + ex.Message;
            }
        }
        public string ConsultarServicesTotalEnvios()
        {
            string retorno = string.Empty;
            try
            {
                string GET = "/api/Services/TotalEnvios";
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44364" + GET);
                httpWebRequest.Method = "GET";

                var response = (HttpWebResponse)httpWebRequest.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                retorno = responseString;

                return retorno;
            }
            catch (Exception ex)
            {
                return retorno + ex.Message;
            }
        }

        #endregion
        
    }
}
