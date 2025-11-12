namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
       // public UsersManeger maneger = new UsersManeger();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  UsersManeger maneger = new UsersManeger();

            if (textBox1.Text == "" || textBox2.Text == "")
                return;

            if (UsersManeger.isConnect(textBox1.Text, textBox2.Text))
            {
                Form3 newForm = new Form3();
                newForm.ShowDialog();
            }
            else
            {
                label3.Text = "אינך קיים במערכת";
                Form2 newForm = new Form2();
                newForm.ShowDialog();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
