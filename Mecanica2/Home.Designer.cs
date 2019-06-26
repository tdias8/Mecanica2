namespace Mecanica2
{
    partial class Home
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
            this.menu = new System.Windows.Forms.ToolStrip();
            this.menuAgenda = new System.Windows.Forms.ToolStripLabel();
            this.menuAtendimento = new System.Windows.Forms.ToolStripLabel();
            this.menuCliente = new System.Windows.Forms.ToolStripLabel();
            this.menuProfissional = new System.Windows.Forms.ToolStripLabel();
            this.menuRelatorios = new System.Windows.Forms.ToolStripLabel();
            this.menuServico = new System.Windows.Forms.ToolStripLabel();
            this.menuSair = new System.Windows.Forms.ToolStripLabel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
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
            this.menu.TabIndex = 26;
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
            this.menuCliente.Click += new System.EventHandler(this.menuCliente_Click_1);
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripLabel menuAgenda;
        private System.Windows.Forms.ToolStripLabel menuAtendimento;
        private System.Windows.Forms.ToolStripLabel menuCliente;
        private System.Windows.Forms.ToolStripLabel menuProfissional;
        private System.Windows.Forms.ToolStripLabel menuRelatorios;
        private System.Windows.Forms.ToolStripLabel menuServico;
        private System.Windows.Forms.ToolStripLabel menuSair;
    }
}