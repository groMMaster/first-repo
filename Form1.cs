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
        int Level = 0;
        Label label;
        public Form1()
        {
            InitializeComponent();
            Levels.CreateLevels();

            label = new Label
            {
                Location = new Point(450, 300),
                Size = new Size(400, 250),
                Text = Levels.LevelList[Level].Question
            };

            checkedListBox1.Items.AddRange(new string[] { "A", "B", "C", "D", "E", "F" });

            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Arial Black", 23);
            checkedListBox1.BackColor = Color.Beige;
            checkedListBox1.MultiColumn = true;

            button1.Enabled = false;
            button1.Text = "Продолжить";
            button1.Font = new Font("Arial Black", 24);

            pictureBox1.Image = Levels.LevelList[Level].Condition;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> result = Levels.LevelList[Level].Answer;
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
            Level += 1;
            pictureBox1.Image = Levels.LevelList[Level].Condition;
            button1.Enabled = false;
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(new string[] { "A", "B", "C", "D", "E", "F" });
            label.Text = Levels.LevelList[Level].Question;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }

    public class Levels
    {
        public struct Level
        {
            public Image Condition;
            public List<string> Answer;
            public string Question;
        }

        public static List<Level> LevelList = new List<Level> { };

        public static void CreateLevels()
        {
            LevelList.Add(new Level { Condition = Resource1.B1, Answer = new List<string> { "A", "B", "C" }, 
                Question = "Укажите узлы, удаленные от данного на расстояние √5 и меньше"});
            LevelList.Add(new Level { Condition = Resource1.B2, Answer = new List<string> { "A", "B", "D" }, 
                Question = ""});
            LevelList.Add(new Level { Condition = Resource1.B3, Answer = new List<string> { "A", "B", "E" }, 
                Question = ""});
        }
    }
}
