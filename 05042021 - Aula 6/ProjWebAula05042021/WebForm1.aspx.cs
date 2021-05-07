using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjWebAula05042021
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void GVFerramenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Ferramenta ferramenta = getData();
            var db = new FerramentaDB();

            //if (ferramenta.Id == 0)
            if (IdH.Value == "0")
            {
                if (db.Insert(ferramenta))
                {
                    LblMsg.Text = "Registro inserido!";
                    LoadGrid();
                }
                else
                    LblMsg.Text = "Erro ao inserir registro";
            }
            else
            {
                if (db.Update(ferramenta, int.Parse(IdH.Value)))
                {
                    LblMsg.Text = "Registro atualizado!";
                }
                else
                    LblMsg.Text = "Erro ao atualizar registro";
            }

            LoadGrid();
        }

        private Ferramenta getData()
        {
            return new Ferramenta()
            {
                Descricao = TxtDescricao.Text,
                Tipo = TxtTipo.Text,
                Marca = TxtMarca.Text,
                Preco = TxtPreco.Text
            };
        }

        private void LoadGrid()
        {
            GVFerramenta.DataSource = new FerramentaDB().GetAll();
            GVFerramenta.DataBind();
        }

        protected void GVFerramenta_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GVFerramenta.Rows[index];

            int id = Convert.ToInt32(row.Cells[0].Text);

            var db = new FerramentaDB();

            if (e.CommandName == "Excluir")
            {
                db.Delete(id);
                LoadGrid();

            }
            else if (e.CommandName == "Editar")
            {
                Ferramenta ferramenta = db.SelectById(id);

                TxtDescricao.Text = ferramenta.Descricao;
                TxtTipo.Text = ferramenta.Tipo;
                TxtMarca.Text = ferramenta.Marca;
                TxtPreco.Text = ferramenta.Preco;
                IdH.Value = ferramenta.Id.ToString();
            }
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            TxtDescricao.Text = "";
            TxtTipo.Text = "";
            TxtMarca.Text = "";
            TxtPreco.Text = "";
            IdH.Value = "0";
            TxtDescricao.Focus();
        }
    }
}