using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace needForSpeed.BusinessLayer
{
    public class clsRace
    {
        public int lenght { get; set; }
        public string route { get; set; }
        public int prizePool { get; set; }


        public List<clsPerformanceCar> praticipants { get; set; } = new List<clsPerformanceCar>();

        public clsRace(int lenght, string route, int prizePool)
        {
            this.lenght = lenght;
            this.route = route;
            this.prizePool = prizePool;
        }

    }

    public class clsCasualRace : clsRace
    {
        public clsCasualRace(int lenght, string route, int prizePool) : base(lenght, route, prizePool)
        {
        }
    }

    public class clsDriftRace : clsRace
    {
        public clsDriftRace(int lenght, string route, int prizePool) : base(lenght, route, prizePool)
        {
        }
    }

    public class clsDragRace : clsRace
    {
        public clsDragRace(int lenght, string route, int prizePool) : base(lenght, route, prizePool)
        {
        }
    }
}
