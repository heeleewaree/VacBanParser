using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Drawing;

namespace VacBanParser
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
            dgvMatrix.RowCount = maxAccValue;
            InitialDesign();
        }

        #region Global Vars
        static int maxAccValue = 10000;
        Stopwatch stopWatch = new Stopwatch();
        String[] accList = new String[maxAccValue];
        String[] bans = new String[maxAccValue];
        String[] matrixData = new String[maxAccValue];
        String[] matrixLink = new String[maxAccValue];
        String[] matrixComment = new String[maxAccValue];
        double[] daysAfterDate = new double[maxAccValue];
        int totalPlayers = 0;
        int totalBans = 0;
        double time;
        #endregion

        #region Button AccList
        private void btnAccList_Click(object sender, EventArgs e)
        {
            Process cfg = new Process();
            cfg.StartInfo.FileName = "notepad.exe";
            cfg.StartInfo.Arguments = @"C:\VacBan Parser\AccList.cfg";
            cfg.Start();
        }
        #endregion

        #region Button Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitialDesign();
        }
        #endregion

        #region Button Parse and Save
        private void btnParse_Click(object sender, EventArgs e)
        {
            try
            {
                FileSaving();
                FileReading();
                stopWatch.Start();
                Parallel.ForEach(Iterate(0, totalPlayers - 1, 1), j =>
                {
                    WebClient webclient = new WebClient();
                    String profileID = webclient.DownloadString(accList[j]);
                    String days = "";
                    String daysReversed = "";
                    bool res = profileID.Contains("day(s) since last ban");
                    if (res)
                    {
                        int pos = profileID.IndexOf("day(s) since last ban") - 2;
                        while (profileID[pos] != '\t')
                        {
                            days += profileID[pos];
                            pos--;
                        }
                        for (int i = days.Length - 1; i > -1; i--)
                        {
                            daysReversed += days[i];
                        }
                    }
                    bans[j] = daysReversed;
                    int day = 0, month = 0, year = 0;
                    string dayF = "", monthF = "", yearF = "";
                    int n = 0;
                    String tim = Convert.ToString(dgvMatrix.Rows[j].Cells[0].Value);
                    if (tim != "")
                    {
                        for (int p = 0; p < tim.Length; p++)
                        {
                            if ((tim[p] == '.') || (tim[p] == ',') || (tim[p] == '/') || (tim[p] == ' '))
                            {
                                if ((month == 0) && (n != 0))
                                {
                                    for (int v = n + 1; v < p; v++)
                                        monthF += tim[v];
                                    month = Convert.ToInt32(monthF);
                                    n = p;
                                }
                                if (day == 0)
                                {
                                    for (int v = 0; v < p; v++)
                                        dayF += tim[v];
                                    day = Convert.ToInt32(dayF);
                                    n = p;
                                }
                            }
                        }
                        if ((year == 0) && (n != 0))
                        {
                            for (int v = n + 1; v < tim.Length; v++)
                                yearF += tim[v];
                            year = Convert.ToInt32(yearF);
                        }
                        DateTime data = new DateTime(year, month, day);
                        daysAfterDate[j] = (DateTime.Today - data).TotalDays;
                        if (bans[j] != "")
                        {
                            if (daysAfterDate[j] > Convert.ToInt32(bans[j]))
                                dgvMatrix.Rows[j].Cells[2].Value = bans[j];
                        }
                    }
                });
                stopWatch.Stop();
                time = stopWatch.ElapsedMilliseconds;
                stopWatch.Reset();
                totalBans = 0;
                for (int i = 0; i < totalPlayers - 1; i++)
                {
                    if ((bans[i] != "") && (daysAfterDate[i] > Convert.ToInt32(bans[i])))
                        totalBans++;
                }
                paintGraph();
            }
            catch
            {
                return;
            }
        }
        #endregion

        #region Paint Function
        public void paintGraph()
        {
            Bitmap btmp = new Bitmap(this.Width, this.Height);
            Graphics gr = Graphics.FromImage(btmp);
            pbGraph.Image = btmp;
            int X = 300 + this.Width / 2;
            int Y = -130 + this.Height / 2;
            float bannedUsers = 360.0f * totalBans / (totalPlayers - 1);
            gr.FillPie(new SolidBrush(Color.FromArgb(200, 72, 71)), new Rectangle(X - 75, Y - 75, 150, 150), 90.0f, bannedUsers);
            gr.FillPie(new SolidBrush(Color.FromArgb(100, 149, 237)), new Rectangle(X - 75, Y - 75, 150, 150), 90.0f + bannedUsers, 360.0f - (0.0f + bannedUsers));

            gr.FillRectangle(new SolidBrush(Color.FromArgb(200, 72, 71)), new Rectangle(X - 75 + 20, Y + 100, 15, 15));
            gr.DrawString("Banned: " + totalBans, new Font("Arial", 8), new SolidBrush(Color.White), new Point(X - 55 + 20, Y + 100));
            gr.FillRectangle(new SolidBrush(Color.FromArgb(100, 149, 237)), new Rectangle(X - 75 + 20, Y + 120, 15, 15));
            gr.DrawString("Not banned: " + ((totalPlayers - 1) - totalBans), new Font("Arial", 8), new SolidBrush(Color.White), new Point(X - 55 + 20, Y + 120));

            gr.DrawString("Total players: " + (totalPlayers - 1), new Font("Arial", 8), new SolidBrush(Color.White), new Point(X - 75 + 20, Y + 140));
            gr.DrawString("Percentage: " + Math.Round((1.0 * totalBans / (totalPlayers - 1)) * 100.0, 3) + " %", new Font("Arial", 8), new SolidBrush(Color.White), new Point(X - 75 + 20, Y + 160));

            gr.DrawString("time: " + (time / 1000.0) + " sec", new Font("Arial", 8), new SolidBrush(Color.White), new Point(10, 540));




            gr.Dispose();
        }
        #endregion

        #region Iterate Function
        private IEnumerable<int> Iterate(int x, int y, int a)
        {
            for (int i = x; i < y; i += a)
                yield return i;
        }
        #endregion

        #region File Reading
        private void FileReading()
        {
            totalPlayers = 1;
            try
            {
                StreamReader file = new StreamReader(@"C:\VacBan Parser\AccList.cfg");
                accList[0] = file.ReadLine();
                while (accList[totalPlayers - 1] != "")
                {
                    accList[totalPlayers] = file.ReadLine();
                    totalPlayers++;
                }
                file.Close();
            }
            catch
            {
                return;
            }
        }
        #endregion

        #region File Saving
        public void FileSaving()
        {
            try
            {
                StreamWriter file = new StreamWriter(@"C:\VacBan Parser\MatrixData.cfg");
                for (int i = 0; i < dgvMatrix.RowCount; i++)
                    file.WriteLine(dgvMatrix.Rows[i].Cells[0].Value);

                file.Close();
            }
            catch
            {
                return;
            }

            try
            {
                StreamWriter file = new StreamWriter(@"C:\VacBan Parser\AccList.cfg");
                for (int i = 0; i < dgvMatrix.RowCount; i++)
                    file.WriteLine(dgvMatrix.Rows[i].Cells[1].Value);

                file.Close();
            }
            catch
            {
                return;
            }

            try
            {
                StreamWriter file = new StreamWriter(@"C:\VacBan Parser\MatrixComment.cfg");
                for (int i = 0; i < dgvMatrix.RowCount; i++)
                    file.WriteLine(dgvMatrix.Rows[i].Cells[3].Value);

                file.Close();
            }
            catch
            {
                return;
            }
        }
        #endregion

        #region Initial Design
        public void InitialDesign()
        {
            int i = 1;
            try
            {
                StreamReader file = new StreamReader(@"C:\VacBan Parser\MatrixData.cfg");
                matrixData[0] = file.ReadLine();
                while (matrixData[i - 1] != "")
                {
                    matrixData[i] = file.ReadLine();
                    dgvMatrix.Rows[i - 1].Cells[0].Value = matrixData[i - 1];
                    i++;
                }
                file.Close();
            }
            catch
            {
                return;
            }

            i = 1;
            try
            {
                totalPlayers = 1;
                StreamReader file = new StreamReader(@"C:\VacBan Parser\AccList.cfg");
                matrixLink[0] = file.ReadLine();
                while (matrixLink[i - 1] != "")
                {
                    matrixLink[i] = file.ReadLine();
                    dgvMatrix.Rows[i - 1].Cells[1].Value = matrixLink[i - 1];
                    accList[i - 1] = matrixLink[i - 1];
                    i++;
                    totalPlayers++;
                }
                file.Close();
            }
            catch
            {
                return;
            }

            i = 1;
            try
            {
                StreamReader file = new StreamReader(@"C:\VacBan Parser\MatrixComment.cfg");
                matrixComment[0] = file.ReadLine();
                while (matrixComment[i - 1] != "")
                {
                    matrixComment[i] = file.ReadLine();
                    dgvMatrix.Rows[i - 1].Cells[3].Value = matrixComment[i - 1];
                    i++;
                }
                file.Close();
            }
            catch
            {
                return;
            }
        }
        #endregion
    }
}
