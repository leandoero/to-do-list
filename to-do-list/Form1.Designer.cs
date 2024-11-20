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
            title.Size = new Size(682, 83);
            title.TabIndex = 0;
            title.Text = "TODO";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(0, 83);
            button1.Name = "button1";
            button1.Size = new Size(682, 80);
            button1.TabIndex = 1;
            button1.Text = "Add task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Top;
            button2.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(0, 163);
            button2.Name = "button2";
            button2.Size = new Size(682, 80);
            button2.TabIndex = 2;
            button2.Text = "View tasks";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Top;
            button3.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(0, 243);
            button3.Name = "button3";
            button3.Size = new Size(682, 80);
            button3.TabIndex = 3;
            button3.Text = "Delete task";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Top;
            button4.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(0, 323);
            button4.Name = "button4";
            button4.Size = new Size(682, 80);
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
            panel1.Location = new Point(632, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 458);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Bottom;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(0, 389);
            button5.Name = "button5";
            button5.Size = new Size(682, 69);
            button5.TabIndex = 2;
            button5.Text = "Add and continue";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(126, 171);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(442, 74);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Mongolian Baiti", 30F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(682, 135);
            label1.TabIndex = 0;
            label1.Text = "Add task";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(38, 443);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 458);
            panel2.TabIndex = 0;
            panel2.Visible = false;
            // 
            // button6
            // 
            button6.Location = new Point(294, 232);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 2;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(269, 308);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Mongolian Baiti", 30F);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(682, 135);
            label2.TabIndex = 0;
            label2.Text = "View tasks";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 455);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(title);
            Name = "Form1";
            Text = "to-do";
            Resize += panel2_Resize;
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
            panel1.Width = this.ClientSize.Width;
            panel1.Height = this.ClientSize.Height;
            panel1.Size= new Size(this.ClientSize.Width, this.ClientSize.Height);
        }
        private void panel2_Resize(object sender, EventArgs e)
        {
            panel2.Width = this.ClientSize.Width;
            panel2.Height = this.ClientSize.Height;
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
