namespace calc_kryukova
{
    public partial class Form1 : Form
    {

        double arg_1, arg_2, arg_3;
        int flag = 0;
        string path = "calc_history.txt";

        public Form1()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

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
                MessageBox.Show("Сначала введите аргумент!");
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
                MessageBox.Show("Сначала введите аргумент!");
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
                MessageBox.Show("Сначала введите аргумент!");
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
                MessageBox.Show("Сначала введите аргумент!");
            }
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
                MessageBox.Show("Сначала введите аргумент!");
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
                MessageBox.Show("Сначала введите аргумент!");
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
                result();
            }
            catch
            {
                textBox1.Clear();
                MessageBox.Show("Сначала введите аргумент!");
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
                MessageBox.Show("Сначала введите аргумент!");
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

        //helper text for percent button
        private void root_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(percent, "1 число - 100%, 2 число - кол-во % которое хотим вычислить от 100%");
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        //ограничение на ввод букв с клавиатуры + запятая
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                MessageBox.Show("Вы пытаетесь ввести символ. Пожалуйста,введите цифрy!");
                e.Handled = true;
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
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        await writer.WriteLineAsync(DateTime.Now.ToString() + " ___ Вычитание ___ " + arg_1 + " - " + arg_3 + " = " + textBox1.Text);
                    }
                    break;
                case 2:
                    arg_3 = Convert.ToDouble(textBox1.Text);
                    arg_2 = arg_1 + Convert.ToDouble(textBox1.Text);
                    textBox1.Text = arg_2.ToString();
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        await writer.WriteLineAsync(DateTime.Now.ToString() + " ___ Сложение ___ " + arg_1 + " + " + arg_3 + " = " + textBox1.Text);
                    }
                    break;
                case 3:
                    arg_3 = Convert.ToDouble(textBox1.Text);
                    arg_2 = Math.Pow(arg_1, Convert.ToDouble(textBox1.Text));
                    textBox1.Text = arg_2.ToString();
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        await writer.WriteLineAsync(DateTime.Now.ToString() + " ___ Возведение в степень ___ " + arg_1 + "^" + arg_3 + " = " + textBox1.Text);
                    }
                    break;
                case 4:
                    try
                    {
                        arg_2 = Math.Sqrt(arg_1);
                        textBox1.Text = arg_2.ToString();
                        using (StreamWriter writer = new StreamWriter(path, true))
                        {
                            await writer.WriteLineAsync(DateTime.Now.ToString() + " ___ Квадратный корень ___ " + "sqrt(" + arg_1 + ")" + " = " + textBox1.Text);
                        }
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
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        await writer.WriteLineAsync(DateTime.Now.ToString() + " ___ Возведение в квадрат ___ " + arg_1 + "*" + arg_1 + " = " + textBox1.Text);
                    }
                    break;
                case 6:
                    arg_3 = Convert.ToDouble(textBox1.Text);
                    arg_2 = Math.Round((double)(arg_1 * Convert.ToDouble(textBox1.Text) / 100));
                    textBox1.Text = arg_2.ToString();
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        await writer.WriteLineAsync(DateTime.Now.ToString() + " ___ Процент от числа ___ " + arg_1 + " * " + arg_3 + " / 100 " + " = " + textBox1.Text);
                    }
                    break;
                case 7:
                    arg_3 = Convert.ToDouble(textBox1.Text);
                    arg_2 = arg_1 / Convert.ToDouble(textBox1.Text);
                    textBox1.Text = arg_2.ToString();
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        await writer.WriteLineAsync(DateTime.Now.ToString() + " ___ Деление ___ " + arg_1 + " / " + arg_3 + " = " + textBox1.Text);
                    }
                    break;
                case 8:
                    arg_3 = Convert.ToDouble(textBox1.Text);
                    arg_2 = arg_1 * Convert.ToDouble(textBox1.Text);
                    textBox1.Text = arg_2.ToString();
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        await writer.WriteLineAsync(DateTime.Now.ToString() + " ___ Умножение ___ " + arg_1 + " * " + arg_3 + " = " + textBox1.Text);
                    }
                    break;
            }
            flag = 0;
        }
    }
}