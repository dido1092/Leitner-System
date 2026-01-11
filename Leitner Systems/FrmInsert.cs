using Leitner_Systems.LeitnerSystemsData;
using Leitner_Systems.LeitnerSystemsDataModels;

namespace Leitner_Systems
{
    public partial class FrmInsert : Form
    {
        LeitnerSystemsContex context = new LeitnerSystemsContex();

        private string path = string.Empty;
        public FrmInsert()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string enW = textBoxEnWord.Text.ToUpper();
            string bgW = textBoxBgWord.Text.ToUpper();

            double intervalMilisec = SetTimers();

            if (enW.Length > 0 && bgW.Length > 0)
            {
                var enBgWords = context.EnBgWords!.Where(x => x.EnWord == enW || x.BgWord == bgW).FirstOrDefault();

                var boxOneWords = context.BoxOnes!.Where(x => x.EnWord == enW || x.BgWord == bgW).FirstOrDefault();
                var boxTwoWords = context.BoxTwos!.Where(x => x.EnWord == enW || x.BgWord == bgW).FirstOrDefault();
                var boxThreeWords = context.BoxThrees!.Where(x => x.EnWord == enW || x.BgWord == bgW).FirstOrDefault();
                var boxFourWords = context.BoxFours!.Where(x => x.EnWord == enW || x.BgWord == bgW).FirstOrDefault();
                var boxFiveWords = context.BoxFives!.Where(x => x.EnWord == enW || x.BgWord == bgW).FirstOrDefault();

                if (checkBoxInBoxOne.Checked)
                {
                    if (boxOneWords == null && boxTwoWords == null && boxThreeWords == null && boxFourWords == null && boxFiveWords == null)
                    {
                        BoxOne boxOne = new BoxOne()
                        {
                            EnWord = enW,
                            BgWord = bgW,
                            InsertDate = DateTime.Now,
                            PerformanceTime = DateTime.Now.AddMilliseconds(intervalMilisec)
                        };
                        context.BoxOnes!.Add(boxOne);

                        WordMovement wordMovement = new WordMovement()
                        {
                            EnWord = enW,
                            BgWord = bgW,
                            DisplayLanguage = "",
                            FromBox = "New word",
                            ToBox = "BoxOne",
                            Hint = false,
                            InsertDate = DateTime.Now
                        };
                        context.Add(wordMovement);
                    }
                    else
                    {
                        if (boxOneWords != null)
                        {
                            if (boxOneWords!.EnWord == enW)
                            {
                                MessageBox.Show($"This '{enW}' already exists in one of the boxOne!");
                            }
                            if (boxOneWords!.BgWord == bgW)
                            {
                                MessageBox.Show($"This '{bgW}' already exists in one of the boxOne!");
                            }
                        }
                        if (boxTwoWords != null)
                        {
                            if (boxTwoWords!.EnWord == enW)
                            {
                                MessageBox.Show($"This '{enW}' already exists in one of the boxTwo!");
                            }
                            if (boxTwoWords!.BgWord == bgW)
                            {
                                MessageBox.Show($"This '{bgW}' already exists in one of the boxTwo!");
                            }
                        }
                        if (boxThreeWords != null)
                        {
                            if (boxThreeWords!.EnWord == enW)
                            {
                                MessageBox.Show($"This '{enW}' already exists in one of the boxThree!");
                            }
                            if (boxThreeWords!.BgWord == bgW)
                            {
                                MessageBox.Show($"This '{bgW}' already exists in one of the boxThree!");
                            }
                        }
                        if (boxFourWords != null)
                        {
                            if (boxFourWords!.EnWord == enW)
                            {
                                MessageBox.Show($"This '{enW}' already exists in one of the boxFour!");
                            }
                            if (boxFourWords!.BgWord == bgW)
                            {
                                MessageBox.Show($"This '{bgW}' already exists in one of the boxFour!");
                            }
                        }
                        if (boxFiveWords != null)
                        {
                            if (boxFiveWords!.EnWord == enW)
                            {
                                MessageBox.Show($"This '{enW}' already exists in one of the boxFive!");
                            }
                            if (boxFiveWords!.BgWord == bgW)
                            {
                                MessageBox.Show($"This '{bgW}' already exists in one of the boxFive!");
                            }
                        }
                        return;
                    }
                }
                else
                {
                    if (enBgWords == null)
                    {
                        EnBgWord enBgWord = new EnBgWord()
                        {
                            EnWord = enW,
                            BgWord = bgW,
                            DateTime = DateTime.Now,
                        };
                        context.Add(enBgWord);
                    }
                    else
                    {
                        MessageBox.Show("This word already exists in the database!");
                        return;
                    }
                }

                context.SaveChanges();

                MessageBox.Show("Inserted!");

                Clear();
            }
        }
        public double SetTimers()
        {
            double interval = 0;

            var timers = context.Timers!.Select(t => new { t.Id, t.BoxOne, t.BoxTwo, t.BoxThree, t.BoxFour, t.BoxFive, t.MHD }).FirstOrDefault();

            if (timers != null)
            {
                if (timers.MHD == "Mins")
                {
                    interval = 60000; // 1 minute
                }
                else if (timers.MHD == "Hours")
                {
                    interval = 3600000; // 1 hour
                }
                else if (timers.MHD == "Days")
                {
                    interval = 86400000; // 1 day
                }
            }

            return interval;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            textBoxBgWord.Text = string.Empty;
            textBoxEnWord.Text = string.Empty;
        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButtonInsertFromFile_Click(object sender, EventArgs e)
        {
            OpenFile();
            InsertEnBgWords();
            MessageBox.Show("Import Done!");
        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
        }
        private void InsertEnBgWords()
        {
            string enWord = string.Empty;
            string bgWord = string.Empty;

            DateTime dateTimeNow = DateTime.Now;

            string[] lines = System.IO.File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                string getLine = lines[i];

                string[] arrWords = getLine.Split('-');

                if (getLine == "")
                {
                    continue;
                }

                if (getLine != "")
                {
                    enWord = arrWords[0].Trim().ToUpper();

                    bgWord = arrWords[1].Trim().ToUpper();

                    if (enWord != string.Empty && bgWord != string.Empty)
                    {
                        EnBgWord enBgWord = new EnBgWord()
                        {
                            EnWord = enWord,
                            BgWord = bgWord,
                            DateTime = dateTimeNow
                        };
                        context.EnBgWords!.Add(enBgWord);
                        context.SaveChanges();
                    }
                    bgWord = string.Empty;
                    enWord = string.Empty;
                }
            }
        }
    }
}
