using System;
using System.IO;

namespace Stat
{
    public class StatisticsManager
    {
        const string statPath = "./statistics";
        static public bool Update(string username, string time)
        {
            if (!File.Exists(statPath))
            {
                File.Create(statPath);
            }

            string[] statistics = File.ReadAllLines(statPath);
            bool isSet = false;
            foreach (ref string line in statistics)
            {
                if (line.Contains(username))
                {
                    isSet = true;
                    line = username + " " + time + "\n";
                    break;
                }
            }
            if (!isSet)
            {
                File.AppendAllText(statPath, username + " " + time + "\n");
            }
        }
        static public string[] GetStatistics()
        {
            return File.ReadAllLines(statPath);
        }
    }
}
