namespace Gerador_de_TestesWinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            menuStrip1 = new MenuStrip();
            disciplinasToolStripMenuItem = new ToolStripMenuItem();
            matériasToolStripMenuItem = new ToolStripMenuItem();
            testeToolStripMenuItem = new ToolStripMenuItem();
            label1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusLabelPrincipal = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            pnlRegistros = new Panel();
            questõesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            label1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { disciplinasToolStripMenuItem, matériasToolStripMenuItem, questõesToolStripMenuItem, testeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // disciplinasToolStripMenuItem
            // 
            disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            disciplinasToolStripMenuItem.Size = new Size(75, 20);
            disciplinasToolStripMenuItem.Text = "Disciplinas";
            disciplinasToolStripMenuItem.Click += disciplinasToolStripMenuItem_Click;
            // 
            // matériasToolStripMenuItem
            // 
            matériasToolStripMenuItem.Name = "matériasToolStripMenuItem";
            matériasToolStripMenuItem.Size = new Size(64, 20);
            matériasToolStripMenuItem.Text = "Matérias";
            // 
            // testeToolStripMenuItem
            // 
            testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            testeToolStripMenuItem.Size = new Size(50, 20);
            testeToolStripMenuItem.Text = "Testes";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, statusLabelPrincipal });
            label1.Location = new Point(0, 428);
            label1.Name = "label1";
            label1.Size = new Size(800, 22);
            label1.TabIndex = 1;
            label1.Text = "fescrsaklgsdg";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(0, 17);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 37);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(5);
            btnAdicionar.Size = new Size(34, 34);
            btnAdicionar.Text = "btnAdicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(34, 34);
            btnEditar.Text = "btnEditar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(34, 34);
            btnExcluir.Text = "btnExcluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 37);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(0, 34);
            // 
            // pnlRegistros
            // 
            pnlRegistros.Dock = DockStyle.Fill;
            pnlRegistros.Location = new Point(0, 61);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(800, 367);
            pnlRegistros.TabIndex = 3;
            // 
            // questõesToolStripMenuItem
            // 
            questõesToolStripMenuItem.Name = "questõesToolStripMenuItem";
            questõesToolStripMenuItem.Size = new Size(68, 20);
            questõesToolStripMenuItem.Text = "Questões";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "TelaPrincipalForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de Testes";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            label1.ResumeLayout(false);
            label1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem disciplinasToolStripMenuItem;
        private ToolStripMenuItem matériasToolStripMenuItem;
        private StatusStrip label1;
        private ToolStripMenuItem testeToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel pnlRegistros;
        private ToolStripStatusLabel statusLabelPrincipal;
        private ToolStripMenuItem questõesToolStripMenuItem;
    }
}
