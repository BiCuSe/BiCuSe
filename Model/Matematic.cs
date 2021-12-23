using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPFModernVerticalMenu.Model
{
    public class Matematic
    {
        Random rnd = new Random();
        Random rnds = new Random();
        public int summa { get; set; }

        public Matematic()
        {
            int i;
            
            int sle = rnd.Next(300,5000);
            int sum = rnds.Next(300, 700);
            for(i= sum; i < 500; )
            {
                i ++;
                summa = sum;
              Thread.Sleep(sle);
                
            }
        }

    }
}
