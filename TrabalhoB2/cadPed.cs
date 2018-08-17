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
    public partial class cadPed : Form
    {
        public cadPed()
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

        private void cadPed_Load(object sender, EventArgs e)
        {
            AtualizaGridCliente();
            AtualizaGridPedidos();
        }

        #region Grid Cliente
        private void AtualizaGridCliente()
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand();
            con.ConnectionString = dados.StringdeConexao;

            da.SelectCommand.CommandText = "select nome from cliente";

            con.Open();

            da.SelectCommand.Connection = con;
            da.Fill(dt);
            dgvCliente.DataSource = dt;
        }
        #endregion

        #region CellDoubleClick  DataGrid Cliente
        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCliente.Text = dgvCliente[0, dgvCliente.CurrentRow.Index].Value.ToString();
        }
        #endregion

        #region Buscar Cliente
        private void txtBuscaCli_TextChanged(object sender, EventArgs e)
        {
            string busca = txtBuscaCli.Text;

            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand();
            con.ConnectionString = dados.StringdeConexao;

            da.SelectCommand.CommandText = @"select nome from cliente where nome like @busca";

            da.SelectCommand.Parameters.AddWithValue("@busca", "%" + busca + "%");

            con.Open();

            da.SelectCommand.Connection = con;
            da.Fill(dt);
            dgvCliente.DataSource = dt;
        }
        #endregion

        #region Botão Finalizar Venda
        private void btnVender_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim().Length != 0)
            {
                MessageBox.Show("Esse pedido já está cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("Selecione o cliente no campo abaixo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDescricao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Digite a descrição do pedido do cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbbPagamento.Text.Trim().Length == 0)
            {
                MessageBox.Show("Selecione o meio de pagamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtValor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Digite o valor da compra!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string data = DateTime.Now.ToShortDateString();
                string cliente = txtCliente.Text;
                string descricao = txtDescricao.Text;
                string pagamento = cbbPagamento.Text;
                string valor = txtValor.Text;
                string qtdParcelas = txtParcelas.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = dados.StringdeConexao;

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"insert into pedidos (data, cliente, descricao, pagamento, valor, qtdParcelas)
                                            values (@data, @cliente, @descricao, @pagamento, @valor, @qtdParcelas)";

                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@cliente", cliente);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.Parameters.AddWithValue("@pagamento", pagamento);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@qtdParcelas", qtdParcelas);

                con.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Pedido Cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

                LimparCampos();

                AtualizaGridPedidos();
            }
        }
        #endregion

        #region Grid Pedidos
        private void AtualizaGridPedidos()
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand();
            con.ConnectionString = dados.StringdeConexao;

            da.SelectCommand.CommandText = "select * from pedidos";

            con.Open();

            da.SelectCommand.Connection = con;
            da.Fill(dt);
            dgvPedidos.DataSource = dt;
        }
        #endregion

        #region Botão Limpar Campos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        #endregion

        #region  Método Limpar Campos
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtData.Clear();
            txtCliente.Clear();
            txtDescricao.Clear();
            cbbPagamento.SelectedIndex = -1;
            txtValor.Clear();
            txtParcelas.Clear();
            txtPedido.Clear();
            txtBuscaCli.Clear();
            txtCliente.Focus();
        }

        #endregion

        #region CellDoubleClick dgvPedidos
        private void dgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvPedidos[0, dgvPedidos.CurrentRow.Index].Value.ToString();
            txtData.Text = dgvPedidos[1, dgvPedidos.CurrentRow.Index].Value.ToString();
            txtCliente.Text = dgvPedidos[2, dgvPedidos.CurrentRow.Index].Value.ToString();
            txtDescricao.Text = dgvPedidos[3, dgvPedidos.CurrentRow.Index].Value.ToString();
            cbbPagamento.Text = dgvPedidos[4, dgvPedidos.CurrentRow.Index].Value.ToString();
            txtValor.Text = dgvPedidos[5, dgvPedidos.CurrentRow.Index].Value.ToString();
            txtParcelas.Text = dgvPedidos[6, dgvPedidos.CurrentRow.Index].Value.ToString();
        }
        #endregion

        #region Botão Excluir Venda
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Selecione um pedido para ser excluido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = dados.StringdeConexao;

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"delete pedidos where codigo = @codigo";

                cmd.Parameters.AddWithValue("@codigo", codigo);

                con.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Pedido excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                con.Close();

                LimparCampos();

                AtualizaGridPedidos();
            }
        }
        #endregion

        #region Busca Pedidos
        private void txtPedido_TextChanged(object sender, EventArgs e)
        {
            string busca = txtPedido.Text;

            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = new SqlCommand();
            con.ConnectionString = dados.StringdeConexao;

            da.SelectCommand.CommandText = @"select * from pedidos where cliente like @busca";

            da.SelectCommand.Parameters.AddWithValue("@busca", "%" + busca + "%");

            con.Open();

            da.SelectCommand.Connection = con;
            da.Fill(dt);
            dgvPedidos.DataSource = dt;
        }
        #endregion
    }
}
