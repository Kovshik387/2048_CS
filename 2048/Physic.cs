using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2048;
using System.IO;
using System.Media;

namespace _2048
{
    public partial class Game4 : Form
    {
        private int[,] Field = new int[4, 4];
        private Label[,] Labels = new Label[4,4];
        private PictureBox[,] pics = new PictureBox[4, 4];
        private int score = 0;
        bool GameOverLeft, GameOverRight, GameOverUp, GameOverDown; // old
        public static string NameProfile;


        private void Volume()
        {
            SoundPlayer player = new SoundPlayer("..//..//assets/sound.wav");

            player.Play();
        }

        public Game4()
        {
            InitializeComponent();
            Game2048();
            this.KeyDown += new KeyEventHandler(Keybord);
        }

        ~Game4()
        {
            Application.Exit();
        }

        private void Game2048()
        {
            GameFalse();
            CreateMap();
            RefreshGame();
            CreateObject();
        }

        private void GameOverWindow()
        {
            MessageBox.Show("Конец Игры!", "");
            Refresh.Enabled = true;
            Rating.Enabled = true;
            Refresh.Visible = true;
            Rating.Visible = true;

            if (NameProfile != null)
            {
                List<string> leaders = new List<string>();
                using (StreamReader File = new StreamReader("..//..//scores/Data.txt"))
                {
                    string line;
                    while ((line = File.ReadLine()) != null)
                        leaders.Add(line);
                }
                
                List<string> leaders_temp = new List<string>();
                List<string> leaders_NewTemp = new List<string>();

                for (int i = 0; i < leaders.Count; i++)
                {
                    string[] temp = (leaders[i].Split(new char[] { '\t' }));
                    leaders_temp.Add(temp[1]);
                    leaders_NewTemp.Add(temp[0]);

                    if (NameProfile == leaders_temp[i])
                    {
                        if (score > int.Parse(leaders_NewTemp[i]))
                        {
                            leaders.RemoveAt(i);
                        }
                    }
                }

                using (StreamWriter file = new StreamWriter("..//..//scores/Data.txt", false))
                {
                    for (int i = 0; i < leaders.Count; i++)
                        file.WriteLine(leaders[i]);
                }

                using (StreamWriter file = new StreamWriter("..//..//scores/Data.txt",true))
                {
                    file.WriteLine(score.ToString() + "\t" + NameProfile);
                }
            }
        }

        private void GameFalse()
        {
            GameOverLeft = false; GameOverRight = false; GameOverUp = false; GameOverDown = false;
        }

