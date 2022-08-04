namespace projeto_2_guilherme_ana_ana
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblmake = new System.Windows.Forms.Label();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtCategoriaCadastro = new System.Windows.Forms.TextBox();
            this.txtFornecedorCadastro = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFornecedorCadastro = new System.Windows.Forms.Label();
            this.txtProdutoCadastro = new System.Windows.Forms.TextBox();
            this.lblProdutoCadastro = new System.Windows.Forms.Label();
            this.dgvTabelaDeProdutos = new System.Windows.Forms.DataGridView();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.txtEstoqueEditar = new System.Windows.Forms.TextBox();
            this.lblEstoqueEditar = new System.Windows.Forms.Label();
            this.txtPrecoEditar = new System.Windows.Forms.TextBox();
            this.lblPrecoEditar = new System.Windows.Forms.Label();
            this.txtCategoriaEditar = new System.Windows.Forms.TextBox();
            this.txtFornecedorEditar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblCategoriaEditar = new System.Windows.Forms.Label();
            this.lblFornecedorEditar = new System.Windows.Forms.Label();
            this.txtProdutoEditar = new System.Windows.Forms.TextBox();
            this.lblProdutoEditar = new System.Windows.Forms.Label();
            this.grbExcluir = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblEscloi = new System.Windows.Forms.Label();
            this.grbCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaDeProdutos)).BeginInit();
            this.grbEditar.SuspendLayout();
            this.grbExcluir.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmake
            // 
            this.lblmake.AutoSize = true;
            this.lblmake.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmake.Location = new System.Drawing.Point(296, 18);
            this.lblmake.Name = "lblmake";
            this.lblmake.Size = new System.Drawing.Size(215, 31);
            this.lblmake.TabIndex = 0;
            this.lblmake.Text = "GAA MAKE UP";
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.txtEstoque);
            this.grbCadastrar.Controls.Add(this.lblEstoque);
            this.grbCadastrar.Controls.Add(this.txtPreco);
            this.grbCadastrar.Controls.Add(this.lblPreco);
            this.grbCadastrar.Controls.Add(this.txtCategoriaCadastro);
            this.grbCadastrar.Controls.Add(this.txtFornecedorCadastro);
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.lblCategoria);
            this.grbCadastrar.Controls.Add(this.lblFornecedorCadastro);
            this.grbCadastrar.Controls.Add(this.txtProdutoCadastro);
            this.grbCadastrar.Controls.Add(this.lblProdutoCadastro);
            this.grbCadastrar.Location = new System.Drawing.Point(35, 68);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(232, 318);
            this.grbCadastrar.TabIndex = 1;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastro de produtos:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(82, 190);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(121, 20);
            this.txtEstoque.TabIndex = 12;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(16, 190);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(49, 13);
            this.lblEstoque.TabIndex = 11;
            this.lblEstoque.Text = "Estoque:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(82, 148);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(121, 20);
            this.txtPreco.TabIndex = 10;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(13, 148);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 9;
            this.lblPreco.Text = "Preço:";
            // 
            // txtCategoriaCadastro
            // 
            this.txtCategoriaCadastro.Location = new System.Drawing.Point(82, 102);
            this.txtCategoriaCadastro.Name = "txtCategoriaCadastro";
            this.txtCategoriaCadastro.Size = new System.Drawing.Size(121, 20);
            this.txtCategoriaCadastro.TabIndex = 8;
            // 
            // txtFornecedorCadastro
            // 
            this.txtFornecedorCadastro.Location = new System.Drawing.Point(82, 67);
            this.txtFornecedorCadastro.Name = "txtFornecedorCadastro";
            this.txtFornecedorCadastro.Size = new System.Drawing.Size(121, 20);
            this.txtFornecedorCadastro.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(36, 236);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(157, 53);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(13, 109);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblFornecedorCadastro
            // 
            this.lblFornecedorCadastro.AutoSize = true;
            this.lblFornecedorCadastro.Location = new System.Drawing.Point(9, 70);
            this.lblFornecedorCadastro.Name = "lblFornecedorCadastro";
            this.lblFornecedorCadastro.Size = new System.Drawing.Size(64, 13);
            this.lblFornecedorCadastro.TabIndex = 2;
            this.lblFornecedorCadastro.Text = "Fornecedor:";
            // 
            // txtProdutoCadastro
            // 
            this.txtProdutoCadastro.Location = new System.Drawing.Point(82, 30);
            this.txtProdutoCadastro.Name = "txtProdutoCadastro";
            this.txtProdutoCadastro.Size = new System.Drawing.Size(121, 20);
            this.txtProdutoCadastro.TabIndex = 1;
            // 
            // lblProdutoCadastro
            // 
            this.lblProdutoCadastro.AutoSize = true;
            this.lblProdutoCadastro.Location = new System.Drawing.Point(7, 30);
            this.lblProdutoCadastro.Name = "lblProdutoCadastro";
            this.lblProdutoCadastro.Size = new System.Drawing.Size(47, 13);
            this.lblProdutoCadastro.TabIndex = 0;
            this.lblProdutoCadastro.Text = "Produto:";
            // 
            // dgvTabelaDeProdutos
            // 
            this.dgvTabelaDeProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelaDeProdutos.Location = new System.Drawing.Point(604, 68);
            this.dgvTabelaDeProdutos.Name = "dgvTabelaDeProdutos";
            this.dgvTabelaDeProdutos.Size = new System.Drawing.Size(357, 230);
            this.dgvTabelaDeProdutos.TabIndex = 2;
            this.dgvTabelaDeProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelaDeProdutos_CellClick);
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.txtEstoqueEditar);
            this.grbEditar.Controls.Add(this.lblEstoqueEditar);
            this.grbEditar.Controls.Add(this.txtPrecoEditar);
            this.grbEditar.Controls.Add(this.lblPrecoEditar);
            this.grbEditar.Controls.Add(this.txtCategoriaEditar);
            this.grbEditar.Controls.Add(this.txtFornecedorEditar);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.lblCategoriaEditar);
            this.grbEditar.Controls.Add(this.lblFornecedorEditar);
            this.grbEditar.Controls.Add(this.txtProdutoEditar);
            this.grbEditar.Controls.Add(this.lblProdutoEditar);
            this.grbEditar.Location = new System.Drawing.Point(302, 68);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(232, 318);
            this.grbEditar.TabIndex = 3;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar produto:";
            // 
            // txtEstoqueEditar
            // 
            this.txtEstoqueEditar.Location = new System.Drawing.Point(82, 190);
            this.txtEstoqueEditar.Name = "txtEstoqueEditar";
            this.txtEstoqueEditar.Size = new System.Drawing.Size(121, 20);
            this.txtEstoqueEditar.TabIndex = 12;
            // 
            // lblEstoqueEditar
            // 
            this.lblEstoqueEditar.AutoSize = true;
            this.lblEstoqueEditar.Location = new System.Drawing.Point(16, 190);
            this.lblEstoqueEditar.Name = "lblEstoqueEditar";
            this.lblEstoqueEditar.Size = new System.Drawing.Size(49, 13);
            this.lblEstoqueEditar.TabIndex = 11;
            this.lblEstoqueEditar.Text = "Estoque:";
            // 
            // txtPrecoEditar
            // 
            this.txtPrecoEditar.Location = new System.Drawing.Point(82, 148);
            this.txtPrecoEditar.Name = "txtPrecoEditar";
            this.txtPrecoEditar.Size = new System.Drawing.Size(121, 20);
            this.txtPrecoEditar.TabIndex = 10;
            // 
            // lblPrecoEditar
            // 
            this.lblPrecoEditar.AutoSize = true;
            this.lblPrecoEditar.Location = new System.Drawing.Point(13, 148);
            this.lblPrecoEditar.Name = "lblPrecoEditar";
            this.lblPrecoEditar.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoEditar.TabIndex = 9;
            this.lblPrecoEditar.Text = "Preço:";
            // 
            // txtCategoriaEditar
            // 
            this.txtCategoriaEditar.Location = new System.Drawing.Point(82, 102);
            this.txtCategoriaEditar.Name = "txtCategoriaEditar";
            this.txtCategoriaEditar.Size = new System.Drawing.Size(121, 20);
            this.txtCategoriaEditar.TabIndex = 8;
            // 
            // txtFornecedorEditar
            // 
            this.txtFornecedorEditar.Location = new System.Drawing.Point(82, 67);
            this.txtFornecedorEditar.Name = "txtFornecedorEditar";
            this.txtFornecedorEditar.Size = new System.Drawing.Size(121, 20);
            this.txtFornecedorEditar.TabIndex = 7;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(36, 236);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 53);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblCategoriaEditar
            // 
            this.lblCategoriaEditar.AutoSize = true;
            this.lblCategoriaEditar.Location = new System.Drawing.Point(13, 109);
            this.lblCategoriaEditar.Name = "lblCategoriaEditar";
            this.lblCategoriaEditar.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaEditar.TabIndex = 4;
            this.lblCategoriaEditar.Text = "Categoria:";
            // 
            // lblFornecedorEditar
            // 
            this.lblFornecedorEditar.AutoSize = true;
            this.lblFornecedorEditar.Location = new System.Drawing.Point(9, 70);
            this.lblFornecedorEditar.Name = "lblFornecedorEditar";
            this.lblFornecedorEditar.Size = new System.Drawing.Size(64, 13);
            this.lblFornecedorEditar.TabIndex = 2;
            this.lblFornecedorEditar.Text = "Fornecedor:";
            // 
            // txtProdutoEditar
            // 
            this.txtProdutoEditar.Location = new System.Drawing.Point(82, 30);
            this.txtProdutoEditar.Name = "txtProdutoEditar";
            this.txtProdutoEditar.Size = new System.Drawing.Size(121, 20);
            this.txtProdutoEditar.TabIndex = 1;
            // 
            // lblProdutoEditar
            // 
            this.lblProdutoEditar.AutoSize = true;
            this.lblProdutoEditar.Location = new System.Drawing.Point(7, 30);
            this.lblProdutoEditar.Name = "lblProdutoEditar";
            this.lblProdutoEditar.Size = new System.Drawing.Size(47, 13);
            this.lblProdutoEditar.TabIndex = 0;
            this.lblProdutoEditar.Text = "Produto:";
            // 
            // grbExcluir
            // 
            this.grbExcluir.Controls.Add(this.btnExcluir);
            this.grbExcluir.Controls.Add(this.lblEscloi);
            this.grbExcluir.Enabled = false;
            this.grbExcluir.Location = new System.Drawing.Point(612, 314);
            this.grbExcluir.Name = "grbExcluir";
            this.grbExcluir.Size = new System.Drawing.Size(349, 72);
            this.grbExcluir.TabIndex = 4;
            this.grbExcluir.TabStop = false;
            this.grbExcluir.Text = "Excluir produtos:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.Color.Brown;
            this.btnExcluir.Location = new System.Drawing.Point(203, 22);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(119, 29);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "APAGAR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblEscloi
            // 
            this.lblEscloi.AutoSize = true;
            this.lblEscloi.Location = new System.Drawing.Point(7, 30);
            this.lblEscloi.Name = "lblEscloi";
            this.lblEscloi.Size = new System.Drawing.Size(190, 13);
            this.lblEscloi.TabIndex = 0;
            this.lblEscloi.Text = "Deseja apagar o produto selecionado?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 413);
            this.Controls.Add(this.grbExcluir);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.dgvTabelaDeProdutos);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.lblmake);
            this.Name = "Form1";
            this.Text = "GAA MAKE UP";
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaDeProdutos)).EndInit();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbExcluir.ResumeLayout(false);
            this.grbExcluir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmake;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.Label lblFornecedorCadastro;
        private System.Windows.Forms.TextBox txtProdutoCadastro;
        private System.Windows.Forms.Label lblProdutoCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoriaCadastro;
        private System.Windows.Forms.TextBox txtFornecedorCadastro;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.DataGridView dgvTabelaDeProdutos;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.TextBox txtEstoqueEditar;
        private System.Windows.Forms.Label lblEstoqueEditar;
        private System.Windows.Forms.TextBox txtPrecoEditar;
        private System.Windows.Forms.Label lblPrecoEditar;
        private System.Windows.Forms.TextBox txtCategoriaEditar;
        private System.Windows.Forms.TextBox txtFornecedorEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblCategoriaEditar;
        private System.Windows.Forms.Label lblFornecedorEditar;
        private System.Windows.Forms.TextBox txtProdutoEditar;
        private System.Windows.Forms.Label lblProdutoEditar;
        private System.Windows.Forms.GroupBox grbExcluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblEscloi;
    }
}

