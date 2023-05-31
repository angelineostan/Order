using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Prelim_exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float folder = Convert.ToSingle(textBox1.Text);
            textBox6.Text = (5.25 * folder).ToString();

            float glue = Convert.ToSingle(textBox2.Text);
            textBox7.Text = (28.69 * glue).ToString();

            float bondpaper = Convert.ToSingle(textBox3.Text);
            textBox8.Text = (2.25 * bondpaper).ToString();

            float ballpen = Convert.ToSingle(textBox4.Text);
            textBox9.Text = (8.15 * ballpen).ToString();

            float scissor = Convert.ToSingle(textBox5.Text);
            textBox10.Text = (30.50 * scissor).ToString();

            textBox11.Text = (5.25 * folder + 28.69 * glue + 2.25 * bondpaper + 8.15 * ballpen + 30.50 * scissor).ToString();

            textBox12.Text = (0.07 * (5.25 * folder + 28.69 * glue + 2.25 * bondpaper + 8.15 * ballpen + 30.50 * scissor)).ToString();

            textBox18.Text = ((5.25 * folder + 28.69 * glue + 2.25 * bondpaper + 8.15 * ballpen + 30.50 * scissor) +
                             (0.07 * (5.25 * folder + 28.69 * glue + 2.25 * bondpaper + 8.15 * ballpen + 30.50 * scissor))).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            float amount = Convert.ToSingle(textBox16.Text);
            float netprice = Convert.ToSingle(textBox18.Text);
            textBox17.Text = (amount - netprice).ToString();



            MessageBox.Show("Thank you for your purchase: " + textBox13.Text + " " +
                "\nContact Number : " + textBox14.Text + " " + 
                "\nYour purchase is amounting to: " + textBox18.Text + " " + 
                "\nCash rendered: " + textBox18.Text + " " + 
                "\nYour change is: " + textBox17.Text + " " + 
                "\nYour purchase is dated: " + dateTimePicker1.Text + " ", "Customer Confirmation");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for Serving!!!");
            this.Close();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}