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
        public int Level = 0;
        public Form1()
        {
            InitializeComponent();
            Levels.CreateLevels();
            CreateTextСondition();
            CreateResponseForm();
            CreateJumpButton();
            GraphicСondition.Image = Levels.LevelList[Level].Condition;
        }

        public void CreateJumpButton()
        {
            JumpButton.Enabled = false;
            JumpButton.Text = "Продолжить";
            JumpButton.Font = new Font("Arial Black", 24);
        }

        public void CreateTextСondition()
        {
            TextСondition.Location = new Point(476, 45);
            TextСondition.Text = Levels.LevelList[Level].Question;
            TextСondition.Font = new Font("Arial Black", 23);
            TextСondition.MaximumSize = new Size(450, 0);
            TextСondition.BackColor = Color.Beige;
        }

        public void CreateResponseForm()
        {
            ResponseForm.Items.AddRange(new string[] { "A", "B", "C", "D", "E", "F" });
            ResponseForm.CheckOnClick = true;
            ResponseForm.Font = new Font("Arial Black", 23);
            ResponseForm.BackColor = Color.Beige;
            ResponseForm.MultiColumn = true;
        }

        private void ResponseForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> result = Levels.LevelList[Level].Answer;
            List<string> checkingResponses = new List<string> { };
            foreach (object itemChecked in ResponseForm.CheckedItems)
            {
                checkingResponses.Add(itemChecked.ToString());
            }

            if (checkingResponses.SequenceEqual(result))
                JumpButton.Enabled = true;
        }

        private void JumpButton_Click(object sender, EventArgs e)
        {
            Level += 1;
            if (Level == Levels.LevelList.Count)
            {
                
            }

            GraphicСondition.Image = Levels.LevelList[Level].Condition;
            JumpButton.Enabled = false;
            ResponseForm.Items.Clear();
            ResponseForm.Items.AddRange(new string[] { "A", "B", "C", "D", "E", "F" });
            TextСondition.Text = Levels.LevelList[Level].Question;
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
            LevelList.Add(new Level
            {
                Condition = Resource1.L1,
                Answer = new List<string> { "F" },
                Question = "Укажите узел, симметричный данному"
            });

            LevelList.Add(new Level
            {
                Condition = Resource1.L2,
                Answer = new List<string> { "B" },
                Question = "Укажите узел, равноудаленный от данных"
            });

            LevelList.Add(new Level
            {
                Condition = Resource1.L3,
                Answer = new List<string> { "A", "B", "C" },
                Question = "Укажите узлы, удаленные от данного на расстояние √5 и меньше"
            });
        }
    }
}
