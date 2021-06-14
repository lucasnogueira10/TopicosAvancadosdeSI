using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectP2
{
    public partial class Game : System.Web.UI.Page
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
            string nomeGame = txtNome.Text;
            string descricaoGame = txtDescricao.Text;

            TB_GAME v = new TB_GAME()
            {
                nome = nomeGame,
                descricao = descricaoGame
                
            };
            GameDBEntities contextGame = new GameDBEntities();

            string valor = Request.QueryString["idItem"];

            if (String.IsNullOrEmpty(valor))
            {
                contextGame.TB_GAME.Add(v);
                lblmsg.Text = "Registro Inserido!";
                Clear();
            }
            else
            {
                int id = Convert.ToInt32(valor);
                TB_GAME game = contextGame.TB_GAME.First(c => c.id == id);
                game.nome = v.nome;
                game.descricao = v.descricao;
                lblmsg.Text = "Registro alterado!";
            }

            contextGame.SaveChanges();
        }

        private void Clear()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtDescricao.Focus();
        }



        private void CarregarDadosPagina()
        {
            string valor = Request.QueryString["idItem"];
            int idItem = 0;

            TB_GAME game = new TB_GAME();
            GameDBEntities contextGame = new GameDBEntities();

            if (!String.IsNullOrEmpty(valor))
            {
                idItem = Convert.ToInt32(valor);
                game = contextGame.TB_GAME.First(c => c.id == idItem);

                txtNome.Text = game.nome;
                txtDescricao.Text = game.descricao;
               
            }
        }
    }
}