using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFormCarro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Context ctx = new Context();
            bindingSourceCarro.DataSource =
                ctx.Carros.ToList();
            maskedTextBox1.DataBindings.Add("Text", bindingSourceCarro, "Placa");
        }
    }
}
