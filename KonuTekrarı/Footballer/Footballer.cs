using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonuTekrarı
{
    public class Footballer : aPlayer
    {

        public string FName;
        public int Age;
        public string Nationality;
        public int GoalCount { get; set ; }
        public int AssistCount { get; set; }
        public int Sum { get; set; }

        public aTeam CurrentTeam { get; set; }

        public Footballer (string fName, int age, string nationality, int goalcount, int assistcount, aTeam team)
        {
            FName = fName;
            Age = age;
            Nationality = nationality;
            GoalCount = goalcount;
            AssistCount = assistcount;
            CurrentTeam = team;
        }

        

        public void StatisticSum()
        {
            Sum = GoalCount + AssistCount;
            Console.WriteLine(Sum.ToString());
        }

    }
}
