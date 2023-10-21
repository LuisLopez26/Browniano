using Browniano.Algoritmos;
using Browniano.Modelo;

namespace Browniano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser NO VACÍOS");
                return;

            }

            int dimension = Convert.ToInt32(textBox1.Text);
            int pasos = Convert.ToInt32(textBox2.Text);
            int experimentos = Convert.ToInt32(textBox3.Text);

            if (dimension <= 0 || pasos <= 0 || pasos <= 0)
            {
                MessageBox.Show("Los números deben ser mayor que CERO");
                return;

            }

            if (dimension != 1 && dimension != 2)
            {
                MessageBox.Show("La dimensión solo puede tomar valores de 1 o 2");
                return;
            }

            AlgoritmoGenerador algoritmo = new AlgoritmoGenerador();
            List<Experimentos> listaExperimentos = algoritmo.AlgoritmoBrowniano(dimension, pasos, experimentos);
            double promedio = algoritmo.CalcularPromedioDistanciaMaxima(listaExperimentos);

            textBox4.Text = promedio.ToString();

            dataGridView1_CellContentClick(listaExperimentos);
        }

        public void dataGridView1_CellContentClick(List<Experimentos> lista)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";
            string numeroColumna4 = "4";
            string numeroColumna5 = "5";

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Coordenadas finales");
            dataGridView1.Columns.Add(numeroColumna3, "Distancia final");
            dataGridView1.Columns.Add(numeroColumna4, "Coordenadas máximas");
            dataGridView1.Columns.Add(numeroColumna5, "Distancia máxima");

            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = lista[i].Id.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = ListaACadena(lista[i].CoordenadasFinales);
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna3) - 1].Value = lista[i].DistanciaFinal.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna4) - 1].Value = ListaACadena(lista[i].CoordenadasMaximas);
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna5) - 1].Value = lista[i].DistanciaMaxima.ToString();

            }
        }

        private string ListaACadena(List<double> lista)
        {
            return string.Join(", ", lista);
        }
    }
}