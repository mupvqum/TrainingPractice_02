using System.IO;

namespace GameOfFttention
{
    //Класс, отвечающий за работу с данными в файле
    public class StatisticsManager
    {
        const string statPath = "./statistics";
        static bool mutex = false;
        //Функция, записывающая данные в файл
        static public bool Update(string username, string time)
        {
            if(username.Contains("|"))
            {
                username.Replace("|", "-");
            }
            while (mutex) ;
            mutex = true;

            if (!File.Exists(statPath))
            {
                File.Create(statPath).Close();
            }

            string[] statistics = File.ReadAllLines(statPath);
            bool isSet = false;
            for(int i = 0; i < statistics.Length; ++i)
            {
                if (statistics[i].Contains(username))
                {
                    isSet = true;
                    statistics[i] = username + "|" + time + "\n";
                    File.WriteAllLines(statPath, statistics);
                    break;
                }
            }
            if (!isSet)
            {
                File.AppendAllText(statPath, username + "|" + time + "\n");
            }
            
            mutex = false;
            return true;
        }
        //Функция, достающая из файла данные
        static public string[] GetStatistics()
        {
            return File.ReadAllLines(statPath);
        }
    }
}
