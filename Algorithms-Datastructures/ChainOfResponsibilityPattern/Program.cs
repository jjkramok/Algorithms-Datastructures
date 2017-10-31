using System;
using System.Collections.Generic;

namespace ChainOfResponsibilityPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Client cl0 = new Client();
            cl0.Do(130);
            cl0.Do(1873);
            cl0.Do(12000);
            cl0.Do(9200000);
        }
    }
}