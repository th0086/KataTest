using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTest.Kata_No._2_Dead_Ants
{

    public class Kata2
    {
        public static int DeadAntCount(string ants)
        {
            int DeadCount = 0;

            if (string.IsNullOrEmpty(ants))
            {
                return DeadCount;
            }

            var antStr = ants.Replace("ant", "").Replace(" ","").Replace(".","");
            
            foreach (var ch in "ant")
            {

                if (DeadCount < antStr.Count(x => x.Equals(ch)))
                {
                    DeadCount = antStr.Count(x => x.Equals(ch));
                }

            }
            return DeadCount;

        }

    }

}
