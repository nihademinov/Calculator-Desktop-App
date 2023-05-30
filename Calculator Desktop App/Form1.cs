namespace Calculator_Desktop_App
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(richTextBox1.Text, out double data))
            {

            }
            else
            {
                if (richTextBox1.Text != "")
                {
                    MessageBox.Show("Only digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                richTextBox1.Text = "";
            }

        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            labelOperation.Text = "";
            labelNum.Text = "";

        }

        private void BtMinOrPlus_Click(object sender, EventArgs e)
        {
            double.TryParse(richTextBox1.Text, out double data);
            if (data < 0)
            {
                data *= -1;
                num1 = data;
                richTextBox1.Text = data.ToString();
            }
            else
            {
                data *= -1;
                num1 = data;
                richTextBox1.Text = data.ToString();
            }
        }

        private void BtPercent_Click(object sender, EventArgs e)
        {
            labelNum.Text = num1.ToString();
            labelOperation.Text = "%";
            richTextBox1.Text = "";


        }

        private void BtPlus_Click(object sender, EventArgs e)
        {
            labelNum.Text = num1.ToString();

            labelOperation.Text = "+";
            richTextBox1.Text = "";

        }

        private void BtMinus_Click(object sender, EventArgs e)
        {
            labelNum.Text = num1.ToString();

            labelOperation.Text = "-";
            richTextBox1.Text = "";

        }

        private void BtMultiplic_Click(object sender, EventArgs e)
        {
            labelNum.Text = num1.ToString();

            labelOperation.Text = "*";
            richTextBox1.Text = "";

        }

        private void BtDecimal_Click(object sender, EventArgs e)
        {
            labelNum.Text = num1.ToString();

            labelOperation.Text = "/";
            richTextBox1.Text = "";

        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
            double.TryParse(richTextBox1.Text, out double data);
            num1 = data;
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
            double.TryParse(richTextBox1.Text, out double data);
            num1 = data;

        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
            double.TryParse(richTextBox1.Text, out double data);
            num1 = data;

        }

        private void Bt4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
            double.TryParse(richTextBox1.Text, out double data);
            num1 = data;

        }

        private void Bt5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
            double.TryParse(richTextBox1.Text, out double data);
            num1 = data;

        }

        private void Bt6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6";
            double.TryParse(richTextBox1.Text, out double data);
            num1 = data;

        }

        private void BtNum7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
            double.TryParse(richTextBox1.Text, out double data);
            num1 = data;

        }

        private void Bt8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
            double.TryParse(richTextBox1.Text, out double data);
            num1 = data;

        }

        private void Bt9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
            double.TryParse(richTextBox1.Text, out double data);
            num1 = data;

        }

        private void BtZero_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "0")
            {
                richTextBox1.Text += "0";
                double.TryParse(richTextBox1.Text, out double data);
                num1 = data;
            }
        }

        private void BtDote_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains("."))
            {
                richTextBox1.Text += ".";
                double.TryParse(richTextBox1.Text, out double data);
                num1 = data;

            }
        }

        private void BtMode_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Black;
                richTextBox1.BackColor = Color.Black;
                richTextBox1.ForeColor = Color.White;
                labelOperation.BackColor = Color.Black;
                labelOperation.ForeColor = Color.White;

            }
            else
            {
                this.BackColor = Color.White;
                richTextBox1.BackColor = Color.White;
                richTextBox1.ForeColor = Color.Black;
                labelOperation.BackColor = Color.White;
                labelOperation.ForeColor = Color.Black;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelOperation_Click(object sender, EventArgs e)
        {

        }

        private void BtResult_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" && labelNum.Text != "")
            {
                double.TryParse(richTextBox1.Text, out double data1);
                double.TryParse(labelNum.Text, out double data2);
                if (labelOperation.Text == "+")
                {
                    if (data2 + data1 < 0)
                    {
                        richTextBox1.Text = "-" + (data1 + data2).ToString();

                    }
                    else
                        richTextBox1.Text = (data1 + data2).ToString();

                }
                else if (labelOperation.Text == "-")
                {
                    if (data2 - data1 < 0)
                        richTextBox1.Text = "-" + (data1 - data2).ToString();
                    else
                        richTextBox1.Text = (data1 - data2).ToString();


                }
                else if (labelOperation.Text == "/")
                {
                    if (data2 / data1 < 0)
                        richTextBox1.Text = "-" + (data1 / data2).ToString();
                    else
                        richTextBox1.Text = (data1 / data2).ToString();

                }
                else if (labelOperation.Text == "*")
                {
                    if (data2 * data1 < 0)
                        richTextBox1.Text = "-" + (data1 * data2).ToString();
                    else
                        richTextBox1.Text = (data1 * data2).ToString();


                }
                labelOperation.Text = "";
                labelNum.Text = "";

            }

        }
    }
}