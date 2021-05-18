using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proj17052021
{
   
        public partial class Viagem : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    CarregarDadosPagina();
                }
            }

            protected void btnCadastrar_Click(object sender, EventArgs e)
            {
                string descricaoViagem = txtDescricao.Text;
                DateTime data = Convert.ToDateTime(txtdata.Text);
                TB_VIAGEM v = new TB_VIAGEM()
                {
                    descricao = descricaoViagem,
                    data = data
                };
                ViagemDBEntities contextViagem = new ViagemDBEntities();

                string valor = Request.QueryString["idItem"];

                if (String.IsNullOrEmpty(valor))
                {
                    contextViagem.TB_VIAGEM.Add(v);
                    lblmsg.Text = "Registro Inserido!";
                    Clear();
            }
                else {
                    int id = Convert.ToInt32(valor);
                    TB_VIAGEM viagem = contextViagem.TB_VIAGEM.First(c => c.id == id);
                    viagem.descricao = v.descricao;
                    viagem.data = v.data;
                    lblmsg.Text = "Registro alterado!";
                }

                contextViagem.SaveChanges();
            }

            private void Clear()
            {
                txtdata.Text = "";
                txtDescricao.Text = "";
                txtDescricao.Focus();
            }



            private void CarregarDadosPagina()
            {
                string valor = Request.QueryString["idItem"];
                int idItem = 0;

                TB_VIAGEM viagem = new TB_VIAGEM();
                ViagemDBEntities contextViagem = new ViagemDBEntities();

                if (!String.IsNullOrEmpty(valor))
                {
                    idItem = Convert.ToInt32(valor);
                    viagem = contextViagem.TB_VIAGEM.First(c => c.id == idItem);

                    txtDescricao.Text = viagem.descricao;
                    txtdata.Text = viagem.data.ToString();
                }
            }
        }
    }
