namespace ICT407P_Assignment9
{
    public partial class Form1 : Form
    {
        private string stream, batch;
        private int counter = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button_exit, "Click here to exit the application");
            t.SetToolTip(listbox_assignment, "Click here to checkdifferent options and view details on textarea");
            t.SetToolTip(combobox_assignment, "Click here to choose options from drop down list and get details in textarea");
            combobox_assignment.DropDownStyle = ComboBoxStyle.DropDownList;  // to avoid editing of combobox options
            stream = "";
            batch = "";
            t.SetToolTip(richtextbox_assignment, "Get the details related to options chosen here");
            t.SetToolTip(button_detail, "Click here to get the relevant details about option chosen");
            t.SetToolTip(button_threading, "Click here to perform multithreading");
        }

        private void listbox_assignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_assignment.SelectedIndex != 0)
            {
                stream = (string)listbox_assignment.SelectedItem;
            }
        }

        private void combobox_assignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            batch = (string)combobox_assignment.SelectedItem;
        }

        private void button_detail_Click(object sender, EventArgs e)
        {
            if (stream == "" || batch == "")
            {
                // exception to be raised
                MessageBox.Show("Both set of options need to be chosen", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            }
            else
            {
                richtextbox_assignment.Text = "Stream chosen is " + stream + " with batch " + batch;
            }
        }

        private void WorkerThread()
        {
            // simulating multithreading with thread synchronisation
            lock (this)
            {
                // Simulate some work
                for (int i = 1; i <= 10; i++)
                {
                    // Update the UI from the worker thread
                    MessageBox.Show(i.ToString());

                    // Simulate some delay
                    Thread.Sleep(1000);
                }
                MessageBox.Show("Thread " + counter.ToString() + " execution completed!");
                counter++;
            }
        }

        private void button_threading_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(WorkerThread);
            Thread t2 = new Thread(WorkerThread);
            t1.Start();
            t2.Start();
        }
    }
}
