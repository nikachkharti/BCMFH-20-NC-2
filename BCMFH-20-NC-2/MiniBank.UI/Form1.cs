namespace MiniBank.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void msg1Btn_Click(object sender, EventArgs e)
        {
            Thread thread1 = new(() => SetMessageText("Message 1", 3000));
            thread1.Start();
        }

        private void msg2Btn_Click(object sender, EventArgs e)
        {
            Thread thread2 = new(() => SetMessageText("Message 2", 5000));
            thread2.Start();
        }

        private void SetMessageText(string message, int delay)
        {
            Thread.Sleep(delay);
            labelMessage.Text = message;
        }

    }
}
