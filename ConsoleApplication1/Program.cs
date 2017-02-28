using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clojure.clr.api;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fn = Clojure.var("clojure.core", "println");
            fn.invoke("Hello from Clojure");
            Console.Read();
        }
    }
}
