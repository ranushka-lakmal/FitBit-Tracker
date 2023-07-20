namespace FitBit_Tracker
{
    partial class WorkoutRecPage
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
            panel1 = new Panel();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            cmboPatten = new ComboBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label8 = new Label();
            button5 = new Button();
            button6 = new Button();
            listView1 = new ListView();
            textBox6 = new TextBox();
            button7 = new Button();
            button8 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmboPatten);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(31, 91);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 444);
            panel1.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 250);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 23);
            textBox3.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(18, 210);
            label7.Name = "label7";
            label7.Size = new Size(104, 17);
            label7.TabIndex = 12;
            label7.Text = "Burned Calaries";
            label7.Click += label7_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(140, 301);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(197, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 23);
            textBox2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(13, 357);
            label6.Name = "label6";
            label6.Size = new Size(87, 17);
            label6.TabIndex = 9;
            label6.Text = "Weight (k.g)";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 301);
            label5.Name = "label5";
            label5.Size = new Size(81, 17);
            label5.TabIndex = 8;
            label5.Text = "Height ( f.t)";
            label5.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(143, 351);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 7;
            textBox5.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 256);
            label4.Name = "label4";
            label4.Size = new Size(132, 17);
            label4.TabIndex = 6;
            label4.Text = "Time Duration(Min)";
            label4.Click += label4_Click;
            // 
            // cmboPatten
            // 
            cmboPatten.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboPatten.FormattingEnabled = true;
            cmboPatten.Items.AddRange(new object[] { "Barbell push press", "Goblet squat", "Dumbbell single arm row", "Shoulder lateral raise", "Bench press", "Pull ups/assisted pull ups", "Barbell bicep curls" });
            cmboPatten.Location = new Point(140, 161);
            cmboPatten.Name = "cmboPatten";
            cmboPatten.Size = new Size(200, 23);
            cmboPatten.TabIndex = 5;
            cmboPatten.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 161);
            label3.Name = "label3";
            label3.Size = new Size(106, 17);
            label3.TabIndex = 4;
            label3.Text = "Exersise Pattern";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(140, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 111);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 2;
            label2.Text = "Date";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 64);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 0;
            label1.Text = "Workout Id";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.plus3;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(32, 579);
            button1.Name = "button1";
            button1.Size = new Size(109, 66);
            button1.TabIndex = 2;
            button1.Text = "ADD";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.refresh;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(163, 579);
            button2.Name = "button2";
            button2.Size = new Size(137, 66);
            button2.TabIndex = 3;
            button2.Text = "UPDATE";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.delete1;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(324, 579);
            button3.Name = "button3";
            button3.Size = new Size(127, 66);
            button3.TabIndex = 4;
            button3.Text = "DELETE";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 0, 64);
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Image = Properties.Resources.undo;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(484, 579);
            button4.Name = "button4";
            button4.Size = new Size(117, 66);
            button4.TabIndex = 5;
            button4.Text = "RESET";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(420, 20);
            label8.Name = "label8";
            label8.Size = new Size(295, 45);
            label8.TabIndex = 9;
            label8.Text = "Workout Records";
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
            button5.Location = new Point(32, 20);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(59, 57);
            button5.TabIndex = 10;
            button5.Text = "Home";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Snow;
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Image = Properties.Resources.health_check;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(625, 579);
            button6.Name = "button6";
            button6.Size = new Size(133, 66);
            button6.TabIndex = 11;
            button6.Text = "REPORT";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(470, 153);
            listView1.Name = "listView1";
            listView1.Size = new Size(537, 382);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            listView1.Click += listView1_Click_1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(470, 91);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(384, 41);
            textBox6.TabIndex = 13;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Image = Properties.Resources.search;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(876, 91);
            button7.Name = "button7";
            button7.Size = new Size(131, 42);
            button7.TabIndex = 14;
            button7.Text = "SEARCH";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Snow;
            button8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Image = Properties.Resources.dumbbells_gym_fitness_sport_icon_186993;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(786, 579);
            button8.Name = "button8";
            button8.Size = new Size(221, 66);
            button8.TabIndex = 15;
            button8.Text = "FITNESS STATUS";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // WorkoutRecPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.workout_bg;
            ClientSize = new Size(1028, 729);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(textBox6);
            Controls.Add(listView1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "WorkoutRecPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkoutRecPage";
            Load += WorkoutRecPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox cmboPatten;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private Button button5;
        private Button button6;
        private ListView listView1;
        private TextBox textBox6;
        private Button button7;
        private Button button8;
    }
}