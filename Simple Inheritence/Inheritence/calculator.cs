namespace Baisakh_vbclass
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 - num2;
            label6.Text = result.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 + num2;
            label6.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 * num2;
            label6.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 / num2;
            label6.Text = result.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int num1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Reject any non-digit key
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int num2;
        }
    }
}
