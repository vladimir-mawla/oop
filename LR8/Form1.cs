namespace LR8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double n = Convert.ToDouble(textBox2.Text);
            double r = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            if (radioButton1.Checked)
            {
                double result = 0;
                double chisl = 0;
                for (int i = 1; i <= n; i++)
                {
                    double znam = 2;
                    if (i != 1)
                    {
                        znam = znam * (i + 2);
                    }
                    if (i % 2 == 0)
                        chisl = chisl + (Math.Pow(x, (i-1)));
                    else
                        chisl = chisl - (Math.Pow(x, (i-1)));
                    result += chisl / znam;
                    chisl = 0;
                }
                textBox5.Text=result.ToString();
            }
            else
            {
                double result = 0;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; i <= r; i++)
                    {
                        result += (a * i) / (i*i*i+j*j*j);
                    }
                }
                textBox5.Text = result.ToString();
            }
        }
    }
}