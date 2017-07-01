using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidacaoCpf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex objRegex = new Regex(@"[^\d]"); //Remoção de caracteres não numéricos
            string cpfTratado = objRegex.Replace(campoCpf.Text, "");

            if (cpfTratado == "")
            {
                MessageBox.Show("O CPF digitado não contém números ou o campo está em branco.");
            }
            else
            {
                // Elimina CPFs invalidos conhecidos
                if (cpfTratado.Length != 11 ||
                    cpfTratado.Equals("00000000000") ||
                    cpfTratado.Equals("11111111111") ||
                    cpfTratado.Equals("22222222222") ||
                    cpfTratado.Equals("33333333333") ||
                    cpfTratado.Equals("44444444444") ||
                    cpfTratado.Equals("55555555555") ||
                    cpfTratado.Equals("66666666666") ||
                    cpfTratado.Equals("77777777777") ||
                    cpfTratado.Equals("88888888888") ||
                    cpfTratado.Equals("99999999999"))
                {
                    MessageBox.Show("CPF inválido (não tem 11 dígitos ou todos são iguais)");
                }
                else
                {
                    // validação do primeiro dígito
                    int add = 0;
                    for (int i = 0; i < 9; i++)
                        add += int.Parse(cpfTratado[i].ToString()) * (10 - i);

                    int rev = 11 - (add % 11);
                    if (rev == 10 || rev == 11)
                    {
                        rev = 0;
                    }

                
                    if (rev != int.Parse(cpfTratado[9].ToString()))
                    {
                        MessageBox.Show("CPF inválido (erro no primeiro dígito)");
                    }
                    else
                    {
                        //validação segundo dígito
                        add = 0;
                        for (int i = 0; i < 10; i++)
                            add += int.Parse(cpfTratado[i].ToString()) * (11 - i);

                        rev = 11 - (add % 11);
                        if (rev == 10 || rev == 11)
                        {
                            rev = 0;
                        }
                        if (rev != int.Parse(cpfTratado[10].ToString()))
                        {
                            MessageBox.Show("CPF inválido (erro no segundo dígito)");
                        }
                        else
                        {
                            MessageBox.Show("CPF válido");
                        }
                    }
                }
            }
        }
    }
}
