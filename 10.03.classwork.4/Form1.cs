namespace _10._03.classwork._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(100);
            }
        }
    }
}