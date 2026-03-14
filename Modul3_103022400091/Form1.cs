using System.Diagnostics.Eventing.Reader;

namespace Modul3_103022400091
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            double nilai = Convert.ToDouble(textBox1.Text);
            double hasil = 0;

            string dari = comboBox1.SelectedItem.ToString();
            string ke = comboBox2.SelectedItem.ToString();

            double celcius = nilai;

            if (dari == "Fahrenheit")
                celcius = (nilai - 32) * 5 / 9;
            else if (dari == "Kelvin")
                celcius = nilai - 273;
            else if (dari == "Reamur")
                celcius = nilai * 5 / 4;

            if (dari == "Fahrenheit")
                hasil = (celcius * 9 / 5) + 32;
            else if (dari == "Kelvin")
                hasil = celcius + 273;
            else if (dari == "Reamur")
                hasil = celcius * 4 / 5;
            else
                hasil = celcius;

            textBox2.Text = hasil.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
