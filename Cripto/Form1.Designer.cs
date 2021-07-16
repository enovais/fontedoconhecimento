namespace Cripto
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cifrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decifrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.limparToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beatrisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evertonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ítaloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rayanneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.btnDecifrar = new System.Windows.Forms.Button();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLimparEntrada = new System.Windows.Forms.Button();
            this.btnLimparSaida = new System.Windows.Forms.Button();
            this.qdtCharSaida = new System.Windows.Forms.TextBox();
            this.qdcCharEntrada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.entradaToolStripMenuItem,
            this.saídaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar como...";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.cifrarToolStripMenuItem,
            this.decifrarToolStripMenuItem,
            this.toolStripSeparator2,
            this.limparToolStripMenuItem});
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.entradaToolStripMenuItem.Text = "Entrada";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // cifrarToolStripMenuItem
            // 
            this.cifrarToolStripMenuItem.Name = "cifrarToolStripMenuItem";
            this.cifrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.cifrarToolStripMenuItem.Text = "Cifrar";
            this.cifrarToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // decifrarToolStripMenuItem
            // 
            this.decifrarToolStripMenuItem.Name = "decifrarToolStripMenuItem";
            this.decifrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.decifrarToolStripMenuItem.Text = "Decifrar";
            this.decifrarToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(112, 6);
            this.toolStripSeparator2.Click += new System.EventHandler(this.toolStripSeparator2_Click);
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.limparToolStripMenuItem.Text = "Limpar";
            this.limparToolStripMenuItem.Click += new System.EventHandler(this.button5_Click);
            // 
            // saídaToolStripMenuItem
            // 
            this.saídaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem1,
            this.toolStripSeparator3,
            this.limparToolStripMenuItem1});
            this.saídaToolStripMenuItem.Name = "saídaToolStripMenuItem";
            this.saídaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.saídaToolStripMenuItem.Text = "Saída";
            this.saídaToolStripMenuItem.Click += new System.EventHandler(this.saídaToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem1
            // 
            this.salvarToolStripMenuItem1.Name = "salvarToolStripMenuItem1";
            this.salvarToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.salvarToolStripMenuItem1.Text = "Salvar";
            this.salvarToolStripMenuItem1.Click += new System.EventHandler(this.button4_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(108, 6);
            // 
            // limparToolStripMenuItem1
            // 
            this.limparToolStripMenuItem1.Name = "limparToolStripMenuItem1";
            this.limparToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.limparToolStripMenuItem1.Text = "Limpar";
            this.limparToolStripMenuItem1.Click += new System.EventHandler(this.button6_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipeToolStripMenuItem,
            this.objetivoToolStripMenuItem,
            this.versãoToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // equipeToolStripMenuItem
            // 
            this.equipeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beatrisToolStripMenuItem,
            this.evertonToolStripMenuItem,
            this.ítaloToolStripMenuItem,
            this.rayanneToolStripMenuItem});
            this.equipeToolStripMenuItem.Name = "equipeToolStripMenuItem";
            this.equipeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.equipeToolStripMenuItem.Text = "Equipe";
            // 
            // beatrisToolStripMenuItem
            // 
            this.beatrisToolStripMenuItem.Name = "beatrisToolStripMenuItem";
            this.beatrisToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.beatrisToolStripMenuItem.Text = "Beatris";
            this.beatrisToolStripMenuItem.Click += new System.EventHandler(this.beatrisToolStripMenuItem_Click);
            // 
            // evertonToolStripMenuItem
            // 
            this.evertonToolStripMenuItem.Name = "evertonToolStripMenuItem";
            this.evertonToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.evertonToolStripMenuItem.Text = "Everton";
            this.evertonToolStripMenuItem.Click += new System.EventHandler(this.evertonToolStripMenuItem_Click);
            // 
            // ítaloToolStripMenuItem
            // 
            this.ítaloToolStripMenuItem.Name = "ítaloToolStripMenuItem";
            this.ítaloToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ítaloToolStripMenuItem.Text = "Ítalo";
            this.ítaloToolStripMenuItem.Click += new System.EventHandler(this.ítaloToolStripMenuItem_Click);
            // 
            // rayanneToolStripMenuItem
            // 
            this.rayanneToolStripMenuItem.Name = "rayanneToolStripMenuItem";
            this.rayanneToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rayanneToolStripMenuItem.Text = "Rayanne";
            this.rayanneToolStripMenuItem.Click += new System.EventHandler(this.rayanneToolStripMenuItem_Click);
            // 
            // objetivoToolStripMenuItem
            // 
            this.objetivoToolStripMenuItem.Name = "objetivoToolStripMenuItem";
            this.objetivoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.objetivoToolStripMenuItem.Text = "Objetivo";
            this.objetivoToolStripMenuItem.Click += new System.EventHandler(this.objetivoToolStripMenuItem_Click);
            // 
            // versãoToolStripMenuItem
            // 
            this.versãoToolStripMenuItem.Name = "versãoToolStripMenuItem";
            this.versãoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.versãoToolStripMenuItem.Text = "Versão";
            this.versãoToolStripMenuItem.Click += new System.EventHandler(this.versãoToolStripMenuItem_Click);
            // 
            // txtEntrada
            // 
            this.txtEntrada.AcceptsReturn = true;
            this.txtEntrada.AcceptsTab = true;
            this.txtEntrada.AllowDrop = true;
            this.txtEntrada.Location = new System.Drawing.Point(23, 182);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEntrada.Size = new System.Drawing.Size(273, 168);
            this.txtEntrada.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entrada:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(181, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 65);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(26, 356);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(75, 23);
            this.btnCifrar.TabIndex = 4;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDecifrar
            // 
            this.btnDecifrar.Location = new System.Drawing.Point(124, 356);
            this.btnDecifrar.Name = "btnDecifrar";
            this.btnDecifrar.Size = new System.Drawing.Size(75, 23);
            this.btnDecifrar.TabIndex = 5;
            this.btnDecifrar.Text = "Decifrar";
            this.btnDecifrar.UseVisualStyleBackColor = true;
            this.btnDecifrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSaida
            // 
            this.txtSaida.AcceptsReturn = true;
            this.txtSaida.AcceptsTab = true;
            this.txtSaida.AllowDrop = true;
            this.txtSaida.Location = new System.Drawing.Point(396, 182);
            this.txtSaida.Multiline = true;
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSaida.Size = new System.Drawing.Size(273, 168);
            this.txtSaida.TabIndex = 6;
            this.txtSaida.TextChanged += new System.EventHandler(this.txtSaida_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saída:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(221, 356);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(594, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Salvar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLimparEntrada
            // 
            this.btnLimparEntrada.Location = new System.Drawing.Point(250, 156);
            this.btnLimparEntrada.Name = "btnLimparEntrada";
            this.btnLimparEntrada.Size = new System.Drawing.Size(46, 23);
            this.btnLimparEntrada.TabIndex = 10;
            this.btnLimparEntrada.Text = "limpar";
            this.btnLimparEntrada.UseVisualStyleBackColor = true;
            this.btnLimparEntrada.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnLimparSaida
            // 
            this.btnLimparSaida.Location = new System.Drawing.Point(623, 156);
            this.btnLimparSaida.Name = "btnLimparSaida";
            this.btnLimparSaida.Size = new System.Drawing.Size(46, 23);
            this.btnLimparSaida.TabIndex = 11;
            this.btnLimparSaida.Text = "limpar";
            this.btnLimparSaida.UseVisualStyleBackColor = true;
            this.btnLimparSaida.Click += new System.EventHandler(this.button6_Click);
            // 
            // qdtCharSaida
            // 
            this.qdtCharSaida.Location = new System.Drawing.Point(564, 158);
            this.qdtCharSaida.Name = "qdtCharSaida";
            this.qdtCharSaida.Size = new System.Drawing.Size(53, 20);
            this.qdtCharSaida.TabIndex = 12;
            this.qdtCharSaida.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // qdcCharEntrada
            // 
            this.qdcCharEntrada.Location = new System.Drawing.Point(191, 158);
            this.qdcCharEntrada.Name = "qdcCharEntrada";
            this.qdcCharEntrada.Size = new System.Drawing.Size(53, 20);
            this.qdcCharEntrada.TabIndex = 13;
            this.qdcCharEntrada.TextChanged += new System.EventHandler(this.qdcCharEntrada_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Qtd Char";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Qtd Char";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(303, 250);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(87, 23);
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label5.Location = new System.Drawing.Point(536, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "Versão 1.0 Cifração Finalizada";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 406);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qdcCharEntrada);
            this.Controls.Add(this.qdtCharSaida);
            this.Controls.Add(this.btnLimparSaida);
            this.Controls.Add(this.btnLimparEntrada);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.btnDecifrar);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fonte do Conhecimento 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versãoToolStripMenuItem;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Button btnDecifrar;
        private System.Windows.Forms.ToolStripMenuItem equipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beatrisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evertonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ítaloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rayanneToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLimparEntrada;
        private System.Windows.Forms.Button btnLimparSaida;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cifrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decifrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox qdtCharSaida;
        private System.Windows.Forms.TextBox qdcCharEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;

    }
}

