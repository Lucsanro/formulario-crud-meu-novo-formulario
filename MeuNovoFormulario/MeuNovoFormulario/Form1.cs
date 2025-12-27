using Microsoft.Data.SqlClient;

namespace MeuNovoFormulario
{
    public partial class Formulario : Form
    {
        // Guarde a string aqui em cima para não precisar repetir se criar outros botões
        string strCon = @"Data Source=ACERNITRO-LUCCA;Initial Catalog=MEU_NOVO_FORMULARIO;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            tbxIdade.Text = "0";

            // Estado inicial dos botões
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

            btnNovo.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbxIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxProfissao_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Substitua pela sua string de conexão copiada do passo 1
            string strCon = @"Data Source=ACERNITRO-LUCCA;Initial Catalog=MEU_NOVO_FORMULARIO;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

            // O comando SQL para a primeira tabela (Pessoas)
            // Usamos OUTPUT INSERTED.PESSOA_ID para pegar o ID gerado na hora
            string sqlPessoa = "INSERT INTO PESSOAS (NOME_COMPLETO, IDADE, PROFISSAO, CPF, DATA_NASCIMENTO, FRASE) " +
                               "OUTPUT INSERTED.PESSOA_ID " +
                               "VALUES (@nome, @idade, @prof, @cpf, @nasc, @frase)";

            string sqlEndereco = "INSERT INTO ENDERECOS (PESSOA_ID, LOGRADOURO, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, PAIS, CEP, PONTO_REFERENCIA) " +
                                 "VALUES (@id, @logra, @num, @compl, @bairro, @cidade, @uf, @pais, @cep, @ref)";

