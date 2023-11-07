using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMap
{
    public abstract class aDecors
    {
        public Size DecoreArea {  get; set; }

        public eDecoreColorType eDecoreColorType;

        public string DecoreName;

        public eDecoreType eDecoreType;

    }
}
