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

        private List<int> numbers = new List<int>(){ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private string coefficient = "";
        private bool rad = false;
        private int poslednirad = 0;

        public Polynom(string body)
        {
            this.body = body.Replace(" ", "");

            foreach (char c in body)
            {
                if (char.IsDigit(c))
                {
                    if (rad)
                    {
                        poslednirad = Convert.ToInt32(c.ToString());
                        rad = false;
                    }
                    else if (!rad && numbers.Contains(Convert.ToInt32(c.ToString())))
                    {
                        coefficient += c.ToString();
                    }

                }
                else if (c == 'x')
                {
                    if (coefficient == "")
                        Coefficients.Add(1);
                }
                else if (c == '^')
                {
                    rad = true;
                }
            }
        }

        public static Polynom operator+ (Polynom p1, Polynom p2)
        {
            return null;
        }
    }
}