            if (!ValidarCPF(tbxCPF.Text))
            {
                MessageBox.Show("O CPF digitado é inválido. Por favor, confira os números.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCPF.Focus();
                return;
            }

            if (dtNascimento.Value > DateTime.Now)
            {
                MessageBox.Show("A data de nascimento não pode ser no futuro!", "Data Inválida");
                return; // O 'return' para a execução do botão aqui mesmo
            }

            if (string.IsNullOrWhiteSpace(tbxNome.Text))
            {
                MessageBox.Show("Nome não pode ser vazio!");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxProfissao.Text))
            {
                MessageBox.Show("Profissão não pode ser vazia!");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxCPF.Text))
            {
                MessageBox.Show("CPF não pode ser vazio!");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxCEP.Text))
            {
                MessageBox.Show("CEP não pode ser vazio!");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxLogradouro.Text))
            {
                MessageBox.Show("Logradouro não pode ser vazio!");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxNumero.Text))
            {
                MessageBox.Show("Número não pode ser vazio!");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxBairro.Text))
            {
                MessageBox.Show("Bairro não pode ser vazio!");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxCidade.Text))
            {
                MessageBox.Show("Cidade não pode ser vazia!");
                return;
            }

            if (cbxEstado.SelectedIndex == -1) // -1 significa que nada foi selecionado
            {
                MessageBox.Show("Estado não pode ser vazio!");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxPais.Text))
            {
                MessageBox.Show("País não pode ser vazio!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();

                    // 1. INSERIR PESSOA
                    SqlCommand cmdPessoa = new SqlCommand(sqlPessoa, con);
                    cmdPessoa.Parameters.AddWithValue("@nome", tbxNome.Text);
                    cmdPessoa.Parameters.AddWithValue("@idade", byte.Parse(tbxIdade.Text));
                    cmdPessoa.Parameters.AddWithValue("@prof", tbxProfissao.Text);
                    cmdPessoa.Parameters.AddWithValue("@cpf", tbxCPF.Text);
                    cmdPessoa.Parameters.AddWithValue("@nasc", dtNascimento.Value);
                    cmdPessoa.Parameters.AddWithValue("@frase", tbxFrase.Text);

                    // Executa e guarda o ID gerado
                    int novoIdPessoa = (int)cmdPessoa.ExecuteScalar();

                    // 2. INSERIR ENDEREÇO
                    SqlCommand cmdEnd = new SqlCommand(sqlEndereco, con);
                    cmdEnd.Parameters.AddWithValue("@id", novoIdPessoa); // O ID que veio da tabela anterior!
                    cmdEnd.Parameters.AddWithValue("@logra", tbxLogradouro.Text);
                    cmdEnd.Parameters.AddWithValue("@num", int.Parse(tbxNumero.Text));
                    cmdEnd.Parameters.AddWithValue("@compl", tbxComplemento.Text);
                    cmdEnd.Parameters.AddWithValue("@bairro", tbxBairro.Text);
                    cmdEnd.Parameters.AddWithValue("@cidade", tbxCidade.Text);
                    cmdEnd.Parameters.AddWithValue("@uf", cbxEstado.SelectedItem.ToString());
                    cmdEnd.Parameters.AddWithValue("@pais", tbxPais.Text);
                    cmdEnd.Parameters.AddWithValue("@cep", tbxCEP.Text);
                    cmdEnd.Parameters.AddWithValue("@ref", tbxReferencia.Text);

                    cmdEnd.ExecuteNonQuery();



                    MessageBox.Show("Cadastro realizado com sucesso!");

                    LimparCampos();

                    btnSalvar.Enabled = false;
                    btnNovo.Enabled = true;
                }

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Este CPF já está cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbxCPF.Focus();
                }
                else
                {
                    MessageBox.Show("Erro no banco de dados: " + ex.Message);
                }
            }
            // 4. Captura de qualquer outro erro (ex: erro de conversão de texto para número)
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
            }
        }

        private void tbxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxProfissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxLogradouro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtNascimento_ValueChanged(object sender, EventArgs e)
        {
            // Obtém a data selecionada
            DateTime dataNasc = dtNascimento.Value;
            DateTime hoje = DateTime.Today;

            // Cálculo básico da idade
            int idade = hoje.Year - dataNasc.Year;

            // Ajuste: se a pessoa ainda não fez aniversário este ano, subtraímos 1
            if (dataNasc.Date > hoje.AddYears(-idade))
            {
                idade--;
            }

            // Exibe no campo de texto (garantindo que não seja negativa)
            if (idade < 0)
            {
                tbxIdade.Text = "0";
            }
            else
            {
                tbxIdade.Text = idade.ToString();
            }
        }


        private void tbxIdade_Enter(object sender, EventArgs e)
        {
            // Assim que o campo ganha foco, mandamos o foco para o próximo campo (ex: Profissão)
            dtNascimento.Focus();
        }

        private void LimparCampos()
        {
            // Percorre todos os controles do formulário
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = DateTime.Now;
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1; // Reseta a seleção
                }
            }
            // Reseta a idade manualmente já que é ReadOnly
            tbxIdade.Text = "0";

            btnNovo.Enabled = true;     // Habilita o Novo novamente
            btnConsultar.Enabled = true; // Habilita o Consultar novamente
            btnSalvar.Enabled = false;   // Desabilita o Salvar
            btnAlterar.Enabled = false;  // Garante que Alterar continue desativado
            btnExcluir.Enabled = false;  // Garante que Excluir continue desativado

            // Foco inicial
            btnNovo.Focus();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos(); // Garante que a tela esteja vazia
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnConsultar.Enabled = false;
            tbxNome.Focus(); // Coloca o cursor no primeiro campo
        }

        private bool ValidarCPF(string cpf)
        {
            // Remove qualquer caractere que não seja número (caso você adicione máscaras depois)
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Se não tiver 11 números ou for uma sequência óbvia (111.111...), é inválido
            if (cpf.Length != 11 || new string(cpf[0], 11) == cpf)
                return false;

            // Cálculo do primeiro dígito verificador
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;

            // Cálculo do segundo dígito verificador
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            digito = digito + resto.ToString();

            // Retorna verdadeiro se os dígitos calculados forem iguais aos digitados
            return cpf.EndsWith(digito);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // 1. Validação básica: precisa de um CPF para buscar
            if (string.IsNullOrWhiteSpace(tbxCPF.Text))
            {
                MessageBox.Show("Por favor, digite um CPF para realizar a consulta.");
                return;
            }

            if (!ValidarCPF(tbxCPF.Text))
            {
                MessageBox.Show("O CPF digitado é inválido. Por favor, confira os números.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCPF.Focus();
                return;
            }

            string sqlConsulta = "SELECT P.*, E.* FROM PESSOAS P " +
                                 "INNER JOIN ENDERECOS E ON P.PESSOA_ID = E.PESSOA_ID " +
                                 "WHERE P.CPF = @cpf";

            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlConsulta, con);
                    cmd.Parameters.AddWithValue("@cpf", tbxCPF.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Se o banco retornou uma linha
                        {
                            // --- PREENCHENDO O FORMULÁRIO ---
                            // Tabela PESSOAS
                            tbxNome.Text = reader["NOME_COMPLETO"].ToString();
                            tbxProfissao.Text = reader["PROFISSAO"].ToString();
                            dtNascimento.Value = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                            tbxFrase.Text = reader["FRASE"].ToString();
                            // A idade será recalculada automaticamente pelo evento ValueChanged da data!

                            // Tabela ENDERECOS
                            tbxLogradouro.Text = reader["LOGRADOURO"].ToString();
                            tbxNumero.Text = reader["NUMERO"].ToString();
                            tbxComplemento.Text = reader["COMPLEMENTO"].ToString();
                            tbxBairro.Text = reader["BAIRRO"].ToString();
                            tbxCidade.Text = reader["CIDADE"].ToString();
                            cbxEstado.SelectedItem = reader["ESTADO"].ToString();
                            tbxPais.Text = reader["PAIS"].ToString();
                            tbxCEP.Text = reader["CEP"].ToString();
                            tbxReferencia.Text = reader["PONTO_REFERENCIA"].ToString();

                            // --- AJUSTANDO OS BOTÕES (Modo Edição) ---
                            btnSalvar.Enabled = false;
                            btnNovo.Enabled = false;
                            btnAlterar.Enabled = true;
                            btnExcluir.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado com este CPF.");
                            LimparCampos();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
            }
        }
    }
}
