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

namespace Agenda_Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = dados.Stringdeconexao;

            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"insert into agenda (nome, email, telefone) 
                                values (@nome, @email, @telefone)";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefone", telefone);

            con.Open();

            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();

            limpeza();

            AtualizaGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand();

            con.ConnectionString = dados.Stringdeconexao;
            da.SelectCommand.CommandText = "select * from agenda";

            con.Open();

            da.SelectCommand.Connection = con;
            da.Fill(dt);
            dgvAgenda.DataSource = dt;
        }

        public void limpeza()
        {
                txtCodigo.Clear();
                txtEmail.Clear();
                txtNome.Clear();
                txtTelefone.Clear();
            }

        #region Botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpeza();
            btnIncluir.Enabled = true;
        }
        #endregion

        private void dgvAgenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvAgenda[0, dgvAgenda.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvAgenda[1, dgvAgenda.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dgvAgenda[2, dgvAgenda.CurrentRow.Index].Value.ToString();
            txtTelefone.Text = dgvAgenda[3, dgvAgenda.CurrentRow.Index].Value.ToString();
            btnIncluir.Enabled = false;
        }

        private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione um item", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            else
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = dados.Stringdeconexao;

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"update agenda
                                set nome = @nome,
                                email = @email,
                                telefone = @telefone
                                where codigo = @codigo";

                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);

                con.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro alterado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

                limpeza();

                AtualizaGrid();

                btnIncluir.Enabled = true;
            }
        }

           

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione um item", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = dados.Stringdeconexao;

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"delete agenda
                                where codigo = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);

                con.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro excluido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

                limpeza();

                AtualizaGrid();

            }
            }



        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string busca = txtFiltrar.Text;

            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand();
            con.ConnectionString = dados.Stringdeconexao;

            da.SelectCommand.CommandText = @"select *
                                             from agenda
                                             where nome like @busca";
            da.SelectCommand.Parameters.AddWithValue("@busca", "%" + busca + "%");

            con.Open();
            da.SelectCommand.Connection = con;
            da.Fill(dt);
            dgvAgenda.DataSource = dt;

        }
    }
}
