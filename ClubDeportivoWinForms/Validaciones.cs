using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoWinForms
{
    public static class Validaciones
    {

        public static bool isString(string input)
        {
            if (input == null || string.IsNullOrEmpty(input))
            {
                return false;
            }
            return true; // Return true if the string is not null or empty
        }

        public static bool isNumeric(string input)
        {
            if (int.TryParse(input, out _))
            {
                // It's an integer
                return true;
            }

            if (double.TryParse(input, out _))
            {
                // It's a double
                return true;
            }

            // Not a number (integer or double)
            return false;
        }
    }
}
