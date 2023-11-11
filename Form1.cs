namespace Genera_los_números_del_1_20_con_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            while (a <= 20)
            {
                listBox1.Items.Add(a);
                a++;
            }
        }
    }
}