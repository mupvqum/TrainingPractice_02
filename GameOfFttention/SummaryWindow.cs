using System;
using System.Windows.Forms;

namespace GameOfFttention
{
    public partial class SummaryWindow : Form
    {
        Form parent;
        public SummaryWindow(Form _parent)
        {
            InitializeComponent(); //Вызов функции, которая создает компоненты
            parent = _parent;
        }

        public void SetOuterText(string text)
        {
            outcome.Text = text;
        }
        //Функция, которая при открытии данного окна лишает пользователя возможности взаимодействовать с игровым окном
        private void SummaryWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Enabled = true;
        }
        //Функция, которая при нажатии кнопки "Главное меню", закрывает окно результатов и игровое окно, тем самым открывая главное окно программы
        private void button1_Click(object sender, EventArgs e)
        {           
            this.Close();
            parent.Close();
        }
    }
}
