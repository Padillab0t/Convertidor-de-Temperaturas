namespace Convertidor_de_Temperaturas
{
    public partial class Form1 : Form
    {
        //Agregamos un objeto TextBox
        private TextBox objTextBox = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Conversion()
        {
            try
            {
                double grados;
                //Si se escribe en la caja de texto, grados centigrados...
                if (objTextBox == textBox1)
                {
                    grados = Convert.ToDouble(textBox1.Text);
                    textBox2.Text = ((grados = 9 / 5) + 32).ToString();
                }
                if (objTextBox == textBox2)
                {
                    grados = (Convert.ToDouble(textBox2.Text) - 32);
                    textBox2.Text = (grados * 5 / 9).ToString();
                }
            }
            catch (FormatException)
            {
                textBox1.Text = "0.00";
                textBox2.Text = "32.00aw";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTextBox = (TextBox)sender;
            if (e.KeyChar == Convert.ToChar(13))
            {
                //Enter
                e.Handled = true;
                Conversion();
            }
        }
    }
}
