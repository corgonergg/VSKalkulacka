using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VSKalkulacka
{
    public class Polynom
    {
        // 2x^3 + x^2 + 7x + 4
        private string body;
        private List<int> Coefficients;

        public Polynom(string body)
        {
            this.body = body.Replace(" ", "");

            foreach (char c in body)
            {
                
            }
        }

        public static Polynom operator+ (Polynom p1, Polynom p2)
        {
            return null;
        }
    }
}
