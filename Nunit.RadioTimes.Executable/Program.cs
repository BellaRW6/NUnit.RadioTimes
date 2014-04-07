using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.RadioTime;
using MadeForMoms;


namespace Nunit.RadioTimes.Executable
{
    class Program
    {
        static void Main(string[] args)
        {
            PageNavigation auth = new PageNavigation();
            auth.setup();
            auth.Madeformum();
            auth.teardown();

            Console.ReadLine();
        }
    }
}
