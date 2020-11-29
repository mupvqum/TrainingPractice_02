using System.Windows.Forms;

namespace GameOfFttention
{
    public partial class RecordWindow : Form
    {
        public RecordWindow()
        {
            InitializeComponent(); //Вызов функции, создающей компоненты
            string[] lines = StatisticsManager.GetStatistics(); //Инициализация массива строк и копирование в него значений из файла. с помощью функции, достающей эти значения

            foreach (string line in lines)
            {
                Append(line.Split('|'));
            }
        }
        //Функция добавления строк в таблицу результатов
        public void Append(string[] list)
        {
            display.Rows.Add(list);
        }
    }
}
