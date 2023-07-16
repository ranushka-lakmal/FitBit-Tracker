using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitBit_Tracker
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkoutRecPage workoutRecPage = new WorkoutRecPage();
            workoutRecPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheatMealForm cheatMealForm = new CheatMealForm();
            cheatMealForm.Show();
        }
    }
}
