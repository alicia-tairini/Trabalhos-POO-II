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

namespace TrabalhoB2
{
    public partial class cadCli : Form
    {
        public cadCli()
        {
            InitializeComponent();
        }

        #region Botão Cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "-")
            {
                MessageBox.Show("Esse cliente já está cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                if (txtNome.Text == "")
                {
                    MessageBox.Show("Digite o nome do cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string nome = txtNome.Text;
                    string endereco = txtEndereco.Text;
                    string bairro = txtBairro.Text;
                    string cidade = txtCidade.Text;
                    string email = txtEmail.Text;
                    string telefone = txtTelefone.Text;
                    string cpf = txtCPF.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = dados.StringdeConexao;

                    var cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = @"insert into cliente (nome, endereco, bairro, cidade, email, telefone, cpf)
                                        values (@nome, @endereco, @bairro, @cidade, @email, @telefone, @cpf)";

                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@bairro", bairro);
                    cmd.Parameters.AddWithValue("@cidade", cidade);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@cpf", cpf);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente Cadastrado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();

                    Limpar();

                    AtualizaGrid();
                }
            
            }
        }
        #endregion

        #region Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            menuPrincipal menu = new menuPrincipal();

            this.Close();
            menu.Show();
        }
        #endregion

        #region Botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region Método Limpar
        private void Limpar()
        {
            txtCodigo.Text = "-";
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCPF.Clear();
            txtFiltro.Clear();
            txtNome.Focus();
        }
        #endregion

        #region Alterar Máscara Telefone
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
                else
                {
                    txtTelefone.Mask = "(99) 00000-0000";
                }
            }
        }
        #endregion

        #region Carregar DataGrid
        private void cadCli_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }
        #endregion

        #region Método AtualizaGrid
        private void AtualizaGrid()
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand();
            con.ConnectionString = dados.StringdeConexao;

            da.SelectCommand.CommandText = "select *  from cliente";

            con.Open();

            da.SelectCommand.Connection = con;
            da.Fill(dt);
            dgvCliente.DataSource = dt;
        }
        #endregion

        #region Carregar dados do DataGrid para campos no Form
        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvCliente[0, dgvCliente.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvCliente[1, dgvCliente.CurrentRow.Index].Value.ToString();
            txtEndereco.Text = dgvCliente[2, dgvCliente.CurrentRow.Index].Value.ToString();
            txtBairro.Text = dgvCliente[3, dgvCliente.CurrentRow.Index].Value.ToString();
            txtCidade.Text = dgvCliente[4, dgvCliente.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dgvCliente[5, dgvCliente.CurrentRow.Index].Value.ToString();
            txtTelefone.Text = dgvCliente[6, dgvCliente.CurrentRow.Index].Value.ToString();
            txtCPF.Text = dgvCliente[7, dgvCliente.CurrentRow.Index].Value.ToString();
            txtFiltro.Clear();
        }
        #endregion

        #region Botão Alterar
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Selecione um registro para alterar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                string nome = txtNome.Text;
                string endereco = txtEndereco.Text;
                string bairro = txtBairro.Text;
                string cidade = txtCidade.Text;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;
                string cpf = txtCPF.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = dados.StringdeConexao;

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"update cliente set nome = @nome,
                                                    endereco = @endereco,
                                                    bairro = @bairro,
                                                    cidade = @cidade,
                                                    email = @email,
                                                    telefone = @telefone,
                                                    cpf = @cpf
                                                    where codigo = @codigo";

                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@cpf", cpf);

                con.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

                Limpar();

                AtualizaGrid();
            }            
        }
        #endregion

        #region Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Selecione um registro para excluir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = dados.StringdeConexao;

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"delete cliente where codigo = @codigo";

                cmd.Parameters.AddWithValue("@codigo", codigo);

                con.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente excluido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

                Limpar();

                AtualizaGrid();
            }            
        }
        #endregion

        #region Pesquisar um cliente (Buscar)
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string busca = txtFiltro.Text;

            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand();
            con.ConnectionString = dados.StringdeConexao;

            da.SelectCommand.CommandText = @"select * from cliente where nome like @busca";

            da.SelectCommand.Parameters.AddWithValue("@busca", "%" + busca + "%");

            con.Open();

            da.SelectCommand.Connection = con;
            da.Fill(dt);
            dgvCliente.DataSource = dt;
        }
        #endregion
    }
}
