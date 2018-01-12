using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_TextGame
{
    class Stats
    {
        private int total = 0;
        private int missed = 0;
        private int correct = 0;
        private int accuracy = 0;
        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        public int Missed
        {
            get { return missed; }
            set { missed = value; }
        }

        public int Correct
        {
            get { return correct; }
            set { correct = value; }
        }
        public int Accuray
        {
            get { return accuracy; }
            set { accuracy = value; }
        }
        public void Update(bool correctKey)
        {
            total++;
            if(!correctKey)
            {
                missed++;
            }
            else
            {
                Correct++;
            }
            Accuray = 100 * correct / (missed + correct);
        }
    }
}
