using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _24052021AgendaConsulta
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarLista()
        {
            ConsultaDBEntities context = new ConsultaDBEntities();
            List<TB_CONSULTA> lstViagem = context.TB_CONSULTA.ToList<TB_CONSULTA>();

            GVViagem.DataSource = lstViagem;
            GVViagem.DataBind();
        }

        protected void GVViagem_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idItem = Convert.ToInt32(e.CommandArgument.ToString());
            ConsultaDBEntities contextConsulta = new ConsultaDBEntities();
            TB_CONSULTA consulta = new TB_CONSULTA();

            consulta = contextConsulta.TB_CONSULTA.First(c => c.id == idItem);

            if (e.CommandName == "ALTERAR")
            {
                Response.Redirect("Consulta.aspx?idItem=" + idItem);
            }
            else if (e.CommandName == "EXCLUIR")
            {
                contextConsulta.TB_CONSULTA.Remove(consulta);
                contextConsulta.SaveChanges();
                string msg = "Viagem excluida com sucesso!";
                string titulo = "Informacao";
                CarregarLista();
                DisplayAlert(titulo, msg, this);
            }
        }

        public void DisplayAlert(string titulo, string mensagem, System.Web.UI.Page page)
        {
            h1.InnerText = titulo;
            lblMsgPopup.InnerText = mensagem;
            ClientScript.RegisterStartupScript(typeof(Page), Guid.NewGuid().ToString(), "MostrarPopupMensagem();", true);
        }
    }

}