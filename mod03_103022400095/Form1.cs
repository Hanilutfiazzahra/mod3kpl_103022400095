namespace mod03_103022400095
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (satuanAwal.SelectedItem == null || satuanAkhir.SelectedItem == null)
            //{
            //    MessageBox.Show("PILIH SATUAN TERLEBIH DAHULU.");
            //    return;
            //}

            double nilai;
            double hasil;
            if (!double.TryParse(nilaiAwal.Text, out nilai))
            {
                MessageBox.Show("MASUKKAN NILAI YANG VALID.");
                return;
            }

            string dari = satuanAwal.Text;
            string ke = satuanAkhir.Text;
            hasil = nilai;

            if (dari == "Celcius")
            {
                if (ke == "Fahrenheit")
                {
                    hasil = (nilai * 9 / 5) + 32;
                }
                else if (ke == "Reamur")
                {
                    hasil = nilai * 4 / 5;
                }
                else if (ke == "Kelvin")
                {
                    hasil = nilai + 273.15;
                }
            }
            else if (dari == "Fahrenheit")
            {
                if (ke == "Celcius")
                {
                    hasil = (nilai - 32) * 5 / 9;
                }
                else if (ke == "Reamur")
                {
                    hasil = (nilai - 32) * 4 / 9;
                }
                else if (ke == "Kelvin")
                {
                    hasil = (nilai - 32) * 5 / 9 + 273.15;
                }
            }
            else if (dari == "Reamur")
            {
                if (ke == "Celcius")
                {
                    hasil = nilai * 5 / 4;
                }
                else if (ke == "Fahrenheit")
                {
                    hasil = (nilai * 9 / 4) + 32;
                }
                else if (ke == "Kelvin")
                {
                    hasil = (nilai * 5 / 4) + 273.15;
                }
            }
            else if (dari == "Kelvin")
            {
                if (ke == "Celcius")
                {
                    hasil = nilai - 273.15;
                }
                else if (ke == "Fahrenheit")
                {
                    hasil = ((nilai - 273.15) * 9 / 5) + 32;
                }
                else if (ke == "Reamur")
                {
                    hasil = (nilai - 273.15) * 4 / 5;
                }
            }

            nilaiAkhir.Text = hasil.ToString();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void convert_Click(object sender, EventArgs e, double hasil)
        {
            



        }
    }
}
