using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _24052021AgendaConsulta
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDadosPagina();
            }
        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            string horarioConsulta = txtHorario.Text;

            TB_CONSULTA v = new TB_CONSULTA()
            {
                horario = horarioConsulta,
                id_consulta = string.IsNullOrEmpty(HFId.Value) ? 0 : int.Parse(HFId.Value)

            };
            ConsultaDBEntities contextConsulta = new ConsultaDBEntities();

            string valor = Request.QueryString["idItem"];

            if (String.IsNullOrEmpty(valor))
            {
                contextConsulta.TB_CONSULTA.Add(v);
                lblmsg.Text = "Consulta Inserida!";
                Clear();
            }
            else
            {
                int id = Convert.ToInt32(valor);
                TB_CONSULTA consulta = contextConsulta.TB_CONSULTA.First(c => c.id == id);
                consulta.horario = v.horario;

                lblmsg.Text = "Consulta alterada!";
            }

            contextConsulta.SaveChanges();
        }

        private void Clear()
        {
            txtHorario.Text = "";
            txtHorario.Focus();
        }

        private void CarregarDadosPagina()
        {
            string valor = Request.QueryString["idItem"];
            int idItem = 0;

            TB_CONSULTA consulta = new TB_CONSULTA();
            ConsultaDBEntities contextConsulta = new ConsultaDBEntities();

            if (!String.IsNullOrEmpty(valor))
            {
                idItem = Convert.ToInt32(valor);
                consulta = contextConsulta.TB_CONSULTA.First(c => c.id == idItem);

                txtHorario.Text = consulta.horario;
                
            }
        }


        protected void HFId_ValueChanged(object sender, EventArgs e)
        {

        }

        protected void GVClient_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var db = new ConsultaDBEntities();
            int index = Convert.ToInt32(e.CommandArgument);
            var row = GVClient.Rows[index];

            int idConsulta = int.Parse(row.Cells[0].Text);
            Consulta consulta = db.SelectById(idConsulta);

            if (e.CommandName == "EXCLUIR")
            {
                db.Delete(consulta.id_consulta);
                LoadGrid();
            }
            else if (e.CommandName == "ALTERAR")
            {
                txtHorario.Text = consulta.horario;
 
                HFId.Value = consulta.Id_consulta.ToString();
            }
        }
        public List<Consulta> SelectAll()
        {
            string sql = Consulta.SELECTALL;
            List<Consulta> consultas;

            using (var connection = new ConsultaDBEntities())
            {
                consultas = TransformSQLDataReaderToList(connection.ExecQueryReturn(sql));
            }
            return consultas;
        }
        private void LoadGrid()
        {
            GVClient.DataSource = new ConsultaDBEntities().SelectAll();
            GVClient.DataBind();
        }

    }

}