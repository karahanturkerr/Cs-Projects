
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    public class Galatasaray : aTeam
    {
        public string Location;

        public Galatasaray() { 
        LoadName();
        
        }    

        public override void LoadName()
        {
            var ft = new Icardi()
            {
                Nationalty = "Argentina"
            };
            this.PlayerList.Add(ft);
        }
    }
}
