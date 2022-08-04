using MySqlConnector;
using projeto_2_guilherme_ana_ana.Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_2_guilherme_ana_ana
{
    public partial class Form1 : Form
    {
        private int _idSelecionado;

        public Form1()
        {
            InitializeComponent();

            dgvTabelaDeProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var p = new Produtos();
            var valida = txtProdutoCadastro.Text.Length >= 1 &&
                txtFornecedorCadastro.Text.Length >= 1 &&
                txtCategoriaCadastro.Text.Length >= 1;


            if (valida)
            {
                p.Produto = txtProdutoCadastro.Text;
                p.fornecedor = int.Parse(txtFornecedorCadastro.Text);
                p.categoria = int.Parse(txtCategoriaCadastro.Text);
                p.preco = double.Parse(txtPreco.Text);
                p.estoque = int.Parse(txtEstoque.Text);

                if (ProdutoDAO.Cadastrar(p) == true)
                {
                    MessageBox.Show("Produto Cadastrado!");
                    txtProdutoCadastro.Clear();
                    txtFornecedorCadastro.Clear();
                    txtCategoriaCadastro.Clear();
                    txtPreco.Clear();
                    txtEstoque.Clear();

                }

                else
                {
                    MessageBox.Show("Houve um erro no cadastro. " +
                        "Verifique as informações digitadas");
                }

            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.");
            }
            dgvTabelaDeProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var p = new Produtos();

            p.Produto = txtProdutoEditar.Text;
            p.fornecedor = int.Parse(txtFornecedorEditar.Text);
            p.categoria = int.Parse(txtCategoriaEditar.Text);
            p.preco = double.Parse(txtPrecoEditar.Text);
            p.estoque = int.Parse(txtEstoqueEditar.Text);
            p.id = _idSelecionado;


            // Chamar a modificar:
            if (Banco.ProdutoDAO.Modificar(p))
            {
                MessageBox.Show("Produto modificado com sucesso!");
                // Limpar os campos:
                txtProdutoEditar.Clear();
                txtFornecedorEditar.Clear();
                txtCategoriaEditar.Clear();
                txtPrecoEditar.Clear();
                txtEstoqueEditar.Clear();


            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.");
            }
            dgvTabelaDeProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();

        }



        private void dgvTabelaDeProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mostrar o groupbox de editar:
            grbEditar.Enabled = true;
            grbExcluir.Enabled = true;

            // Descobrir  o numero da linha da célula clicada:
            int numeroLinha = dgvTabelaDeProdutos.CurrentCell.RowIndex;
            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvTabelaDeProdutos.Rows[numeroLinha];

            // variaveis que vão receber os valores da linha selecionada:
            string ProdutoSelecionado = linha.Cells[1].Value.ToString();
            string categoriaSelecionada = linha.Cells[5].Value.ToString();
            string FornecedorSelecionado = linha.Cells[4].Value.ToString();
            string PrecoSelecionado = linha.Cells[2].Value.ToString();
            string EstoqueSelecionado = linha.Cells[3].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());

            // Atribuir os valores das células ao txb do editar:
            txtProdutoEditar.Text = ProdutoSelecionado;
            txtCategoriaEditar.Text = categoriaSelecionada;
            txtFornecedorEditar.Text = FornecedorSelecionado;
            txtPrecoEditar.Text = PrecoSelecionado;
            txtEstoqueEditar.Text = EstoqueSelecionado;

            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Confirmar remoção:
            var r = MessageBox.Show("Deseja realmente apagar?",
                "ATENÇÃO!", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                Banco.ProdutoDAO.ApagarPorID(_idSelecionado);
            }

            // Limpar lblApagar
            lblEscloi.Text = "";
            grbExcluir.Enabled = false;
            // Desabilitar editar:
            grbEditar.Enabled = false;

            // Atualiuzar o dgv 
            dgvTabelaDeProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();

        }

        
    }
}
    
    
    


