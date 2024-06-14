namespace Calculador_Notas_Finales

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float nota_corte1, nota_corte2, nota_corte3;
            nota_corte1 = float.Parse(textBox2.Text);
            nota_corte2 = float.Parse(textBox3.Text);
            nota_corte3 = float.Parse(textBox4.Text);


            float nota_definitiva = (nota_corte1 * 0.35f) + (nota_corte2 * 0.35f) + (nota_corte3 * 0.30f);

            nota_definitiva = (float)Math.Round(nota_definitiva, 1);

            textBox5.Text = nota_definitiva.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Clientedal.CrearEstudiante(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text) > 0)
            {
                MessageBox.Show("Estudiante agregado con exito");
            }
            else
                MessageBox.Show("Error al registrar al estudiante"); 
        }
    }
}