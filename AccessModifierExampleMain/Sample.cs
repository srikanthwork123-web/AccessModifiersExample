using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierExampleMain
{
    //if you create any class.you will get a default accessmofier is  "internal".
    //Internal is used with in the current project only.
    internal class Sample
    {
//If we declare a variable as private, then we can use those variables only in same class.
        private string private_a1 = "hai";
        public string public_a2 = "hai1";
        protected string protected_a3 = "hai2";
        internal string internal_a4 = "hai4";
      
        public void publicDisplayData()
        {//private variables/methods we can access with in the class only.outside class we can't access.
            Console.WriteLine(private_a1);

        }
        private void privateDisplayData()
        {
            Console.WriteLine(private_a1);

        }
        protected void protectedDisplayData()
        {
            Console.WriteLine(private_a1);

        }
        internal void internalDisplayData()
        {
            Console.WriteLine(private_a1);

        }
    }
}
