using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    abstract class Player
    {
        protected string name = null;
        protected string RoshamboValue = null;
        protected int wins = 0;
        protected int losses = 0;
        protected int ties = 0;

        public abstract string GenerateRoshambo();

        public abstract void AddWin();

        public abstract void AddLoss();

        public abstract void AddTie();

        public abstract void Totals();
    }
}
