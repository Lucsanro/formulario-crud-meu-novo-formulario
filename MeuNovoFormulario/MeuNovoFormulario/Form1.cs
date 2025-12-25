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

            using (SqlConnection con = new SqlConnection(strCon))
            {
                try
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
                    cmdEnd.Parameters.AddWithValue("@uf", tbxEstado.Text);
                    cmdEnd.Parameters.AddWithValue("@pais", tbxPais.Text);
                    cmdEnd.Parameters.AddWithValue("@cep", tbxCEP.Text);
                    cmdEnd.Parameters.AddWithValue("@ref", tbxReferencia.Text);

                    cmdEnd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar: " + ex.Message);
                }
            }
        }

        private void tbxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                e.Handled = true;
            }
        }
    }
}
