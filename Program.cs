using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            DateTime datetime = DateTime.UtcNow.Date;
            Console.WriteLine("name");
            a= Console.ReadLine();
            Console.WriteLine("surname");
            b= Console.ReadLine();
            Console.WriteLine("Bonjour " + a + " " + b +" ,nous sommes le "+ datetime.ToString("dd/MM/yyyy ")+ ",comment allez-vous?");

        }
    }
}
