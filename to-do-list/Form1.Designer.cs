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
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
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
            title.Click += title_Click;
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
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 462);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 216);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(442, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Mongolian Baiti", 30F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(682, 83);
            label1.TabIndex = 0;
            label1.Text = "Add task";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 455);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(title);
            Name = "Form1";
            Text = "to-do";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void AddControlsToPanel()
        {
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
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
    }
}
