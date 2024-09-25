using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ImportarDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog arquivo = new OpenFileDialog())
            {
                arquivo.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

                if (arquivo.ShowDialog() == DialogResult.OK)
                {
                    CarregarDados(arquivo.FileName);
                }
            }
        }

        private void CarregarDados(string caminhoArquivo)
        {
            try
            {
                //Lê todas as linhas do arquivo
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                string nome = string.Empty;
                string idade = string.Empty;
                string nomeMae = string.Empty;
                string endereco = string.Empty;
                string telefone = string.Empty;


                //Processa cada linha
                foreach (string line in linhas)
                {
                    if (line.StartsWith("Nome:"))
                    {
                        nome = line.Substring(5).Trim(); //Remove "Nome:" e espaços
                    }
                    else if (line.StartsWith("Idade:"))
                    {
                        idade = line.Substring(6).Trim(); //Remove "Idade:" e espaços
                    }
                    else if (line.StartsWith("Nome da Mãe:"))
                    {
                        nomeMae = line.Substring(12).Trim(); //Remove "Nome da Mãe:" e espaços
                    }
                    else if (line.StartsWith("Endereço:"))
                    {
                        endereco = line.Substring(9).Trim(); //Remove "Endereço:" e espaços
                    }
                    else if (line.StartsWith("Telefone:"))
                    {
                        telefone = line.Substring(9).Trim(); //Remove "Telefone:" e espaços
                    }
                }

                //Coloca dentro de uma variavel
                string Nome1 = nome;
                string Idade1 = idade;
                string NomeMae1 = nomeMae;
                string Endereco1 = endereco;
                string Telefone1 = telefone;

                try
                {
                    MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=importardados");

                    conn.Open();

                    MySqlCommand command = new MySqlCommand("INSERT INTO `pera` (`Nome`, `Idade`, `NomeMae`, `Endereco`, `Telefone`) VALUES (@Nome,@Idade,@NomeMae,@Endereco,@Telefone)", conn);

                    command.Parameters.AddWithValue("@Nome", Nome1);

                    command.Parameters.AddWithValue("@Idade", Idade1);

                    command.Parameters.AddWithValue("@NomeMae", NomeMae1);

                    command.Parameters.AddWithValue("@Endereco", Endereco1);

                    command.Parameters.AddWithValue("@Telefone", Telefone1);

                    command.ExecuteNonQuery();

                    conn.Close();

                    lblResposta.Text = "🛢 Deu td certo";
                }
                catch (Exception ex) { MessageBox.Show($"Erro ao ler o arquivo: {ex.Message}"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao ler o arquivo: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
