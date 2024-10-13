namespace ICT407P_Assignment5_TemparatureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            if (combobox_temp_scale.SelectedIndex == -1)
            {
                MessageBox.Show("Option not selected properly", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (combobox_temp_scale.SelectedIndex == 0)
            {
                // for Celsius scale
                try
                {
                    double temp = Double.Parse(textbox_temp_num.Text);
                    double fahren_temp = 1.8 * temp + 32.0;
                    textbox_result.Clear();
                    textbox_result.Focus();
                    textbox_result.Text = "Converted temparature is " + fahren_temp.ToString() + " degrees fahrenheit.";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Number Parse Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                // for Fahrenheit scale
                try
                {
                    double temp = Double.Parse(textbox_temp_num.Text);
                    double cels_temp = (temp - 32.0) * 5 / 9;
                    textbox_result.Clear();
                    textbox_result.Focus();
                    textbox_result.Text = "Converted temparature is " + cels_temp.ToString() + " degrees celsius.";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Number Parse Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
