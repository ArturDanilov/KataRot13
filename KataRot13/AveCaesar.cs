using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRot13
{
    public class AveCaesar
    {
        public string Converter(string  str)
        {
            str = str.ToUpper();
            var ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ ,!";            
            string temp = "";

            foreach (var item in str)
            {
                int index;

                if (ABC.Contains(item))
                {
                    if (item != ' ' && item != ',' && item != '!')
                    {
                        index = ABC.IndexOf(item);
                        temp += ABC[index + 13].ToString().ToUpper();
                    }
                    else
                    {
                        temp += item;
                    }
                }               
            }
            return temp;
        }
    }
}
