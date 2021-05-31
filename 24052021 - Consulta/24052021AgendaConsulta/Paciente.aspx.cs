using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _24052021AgendaConsulta
{
    public partial class Paciente : System.Web.UI.Page
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
            string nomePaciente = txtNome.Text;
            string telefonePaciente = txtTelefone.Text;
            string enderecoPaciente = txtEndereco.Text;
            //DateTime data = Convert.ToDateTime(txtdata.Text);
            TB_PACIENTE p = new TB_PACIENTE()
            {
                nome = nomePaciente,
                telefone = telefonePaciente,
                endereco = enderecoPaciente
            };
            ConsultaDBEntities contextPaciente = new ConsultaDBEntities();

            string valor = Request.QueryString["idItem"];

            if (String.IsNullOrEmpty(valor))
            {
                contextPaciente.TB_PACIENTE.Add(p);
                lblmsg.Text = "Registro Inserido!";
                Clear();
            }
            else
            {
                int id = Convert.ToInt32(valor);
                TB_PACIENTE paciente = contextPaciente.TB_PACIENTE.First(c => c.id == id);
                paciente.nome = p.nome;
                paciente.telefone = p.telefone;
                paciente.endereco = p.endereco;
                lblmsg.Text = "Registro alterado!";
            }

            contextPaciente.SaveChanges();
        }

        private void Clear()
        {
            
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtEndereco.Focus();
        }



        private void CarregarDadosPagina()
        {
            string valor = Request.QueryString["idItem"];
            int idItem = 0;

            TB_PACIENTE paciente = new TB_PACIENTE();
            ConsultaDBEntities contextPaciente = new ConsultaDBEntities();

            if (!String.IsNullOrEmpty(valor))
            {
                idItem = Convert.ToInt32(valor);
                paciente = contextPaciente.TB_PACIENTE.First(c => c.id == idItem);

                txtNome.Text = paciente.nome;
                txtTelefone.Text = paciente.telefone;
                txtEndereco.Text = paciente.endereco;
            }
        }
    }

}