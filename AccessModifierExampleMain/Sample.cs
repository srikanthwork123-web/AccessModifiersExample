using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer;
namespace AccessModifierExampleMain
{
    //if you create any class.you will get a default accessmofier is  "internal".
    //Internal is used with in the current project only.
//If you  inherit or access  internal class in outside project, it will throw compiletie error like(Inaccessible due to it's protection level)
    //internal class Sample: sipdashboard  //here sipdashboard class is internal.internal class we can't access outside prject
//accessmodier class childclass:parentclass    
    internal class Sample :Class1//here class is public.due to that we can access any where in the all the projects
    {
//If we declare a variable as private, then we can use those variables only in same class.
        private string private_a1 = "hai";
        public string public_a2 = "hai1";
        protected string protected_a3 = "hai2";
        internal string internal_a4 = "hai4";
      
        public void publicDisplayData()
        {//private variables/methods we can access with in the class only.outside class we can't access.
            Console.WriteLine(private_a1);
            Console.WriteLine(protected_internal_mainvariable);//another project derived class only we can access protected internalvariable
            Console.WriteLine(protected_c);//in derived class we can acess protcted variable.
            base.pr_in_voidMethod();//we can call the protected internal method in outside project derived class only.
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
