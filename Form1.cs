using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int NumberLevel = 0;
        public Form1()
        {
            InitializeComponent();
            CreateLevels();

            string[] myFruit = { "A", "B", "C", "D", "E", "F" };
            checkedListBox1.Items.AddRange(myFruit);

            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Arial Black", 23);
            checkedListBox1.BackColor = Color.Beige;
            checkedListBox1.MultiColumn = true;

            button1.Enabled = false;
            button1.Text = "Продолжить";
            button1.Font = new Font("Arial Black", 24);

            pictureBox1.Image = LevelList[NumberLevel].Condition;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> result = LevelList[NumberLevel].Answer;
            List<string> checkingResponses = new List<string> { };
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                checkingResponses.Add(itemChecked.ToString());
            }

            if (checkingResponses.SequenceEqual(result))
                button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberLevel += 1;
            pictureBox1.Image = LevelList[NumberLevel].Condition;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        public struct Level
        {
            public Image Condition;
            public List<string> Answer;
        }

        public static List<Level> LevelList = new List<Level> { };
        public void CreateLevels()
        {
            LevelList.Add(new Level { Condition = Resource1.B1, Answer = new List<string> { "A", "B", "C" } });
            LevelList.Add(new Level { Condition = Resource1.B2, Answer = new List<string> { "A", "B", "D" } });
            LevelList.Add(new Level { Condition = Resource1.B3, Answer = new List<string> { "A", "B", "E" } });
        }
    }
}