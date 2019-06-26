namespace Mecanica2
{
    partial class ClienteLstView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCliente = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu = new System.Windows.Forms.ToolStrip();
            this.menuAgenda = new System.Windows.Forms.ToolStripLabel();
            this.menuAtendimento = new System.Windows.Forms.ToolStripLabel();
            this.menuCliente = new System.Windows.Forms.ToolStripLabel();
            this.menuProfissional = new System.Windows.Forms.ToolStripLabel();
            this.menuRelatorios = new System.Windows.Forms.ToolStripLabel();
            this.menuServico = new System.Windows.Forms.ToolStripLabel();
            this.menuSair = new System.Windows.Forms.ToolStripLabel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listCliente
            // 
            this.listCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listCliente.Location = new System.Drawing.Point(27, 91);
            this.listCliente.Name = "listCliente";
            this.listCliente.Size = new System.Drawing.Size(649, 228);
            this.listCliente.TabIndex = 0;
            this.listCliente.UseCompatibleStateImageBehavior = false;
            this.listCliente.View = System.Windows.Forms.View.Details;
            this.listCliente.SelectedIndexChanged += new System.EventHandler(this.listCliente_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 161;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CPF";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E-mail";
            this.columnHeader3.Width = 137;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefone";
            this.columnHeader4.Width = 79;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Situação";
            this.columnHeader5.Width = 144;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgenda,
            this.menuAtendimento,
            this.menuCliente,
            this.menuProfissional,
            this.menuRelatorios,
            this.menuServico,
            this.menuSair});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 25);
            this.menu.TabIndex = 28;
            this.menu.Text = "toolStrip1";
            // 
            // menuAgenda
            // 
            this.menuAgenda.Name = "menuAgenda";
            this.menuAgenda.Size = new System.Drawing.Size(48, 22);
            this.menuAgenda.Text = "Agenda";
            // 
            // menuAtendimento
            // 
            this.menuAtendimento.Name = "menuAtendimento";
            this.menuAtendimento.Size = new System.Drawing.Size(82, 22);
            this.menuAtendimento.Text = "Atendimentos";
            // 
            // menuCliente
            // 
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(49, 22);
            this.menuCliente.Text = "Clientes";
            this.menuCliente.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // menuProfissional
            // 
            this.menuProfissional.Name = "menuProfissional";
            this.menuProfissional.Size = new System.Drawing.Size(73, 22);
            this.menuProfissional.Text = "Profissionais";
            this.menuProfissional.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(59, 22);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // menuServico
            // 
            this.menuServico.Name = "menuServico";
            this.menuServico.Size = new System.Drawing.Size(50, 22);
            this.menuServico.Text = "Serviços";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(26, 22);
            this.menuSair.Text = "Sair";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(588, 28);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 34);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "Novo";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ClienteLstView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.listCliente);
            this.Name = "ClienteLstView";
            this.Text = "ClienteLstView";
            this.Load += new System.EventHandler(this.ClienteLstView_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listCliente;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripLabel menuAgenda;
        private System.Windows.Forms.ToolStripLabel menuAtendimento;
        private System.Windows.Forms.ToolStripLabel menuCliente;
        private System.Windows.Forms.ToolStripLabel menuProfissional;
        private System.Windows.Forms.ToolStripLabel menuRelatorios;
        private System.Windows.Forms.ToolStripLabel menuServico;
        private System.Windows.Forms.ToolStripLabel menuSair;
        private System.Windows.Forms.Button btnSalvar;
    }
}