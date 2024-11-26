namespace to_do_list
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            title = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            button5 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            button6 = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.Dock = DockStyle.Top;
            title.Font = new Font("Mongolian Baiti", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title.ImageAlign = ContentAlignment.TopCenter;
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(535, 75);
            title.TabIndex = 0;
            title.Text = "TODO";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(0, 75);
            button1.Name = "button1";
            button1.Size = new Size(535, 72);
            button1.TabIndex = 1;
            button1.Text = "Add task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Top;
            button2.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(0, 147);
            button2.Name = "button2";
            button2.Size = new Size(535, 72);
            button2.TabIndex = 2;
            button2.Text = "View tasks";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Top;
            button3.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(0, 219);
            button3.Name = "button3";
            button3.Size = new Size(535, 72);
            button3.TabIndex = 3;
            button3.Text = "Delete task";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Top;
            button4.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(0, 291);
            button4.Name = "button4";
            button4.Size = new Size(535, 72);
            button4.TabIndex = 4;
            button4.Text = "Notes";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 393);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Bottom;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(0, 324);
            button5.Name = "button5";
            button5.Size = new Size(535, 69);
            button5.TabIndex = 2;
            button5.Text = "Add and continue";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button5_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(52, 138);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(442, 74);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Mongolian Baiti", 30F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(535, 135);
            label1.TabIndex = 0;
            label1.Text = "Add task";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(532, 393);
            panel2.TabIndex = 0;
            panel2.Visible = false;
            // 
            // button6
            // 
            button6.Location = new Point(211, 321);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 2;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(144, 95);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(244, 204);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Mongolian Baiti", 30F);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(532, 104);
            label2.TabIndex = 0;
            label2.Text = "View tasks";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 397);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(title);
            Name = "Form1";
            Text = "to-do";
            Resize += panel1_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void AddControlsToPanel1()
        {
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button5);
        }
        private void AddControlsToPanel2()
        {
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button6);

        }
        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }
        private void panel2_Resize(object sender, EventArgs e)
        {
            panel2.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);

        }
        #endregion

        private Label title;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Button button5;
        private Panel panel2;
        private Label label2;
        private ListBox listBox1;
        private Button button6;
    }
}
