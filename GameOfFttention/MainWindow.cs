using System;
using System.Windows.Forms;

namespace GameOfFttention
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        //Функция, которая при нажатии кнопки "Начать игру" открывает окно регистрации
        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationWindow register = new RegistrationWindow(this);
            register.Show();
            this.Hide();
        }
        //Функция выхода из программы при нажатии кропки "Выход"
        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //Функция, открывающая окно с результатами игр, при нажатии кнопки "Таблица рекордов"
        private void button2_Click(object sender, EventArgs e)
        {
            RecordWindow recordWindow = new RecordWindow();
            recordWindow.Show();
           
        }
    }
}
