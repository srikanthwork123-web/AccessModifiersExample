using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//classlibrary project conatins classes and enums.....etc
//class library project you can access with .dllFile into another project,
//class library project doesnot contain main method.
namespace RepositoryLayer
{
   // we can apply these accessmodifiers to  3places (classlevel and method level and variable level)
    //accessmodifier class classname
    public class Class1//1.appying the accessmodifier at classlevel
    {//public means you can access public any where in the project application.
     //classmembers(whatever you written inside the class is called classmembers).
     //classmembers=variables+Methods.
     //=========Varaibles creation sytax================
//Synatx:accessmodier datatype varibalename=value;
        public string public_a = "hai";//2.applying the accessmodier at variables level
        private string private_b = "hai1";//private variable access only within the class.outside class you can't access
        protected string protected_c = "hai2";
        internal string internal_d = "hai3";
        protected internal string protected_internal_mainvariable = "hai";
        /*MethodsCreation syntax
         ============================
              accessmodifier qualifier methodreturntype methodname()
               {
                return "yourdata"
               }
         */
        /*
         Public:-
        =============
        If we declare a variable or method or class as public, then we can use those variables in same project and also in new project also.
        Private: -(you ca't apply private to the class before.it will throw error
        ===========
        If we declare a variable or method or class as private , then we can use those variables only in same class.
        Internal:-(internal is used within the project only.outside project you can't access internal class/variables and methods).
        ============
         If we declare a variable or method or class as internal, then we can use those variables in same assembly(or project) only
        Protected:-
        ================
        If we declare a variable as protected, then we can use those variables in same class and derived class .
        */
        public void Public_display()//3.applying the accessmodier at method level.
        {
            Console.WriteLine(private_b);//accessing the private variable in same class only.outside class not possible.it will throw compiletime error
            Console.WriteLine(protected_c);//accessing the protected variable in same class
            Console.WriteLine("I am public mehod");
        }
        private void Private_display1()
        {
            Console.WriteLine("I am private mehod");
        }
        protected void protected_display2()
        {
            Console.WriteLine("I am protected mehod");
        }
        protected internal void pr_in_voidMethod()
        {
            Console.WriteLine("I am protectedInternal method ");
        }
        internal void internal_display3()
        {
            Console.WriteLine("I am internal mehod");
        }
    }
}
