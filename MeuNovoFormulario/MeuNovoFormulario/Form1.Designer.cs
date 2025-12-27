namespace MeuNovoFormulario
{
    partial class Formulario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbxNome = new TextBox();
            tbxIdade = new TextBox();
            tbxProfissao = new TextBox();
            dtNascimento = new DateTimePicker();
            tbxCPF = new TextBox();
            tbxFrase = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            tbxLogradouro = new TextBox();
            tbxNumero = new TextBox();
            tbxComplemento = new TextBox();
            tbxBairro = new TextBox();
            tbxCidade = new TextBox();
            tbxPais = new TextBox();
            tbxCEP = new TextBox();
            tbxReferencia = new TextBox();
            btnSalvar = new Button();
            btnLimpar = new Button();
            cbxEstado = new ComboBox();
            btnExcluir = new Button();
            btnAlterar = new Button();
            btnConsultar = new Button();
            btnNovo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(620, 15);
            label1.TabIndex = 0;
            label1.Text = "Para cadastrar um novo usuário clique em NOVO. Para consultas por favor preencha o CPF e clique em CONSULTAR.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(285, 107);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "ldade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 107);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Profissão";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 107);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 4;
            label5.Text = "Data de nascimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(642, 107);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 5;
            label6.Text = "CPF";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 172);
            label7.Name = "label7";
            label7.Size = new Size(163, 15);
            label7.TabIndex = 6;
            label7.Text = "Insira uma frase sobre o Natal";
            label7.Click += label7_Click;
            // 
            // tbxNome
            // 
            tbxNome.Location = new Point(12, 72);
            tbxNome.MaxLength = 150;
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(776, 23);
            tbxNome.TabIndex = 7;
            tbxNome.KeyPress += tbxNome_KeyPress;
            // 
            // tbxIdade
            // 
            tbxIdade.BackColor = SystemColors.Window;
            tbxIdade.Cursor = Cursors.No;
            tbxIdade.Location = new Point(285, 125);
            tbxIdade.Name = "tbxIdade";
            tbxIdade.ReadOnly = true;
            tbxIdade.Size = new Size(56, 23);
            tbxIdade.TabIndex = 8;
            tbxIdade.TabStop = false;
            tbxIdade.TextChanged += tbxIdade_TextChanged;
            tbxIdade.Enter += tbxIdade_Enter;
            // 
            // tbxProfissao
            // 
            tbxProfissao.Location = new Point(13, 125);
            tbxProfissao.MaxLength = 50;
            tbxProfissao.Name = "tbxProfissao";
            tbxProfissao.Size = new Size(227, 23);
            tbxProfissao.TabIndex = 9;
            tbxProfissao.TextChanged += tbxProfissao_TextChanged;
            tbxProfissao.KeyPress += tbxProfissao_KeyPress;
            // 
            // dtNascimento
            // 
            dtNascimento.Location = new Point(366, 125);
            dtNascimento.Name = "dtNascimento";
            dtNascimento.Size = new Size(249, 23);
            dtNascimento.TabIndex = 10;
            dtNascimento.ValueChanged += dtNascimento_ValueChanged;
            // 
            // tbxCPF
            // 
            tbxCPF.Location = new Point(642, 125);
            tbxCPF.MaxLength = 11;
            tbxCPF.Name = "tbxCPF";
            tbxCPF.Size = new Size(146, 23);
            tbxCPF.TabIndex = 11;
            tbxCPF.KeyPress += tbxCPF_KeyPress;
            // 
            // tbxFrase
            // 
            tbxFrase.Location = new Point(12, 190);
            tbxFrase.MaxLength = 500;
            tbxFrase.Multiline = true;
            tbxFrase.Name = "tbxFrase";
            tbxFrase.Size = new Size(776, 68);
            tbxFrase.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 278);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 13;
            label8.Text = "Logradouro";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(503, 278);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 14;
            label9.Text = "Número";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 334);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 15;
            label10.Text = "Bairro";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(205, 334);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 16;
            label11.Text = "Cidade";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(419, 334);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 17;
            label12.Text = "Estado";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(503, 334);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 18;
            label13.Text = "País";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(625, 334);
            label14.Name = "label14";
            label14.Size = new Size(28, 15);
            label14.TabIndex = 19;
            label14.Text = "CEP";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 393);
            label15.Name = "label15";
            label15.Size = new Size(113, 15);
            label15.TabIndex = 20;
            label15.Text = "Ponto de Referência";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(625, 278);
            label16.Name = "label16";
            label16.Size = new Size(84, 15);
            label16.TabIndex = 21;
            label16.Text = "Complemento";
            label16.Click += label16_Click;
            // 
            // tbxLogradouro
            // 
            tbxLogradouro.Location = new Point(12, 296);
            tbxLogradouro.MaxLength = 100;
            tbxLogradouro.Name = "tbxLogradouro";
            tbxLogradouro.Size = new Size(451, 23);
            tbxLogradouro.TabIndex = 22;
            tbxLogradouro.KeyPress += tbxLogradouro_KeyPress;
            // 
            // tbxNumero
            // 
            tbxNumero.Location = new Point(503, 296);
            tbxNumero.MaxLength = 7;
            tbxNumero.Name = "tbxNumero";
            tbxNumero.Size = new Size(64, 23);
            tbxNumero.TabIndex = 23;
            tbxNumero.TextChanged += tbxNumero_TextChanged;
            tbxNumero.KeyPress += tbxNumero_KeyPress;
            // 
            // tbxComplemento
            // 
            tbxComplemento.Location = new Point(625, 296);
            tbxComplemento.MaxLength = 20;
            tbxComplemento.Name = "tbxComplemento";
            tbxComplemento.Size = new Size(133, 23);
            tbxComplemento.TabIndex = 24;
            // 
            // tbxBairro
            // 
            tbxBairro.Location = new Point(12, 352);
            tbxBairro.MaxLength = 100;
            tbxBairro.Name = "tbxBairro";
            tbxBairro.Size = new Size(163, 23);
            tbxBairro.TabIndex = 25;
            tbxBairro.KeyPress += tbxBairro_KeyPress;
            // 
            // tbxCidade
            // 
            tbxCidade.Location = new Point(205, 352);
            tbxCidade.MaxLength = 100;
            tbxCidade.Name = "tbxCidade";
            tbxCidade.Size = new Size(174, 23);
            tbxCidade.TabIndex = 26;
            tbxCidade.KeyPress += tbxCidade_KeyPress;
            // 
            // tbxPais
            // 
            tbxPais.Location = new Point(503, 352);
            tbxPais.MaxLength = 100;
            tbxPais.Name = "tbxPais";
            tbxPais.Size = new Size(90, 23);
            tbxPais.TabIndex = 28;
            tbxPais.KeyPress += tbxPais_KeyPress;
            // 
            // tbxCEP
            // 
            tbxCEP.Location = new Point(625, 352);
            tbxCEP.MaxLength = 8;
            tbxCEP.Name = "tbxCEP";
            tbxCEP.Size = new Size(133, 23);
            tbxCEP.TabIndex = 29;
            tbxCEP.KeyPress += tbxCEP_KeyPress;
            // 
            // tbxReferencia
            // 
            tbxReferencia.Location = new Point(12, 411);
            tbxReferencia.MaxLength = 100;
            tbxReferencia.Name = "tbxReferencia";
            tbxReferencia.Size = new Size(344, 23);
            tbxReferencia.TabIndex = 30;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(677, 465);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(107, 49);
            btnSalvar.TabIndex = 31;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(544, 465);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(107, 49);
            btnLimpar.TabIndex = 32;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // cbxEstado
            // 
            cbxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "AC ", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO", "EX" });
            cbxEstado.Location = new Point(418, 352);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(60, 23);
            cbxEstado.TabIndex = 33;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(411, 465);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(107, 49);
            btnExcluir.TabIndex = 34;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(278, 465);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(107, 49);
            btnAlterar.TabIndex = 35;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(145, 465);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(107, 49);
            btnConsultar.TabIndex = 36;
            btnConsultar.Text = "CONSULTAR";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(12, 465);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(107, 49);
            btnNovo.TabIndex = 37;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 526);
            Controls.Add(btnNovo);
            Controls.Add(btnConsultar);
            Controls.Add(btnAlterar);
            Controls.Add(btnExcluir);
            Controls.Add(cbxEstado);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(tbxReferencia);
            Controls.Add(tbxCEP);
            Controls.Add(tbxPais);
            Controls.Add(tbxCidade);
            Controls.Add(tbxBairro);
            Controls.Add(tbxComplemento);
            Controls.Add(tbxNumero);
            Controls.Add(tbxLogradouro);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(tbxFrase);
            Controls.Add(tbxCPF);
            Controls.Add(dtNascimento);
            Controls.Add(tbxProfissao);
            Controls.Add(tbxIdade);
            Controls.Add(tbxNome);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Formulario";
            Text = "Formulário de Cadastro";
            Load += Formulario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbxNome;
        private TextBox tbxIdade;
        private TextBox tbxProfissao;
        private DateTimePicker dtNascimento;
        private TextBox tbxCPF;
        private TextBox tbxFrase;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox tbxLogradouro;
        private TextBox tbxNumero;
        private TextBox tbxComplemento;
        private TextBox tbxBairro;
        private TextBox tbxCidade;
        private TextBox tbxPais;
        private TextBox tbxCEP;
        private TextBox tbxReferencia;
        private Button btnSalvar;
        private Button btnLimpar;
        private ComboBox cbxEstado;
        private Button btnExcluir;
        private Button btnAlterar;
        private Button btnConsultar;
        private Button btnNovo;
    }
}
