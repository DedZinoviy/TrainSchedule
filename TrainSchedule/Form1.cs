namespace TrainSchedule
{
    public partial class TrainSchedule : Form
    {
        public TrainSchedule()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Delete_pass_Click(object sender, EventArgs e)
        {

        }

        private void Add_pass_Click(object sender, EventArgs e)
        {
            Add_form form = new Add_form();
            form.ShowDialog();
        }
    }
}