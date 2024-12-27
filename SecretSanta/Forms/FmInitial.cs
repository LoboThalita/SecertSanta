using SecretSanta.Forms;

namespace SecretSanta
{
    public partial class FmInitial : Form
    {
        public FmInitial()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbEmailWhats.Text = "Whatsapp:";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbEmailWhats.Text = "Email:";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fmNameList = new FmNameList();

            FmInitial fmInitial = this;
            fmNameList.Show();
            fmInitial.Hide();
        }
    }
}
