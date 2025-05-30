using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        string filePath = @"C:\Users\윤대영\Documents\Project DB\gamedata.txt";
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Click -= pictureBox1_Click; // 이미 추가된 이벤트 핸들러를 제거
            pictureBox1.Click += pictureBox1_Click; // 이벤트 핸들러를 다시 추가

            pictureBox2.Click -= pictureBox2_Click; // 이미 추가된 이벤트 핸들러를 제거
            pictureBox2.Click += pictureBox2_Click; // 이벤트 핸들러를 다시 추가

            pictureBox3.Click -= pictureBox3_Click; // 이미 추가된 이벤트 핸들러를 제거
            pictureBox3.Click += pictureBox3_Click; // 이벤트 핸들러를 다시 추가
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Process gameProcess = new Process();
                gameProcess.StartInfo.FileName = @"C:\Users\윤대영\Documents\InfinityStairs\InfinityStairs.exe";
                gameProcess.EnableRaisingEvents = true;
                gameProcess.Exited += (s, args) =>
                {
                    // 게임이 완전히 종료될 때까지 기다립니다.
                    gameProcess.WaitForExit();

                    // 게임이 끝나면 결과를 저장합니다.
                    string maxScoreText = File.ReadAllText(@"C:\Users\윤대영\Documents\Infinity Stair DB\maxscore.txt");
                    int maxScore;
                    if (int.TryParse(maxScoreText, out maxScore))
                    {
                        SaveGameData(textBox1.Text, maxScore);
                    }
                    else
                    {
                        MessageBox.Show("최대 점수 읽기에 실패했습니다.");
                    }
                };
                gameProcess.Start();

                MessageBox.Show("무한의 계단 시작!");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("게임 실행에 실패했습니다. 파일이 존재하는지, 실행 권한이 있는지 확인해 주세요.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Process gameProcess = new Process();
                gameProcess.StartInfo.FileName = @"C:\Users\윤대영\Documents\SlidingPuzzleGame\My project.exe";
                gameProcess.EnableRaisingEvents = true;
                gameProcess.Exited += (s, args) =>
                {
                    // 게임이 완전히 종료될 때까지 기다립니다.
                    gameProcess.WaitForExit();

                    // 게임이 끝나면 결과를 저장합니다.
                    string maxScoreText = File.ReadAllText(@"C:\Users\윤대영\Documents\Sliding Puzzle DB\Playtime.txt");
                    int Playtime;
                    if (int.TryParse(maxScoreText, out Playtime))
                    {
                        SaveGameData3(textBox1.Text, Playtime);
                    }
                    else
                    {
                        MessageBox.Show("최대 점수 읽기에 실패했습니다.");
                    }
                };
                gameProcess.Start();

                MessageBox.Show("슬라이딩 퍼즐 시작!");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("게임 실행에 실패했습니다. 파일이 존재하는지, 실행 권한이 있는지 확인해 주세요.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                Process gameProcess = new Process();
                gameProcess.StartInfo.FileName = @"C:\Users\윤대영\Documents\PlatformerGame\platformer\flatfiomer game.exe";
                gameProcess.EnableRaisingEvents = true;
                gameProcess.Exited += (s, args) =>
                {
                    // 게임이 완전히 종료될 때까지 기다립니다.
                    gameProcess.WaitForExit();

                    // 게임이 끝나면 결과를 저장합니다.
                    string UIpointText = File.ReadAllText(@"C:\Users\윤대영\Documents\Platformer DB\UIpoint.txt");
                    int UIpoint;
                    if (int.TryParse(UIpointText, out UIpoint))
                    {
                        SaveGameData1(textBox1.Text, UIpoint);
                    }
                    else
                    {
                        MessageBox.Show("최대 점수 읽기에 실패했습니다.");
                    }
                    string UIstageText = File.ReadAllText(@"C:\Users\윤대영\Documents\Platformer DB\UIstage.txt");
                    int UIstage;
                    if (int.TryParse(UIstageText, out UIstage))
                    {
                        SaveGameData2(textBox1.Text, UIstage);
                    }
                    else
                    {
                        MessageBox.Show("최대 점수 읽기에 실패했습니다.");
                    }
                };
                gameProcess.Start();

                MessageBox.Show("플랫포머 게임 시작!");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("게임 실행에 실패했습니다. 파일이 존재하는지, 실행 권한이 있는지 확인해 주세요.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveGameData(string playerName, int maxScore)
        {
            string gameData = $"{playerName} : 무한의 계단 {maxScore}점";
            

            try
            {
                File.AppendAllText(filePath, gameData + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void SaveGameData1(string playerName, int UIpoint)
        {
            string gameData = $"{playerName} : 플랫포머 게임 {UIpoint}점";


            try
            {
                File.AppendAllText(filePath, gameData + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void SaveGameData2(string playerName, int UIstage)
        {
            string gameData = $"{playerName} : 플랫포머 게임 {UIstage + 1} 단계";


            try
            {
                File.AppendAllText(filePath, gameData + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void SaveGameData3(string playerName, int Playtime)
        {
            string gameData = $"{playerName} : 게임 진행시간 {Playtime}초";


            try
            {
                File.AppendAllText(filePath, gameData + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
