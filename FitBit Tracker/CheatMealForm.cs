using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitBit_Tracker
{
    public partial class CheatMealForm : Form
    {
        public CheatMealForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return;

            string[] row = { textBox1.Text,
                             dateTimePicker1.Text,
                             textBox3.Text,
                             textBox4.Text,
                             textBox5.Text
                            };

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
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
                listView1.SelectedItems[0].SubItems[1].Text = dateTimePicker1.Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text = textBox4.Text;
                textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text = textBox5.Text;

                MessageBox.Show("Successfully Update !!");
            }
            else
            {
                MessageBox.Show("Please select item to update !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "Delete", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            }
            else
            {
                MessageBox.Show("Please select item to Delete !");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearData();
            MessageBox.Show("Reset All");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("dddd");

            try
            {
                // Save the PDF to a specified file path
                string filePath = formattedDateTime + "_CheatMeal_records.pdf";
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                // Open the PDF document
                document.Open();

                // Add a new page
                document.NewPage();
                document.AddHeader("Meal", "Cheat Meal Report");

                // Create a table with eight columns
                PdfPTable table = new PdfPTable(5);

                table.SetWidths(new float[] { 1f, 1f, 1f, 1f, 1f });

                table.AddCell("ID");
                table.AddCell("Date");
                table.AddCell("Week");
                table.AddCell("Time");
                table.AddCell("Description");

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

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