        private void RefreshGame()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Field[i, j] = 0;
                    this.Controls.Remove(pics[i, j]);
                    this.Controls.Remove(Labels[i, j]);
                    pics[i, j] = null;
                }
            }
            score = 0;
            Score_.Text = score.ToString();
            Refresh.Visible = false;
            Refresh.Enabled = false;
            Rating.Visible  = false;
            Rating.Enabled  = false;
        }

        private void CreateMap()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    PictureBox pics = new PictureBox
                    {
                        Location = new Point(12 + 56 * j, 46 + 56 * i),
                        Size = new Size(50, 50),
                        BackColor = Color.FromArgb(205, 191, 180)
                    };
                    this.Controls.Add(pics);
                }
        }

        private void CreateObject()
        {
            Random random = new Random();

            // Первый квадрат
            int NumA = random.Next(0, 4);
            int NumB = random.Next(0, 4);

            while (pics[NumA, NumB] != null)
            {
                NumA = random.Next(0, 4);
                NumB = random.Next(0, 4);
            }

            Field[NumA, NumB] = 1;

            pics[NumA, NumB] = new PictureBox();
            Labels[NumA, NumB] = new Label
            {
                Text = "2",
                Size = new Size(50, 50),
                Font = new Font(new FontFamily("Cascadia Code SemiBold"), 15)
            };
            pics[NumA, NumB].Controls.Add(Labels[NumA, NumB]);
            pics[NumA, NumB].Location = new Point(12 + NumB * 56, 46 + NumA * 56);
            pics[NumA, NumB].Size = new Size(50, 50);
            pics[NumA, NumB].BackColor = Color.FromArgb(239, 227, 215);
            this.Controls.Add(pics[NumA, NumB]);
            pics[NumA, NumB].BringToFront();

            
            //Второй квадрат
            int BeginA = random.Next(0, 4);
            int BeginB = random.Next(0, 4);
            while (pics[BeginA, BeginB] != null)
            {
                BeginA = random.Next(0, 4);
                BeginB = random.Next(0, 4);
            }

            Field[BeginA, BeginB] = 1;

            pics[BeginA, BeginB] = new PictureBox();
            Labels[BeginA, BeginB] = new Label
            {
                Text = "2",
                Size = new Size(50, 50),
                Font = new Font(new FontFamily("Cascadia Code SemiBold"), 15)
            };
            pics[BeginA, BeginB].Controls.Add(Labels[BeginA, BeginB]);
            pics[BeginA, BeginB].Location = new Point(12 + 56 * BeginB, 46 + 56 * BeginA);
            pics[BeginA, BeginB].Size = new Size(50, 50);
            pics[BeginA, BeginB].BackColor = Color.FromArgb(239, 227, 215);
            this.Controls.Add(pics[BeginA, BeginB]);
            pics[BeginA, BeginB].BringToFront();
        }

        private void GenerateNewCell()
        {
            Random random = new Random();

            int or = random.Next(0, 10);

            if (or == 8)
            {
                int NumA = random.Next(0, 4);
                int NumB = random.Next(0, 4);
                while (pics[NumA, NumB] != null)
                {
                    NumA = random.Next(0, 4);
                    NumB = random.Next(0, 4);
                }

                Field[NumA, NumB] = 1;
                pics[NumA, NumB] = new PictureBox();
                Labels[NumA, NumB] = new Label();

                Task task = Task.Factory.StartNew(() => AnimationFront(NumA, NumB));

                Labels[NumA, NumB].Text = "4";
                Labels[NumA, NumB].Font = new Font(new FontFamily("Cascadia Code SemiBold"), 15);
                pics[NumA, NumB].Controls.Add(Labels[NumA, NumB]);
                pics[NumA, NumB].Location = new Point(12 + NumB * 56, 46 + NumA * 56);
                pics[NumA, NumB].BackColor = Color.FromArgb(238, 223, 202);
                this.Controls.Add(pics[NumA, NumB]);
                
                pics[NumA, NumB].BringToFront();
            }
            else
            {
                int NumA = random.Next(0, 4);
                int NumB = random.Next(0, 4);
                while (pics[NumA, NumB] != null)
                {
                    NumA = random.Next(0, 4);
                    NumB = random.Next(0, 4);
                }

                Field[NumA, NumB] = 1;

                pics[NumA, NumB] = new PictureBox();
                Labels[NumA, NumB] = new Label
                {
                    Text = "2",
                    Font = new Font(new FontFamily("Cascadia Code SemiBold"), 15)
                };

                Task task = Task.Factory.StartNew(() => AnimationFront(NumA, NumB));
                                                
                pics[NumA, NumB].Controls.Add(Labels[NumA, NumB]);
                pics[NumA, NumB].Location = new Point(12 + NumB * 56, 46 + NumA * 56);
                pics[NumA, NumB].BackColor = Color.FromArgb(239, 227, 215);

                this.Controls.Add(pics[NumA, NumB]);

                pics[NumA, NumB].BringToFront();

                Task.WaitAll(task);
                
            }
        }

        void AnimationFront(int a, int b)
        {
            for (int i = 1; i < 6; i++)
            {
                Thread.Sleep(2);
                pics[a, b].Size = new Size(i * 10, i * 10);
            }
            Thread.Sleep(20);
        }
        private void Start_Game_Click(object sender, EventArgs e)
        {
            Start_Game.Visible  = false;
            Start_Game.Enabled  = false;
            Profile.Visible     = false;
            Profile.Enabled     = false;
            Rating.Enabled      = false;
            Rating.Visible      = false;

        }

        private void Profile_Click(object sender, EventArgs e)
        {
            Profile_Form prof = new Profile_Form();

            prof.ShowDialog();

        }

        private void Rating_Click(object sender, EventArgs e)
        {
            LeadersScores lead = new LeadersScores();

            lead.ShowDialog();
        }

        private void ChangeColor(int sum,int j, int i)
        {
            if (sum % 1024 == 0)     pics[j, i].BackColor  = Color.FromArgb(239, 197,  63);
            else if (sum % 512 == 0) pics[j, i].BackColor  = Color.FromArgb(233, 199, 101);
            else if (sum % 256 == 0) pics[j, i].BackColor  = Color.FromArgb(234, 195,  86);
            else if (sum % 128 == 0) pics[j, i].BackColor  = Color.FromArgb(233, 199, 101);
            else if (sum % 64 == 0)  pics[j, i].BackColor  = Color.FromArgb(247, 94,   60);
            else if (sum % 32 == 0)  pics[j, i].BackColor  = Color.FromArgb(245, 124,  95);
            else if (sum % 16 == 0)  pics[j, i].BackColor  = Color.FromArgb(245, 149, 101);
            else if (sum % 8 == 0)   pics[j, i].BackColor  = Color.FromArgb(242, 177, 121);
            else if (sum % 4 == 0)   pics[j, i].BackColor  = Color.FromArgb(238, 223, 202);
            else if (sum % 2048 == 0) 
            {
                pics[j, i].BackColor = Color.FromArgb(238, 223, 202);
                Refresh.Enabled = true;
                Rating.Enabled = true;
                Refresh.Visible = true;
                Rating.Visible = true;
                MessageBox.Show("Вы выиграли", "");
            }
        }

        private void Keybord(object sender, KeyEventArgs e)
        {
            bool flag = false;

            if ((GameOverDown == true) && (GameOverLeft == true) && (GameOverRight == true) && (GameOverUp == true)) { GameOverWindow(); }

            switch (e.KeyCode.ToString())
            {
                case "Right":
                    for (int j = 0; j < 4; j++)
                    {
                        for (int ij = 2; ij >= 0; ij--)
                        {
                            if (Field[j, ij] == 1)
                            {
                                for (int i = ij + 1; i < 4; i++)
                                {
                                    if (Field[j, i] == 0)
                                    {
                                        
                                        flag = true;
                                        GameOverRight = false;
                                        Field[j, i - 1] = 0;
                                        Field[j, i] = 1;
                                        pics[j, i] = pics[j, i - 1];
                                        pics[j, i - 1] = null;
                                        Labels[j, i] = Labels[j, i - 1];
                                        Labels[j, i - 1] = null;
                                        pics[j, i].Location = new Point(pics[j, i].Location.X + 56, pics[j, i].Location.Y);
                                        Volume();
                                    }
                                    else
                                    {
                                        int NumA = int.Parse(Labels[j, i].Text);
                                        int NumB = int.Parse(Labels[j, i - 1].Text);
                                        if (NumA == NumB)
                                        {
                                            
                                            flag = true;
                                            GameFalse();
                                            score += NumA + NumB;
                                            Score_.Text = score.ToString();
                                            ChangeColor(NumA + NumB, j, i);
                                            Labels[j, i].Text = (NumB + NumA).ToString();
                                            Field[j, i - 1] = 0;
                                            this.Controls.Remove(pics[j, i - 1]);
                                            this.Controls.Remove(Labels[j, i - 1]);
                                            pics[j, i - 1] = null;
                                            Labels[j, i - 1] = null;
                                            Volume();
                                        }
                                        else GameOverRight = true;
                                    }
                                }
                            }
                        }
                    }
                    break;  //15 old


                case "Left":

                    for (int j = 0; j < 4; j++)
                    {
                        for (int ij = 0; ij < 4; ij++)
                        {
                            if (Field[j, ij] == 1)
                            {
                                for (int i = ij - 1; i >= 0; i--)
                                {
                                    if (Field[j, i] == 0)
                                    {
                                        
                                        flag = true;
                                        GameFalse();
                                        Field[j, i + 1] = 0;
                                        Field[j, i] = 1;
                                        pics[j, i] = pics[j, i + 1];
                                        pics[j, i + 1] = null;
                                        Labels[j, i] = Labels[j, i + 1];
                                        Labels[j, i + 1] = null;
                                        pics[j, i].Location = new Point(pics[j, i].Location.X - 56, pics[j, i].Location.Y);
                                        Volume();
                                    }
                                    else
                                    {
                                        int NumA = int.Parse(Labels[j, i].Text);
                                        int NumB = int.Parse(Labels[j, i + 1].Text);
                                        if (NumA == NumB)
                                        {
                                            
                                            flag = true;
                                            GameFalse();
                                            score += NumA + NumB;
                                            Score_.Text = score.ToString();
                                            ChangeColor(NumA + NumB, j, i);
                                            Labels[j, i].Text = (NumB + NumA).ToString();
                                            Field[j, i + 1] = 0;
                                            this.Controls.Remove(pics[j, i + 1]);
                                            this.Controls.Remove(Labels[j, i + 1]);
                                            pics[j, i + 1] = null;
                                            Labels[j, i + 1] = null;
                                            Volume();
                                        }
                                        else GameOverLeft = true;
                                    }
                                    
                                }
                            }
                        }
                    }
                    break;  //15

                case "Down":

                    for (int j = 2; j >= 0 ; j--)
                    {
                        for (int ij = 0; ij < 4; ij++)
                        {
                            if (Field[j, ij] == 1)
                            {
                                for (int i = j + 1; i < 4; i++)
                                {
                                    if (Field[i, ij] == 0)
                                    {
                                        
                                        flag = true;
                                        GameFalse();
                                        Field[i - 1, ij] = 0;
                                        Field[i, ij] = 1;
                                        pics[i, ij] = pics[i - 1, ij];
                                        pics[i - 1, ij] = null;
                                        Labels[i, ij] = Labels[i - 1, ij];
                                        Labels[i - 1, ij] = null;
                                        pics[i, ij].Location = new Point(pics[i, ij].Location.X, pics[i, ij].Location.Y + 56);
                                        Volume();
                                    }
                                    else
                                    {
                                        int NumA = int.Parse(Labels[i, ij].Text);
                                        int NumB = int.Parse(Labels[i - 1, ij].Text);
                                        if (NumA == NumB)
                                        {
                                            
                                            flag = true;
                                            GameOverDown = false;
                                            score += NumA + NumB;
                                            Score_.Text = score.ToString();
                                            ChangeColor(NumA + NumB, i, ij);
                                            Labels[i, ij].Text = (NumB + NumA).ToString();
                                            Field[i - 1, ij] = 0;
                                            this.Controls.Remove(pics[i - 1, ij]);
                                            this.Controls.Remove(Labels[i - 1, ij]);
                                            pics[i - 1, ij] = null;
                                            Labels[i - 1, ij] = null;
                                            Volume();
                                        }
                                        else GameOverDown = true;
                                    }
                                }
                            }
                        }
                    }
                    break;  //15


                case "Up":

                    for (int j = 1; j < 4; j++)
                    {
                        for (int ij = 0; ij < 4; ij++)
                        {
                            if (Field[j, ij] == 1)
                            {
                                for (int i = j - 1; i >= 0; i--)
                                {
                                    if (Field[i, ij] == 0)
                                    {
                                        
                                        GameFalse();
                                        flag = true;
                                        Field[i + 1, ij] = 0;
                                        Field[i, ij] = 1;
                                        pics[i, ij] = pics[i + 1, ij];
                                        pics[i + 1, ij] = null;
                                        Labels[i, ij] = Labels[i + 1, ij];
                                        Labels[i + 1, ij] = null;
                                        pics[i, ij].Location = new Point(pics[i, ij].Location.X, pics[i, ij].Location.Y - 56);
                                        Volume();
                                    }
                                    else
                                    {
                                        int NumA = int.Parse(Labels[i, ij].Text);
                                        int NumB = int.Parse(Labels[i + 1, ij].Text);
                                        if (NumA == NumB)
                                        {
                                           
                                            GameFalse();
                                            flag = true;
                                            score += NumA + NumB;
                                            Score_.Text = score.ToString();
                                            ChangeColor(NumA + NumB, i, ij);
                                            Labels[i, ij].Text = (NumB + NumA).ToString();
                                            Field[i + 1, ij] = 0;
                                            this.Controls.Remove(pics[i + 1, ij]);
                                            this.Controls.Remove(Labels[i + 1, ij]);
                                            pics[i + 1, ij] = null;
                                            Labels[i + 1, ij] = null;
                                            Volume();
                                        }
                                        else GameOverUp = true;
                                    }
                                }
                            }
                        }
                    }
                    break;  //15  // old

            }
            
            if (flag) { GenerateNewCell();  }
            if ((GameOverDown == true) && (GameOverLeft == true) && (GameOverRight == true) && (GameOverUp == true)) { GameOverWindow(); GameFalse(); }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshGame();
            Game2048();
        }
    }
}
