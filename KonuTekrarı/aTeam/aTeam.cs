using KonuTekrarı.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonuTekrarı
{
    public abstract class aTeam
    {
        public string TeamName;
        public int ChampionsCount;
        public eTeamColor Color;
        public string StadiumName;
        public double StadiumCapacity;
        public int FansCount;

        public List<aPlayer> footballerss;

        public abstract void LoadTeam();
    }
}
