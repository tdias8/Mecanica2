namespace Mecanica2
{
    partial class ClienteView
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
            this.nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.cpf = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.fone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.txtEstadoCivil = new System.Windows.Forms.TextBox();
            this.estadocivil = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.Label();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.dtnasc = new System.Windows.Forms.Label();
            this.panelSituacao = new System.Windows.Forms.Panel();
            this.rInativo = new System.Windows.Forms.RadioButton();
            this.rAtivo = new System.Windows.Forms.RadioButton();
            this.situacao = new System.Windows.Forms.Label();
            this.listsexo = new System.Windows.Forms.ComboBox();
            this.menu = new System.Windows.Forms.ToolStrip();
            this.menuAgenda = new System.Windows.Forms.ToolStripLabel();
            this.menuAtendimento = new System.Windows.Forms.ToolStripLabel();
            this.menuCliente = new System.Windows.Forms.ToolStripLabel();
            this.menuProfissional = new System.Windows.Forms.ToolStripLabel();
            this.menuRelatorios = new System.Windows.Forms.ToolStripLabel();
            this.menuServico = new System.Windows.Forms.ToolStripLabel();
            this.menuSair = new System.Windows.Forms.ToolStripLabel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelSituacao.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(30, 69);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(38, 13);
            this.nome.TabIndex = 2;
            this.nome.Text = "Nome:";
            this.nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(368, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(74, 121);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(151, 20);
            this.txtCpf.TabIndex = 4;
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(38, 121);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(30, 13);
            this.cpf.TabIndex = 6;
            this.cpf.Text = "CPF:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(74, 92);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(368, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Location = new System.Drawing.Point(13, 95);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(56, 13);
            this.endereco.TabIndex = 8;
            this.endereco.Text = "Endereço:";
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(74, 147);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(151, 20);
            this.txtFone.TabIndex = 5;
            // 
            // fone
            // 
            this.fone.AutoSize = true;
            this.fone.Location = new System.Drawing.Point(33, 150);
            this.fone.Name = "fone";
            this.fone.Size = new System.Drawing.Size(34, 13);
            this.fone.TabIndex = 10;
            this.fone.Text = "Fone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(34, 180);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(38, 13);
            this.email.TabIndex = 12;
            this.email.Text = "E-mail:";
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.Location = new System.Drawing.Point(74, 199);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(187, 20);
            this.txtEstadoCivil.TabIndex = 7;
            // 
            // estadocivil
            // 
            this.estadocivil.AutoSize = true;
            this.estadocivil.Location = new System.Drawing.Point(5, 206);
            this.estadocivil.Name = "estadocivil";
            this.estadocivil.Size = new System.Drawing.Size(62, 13);
            this.estadocivil.TabIndex = 14;
            this.estadocivil.Text = "Estado Civil";
            // 
            // sexo
            // 
            this.sexo.AutoSize = true;
            this.sexo.Location = new System.Drawing.Point(34, 232);
            this.sexo.Name = "sexo";
            this.sexo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sexo.Size = new System.Drawing.Size(34, 13);
            this.sexo.TabIndex = 16;
            this.sexo.Text = "Sexo:";
            this.sexo.Click += new System.EventHandler(this.label8_Click);
            // 
            // dtNascimento
            // 
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(341, 121);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(101, 20);
            this.dtNascimento.TabIndex = 3;
            this.dtNascimento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtnasc
            // 
            this.dtnasc.AutoSize = true;
            this.dtnasc.Location = new System.Drawing.Point(231, 125);
            this.dtnasc.Name = "dtnasc";
            this.dtnasc.Size = new System.Drawing.Size(104, 13);
            this.dtnasc.TabIndex = 19;
            this.dtnasc.Text = "Data de Nascimento";
            // 
            // panelSituacao
            // 
            this.panelSituacao.Controls.Add(this.rInativo);
            this.panelSituacao.Controls.Add(this.rAtivo);
            this.panelSituacao.Location = new System.Drawing.Point(74, 256);
            this.panelSituacao.Name = "panelSituacao";
            this.panelSituacao.Size = new System.Drawing.Size(187, 35);
            this.panelSituacao.TabIndex = 9;
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
            this.situacao.Location = new System.Drawing.Point(23, 263);
            this.situacao.Name = "situacao";
            this.situacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.situacao.Size = new System.Drawing.Size(52, 13);
            this.situacao.TabIndex = 22;
            this.situacao.Text = "Situação:";
            this.situacao.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // listsexo
            // 
            this.listsexo.FormattingEnabled = true;
            this.listsexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.listsexo.Location = new System.Drawing.Point(74, 229);
            this.listsexo.Name = "listsexo";
            this.listsexo.Size = new System.Drawing.Size(151, 21);
            this.listsexo.TabIndex = 8;
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
            this.menu.TabIndex = 27;
            this.menu.Text = "toolStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
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
            this.btnSalvar.Location = new System.Drawing.Point(354, 180);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 34);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgDados
            // 
            this.dgDados.AllowUserToAddRows = false;
            this.dgDados.AllowUserToDeleteRows = false;
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Location = new System.Drawing.Point(448, 66);
            this.dgDados.Name = "dgDados";
            this.dgDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDados.Size = new System.Drawing.Size(344, 351);
            this.dgDados.TabIndex = 31;
            this.dgDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDados_CellContentClick);
            this.dgDados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDados_CellContentDoubleClick);
            this.dgDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDados_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 32;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 33;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgDados);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.listsexo);
            this.Controls.Add(this.panelSituacao);
            this.Controls.Add(this.situacao);
            this.Controls.Add(this.dtnasc);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.txtEstadoCivil);
            this.Controls.Add(this.estadocivil);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.fone);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.nome);
            this.Name = "ClienteView";
            this.Text = "ClienteView";
            this.Load += new System.EventHandler(this.ClienteView_Load);
            this.panelSituacao.ResumeLayout(false);
            this.panelSituacao.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.Label fone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtEstadoCivil;
        private System.Windows.Forms.Label estadocivil;
        private System.Windows.Forms.Label sexo;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.Label dtnasc;
        private System.Windows.Forms.Panel panelSituacao;
        private System.Windows.Forms.RadioButton rInativo;
        private System.Windows.Forms.RadioButton rAtivo;
        private System.Windows.Forms.Label situacao;
        private System.Windows.Forms.ComboBox listsexo;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripLabel menuAgenda;
        private System.Windows.Forms.ToolStripLabel menuAtendimento;
        private System.Windows.Forms.ToolStripLabel menuCliente;
        private System.Windows.Forms.ToolStripLabel menuProfissional;
        private System.Windows.Forms.ToolStripLabel menuRelatorios;
        private System.Windows.Forms.ToolStripLabel menuServico;
        private System.Windows.Forms.ToolStripLabel menuSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}