namespace calc_kryukova
{
    public partial class Form1 : Form
    {

        double arg_1, arg_2, arg_3, pi = Math.PI;
        int flag = 0;

        private void min_Click(object sender, EventArgs e)
        {
            try
            {
                arg_1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                flag = 1;

            }
            catch
            {
                textBox1.Clear();
                MessageBox.Show("Ошибка ввода.");
            }
        }

        private void sum_Click(object sender, EventArgs e)
        {
            try
            {
                arg_1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                flag = 2;
            }
            catch
            {
                textBox1.Clear();
                MessageBox.Show("Ошибка ввода.");
            }
        }

        private void pow_Click(object sender, EventArgs e)
        {
            try
            {
                arg_1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                flag = 3;
            }
            catch
            {
                textBox1.Clear();
                MessageBox.Show("Ошибка ввода.");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            textBox1.Text = textBox1.Text + B.Text;
        }

        private void comma_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += '.';
        }

        
    }
}