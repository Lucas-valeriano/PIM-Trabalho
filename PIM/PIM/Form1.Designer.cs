namespace PIM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaPrazoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parceiroDeNegócioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraçãoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarSetorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhaContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 32);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.compraToolStripMenuItem1,
            this.financeiroToolStripMenuItem,
            this.administraçãoDeUsuariosToolStripMenuItem,
            this.minhaContaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaVendaToolStripMenuItem,
            this.cadastrarClienteToolStripMenuItem,
            this.vendaPrazoToolStripMenuItem});
            this.vendaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // novaVendaToolStripMenuItem
            // 
            this.novaVendaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.novaVendaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.novaVendaToolStripMenuItem.Image = global::PIM.Properties.Resources.money_bag;
            this.novaVendaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            this.novaVendaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.novaVendaToolStripMenuItem.Text = "Venda";
            this.novaVendaToolStripMenuItem.Click += new System.EventHandler(this.novaVendaToolStripMenuItem_Click);
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.cadastrarClienteToolStripMenuItem.Image = global::PIM.Properties.Resources.add_user_to_social_network;
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Image = global::PIM.Properties.Resources.add_user_to_social_network;
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::PIM.Properties.Resources.users;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // vendaPrazoToolStripMenuItem
            // 
            this.vendaPrazoToolStripMenuItem.Image = global::PIM.Properties.Resources.buy;
            this.vendaPrazoToolStripMenuItem.Name = "vendaPrazoToolStripMenuItem";
            this.vendaPrazoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.vendaPrazoToolStripMenuItem.Text = "Venda prazo";
            this.vendaPrazoToolStripMenuItem.Click += new System.EventHandler(this.vendaPrazoToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem1});
            this.estoqueToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // estoqueToolStripMenuItem1
            // 
            this.estoqueToolStripMenuItem1.Image = global::PIM.Properties.Resources.warehouse;
            this.estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
            this.estoqueToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.estoqueToolStripMenuItem1.Text = "Estoque";
            this.estoqueToolStripMenuItem1.Click += new System.EventHandler(this.estoqueToolStripMenuItem1_Click);
            // 
            // compraToolStripMenuItem1
            // 
            this.compraToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProdutoToolStripMenuItem2,
            this.ordemDeCompraToolStripMenuItem,
            this.parceiroDeNegócioToolStripMenuItem});
            this.compraToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.compraToolStripMenuItem1.Name = "compraToolStripMenuItem1";
            this.compraToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.compraToolStripMenuItem1.Text = "Compra";
            // 
            // cadastrarProdutoToolStripMenuItem2
            // 
            this.cadastrarProdutoToolStripMenuItem2.Image = global::PIM.Properties.Resources.bag;
            this.cadastrarProdutoToolStripMenuItem2.Name = "cadastrarProdutoToolStripMenuItem2";
            this.cadastrarProdutoToolStripMenuItem2.Size = new System.Drawing.Size(179, 22);
            this.cadastrarProdutoToolStripMenuItem2.Text = "Cadastrar Produto";
            this.cadastrarProdutoToolStripMenuItem2.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem2_Click);
            // 
            // ordemDeCompraToolStripMenuItem
            // 
            this.ordemDeCompraToolStripMenuItem.Image = global::PIM.Properties.Resources.shopping_bag1;
            this.ordemDeCompraToolStripMenuItem.Name = "ordemDeCompraToolStripMenuItem";
            this.ordemDeCompraToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ordemDeCompraToolStripMenuItem.Text = "Ordem de compra";
            this.ordemDeCompraToolStripMenuItem.Click += new System.EventHandler(this.ordemDeCompraToolStripMenuItem_Click);
            // 
            // parceiroDeNegócioToolStripMenuItem
            // 
            this.parceiroDeNegócioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.editarToolStripMenuItem1});
            this.parceiroDeNegócioToolStripMenuItem.Image = global::PIM.Properties.Resources.delivery_truck;
            this.parceiroDeNegócioToolStripMenuItem.Name = "parceiroDeNegócioToolStripMenuItem";
            this.parceiroDeNegócioToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.parceiroDeNegócioToolStripMenuItem.Text = "Parceiro de negócio";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Image = global::PIM.Properties.Resources.deal;
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Image = global::PIM.Properties.Resources.employee;
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.editarToolStripMenuItem1.Text = "Editar";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.editarToolStripMenuItem1_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aReceberToolStripMenuItem});
            this.financeiroToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // aReceberToolStripMenuItem
            // 
            this.aReceberToolStripMenuItem.Image = global::PIM.Properties.Resources.change;
            this.aReceberToolStripMenuItem.Name = "aReceberToolStripMenuItem";
            this.aReceberToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.aReceberToolStripMenuItem.Text = "Venda efetuada";
            this.aReceberToolStripMenuItem.Click += new System.EventHandler(this.aReceberToolStripMenuItem_Click);
            // 
            // administraçãoDeUsuariosToolStripMenuItem
            // 
            this.administraçãoDeUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuariosToolStripMenuItem,
            this.cadastrarSetorToolStripMenuItem,
            this.cadastrarMetasToolStripMenuItem});
            this.administraçãoDeUsuariosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.administraçãoDeUsuariosToolStripMenuItem.Name = "administraçãoDeUsuariosToolStripMenuItem";
            this.administraçãoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.administraçãoDeUsuariosToolStripMenuItem.Text = "Administração de Usuarios";
            // 
            // cadastrarUsuariosToolStripMenuItem
            // 
            this.cadastrarUsuariosToolStripMenuItem.Image = global::PIM.Properties.Resources.businessman;
            this.cadastrarUsuariosToolStripMenuItem.Name = "cadastrarUsuariosToolStripMenuItem";
            this.cadastrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cadastrarUsuariosToolStripMenuItem.Text = "Cadastrar usuarios";
            this.cadastrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuariosToolStripMenuItem_Click);
            // 
            // cadastrarSetorToolStripMenuItem
            // 
            this.cadastrarSetorToolStripMenuItem.Image = global::PIM.Properties.Resources.folder;
            this.cadastrarSetorToolStripMenuItem.Name = "cadastrarSetorToolStripMenuItem";
            this.cadastrarSetorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cadastrarSetorToolStripMenuItem.Text = "Cadastrar setor";
            this.cadastrarSetorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarSetorToolStripMenuItem_Click);
            // 
            // cadastrarMetasToolStripMenuItem
            // 
            this.cadastrarMetasToolStripMenuItem.Image = global::PIM.Properties.Resources.goal;
            this.cadastrarMetasToolStripMenuItem.Name = "cadastrarMetasToolStripMenuItem";
            this.cadastrarMetasToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cadastrarMetasToolStripMenuItem.Text = "Cadastrar Metas";
            this.cadastrarMetasToolStripMenuItem.Click += new System.EventHandler(this.cadastrarMetasToolStripMenuItem_Click);
            // 
            // minhaContaToolStripMenuItem
            // 
            this.minhaContaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarSenhaToolStripMenuItem,
            this.logoffToolStripMenuItem});
            this.minhaContaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.minhaContaToolStripMenuItem.Name = "minhaContaToolStripMenuItem";
            this.minhaContaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.minhaContaToolStripMenuItem.Text = "Conta";
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Image = global::PIM.Properties.Resources.key;
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar senha";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Image = global::PIM.Properties.Resources.exit;
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.logoffToolStripMenuItem.Text = "Sair";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::PIM.Properties.Resources._62722;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 623);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.carregado);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ordemDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parceiroDeNegócioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraçãoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarSetorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minhaContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendaPrazoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
    }
}

