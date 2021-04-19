using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ProjCadastro
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=DESKTOP-SFCGB24;Initial Catalog=Lanchonete;Integrated Security=True";
            con.Open();
            if (!Page.IsPostBack)
            {
                DataShow();
            }
        }

        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * From Lanche";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }


        protected void btnCriar_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert into Lanche (Nome,Descricao,Valor)values('" + TxtNome.Text.ToString() + "','" + TxtDescricao.Text.ToString() + "','" + TxtValor.Text.ToString() + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();


        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "delete from Lanche where Nome='" + TxtNome.Text.ToString() + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Lanche set Nome='" + TxtNome.Text.ToString() + "',Descricao='" + TxtDescricao.Text.ToString() + "',Valor='" + TxtValor.Text.ToString() + "' where Nome='" + TxtNome.Text.ToString() + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }
    }
}