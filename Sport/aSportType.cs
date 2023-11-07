using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    public abstract class aSportType
    {
        public abstract string SportName { get; set; }
        public abstract List<aArea> Areas { get; set; }
        public abstract List<aTeam> Teams { get; set; }
    }
}
