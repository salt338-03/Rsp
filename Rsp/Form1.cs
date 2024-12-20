using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rsp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int userScore;
        int computerScore;

        int RSPresult()
        {
            int a = random.Next(0,3);
            //0 = 가위
            //1 = 바위
            //2 = 보
            return a;
        }
        void result(int a, int b)
        {
            if (a == b)
            {
                textBox1.Text = $"컴퓨터가 낸것 {ChoiceToString(a)}!\r\n";
                textBox1.Text += "무승부!\r\n";
                textBox1.Text += $"현재 스코어 - 유저:{userScore} 컴퓨터 :{computerScore} \r\n";

            }
            else if ((a == 0 && b == 2) || // 가위 > 보
                     (a == 1 && b == 0) || // 바위 > 가위
                     (a == 2 && b == 1))   // 보 > 바위
            {
                textBox1.Text = $"컴퓨터가 낸것 {ChoiceToString(a)}!\r\n";
                textBox1.Text += "사용자가 승리했습니다!\r\n";
                userScore += 1;
                textBox1.Text += $"현재 스코어 - 유저:{userScore} 컴퓨터 :{computerScore}\r\n";
            }
            else
            {
                textBox1.Text = $"컴퓨터가 낸것 {ChoiceToString(a)}!\r\n";
                textBox1.Text += "컴퓨터가 승리했습니다!\r\n";
                computerScore += 1;
                textBox1.Text += $"현재 스코어 - 유저:{userScore} 컴퓨터 :{computerScore}\r\n";
            }
            if (userScore == 3)
            {
                textBox1.AppendText("사용자가 최종 승리했습니다!\r\n");
                textBox1.AppendText("점수를 초기화합니다.\r\n");
                userScore = 0;
                computerScore = 0;
            }
            else if (computerScore == 3)
            {
                textBox1.AppendText("컴퓨터가 최종 승리했습니다!\r\n");
                textBox1.AppendText("점수를 초기화합니다.\r\n");
                userScore = 0;
                computerScore = 0;
            }

        }
        string ChoiceToString(int choice)
        {
            switch (choice)
            {
                case 0:
                    return "가위";
                case 1:
                    return "바위";
                case 2:
                    return "보";
                default:
                    return "알 수 없음";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Computer = RSPresult();
            int User = 0;
            result(Computer, User);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Computer = RSPresult();
            int User = 1;
            result(Computer, User);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Computer = RSPresult();
            int User = 2;
            result(Computer, User);
        }
      
    }
}

