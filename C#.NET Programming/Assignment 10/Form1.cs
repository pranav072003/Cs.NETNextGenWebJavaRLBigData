namespace ICT407P_Assignment10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string detail = "Name- " + textbox_name.Text + " Enrollment Number- " + textbox_enrollnum.Text;
            MessageBox.Show(detail);
        }
    }
}
