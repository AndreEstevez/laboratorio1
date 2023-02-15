using libreria;

namespace laboratorio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            libreria.Class1 suma = new libreria.Class1(a, b);
            textBox3.Text = suma.suma().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            libreria.Class1 resta = new libreria.Class1(a, b);
            textBox3.Text = resta.resta().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            libreria.Class1 div = new libreria.Class1(a, b);
            textBox3.Text = div.div().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            libreria.Class1 mult = new libreria.Class1(a, b);
            textBox3.Text = mult.multi().ToString();
        }

       
    }
}