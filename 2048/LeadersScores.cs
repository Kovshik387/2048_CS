using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using _2048;

namespace _2048
{
    public partial class LeadersScores : Form
    {
        public LeadersScores()
        {
            InitializeComponent();
            SeeLeaders();
        }
        public void SeeLeaders()
        {
            List<string> leaders = new List<string>();
            using (StreamReader File = new StreamReader("..//..//scores/Data.txt"))
            {
                string line;
                while ((line = File.ReadLine()) != null)
                    leaders.Add(line);
            }

            List<string> leaders_temp = new List<string>();

            for (int i = 0; i < leaders.Count; i++)
            {
                string[] temp = (leaders[i].Split(new char[] { '\t' }));

                leaders_temp.Add(temp[0]);
            }

            for (int i = 0; i < leaders.Count;i++)
            {
                for (int j = 0; j < leaders.Count - 1; j++)
                {
                    if (int.Parse(leaders_temp[j]) < int.Parse(leaders_temp[j +1]))
                    {
                        string Temp_Int = leaders_temp[j];
                        string Temp_String = leaders[j];

                        leaders_temp[j] = leaders_temp[j + 1];
                        leaders[j] = leaders[j + 1];

                        leaders_temp[j + 1] = Temp_Int;
                        leaders[j + 1] = Temp_String;
                    }
                }
            }

            for (int i = 0; i < leaders.Count; i++)
            {
                string[] TempLeadrs = leaders[i].Split(new char[] {'\t'});

                ListViewItem Rating = new ListViewItem((i+1).ToString());
                ListViewItem.ListViewSubItem Name = new ListViewItem.ListViewSubItem(Rating,TempLeadrs[1]);
                ListViewItem.ListViewSubItem Score = new ListViewItem.ListViewSubItem(Rating,TempLeadrs[0]);

                Rating.SubItems.Add(Name);
                Rating.SubItems.Add(Score);

                View_R.Items.AddRange(new ListViewItem[] {Rating});
                
            }
        }
    }


}
