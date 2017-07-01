using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaDia2205
{
    public partial class Form1 : Form
    {
        Dictionary<String, String> dicionario = new Dictionary<String, String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<String> lista = new List<String>();
            lista.Add("Medicina");
            lista.Add("Análise");
            lista.Add("Direito");
            comboBox1.Items.AddRange(lista.ToArray());

            dicionario.Add("Medicina", "http://www.up.edu.br/graduacao/medicina");
            dicionario.Add("Análise", "http://www.ctpositivo.edu.br/cursos-de-tecnologia/analise-e-desenvolvimento-de-sistemas");
            dicionario.Add("Direito", "http://www.up.edu.br/graduacao/direito");
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this, e.Location);
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate(dicionario[comboBox1.SelectedItem.ToString()]);
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            progressBar2.Maximum = (int)e.MaximumProgress;
            progressBar2.Value = 
                ((int)e.CurrentProgress < 0 || (int)e.MaximumProgress < (int)e.CurrentProgress) 
                    ? (int)e.MaximumProgress 
                    : (int)e.CurrentProgress;
        }
    }
}
