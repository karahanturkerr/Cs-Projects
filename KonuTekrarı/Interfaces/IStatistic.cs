using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonuTekrarı
{
    public interface IStatistic
    {
        int GoalCount { get; set; }
        int AssistCount { get; set; }

        int Sum { get; set; }

        void StatisticSum();
    }
}
