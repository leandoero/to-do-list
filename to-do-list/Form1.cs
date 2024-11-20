using Logic;
using System.Collections.Specialized;

namespace to_do_list
{
    public partial class Form1 : Form
    {
        private ClassForLogic classForLogic;
        private string inputTask;
        public Form1()
        {
            InitializeComponent();
            classForLogic = new ClassForLogic();
            inputTask = string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            panel2.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
            panel1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            inputTask = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputTask))
            {
                classForLogic.addTask(inputTask);
                panel1.Visible = false;
                textBox1.Clear();
            }
        }

        
    }
}
