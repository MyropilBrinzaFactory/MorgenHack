namespace MorgenHack
{
    public partial class Form1 : Form
    {

        private int field = 111;
        public Form1()
        {
            InitializeComponent();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            try
            {
                field = Convert.ToInt32(writeTextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void readButton_Click(object sender, EventArgs e)
        {
            readTextBox.Text = field.ToString();
        }
    }
}