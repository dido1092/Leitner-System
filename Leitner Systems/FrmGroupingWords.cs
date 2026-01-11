using Leitner_Systems.LeitnerSystemsData;
using Leitner_Systems.LeitnerSystemsDataCommon;
using Leitner_Systems.LeitnerSystemsDataModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Leitner_Systems
{
    public partial class FrmGroupingWords : Form
    {
        LeitnerSystemsContex context = new LeitnerSystemsContex();
        public FrmGroupingWords()
        {
            InitializeComponent();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            SetGroupingWords();

            TableGroupingWords();
        }

        public void SetGroupingWords()
        {
            string boxName = comboBoxBoxName.Text;

            int groupNum = int.Parse(comboBoxGroupNum.Text);

            int timeNum = int.Parse(comboBoxTimeNum.Text);

            string MHD = comboBoxMHD.Text;

            if (boxName != string.Empty && groupNum != 0 && timeNum != 0 && MHD != string.Empty)
            {
                var groupingWords = context.GroupingWords!.Select(g => new { g.Id, g.BoxName, g.GroupNum, g.TimeNum, g.TimeType }).Where(g => g.BoxName == boxName).FirstOrDefault();

                if (groupingWords != null)
                {
                    UpdateGroupingWords(boxName, groupNum, timeNum, MHD);
                }
                else
                {
                    GroupingWord groupingWord = new GroupingWord()
                    {
                        BoxName = boxName,
                        GroupNum = groupNum,
                        TimeNum = timeNum,
                        TimeType = MHD,
                        InsertDate = DateTime.Now
                    };
                    context.Add(groupingWord);
                    context.SaveChanges();
                }

                GroupinWords(boxName, groupNum, timeNum, MHD);

                MessageBox.Show("Done!");
            }
        }

        private void UpdateGroupingWords(string boxName, int groupNum, int timeNum, string timeType)
        {
            SqlConnection cnn = new SqlConnection(DbConfig.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            try
            {
                using (cnn = new SqlConnection(DbConfig.ConnectionString))
                {
                    cnn.Open();
                    string sqlCommand = $"Update GroupingWords set GroupNum=@GroupNum, TimeNum=@TimeNum, TimeType=@TimeType, InsertDate=@InsertDate WHERE BoxName=@BoxName";
                    cmd = new SqlCommand(sqlCommand, cnn);

                    cmd.Parameters.AddWithValue($"@GroupNum", groupNum);
                    cmd.Parameters.AddWithValue($"@BoxName", boxName);
                    cmd.Parameters.AddWithValue($"@TimeNum", timeNum);
                    cmd.Parameters.AddWithValue($"@TimeType", timeType);
                    cmd.Parameters.AddWithValue($"@InsertDate", DateTime.Now);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    cnn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void GroupinWords(string boxName, int groupNum, int timeNum, string MHD)
        {
            DateTime dateTimeToSet = new DateTime();
            List<Boxes> boxesList = new List<Boxes>();

            int count = 0;

            if (boxName == "BoxOnes")
            {
                var query = from b in context.BoxOnes!
                            select new { b.Id, b.PerformanceTime };

                var getBoxOne = query.Select(x => new BoxOne { Id = x.Id, PerformanceTime = x.PerformanceTime }).ToList().OrderBy(b => b.Id).ToList();

                boxesList = getBoxOne.Select(b => new Boxes { BoxName = "BoxOnes", Id = b.Id, PerformanceTime = b.PerformanceTime }).ToList();
            }
            else if (boxName == "BoxTwos")
            {
                var query = from b in context.BoxTwos!
                            select new { b.Id, b.PerformanceTime };

                var boxTwos = query.Select(x => new BoxTwo { Id = x.Id, PerformanceTime = x.PerformanceTime }).ToList().OrderBy(b => b.Id).ToList();

                boxesList = boxTwos.Select(b => new Boxes { BoxName = "BoxTwos", Id = b.Id, PerformanceTime = b.PerformanceTime }).ToList();
            }
            else if (boxName == "BoxThrees")
            {
                var query = from b in context.BoxThrees!
                            select new { b.Id, b.PerformanceTime };
                var boxThrees = query.Select(x => new BoxThree { Id = x.Id, PerformanceTime = x.PerformanceTime }).ToList().OrderBy(b => b.Id).ToList();

                boxesList = boxThrees.Select(b => new Boxes { BoxName = "BoxThrees", Id = b.Id, PerformanceTime = b.PerformanceTime }).ToList();
            }
            else if (boxName == "BoxFours")
            {
                var query = from b in context.BoxFours!
                            select new { b.Id, b.PerformanceTime };
                var boxFour = query.Select(x => new BoxFour { Id = x.Id, PerformanceTime = x.PerformanceTime }).ToList().OrderBy(b => b.Id).ToList();

                boxesList = boxFour.Select(b => new Boxes { BoxName = "BoxFours", Id = b.Id, PerformanceTime = b.PerformanceTime }).ToList();
            }
            else if (boxName == "BoxFives")
            {
                var query = from b in context.BoxFives!
                            select new { b.Id, b.PerformanceTime };
                var boxFive = query.Select(x => new BoxFive { Id = x.Id, PerformanceTime = x.PerformanceTime }).ToList().OrderBy(b => b.Id).ToList();

                boxesList = boxFive.Select(b => new Boxes { BoxName = "BoxFives", Id = b.Id, PerformanceTime = b.PerformanceTime }).ToList();
            }
            else if (boxName == "BoxSixs")
            {
                var query = from b in context.BoxSixs!
                            select new { b.Id, b.PerformanceTime };
                var boxSix = query.Select(x => new BoxSix { Id = x.Id, PerformanceTime = x.PerformanceTime }).ToList().OrderBy(b => b.Id).ToList();

                boxesList = boxSix.Select(b => new Boxes { BoxName = "BoxSixs", Id = b.Id, PerformanceTime = b.PerformanceTime }).ToList();
            }
            else if (boxName == "BoxSevens")
            {
                var query = from b in context.BoxSevens!
                            select new { b.Id, b.PerformanceTime };
                var boxSeven = query.Select(x => new BoxSeven { Id = x.Id, PerformanceTime = x.PerformanceTime }).ToList().OrderBy(b => b.Id).ToList();

                boxesList = boxSeven.Select(b => new Boxes { BoxName = "BoxSevens", Id = b.Id, PerformanceTime = b.PerformanceTime }).ToList();
            }
            double milliseconds = 0;

            if (MHD == "Mins")
            {
                milliseconds = timeNum * 60000;
            }
            else if (MHD == "Hours")
            {
                milliseconds = timeNum * 3600000;
            }
            else if (MHD == "Days")
            {
                milliseconds = timeNum * 86400000;
            }

            if (boxesList.Count > 0)
            {
                foreach (var dt in boxesList)
                {
                    if (count == 0)// Get the first date time from the table
                    {
                        dateTimeToSet = dt.PerformanceTime;
                    }

                    count++;
                    if (count > groupNum)// If the count is more than index then set the count to 0 and add one day to the date time for next group of words
                    {
                        count = 1;
                        dateTimeToSet = dateTimeToSet.AddMilliseconds(milliseconds);
                    }
                    if (count <= groupNum)// Set the date time to the next index words
                    {
                        GroupingBoxesPerformanceTime(dt.BoxName!, dt.Id, dateTimeToSet);
                    }
                }
            }
        }
        private void GroupingBoxesPerformanceTime(string boxName, int id, DateTime dateTimeToSet)
        {
            SqlConnection cnn = new SqlConnection(DbConfig.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            try
            {
                using (cnn = new SqlConnection(DbConfig.ConnectionString))
                {
                    cnn.Open();
                    string sqlCommand = $"Update {boxName} set PerformanceTime=@PerformanceTime WHERE Id={id}";
                    cmd = new SqlCommand(sqlCommand, cnn);

                    cmd.Parameters.AddWithValue($"@PerformanceTime", dateTimeToSet);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    cnn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void comboBoxBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string boxName = comboBoxBoxName.Text;

            var groupingWords = context.GroupingWords!.Select(g => new { g.Id, g.BoxName, g.GroupNum, g.TimeNum, g.TimeType }).Where(g => g.BoxName == boxName).FirstOrDefault();

            if (groupingWords != null)
            {
                comboBoxGroupNum.Text = groupingWords.GroupNum.ToString();
                comboBoxTimeNum.Text = groupingWords.TimeNum.ToString();
                comboBoxMHD.Text = groupingWords.TimeType;
            }
            else
            {
                comboBoxGroupNum.Text = string.Empty;
                comboBoxTimeNum.Text = string.Empty;
                comboBoxMHD.Text = string.Empty;
            }
        }
        private void FrmGroupingWords_Load(object sender, EventArgs e)
        {
            var groupingWordsCount = context.GroupingWords!.Count();

            TableGroupingWords();

            labelInfo.Text = $"Rows: {groupingWordsCount}";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            TableGroupingWords();
        }
        private void TableGroupingWords()
        {
            SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM GroupingWords", DbConfig.ConnectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, $"GroupingWords");
            dataGridViewGroupingWords.DataSource = ds.Tables[$"GroupingWords"]?.DefaultView;

            //dataGridViewGroupingWords.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void Delete()
        {
            DataGridViewCell cell = dataGridViewGroupingWords.SelectedCells[0] as DataGridViewCell;
            string value = cell.Value.ToString()!;

            int getID = int.Parse(value);

            //Remove row from DataGridView
            int rowIndex = dataGridViewGroupingWords.CurrentCell.RowIndex;
            this.dataGridViewGroupingWords.Rows.RemoveAt(rowIndex);

            //String Connection
            string connetionString = string.Empty;
            connetionString = DbConfig.ConnectionString;
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            //Delete from DB
            cmd.CommandText = ($"Delete From GroupingWords Where Id = " + getID + "");

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("The row has been deleted ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection ! ");
            }
        }
    }
}
