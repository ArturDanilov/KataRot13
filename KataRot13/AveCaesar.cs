using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KataRot13
{
    public class AveCaesar
    {
        public const int verschlüsselungSchicht = 13;
        public const int indexBuchstabeA = 65;
        public const int indexBuchstabeZ = 90;

        public string Converter(string  str)
        {
            str = str.ToUpper();
            str = str.Replace("Ö", "OE");
            str = str.Replace("Ä", "AE");
            str = str.Replace("Ü", "UE");
            str = str.Replace("ß", "SS");

            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] >= indexBuchstabeA && charArray[i] <= indexBuchstabeZ)
                {
                    if (charArray[i] >= indexBuchstabeZ - verschlüsselungSchicht)
                    {
                        charArray[i] = (char)((charArray[i] - indexBuchstabeA + verschlüsselungSchicht) % 26 + indexBuchstabeA);
                    }
                    else
                    {
                        charArray[i] = (char)(charArray[i] + verschlüsselungSchicht);
                    }                    
                }
            }
            return new string(charArray);
        }
    }
}
