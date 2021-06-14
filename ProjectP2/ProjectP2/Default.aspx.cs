using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectP2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarLista()
        {
            GameDBEntities context = new GameDBEntities();
            List<TB_GAME> lstGame = context.TB_GAME.ToList<TB_GAME>();

            GVGame.DataSource = lstGame;
            GVGame.DataBind();
        }

        protected void GVGame_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idItem = Convert.ToInt32(e.CommandArgument.ToString());
            GameDBEntities contextGame = new GameDBEntities();
            TB_GAME game = new TB_GAME();

            game = contextGame.TB_GAME.First(c => c.id == idItem);

            if (e.CommandName == "ALTERAR")
            {
                Response.Redirect("Game.aspx?idItem=" + idItem);
            }
            else if (e.CommandName == "EXCLUIR")
            {
                contextGame.TB_GAME.Remove(game);
                contextGame.SaveChanges();
                string msg = "Game excluido com sucesso!";
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