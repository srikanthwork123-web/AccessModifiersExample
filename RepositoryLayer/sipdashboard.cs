using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    //if you create any new class by default accessmodifier class is internal.
    /*
If you create any class what is the default accessmodifier?=>Internal
if you create any variables or methods inside class, what is the default accessmodfier=>private
Note:
1.Same Assembly or same project   both are same.
2.Other Assembly or other projet  both are same.
     */
    internal class sipdashboard: Class1
    {
        internal string internal_collegename = "JNTU";
        protected string protected_Address = "Hyderabad";
        private string private_pincode = "123123";
        
        internal void internal_displayData()
        {
            Console.WriteLine(public_a);//we can access public variables in derived class
            Console.WriteLine(protected_c);//we can access proteced varible in the child class
            Console.WriteLine(internal_collegename);//internal variable also we can access in derived class
            base.protected_display2();//protected method we can access in only derived classes
            base.internal_display3();//internal method also we can access in dervied class
            base.Public_display();//public methods we can access in derived class
        }
        protected void protected_address()
        {
            Console.WriteLine(protected_Address);
        }
    }
}
/*assembly means.(simply says one project)
 * 
 * 
 * when you build the class library project it will generte dll flile.
 * this file you can add to other projects and you ca access those classes.
 */