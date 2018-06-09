using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fornecedores.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Tipo_Click(object sender, EventArgs e)
        {

        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {

        }

        private void cbbTipo_Leave(object sender, EventArgs e)
        {
            if (cbbTipo.Text == "Física")
            {
                txtDocumento.Mask = "000,000,000-00";
            }
            else if (cbbTipo.Text == "Jurídica")
            {
                txtDocumento.Mask = "00,000,000/0000-00";
            }
            else
            {
                txtDocumento.Mask = "";
            }
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            string telefone = txtTelefone.Text;
            telefone = telefone.Replace(" ", "");
            telefone = telefone.Replace("-", "");

            if (telefone.Length == 5)
            {
                char[] telarray = txtTelefone.Text.ToCharArray();
                if (telarray[5].ToString() != "9")
                {
                    txtTelefone.Mask = "(99) 0000-0000";
                }
            }
        
            else
            {
                txtTelefone.Mask = "(99)00000-0000";
            }
        }
    
        private void Limpar()
        {
            txtNome.Clear();
            cbbTipo.SelectedIndex = -1;
            txtDocumento.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
        }
         private void AtuaçizaGrid()
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand();
            con.ConnectionString = Dadoos.StringDeConexao;

            da.SelectCommand.CommandText = "select * from DadosCadastrais";

            con.Open();

            da.SelectCommand.Connection = con;
            da.Fill(dt);
            dgvFornecedores.DataSource = dt;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string tipo = cbbTipo.Text;
            string documento = txtDocumento.Text;
            string telefone = txtTelefone.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Dadoos.StringDeConexao;

            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"insert into DadosCadastrais (nome, email, telefone, pessoa, documento) values (@nome, @email, @telefone, @pessoa, @documento)";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@pessoa", tipo);
            cmd.Parameters.AddWithValue("@documento", documento);

            con.Open();

            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();

            Limpar();

            AtuaçizaGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtuaçizaGrid();

        }
    }
}
