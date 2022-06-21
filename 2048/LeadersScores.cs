using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
