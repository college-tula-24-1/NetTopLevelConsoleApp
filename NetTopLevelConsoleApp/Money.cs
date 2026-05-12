using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTopLevelConsoleApp
{
    class Money
    {
        int rub;
        int kop;

        public Money(int rub = 0, int kop = 0)
        {
            SetRub(rub);
            SetKop(kop);
        }

        public void SetRub(int rub) { this.rub = rub; }
        public int GetRub() { return this.rub; }

        public void SetKop(int kop)
        {
            this.rub += kop / 100;
            this.kop = kop % 100;
        }
        public int GetKop() { return this.kop; }

        public void Print()
        {
            Console.WriteLine($"{rub} R, {kop} K");
        }
    }
}
