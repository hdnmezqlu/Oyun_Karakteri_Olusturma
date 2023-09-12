namespace karakter_oluşturma
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        struct karakter
        {
            public string ad;
            public string özelliği;
            public double boy;
            public int sağlık;
            public string saç;
            public string cinsiyet;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            karakter krt = new karakter();
            krt.ad = textBox1.Text;
            krt.özelliği = comboBox1.Text;
            krt.boy = Convert.ToDouble(maskedTextBox1.Text);
            krt.sağlık = Convert.ToInt32(textBox2.Text);
            krt.saç = comboBox2.Text;
            krt.cinsiyet = radioButton2.Text;
            krt.cinsiyet = radioButton3.Text;

           

            MessageBox.Show("KARAKTER OLUŞTURULDU!"+ "\n " + "Karakter Adı :" + krt.ad +"\n "+"Karakter Özelliği :" + krt.özelliği + "\n" + "Karakter Boyu :" + krt.boy + "\n" + "Karakter Sağlığı:" + krt.sağlık +"\n" + "Karakter Saç Rengi :" + krt.saç+"\n" +"Karakter Cinsiyet :"+krt.cinsiyet);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                

            }
        }
    }
}