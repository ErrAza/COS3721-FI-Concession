using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynchroProgCsharp
{
    class Program
    {
        public static uint PageSize = 4096;

        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No Address Specified. Please Enter the Address: ");
                return 1;
            }
            uint address = Convert.ToUInt32(args[0]);
            uint pageNumber = address/PageSize;
            uint offset = address % PageSize;

            Console.WriteLine("The Address: " + address + " contains:\n" + "Page Number: " + pageNumber + "\n" + "Offset: " + offset);
            Console.ReadLine();
            return 0;
        }
    }
}
