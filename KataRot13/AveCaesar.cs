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
            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {                
                if(charArray[i] == ' ' || charArray[i] == ',')
                {
                    i++;
                }

                if (charArray[i] >= indexBuchstabeA && charArray[i] <= indexBuchstabeZ - verschlüsselungSchicht)
                {
                    charArray[i] = (char)(charArray[i] + verschlüsselungSchicht);
                }
                else
                {
                    if (charArray[i] == ' ')
                    {
                        i++;
                    }
                    charArray[i] = (char)(indexBuchstabeA + (verschlüsselungSchicht - (indexBuchstabeZ - charArray[i]) - 1));
                }

            }
            return new string(charArray);

            //foreach (var item in str)
            //{
            //    int index;

            //    if (ABC.Contains(item))
            //    {
            //        if (item != ' ' && item != ',' && item != '!')
            //        {
            //            index = ABC.IndexOf(item);
            //            temp += ABC[index + 13].ToString().ToUpper();
            //        }
            //        else
            //        {
            //            temp += item;
            //        }
            //    }               
            //}
            //return temp;
        }
    }
}
