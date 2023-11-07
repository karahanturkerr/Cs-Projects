using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMap
{
    public class Game_Main
    {
        public string GameName { get; set; }

        public List<aCharacter> Characters = new List<aCharacter>();
        public List<aDecors> Decors = new List<aDecors>();

        public Size MapArea { get; set; }


    }
}
