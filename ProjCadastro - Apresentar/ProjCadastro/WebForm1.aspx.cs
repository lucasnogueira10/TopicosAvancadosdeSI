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
    public partial class WebForm1 : System.Web.UI.Page
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
            cmd.CommandText = "Select * From tableLanchonete";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }

  
        protected void btnPedir_Click1(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert into tableLanchonete (Nome,Telefone,Lanche,Endereco)values('" + TxtNome.Text.ToString() + "','" + TxtTelefone.Text.ToString() + "','" + TxtLanche.Text.ToString() + "','" + TxtEndereço.Text.ToString() + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();


        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "delete from tableLanchonete where Nome='" + TxtNome.Text.ToString() + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update tableLanchonete set Nome='" + TxtNome.Text.ToString()+"',Telefone='"+TxtTelefone.Text.ToString()+"',Lanche='" +TxtLanche.Text.ToString()+"',Endereco='"+TxtEndereço.Text.ToString()+"' where Nome='"+TxtNome.Text.ToString()+"'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }
    }
}