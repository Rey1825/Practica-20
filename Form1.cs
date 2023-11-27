namespace Practica_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad;
            edad = int.Parse(textBox1.Text);

            if (edad <= 12) MessageBox.Show("Es un niño");

            else

            if (edad <= 18) MessageBox.Show("Es un adolecente");

            else

            if (edad <= 60) MessageBox.Show("Es un adulto");

            else

            if (edad > 60) MessageBox.Show("Es un adulto mayor");

        }
    }
}