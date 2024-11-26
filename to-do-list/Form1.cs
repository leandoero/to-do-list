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
        private void Button1_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.Visible = true;
            panel2.Visible = false;

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            inputTask = textBox1.Text;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputTask))
            {
                classForLogic.addTask(inputTask);
                panel1.Visible = false;
                textBox1.Clear();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
