using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Document = iTextSharp.text.Document;

namespace FitBit_Tracker
{
    public partial class WorkoutRecPage : Form
    {
        public WorkoutRecPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(cmboPatten.Text))
                return;

            string[] row = { textBox1.Text,
                             dateTimePicker1.Text,
                             cmboPatten.Text,
                             textBox2.Text,
                             textBox3.Text,
                             textBox4.Text,
                             textBox5.Text};

            var listItem = new ListViewItem(row);
            listView1.Items.Add(listItem);

            clearData();
            textBox1.Focus();

            MessageBox.Show("Successfully Saved!");
        }

        private void clearData()
        {
            textBox1.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            cmboPatten.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;


        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearData();
            MessageBox.Show("Reset All");
        }



        private void WorkoutRecPage_Load(object sender, EventArgs e)
        {
         

            listView1.Columns.Add("ID", 80);
            listView1.Columns.Add("Date", 120);
            listView1.Columns.Add("Excersise Pattern", 120);
            listView1.Columns.Add("Burned Calories", 120);
            listView1.Columns.Add("TIME", 120);
            listView1.Columns.Add("HEIGHT", 120);
            listView1.Columns.Add("WEIGHT", 120);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listView1_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                cmboPatten.Text = listView1.SelectedItems[0].SubItems[2].Text;

                textBox2.Text = listView1.SelectedItems[0].SubItems[3].Text; //WE //TI
                textBox3.Text = listView1.SelectedItems[0].SubItems[4].Text;//CAL //WE
                textBox4.Text = listView1.SelectedItems[0].SubItems[5].Text;//HE //HE
                textBox5.Text = listView1.SelectedItems[0].SubItems[6].Text;//TI //CAL

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
                listView1.SelectedItems[0].SubItems[1].Text = dateTimePicker1.Text;
                listView1.SelectedItems[0].SubItems[2].Text = cmboPatten.Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text = textBox3.Text;
                textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text = textBox5.Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[5].Text = textBox2.Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[6].Text = textBox4.Text;

                MessageBox.Show("Successfully Update !!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("dddd");

            try
            {
                // Save the PDF to a specified file path
                string filePath = formattedDateTime + "_workout_records.pdf";
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                // Open the PDF document
                document.Open();

                // Add a new page
                document.NewPage();

                // Create a table with eight columns
                PdfPTable table = new PdfPTable(7);

                table.SetWidths(new float[] { 1f, 1f, 1f, 1f, 1f, 1f, 1f });

                table.AddCell("Workout ID");
                table.AddCell("Date");
                table.AddCell("Exersise Pattern");
                table.AddCell("Burned Cal");
                table.AddCell("Time");
                table.AddCell("Height");
                table.AddCell("Weight");

                foreach (ListViewItem item in listView1.Items)
                {
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        table.AddCell(item.SubItems[i].Text);
                    }
                }


                document.Add(table);
                MessageBox.Show("Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                document.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        //serach btn
        private void button7_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (!item.ToString().ToLower().Contains(textBox6.Text.ToLower()))
                {
                    listView1.Items.Remove(item);
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DateTime maxDate = DateTime.MinValue;
            DateTime minDate = DateTime.MaxValue;
            double maxWeight = 0;
            double minWeight = 0;

            // to find max & min date and relevent weights
            foreach (ListViewItem item in listView1.Items)
            {
                DateTime currentDate = DateTime.Parse(item.SubItems[1].Text);


                double currentWeight = double.Parse(item.SubItems[6].Text);

                if (currentDate > maxDate)
                {
                    maxDate = currentDate;
                    maxWeight = currentWeight;
                }

                if (currentDate < minDate)
                {
                    minDate = currentDate;
                    minWeight = currentWeight;
                }
            }

            // cal weight diff
            double weightDifference = maxWeight - minWeight;
            if (weightDifference > 0)
            {
                MessageBox.Show($"Current Date: {maxDate}" +
                    $"\nWorkout Started At: {minDate}" +
                    $"\nCurrent Weight: {maxWeight}" +
                    $"\nWeight on start: {minWeight}" +
                    $"\nYou gained: {weightDifference}kgs" +
                    $"\nWAW, GREAT JOB KEEP IT !!");
            }
            else
            {
                MessageBox.Show($"Current Date: {maxDate}" +
                    $"\nWorkout Started At: {minDate}" +
                    $"\nCurrent Weight: {maxWeight}" +
                    $"\nWeight on start: {minWeight}" +
                    $"\nYou lost: {weightDifference}kgs" +
                    $"\nWAW, GREAT JOB KEEP IT !!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
