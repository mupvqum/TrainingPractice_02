using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfFttention
{
    public partial class GameWindow : Form
    {
        //Вспомогательный класс, для удобного вывода на экран
        private class Time
        {
            ushort seconds = 0;
            ushort minutes = 0;
            
            public static Time operator++(Time tm)
            {
                ++tm.seconds;
                if(tm.seconds < 60)
                {
                    return tm;
                }

                tm.seconds = 0;
                ++tm.minutes;
                return tm;
            }
            //Функция, отвечающая за формат таймера
            public override string ToString()
            {
                return string.Format(
                    "{0}:{1}",
                    ((minutes < 10) ? "0" : "") + minutes.ToString(),
                    ((seconds < 10) ? "0" : "") + seconds.ToString()
                );
            }
        }

        Time tm = new Time();
        int count = 0;
        Form parent;
        string username;
        bool gameRunning = false;

        public GameWindow(Form parent, string username)
        {
            this.username = username;
            InitializeComponent();
            Text += " | " + username;
            this.parent = parent;
        }
        //Функция, которая отвечает за логику нажатия в игре
        private void ButtonClick(object sender, EventArgs e)
        {
            if(!gameRunning)
            {
                timer1.Start();
                gameRunning = true;
            }

            ++count;
            Button btn = sender as Button;
            if(btn.Text != count.ToString())
            {
                btn.BackColor = Color.Red;
                ShowWinnerMessage(false);
                return;
            }

            btn.BackColor = Color.Pink;
            if (count == 51)
            {
                ShowWinnerMessage(true);
            }
        }
        //Функция, открывающая главное окно программы, при закрытии игрового окна
        private void GameWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
        //Функция вывода выигрыша/проигрыша пользователя
        private void ShowWinnerMessage(bool isWin)
        {
            if(isWin)
            {
                StatisticsManager.Update(username, tm.ToString());
            }
            timer1.Stop();
            string outtext = (isWin ? "Вы выйграли" : "Вы проиграли");
            SummaryWindow sumWin = new SummaryWindow(this);
            sumWin.SetOuterText(outtext);
            sumWin.Show();
            Enabled = false;
        }
        //Функция запускающая таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeDisplay.Text = (++tm).ToString();
        }
    }
}
