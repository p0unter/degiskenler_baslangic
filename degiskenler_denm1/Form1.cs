namespace degiskenler_denm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Label1, Label2;
            Label1 = "1";
            Label2 = "2";
            label1.Text = Label1;
            label2.Text = Label2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sehir;
            sehir = textBox1.Text;
            label3.Text = sehir;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string adsoyad;
            string meslek;
            string cinsiyet;
            string yaþ;
            adsoyad = textBox2.Text;
            meslek = comboBox1.Text;
            cinsiyet = comboBox2.Text;
            yaþ = maskedTextBox1.Text;
            listBox1.Items.Add(adsoyad + ", " + meslek + ", " + cinsiyet + ", " + yaþ);
        }
    }
}