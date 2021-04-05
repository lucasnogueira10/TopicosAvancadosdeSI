using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjWFFerramentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // LoadGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var ferramenta = getFerramenta();
            if (Crud().Insert(ferramenta))
            {
                MessageBox.Show("Inserido com sucesso!");
                LoadGrid();
            }
        }

        private void LoadGrid()
        {
            dGVDados.DataSource = Crud().GetAll();
        }

        private Ferramenta getFerramenta()
        {
            return new Ferramenta
            {
                Id = int.Parse(txtId.Text),
                Descricao = txtDescricao.Text,
                Tipo = txtTipo.Text,
                Marca = txtMarca.Text,
                Preco = txtPreco.Text
            };
        }

        private IFerramentaDB Crud()
        {
            return new FerramentaDB();
        }

        private void btnGerarTxt_Click(object sender, EventArgs e)
        {
            StreamWriter x;
            var ferramenta = getFerramenta();
            string output = "";

            string CaminhoNome = "C:\\TopicosAvancadosEmSistemasDeInformacao\\SolutionExercicio29032021\\Ferramentas.txt";

            x = File.CreateText(CaminhoNome);

            foreach (var item in Crud().GetAll())
                output += item.ToString();
            
            x.WriteLine(output);

            x.Close();
            MessageBox.Show("Arquivo criado com sucesso no seguinte diretório:\n\n" + CaminhoNome);
        }
    }
}
