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

namespace ImportarDados
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string texto = "Nome: " + Nome.Text + "\n" +
                "Idade: " + Idade.Text + "\n" +
                "Nome da Mãe: " + NomeMae.Text + "\n" +
                "Endereço: " + Endereco.Text + "\n" +
                "Telefone: " + Telefone.Text;

            //Criar um novo saveFileDialog
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "Texto (*.txt)|*.txt";
                save.Title = "Salvar como";

                //Se o usuario clicar em salvar
                if (save.ShowDialog() == DialogResult.OK)
                {
                    //Obtem o caminho do arquivo
                    string filepath = save.FileName;

                    //Salva o conteudo de RichTextBox no arquivo
                    if (Path.GetExtension(filepath) == "*.txt")
                    {
                        RichTextBox textoFormatado = new RichTextBox();
                        textoFormatado.Clear();
                        textoFormatado.AppendText(texto);
                        textoFormatado.SaveFile(filepath, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        File.WriteAllText(filepath, texto);
                    }
                }
            }
            Nome.Text = ""; Idade.Text = ""; NomeMae.Text = ""; Endereco.Text = ""; Telefone.Text = "";
        }
    }
}
