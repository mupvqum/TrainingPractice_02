using System;
using System.Windows.Forms;

namespace GameOfFttention
{
    public partial class RegistrationWindow : Form
    {
        private bool EnterPressed = false;
        private Form parent;
        public RegistrationWindow(Form _parent)
        {
            InitializeComponent();
            parent = _parent;
        }
        //Функция, которая при нажатии кнопки "Вернуться в главное меню" скрывает данное окно и открывает главное окно программы
        private void OnBackButtonPressed(object sender, EventArgs e)
        {
            parent.Show();
            this.Hide();
        }
        //Функция, которая при нажатии клавиши enter открывает игровое окно
        private void OnInputLineKeyPressed(object sender, KeyPressEventArgs e)
        {

            if(e.KeyChar != Convert.ToInt32(Keys.Enter))
            {
                return;
            }
            EnterPressed = true;

            if(InputBox.Text.Length == 0)
            {
                MessageBox.Show(this, "Вы не ввели имя!", "Внимание!", MessageBoxButtons.OK);
                return;
            }

            GameWindow game = new GameWindow(parent, InputBox.Text);
            game.Show();
            this.Close();
        }
        //Функция, которая при закрытии данного окна открывает главное окно программы
        private void RegistrationWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!EnterPressed)
            {
                parent.Show();
            }
        }
    }
}
