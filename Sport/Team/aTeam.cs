using Sport.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    public abstract class aTeam 
    {
        public string TeamName;
        public eColorType Color;
        public List<aPlayer> PlayerList = new List<aPlayer>();
        public abstract void LoadName();

  
    }
}
