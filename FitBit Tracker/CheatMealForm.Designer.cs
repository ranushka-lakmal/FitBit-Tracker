namespace FitBit_Tracker
{
    partial class CheatMealForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button5 = new Button();
            label8 = new Label();
            splitContainer1 = new SplitContainer();
            dateTimePicker1 = new DateTimePicker();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            button3 = new Button();
            textBox3 = new TextBox();
            button2 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button7 = new Button();
            textBox6 = new TextBox();
            button6 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = Properties.Resources.workout_bg;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Image = Properties.Resources.home_button__1_;
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(37, 22);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(59, 57);
            button5.TabIndex = 12;
            button5.Text = "Home";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(425, 22);
            label8.Name = "label8";
            label8.Size = new Size(331, 45);
            label8.TabIndex = 11;
            label8.Text = "Cheat Meal Records";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(37, 112);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dateTimePicker1);
            splitContainer1.Panel1.Controls.Add(textBox5);
            splitContainer1.Panel1.Controls.Add(textBox4);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(textBox3);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint_1;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button7);
            splitContainer1.Panel2.Controls.Add(textBox6);
            splitContainer1.Panel2.Controls.Add(button6);
            splitContainer1.Panel2.Controls.Add(listView1);
            splitContainer1.Panel2.Controls.Add(button4);
            splitContainer1.Size = new Size(960, 559);
            splitContainer1.SplitterDistance = 392;
            splitContainer1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(110, 136);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(245, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(110, 319);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(245, 161);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(110, 258);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(245, 23);
            textBox4.TabIndex = 8;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.delete1;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(264, 498);
            button3.Name = "button3";
            button3.Size = new Size(119, 49);
            button3.TabIndex = 12;
            button3.Text = "DELETE";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 195);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 23);
            textBox3.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.refresh1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(118, 498);
            button2.Name = "button2";
            button2.Size = new Size(134, 49);
            button2.TabIndex = 11;
            button2.Text = "UPDATE";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 23);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 320);
            label5.Name = "label5";
            label5.Size = new Size(90, 18);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.plus3;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(6, 498);
            button1.Name = "button1";
            button1.Size = new Size(101, 49);
            button1.TabIndex = 10;
            button1.Text = "ADD";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 259);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 3;
            label4.Text = "Meal Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 196);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 2;
            label3.Text = "Week";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 136);
            label2.Name = "label2";
            label2.Size = new Size(84, 18);
            label2.TabIndex = 1;
            label2.Text = "Date & Time";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 77);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 0;
            label1.Text = "Meal ID";
            label1.Click += label1_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Image = Properties.Resources.search;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(406, 15);
            button7.Name = "button7";
            button7.Size = new Size(135, 42);
            button7.TabIndex = 17;
            button7.Text = "SEARCH";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(23, 16);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(381, 41);
            textBox6.TabIndex = 16;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Image = Properties.Resources.health_check;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(406, 498);
            button6.Name = "button6";
            button6.Size = new Size(135, 49);
            button6.TabIndex = 15;
            button6.Text = "REPORT GENERATE";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.GridLines = true;
            listView1.Location = new Point(23, 76);
            listView1.Name = "listView1";
            listView1.Size = new Size(518, 404);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.Click += listView1_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "date";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "week";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "meal type";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "description";
            columnHeader5.Width = 132;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 0, 64);
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Image = Properties.Resources.undo;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(23, 498);
            button4.Name = "button4";
            button4.Size = new Size(118, 49);
            button4.TabIndex = 14;
            button4.Text = "RESET";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // CheatMealForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.workout_bg;
            ClientSize = new Size(1028, 729);
            Controls.Add(splitContainer1);
            Controls.Add(button5);
            Controls.Add(label8);
            Name = "CheatMealForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheatMealForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Label label8;
        private SplitContainer splitContainer1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private DateTimePicker dateTimePicker1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button7;
        private TextBox textBox6;
    }
}