using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //ConfigurarChart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TBDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        private void BTNPrimos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBDesde.Text) || string.IsNullOrWhiteSpace(TBHasta.Text))
            {
                MessageBox.Show("Complete todos los campos por favor.");
                return;
            }

            int desde = int.Parse(TBDesde.Text);
            int hasta = int.Parse(TBHasta.Text);

            if (desde >= hasta)
            {
                MessageBox.Show("El valor 'Desde' debe ser menor que 'Hasta'.");
                return;
            }
            LBNumeros.Items.Clear();
            for (int i = desde; i <= hasta; i++)
            {
                if (IsPrime(i))
                {
                    LBNumeros.Items.Add(i);
                }
            }
        }

        private void BTNPares_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBDesde.Text) || string.IsNullOrWhiteSpace(TBHasta.Text))
            {
                MessageBox.Show("Complete todos los campos por favor.");
                return;
            }

            int desde = int.Parse(TBDesde.Text);
            int hasta = int.Parse(TBHasta.Text);

            if (desde >= hasta)
            {
                MessageBox.Show("El valor 'Desde' debe ser menor que 'Hasta'.");
                return;
            }
            LBNumeros.Items.Clear();
            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 == 0)
                {
                    LBNumeros.Items.Add(i);
                }
            }
        }

        private void BTNImpares_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBDesde.Text) || string.IsNullOrWhiteSpace(TBHasta.Text))
            {
                MessageBox.Show("Complete todos los campos por favor.");
                return;
            }

            int desde = int.Parse(TBDesde.Text);
            int hasta = int.Parse(TBHasta.Text);

            if (desde >= hasta)
            {
                MessageBox.Show("El valor 'Desde' debe ser menor que 'Hasta'.");
                return;
            }
            LBNumeros.Items.Clear();
            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 != 0)
                {
                    LBNumeros.Items.Add(i);
                }
            }
        }
        private void ConfigurarChart()
        {
            // Configuración inicial del Chart
            chart1.Series.Clear();
            chart1.ChartAreas.Add(new ChartArea("ChartArea1"));
        }

        private void BGFuncion_Click(object sender, EventArgs e)
        {
            // Limpiar series existentes
            chart1.Series.Clear();

            // Crear series para pares e impares
            Series seriePares = new Series("Números Pares")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.Blue
            };

            Series serieImpares = new Series("Números Impares")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.Red
            };

            // Generar datos de ejemplo
            for (int i = 1; i <= 20; i++)
            {
                if (EsPar(i))
                {
                    seriePares.Points.AddXY(i, i);
                }
                else
                {
                    serieImpares.Points.AddXY(i, i);
                }
            }

            // Agregar las series al Chart
            chart1.Series.Add(seriePares);
            chart1.Series.Add(serieImpares);
        }

        private bool EsPar(int numero)
        {
            return numero % 2 == 0;
        }
    }
}
