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
    public partial class cadForn : Form
    {
        public cadForn()
        {
            InitializeComponent();
        }

        #region Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            menuPrincipal menu = new menuPrincipal();

            this.Close();
            menu.Show();
        }

        #endregion

        #region Botão Cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "-")
            {
                MessageBox.Show("Fornecedor já cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else 
            if (txtRazao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Digite a Razão Social do Fornecedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if (txtCNPJ.Text == "  ,   ,   /    -")
            {
                MessageBox.Show("Digite o CNPJ do Fornecedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string razaoSocial = txtRazao.Text;
                string cnpj = txtCNPJ.Text;
                string nomeFantasia = txtFantasia.Text;
                string endereco = txtEndereco.Text;
                string bairro = txtBairro.Text;
                string cidade = txtCidade.Text;
                string UF = txtUF.Text;
                string email = txtEmail.Text;
                string produtos = txtProduto.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = dados.StringdeConexao;

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"insert into fornecedores (razaoSocial, cnpj, nomeFantasia,
                                                     endereco, bairro, cidade, estado,
                                                       email, mercadorias) values (@razaoSocial,
                                                            @cnpj, @nomeFantasia, @endereco, @bairro,
                                                                @cidade, @UF, @email, @produtos)";

                cmd.Parameters.AddWithValue("@razaoSocial", razaoSocial);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@nomeFantasia", nomeFantasia);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@UF", UF);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@produtos", produtos);

                con.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                con.Close();

                LimpaTela();

                AtualizaGrid();
            }            
        }
        #endregion

        #region Botão Atualizar
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "-")
            {
                MessageBox.Show("Selecione um Fornecedor para alterar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                string razaoSocial = txtRazao.Text;
                string cnpj = txtCNPJ.Text;
                string nomeFantasia = txtFantasia.Text;
                string endereco = txtEndereco.Text;
                string bairro = txtBairro.Text;
                string cidade = txtCidade.Text;
                string UF = txtUF.Text;
                string email = txtEmail.Text;
                string produtos = txtProduto.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = dados.StringdeConexao;

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"update fornecedores set razaoSocial = @razaoSocial,
                                cnpj = @cnpj, nomeFantasia = @nomeFantasia,
                                endereco = @endereco, bairro = @bairro,
                                cidade = @cidade, estado = @UF,
                                email = @email, mercadorias = @produtos
                                where codigo = @codigo";

                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@razaoSocial", razaoSocial);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@nomeFantasia", nomeFantasia);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@UF", UF);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@produtos", produtos);

                con.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Atualizados!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                con.Close();

                LimpaTela();

                AtualizaGrid();
            }            
        }
        #endregion

        #region Carregar o DataGrid quando abrir o Form
        private void cadForn_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }
        #endregion

        #region Método Atualiza Grid
        private void AtualizaGrid()
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand();
            con.ConnectionString = dados.StringdeConexao;

            da.SelectCommand.CommandText = "select * from fornecedores";

            con.Open();

            da.SelectCommand.Connection = con;
            da.Fill(dt);
            dgvFornecedor.DataSource = dt;
        }
        #endregion

        #region Metodo Limpar Tela
        private void LimpaTela()
        {
            txtCodigo.Text = "-";
            txtCNPJ.Clear();
            txtRazao.Clear();
            txtFantasia.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            txtEmail.Clear();
            txtProduto.Clear();
            txtFiltrar.Clear();
            txtRazao.Focus();
        }
        #endregion

        #region Botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }
        #endregion

        #region CellDoubleClick dgvFonecedor
        private void dgvFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvFornecedor[0, dgvFornecedor.CurrentRow.Index].Value.ToString();
            txtRazao.Text = dgvFornecedor[1, dgvFornecedor.CurrentRow.Index].Value.ToString();
            txtCNPJ.Text = dgvFornecedor[2, dgvFornecedor.CurrentRow.Index].Value.ToString();
            txtFantasia.Text = dgvFornecedor[3, dgvFornecedor.CurrentRow.Index].Value.ToString();
            txtEndereco.Text = dgvFornecedor[4, dgvFornecedor.CurrentRow.Index].Value.ToString();
            txtBairro.Text = dgvFornecedor[5, dgvFornecedor.CurrentRow.Index].Value.ToString();
            txtCidade.Text = dgvFornecedor[6, dgvFornecedor.CurrentRow.Index].Value.ToString();
            txtUF.Text = dgvFornecedor[7, dgvFornecedor.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dgvFornecedor[8, dgvFornecedor.CurrentRow.Index].Value.ToString();
            txtProduto.Text = dgvFornecedor[9, dgvFornecedor.CurrentRow.Index].Value.ToString();
        }
        #endregion

        #region Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "-")
            {
                MessageBox.Show("Selecione um Fornecedor para excluir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = dados.StringdeConexao;

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"delete fornecedores where codigo = @codigo";

                cmd.Parameters.AddWithValue("@codigo", codigo);

                con.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor Excluido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                con.Close();

                LimpaTela();

                AtualizaGrid();
            }            
        }
        #endregion

        #region Filtro de Busca
        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            string busca = txtFiltrar.Text;

            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand();
            con.ConnectionString = dados.StringdeConexao;

            da.SelectCommand.CommandText = @"select * from fornecedores where
                                                razaoSocial like @busca";

            da.SelectCommand.Parameters.AddWithValue("@busca", "%" + busca + "%");

            con.Open();

            da.SelectCommand.Connection = con;
            da.Fill(dt);
            dgvFornecedor.DataSource = dt;
        }
        #endregion
    }
}