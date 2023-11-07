using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Animal : aLive, IMove
    {
        public override int Hp => throw new NotImplementedException();

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
