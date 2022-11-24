using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    internal class IceCream
    {
        private int Id;
        public int ballsCount;
        private int myId = 0;

        public int id
        {
            get { return Id; }
            set
            {
                if (myId == 0)
                {
                    Id = value;
                    myId++;
                }
            }
        }
    }
}
