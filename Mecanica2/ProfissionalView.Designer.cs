namespace Mecanica2
{
    partial class ProfissionalView
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
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.cpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.ToolStrip();
            this.menuAgenda = new System.Windows.Forms.ToolStripLabel();
            this.menuAtendimento = new System.Windows.Forms.ToolStripLabel();
            this.menuCliente = new System.Windows.Forms.ToolStripLabel();
            this.menuProfissional = new System.Windows.Forms.ToolStripLabel();
            this.menuRelatorios = new System.Windows.Forms.ToolStripLabel();
            this.menuServico = new System.Windows.Forms.ToolStripLabel();
            this.menuSair = new System.Windows.Forms.ToolStripLabel();
            this.panelSituacao = new System.Windows.Forms.Panel();
            this.rInativo = new System.Windows.Forms.RadioButton();
            this.rAtivo = new System.Windows.Forms.RadioButton();
            this.situacao = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.fone = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.panelSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(69, 93);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(151, 20);
            this.txtCpf.TabIndex = 2;
            this.txtCpf.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(33, 93);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(30, 13);
            this.cpf.TabIndex = 28;
            this.cpf.Text = "CPF:";
            this.cpf.Click += new System.EventHandler(this.cpf_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 67);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(368, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(25, 70);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(38, 13);
            this.nome.TabIndex = 26;
            this.nome.Text = "Nome:";
            this.nome.Click += new System.EventHandler(this.nome_Click);
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
            this.menu.TabIndex = 25;
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
            // panelSituacao
            // 
            this.panelSituacao.Controls.Add(this.rInativo);
            this.panelSituacao.Controls.Add(this.rAtivo);
            this.panelSituacao.Location = new System.Drawing.Point(69, 171);
            this.panelSituacao.Name = "panelSituacao";
            this.panelSituacao.Size = new System.Drawing.Size(187, 35);
            this.panelSituacao.TabIndex = 5;
            this.panelSituacao.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rInativo
            // 
            this.rInativo.AutoSize = true;
            this.rInativo.Location = new System.Drawing.Point(94, 3);
            this.rInativo.Name = "rInativo";
            this.rInativo.Size = new System.Drawing.Size(57, 17);
            this.rInativo.TabIndex = 1;
            this.rInativo.TabStop = true;
            this.rInativo.Text = "Inativo";
            this.rInativo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rInativo.UseVisualStyleBackColor = true;
            // 
            // rAtivo
            // 
            this.rAtivo.AutoSize = true;
            this.rAtivo.Location = new System.Drawing.Point(3, 3);
            this.rAtivo.Name = "rAtivo";
            this.rAtivo.Size = new System.Drawing.Size(49, 17);
            this.rAtivo.TabIndex = 0;
            this.rAtivo.TabStop = true;
            this.rAtivo.Text = "Ativo";
            this.rAtivo.UseVisualStyleBackColor = true;
            // 
            // situacao
            // 
            this.situacao.AutoSize = true;
            this.situacao.Location = new System.Drawing.Point(18, 178);
            this.situacao.Name = "situacao";
            this.situacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.situacao.Size = new System.Drawing.Size(52, 13);
            this.situacao.TabIndex = 41;
            this.situacao.Text = "Situação:";
            this.situacao.Click += new System.EventHandler(this.situacao_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(69, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(29, 152);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(38, 13);
            this.email.TabIndex = 34;
            this.email.Text = "E-mail:";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(69, 119);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(151, 20);
            this.txtFone.TabIndex = 3;
            this.txtFone.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // fone
            // 
            this.fone.AutoSize = true;
            this.fone.Location = new System.Drawing.Point(28, 122);
            this.fone.Name = "fone";
            this.fone.Size = new System.Drawing.Size(34, 13);
            this.fone.TabIndex = 32;
            this.fone.Text = "Fone:";
            this.fone.Click += new System.EventHandler(this.fone_Click);
            // 
            // ProfissionalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panelSituacao);
            this.Controls.Add(this.situacao);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.fone);
            this.Name = "ProfissionalView";
            this.Text = "ProfissionalView";
            this.Load += new System.EventHandler(this.ProfissionalView_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panelSituacao.ResumeLayout(false);
            this.panelSituacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripLabel menuAgenda;
        private System.Windows.Forms.ToolStripLabel menuAtendimento;
        private System.Windows.Forms.ToolStripLabel menuCliente;
        private System.Windows.Forms.ToolStripLabel menuProfissional;
        private System.Windows.Forms.ToolStripLabel menuServico;
        private System.Windows.Forms.ToolStripLabel menuSair;
        private System.Windows.Forms.Panel panelSituacao;
        private System.Windows.Forms.RadioButton rInativo;
        private System.Windows.Forms.RadioButton rAtivo;
        private System.Windows.Forms.Label situacao;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.Label fone;
        private System.Windows.Forms.ToolStripLabel menuRelatorios;
    }
}