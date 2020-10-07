using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            StringList myLlist = new StringList();
            myLlist.Add("Pudge");
            myLlist.Add("Omnik");
            myLlist.Add("Void");
            myLlist.Add("Viper");
            myLlist.Add("Riki");

            StringList exceptList = new StringList();
            exceptList.Add("Riki"); //because riki is a rat

            StringList.Except(ref myLlist, exceptList);

            foreach (string item in myLlist)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
