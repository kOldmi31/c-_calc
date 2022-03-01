namespace calc_kryukova
{
    public partial class Form1 : Form
    {

        double arg_1, arg_2, arg_3;
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

        private void root_Click(object sender, EventArgs e)
        {
            try
            {
                arg_1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                flag = 4;
                result();
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

        private void devide_Click(object sender, EventArgs e)
        {
            try
            {
                arg_1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                flag = 7;
            }
            catch
            {
                textBox1.Clear();
                MessageBox.Show("Ошибка ввода.");
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            try
            {
                arg_1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                flag = 8;
            }
            catch
            {
                textBox1.Clear();
                MessageBox.Show("Ошибка ввода.");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < text.Length - 1; i++)
            {
                textBox1.Text += text[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void pow_double_Click(object sender, EventArgs e)
        {
            try
            {
                arg_1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                flag = 5;
            }
            catch
            {
                textBox1.Clear();
                MessageBox.Show("Ошибка ввода.");
            }
        }

        private void percent_Click(object sender, EventArgs e)
        {
            try
            {
                arg_1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                flag = 6;
            }
            catch
            {
                textBox1.Clear();
                MessageBox.Show("Ошибка ввода.");
            }
        }

        private void res_Click_1(object sender, EventArgs e)
        {
            result();
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

        async void result()
        {
            switch (flag)
            {
                case 1:
                    arg_3 = Convert.ToDouble(textBox1.Text);
                    arg_2 = arg_1 - Convert.ToDouble(textBox1.Text);
                    textBox1.Text = arg_2.ToString();
                    break;
                case 2:
                    arg_3 = Convert.ToDouble(textBox1.Text);
                    arg_2 = arg_1 + Convert.ToDouble(textBox1.Text);
                    textBox1.Text = arg_2.ToString();
                    break;
                case 3:
                    arg_3 = Convert.ToDouble(textBox1.Text);
                    arg_2 = Math.Pow(arg_1, Convert.ToDouble(textBox1.Text));
                    textBox1.Text = arg_2.ToString();
                    break;
                case 4:
                    try
                    {
                        arg_2 = Math.Sqrt(arg_1);
                        textBox1.Text = arg_2.ToString();
                    }
                    catch
                    {
                        textBox1.Clear();
                        MessageBox.Show("Операция недоступна.");
                    }
                    break;
                case 5:
                        arg_2 = arg_1 * arg_1;
                        textBox1.Text = arg_2.ToString();
                    break;
                case 6:
                    arg_3 = Convert.ToDouble(textBox1.Text);
                    arg_2 = Math.Round((double)(arg_1 * Convert.ToDouble(textBox1.Text) / 100));
                    textBox1.Text = arg_2.ToString();
                    break;
                case 7:
                    arg_3 = Convert.ToDouble(textBox1.Text);
                    arg_2 = arg_1 / Convert.ToDouble(textBox1.Text);
                    textBox1.Text = arg_2.ToString();
                    break;
                case 8:
                    arg_3 = Convert.ToDouble(textBox1.Text);
                    arg_2 = arg_1 * Convert.ToDouble(textBox1.Text);
                    textBox1.Text = arg_2.ToString();
                    break;
            }
            flag = 0;
        }
    }
}