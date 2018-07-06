using System;
namespace codewars_population
{
    class Arge
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            //decimal newPercent = (Convert.ToDecimal(percent));
            //newPercent *= 0.01m;
            percent *= 0.01;
            int years = 0;
            do
            {
                //p0 += (int)(p0 * newPercent) + aug;
                p0 += (int)(p0 * percent) + aug;
                years++;
            } while (p0 < p);
            return years;
        }
    }
}


