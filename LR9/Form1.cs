namespace LR9
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
            double y = Convert.ToDouble(textBox2.Text);
            double n = Convert.ToDouble(textBox3.Text);
            double k = Convert.ToDouble(textBox4.Text);
            double sum = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < k; j++)
                {
                    sum += (i * Math.Cos(Math.Pow(x, i)) + j * Math.Sin(Math.Pow(y, j)) / (i * j));
                }
            }
            int summ = Convert.ToInt32(sum);
            textBox5.Text = Convert.ToString(summ);
            textBox6.Text = Convert.ToString(summ,2);
            textBox7.Text = Convert.ToString(summ,8);
        }
    }
}