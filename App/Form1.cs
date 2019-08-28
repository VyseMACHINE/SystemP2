using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace T9App
{
    public partial class Form1 : Form
    {
        List<string> vocabulary = new List<string>();
        Thread thT9 = null;

        public Form1()
        {
            InitializeComponent();
            Init();

            string vocabularyItemsForLogging = "";

            foreach(var item in vocabulary) vocabularyItemsForLogging += item + "\r\n";

            MessageBox.Show("Стартовый словарь для Т9:\r\n\r\n" + vocabularyItemsForLogging + "\r\n\r\n" + "В программе есть возможность добавления новых слов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Init()
        {
            vocabulary.Add("Apple");
            vocabulary.Add("apple");
            vocabulary.Add("Iphone");
            vocabulary.Add("iphone");
            vocabulary.Add("Samsung");
            vocabulary.Add("samsung");
            vocabulary.Add("House");
            vocabulary.Add("house");
            vocabulary.Add("Computer");
            vocabulary.Add("computer");
            vocabulary.Add("Coordinate");
            vocabulary.Add("coordinate");
        }

        public string FindLastWord()
        {
            int lastSpacePosition = 0;

            string text = writingTB.Text;
            List<char> symbols = text.ToList<char>();
 
            for(int i = 0; i < symbols.Count; i++)
            {
                if (symbols[i] == ' ') lastSpacePosition = (i+1);
            }

            string result =  text.Remove(0, lastSpacePosition);

            return result;
        }

        private void writingTB_TextChanged(object sender, EventArgs e)
        {
            log.Text = " ";
            thT9 = new Thread(T9Routine);
            thT9.IsBackground = true;
            thT9.Start();
        }

        private void T9Routine()
        {
            log.Invoke(new Action<string>(
                (x) =>
                {
                    log.Text = x;
                    log.Update();
                }
                ), t9(FindLastWord()));
        }

        public string t9(string str)
        {
            string word = "";

            for (int i = 0; i < vocabulary.Count; i++)
            {
                if (vocabulary[i].Contains(str))
                {
                    word = vocabulary[i];
                }
            }

            return word;
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            vocabulary.Add(FindLastWord());
        }

        private void btnUseWord_Click(object sender, EventArgs e)
        {
            string result = " ";
            if (writingTB.Text.Contains(FindLastWord()))
            {
                result = writingTB.Text.Remove(writingTB.Text.Length - FindLastWord().Length, FindLastWord().Length);
            }

            result += t9(FindLastWord());

            writingTB.Text = result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
