
namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Khởi tạo một đối tượng Thread với phương thức xử lý tác vụ nặng DoWork()
            Thread t = new Thread(DoWork);
            Thread t1 = new Thread(DoWork_2);

            // Khởi động thread
            t.Start();
            label3.Text = "State of thread t: " + t.ThreadState.ToString(); // check trạng thái của thread Doword

            t1.Start();
            label4.Text = "State of thread t_1: " + t1.ThreadState.ToString();


            //Chạy thread
            label5.Text = "State of thread t: " + t.ThreadState.ToString();
            label6.Text = "State of thread t_1: " + t1.ThreadState.ToString();

            //Kết thúc luồng
            bool shouldStop = true; // set biến đánh dấu để dừng luồng
            t.Join(); // đợi luồng kết thúc

            label7.Text = "State of thread t: " + t.ThreadState.ToString();
            label8.Text = "State of thread t_1: " + t1.ThreadState.ToString();

            //ThreadState "WaitSleepJoin" có nghĩa là thread đang trong trạng thái chờ đợi (wait)
            //hoặc ngủ (sleep) hoặc tham gia (join) vào một thread khá


        }

        private delegate void SettextCallBack(string text);
        private void DoWork()
        {
            Thread.Sleep(3000); // cho form đứng trong 3s
            double result = 0;
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                result += i;
            }
            label1.Text = result.ToString(); // Tính tổng từ i -> số trong textbox
        }

        private bool shouldStop = false; // cờ đánh dấu tạm dừng thread

        private void DoWork_2()
        {
            for (int i = 0; i <= Convert.ToInt32(textBox1.Text); i++)
            {
                label2.Text = i.ToString(); // Tính tổng từ i -> số trong textbox
                Thread.Sleep(100);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}