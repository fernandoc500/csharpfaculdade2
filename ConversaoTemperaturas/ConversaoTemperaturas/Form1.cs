using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversaoTemperaturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            
            switch(tempIni.SelectedItem.ToString())
            {
                case "Celsius":
                    Celsius c = new Celsius(Convert.ToDouble(textBox1.Text));
                    switch(tempDestino.SelectedItem.ToString())
                    {
                        case "Fahrenheit":
                            res.Text = c.ToFahrenheit().ToString();
                            break;

                        case "Kelvin":
                            res.Text = c.ToKelvin().ToString();
                            break;

                        case "Rankine":
                            res.Text = c.ToRankine().ToString();
                            break;

                        case "Reaumur":
                            res.Text = c.ToReaumur().ToString();
                            break;

                        default:
                            res.Text = textBox1.Text;
                            break;
                    }
                    break;

                case "Fahrenheit":
                    Fahrenheit f = new Fahrenheit(Convert.ToDouble(textBox1.Text));
                    switch (tempDestino.SelectedItem.ToString())
                    {
                        case "Celsius":
                            res.Text = f.ToCelsius().ToString();
                            break;

                        case "Kelvin":
                            res.Text = f.ToKelvin().ToString();
                            break;

                        case "Rankine":
                            res.Text = f.ToRankine().ToString();
                            break;

                        case "Reaumur":
                            res.Text = f.ToReaumur().ToString();
                            break;

                        default:
                            res.Text = textBox1.Text;
                            break;
                    }
                    break;

                case "Kelvin":
                    Kelvin k = new Kelvin(Convert.ToDouble(textBox1.Text));
                    switch (tempDestino.SelectedItem.ToString())
                    {
                        case "Celsius":
                            res.Text = k.ToCelsius().ToString();
                            break;

                        case "Fahrenheit":
                            res.Text = k.ToFahrenheit().ToString();
                            break;

                        case "Rankine":
                            res.Text = k.ToRankine().ToString();
                            break;

                        case "Reaumur":
                            res.Text = k.ToReaumur().ToString();
                            break;

                        default:
                            res.Text = textBox1.Text;
                            break;
                    }
                    break;

                case "Rankine":

                    Rankine r = new Rankine(Convert.ToDouble(textBox1.Text));
                    switch (tempDestino.SelectedItem.ToString())
                    {
                        case "Celsius":
                            res.Text = r.ToCelsius().ToString();
                            break;

                        case "Fahrenheit":
                            res.Text = r.ToFahrenheit().ToString();
                            break;

                        case "Kelvin":
                            res.Text = r.ToKelvin().ToString();
                            break;

                        case "Reaumur":
                            res.Text = r.ToReaumur().ToString();
                            break;

                        default:
                            res.Text = textBox1.Text;
                            break;
                    }
                    break;

                case "Reaumur":

                    Reaumur re = new Reaumur(Convert.ToDouble(textBox1.Text));
                    switch (tempDestino.SelectedItem.ToString())
                    {
                        case "Celsius":
                            res.Text = re.ToCelsius().ToString();
                            break;

                        case "Fahrenheit":
                            res.Text = re.ToFahrenheit().ToString();
                            break;

                        case "Kelvin":
                            res.Text = re.ToKelvin().ToString();
                            break;

                        case "Rankine":
                            res.Text = re.ToRankine().ToString();
                            break;

                        default:
                            res.Text = textBox1.Text;
                            break;
                    }
                    break;

                default:
                    MessageBox.Show("Selecione uma opção no dropdown");
                    break;
                }
            } catch (Exception excp)
            {
                MessageBox.Show("Selecione as duas opções de temperatura e coloque a temperatura inicial para converter.");
            }
        }
    }
}
