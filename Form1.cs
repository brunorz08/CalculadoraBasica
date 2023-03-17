namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textresultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void suma_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(text1.Text);
            int b = Convert.ToInt32(text2.Text);
            int r = a + b;
            textresultado.Text = r.ToString();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(text1.Text);
            int b = Convert.ToInt32(text2.Text);
            int r = a - b;
            textresultado.Text = r.ToString();
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(text1.Text);
            int b = Convert.ToInt32(text2.Text);
            int r = a * b;
            textresultado.Text = r.ToString();
        }

        private void division_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(text1.Text);
            int b = Convert.ToInt32(text2.Text);
            int r = a / b;
            textresultado.Text = r.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
            textresultado.Text = "";
        }

      

        

    }
}