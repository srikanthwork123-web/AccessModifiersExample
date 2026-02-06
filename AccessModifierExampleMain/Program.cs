using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer;//to add any project to another project use like(using yourpojectname;)
namespace AccessModifierExampleMain
{
    internal class Program
    {
        static void Main(string[] args)
        {//scope starts here
           //To access outside non static classmembers we need to create a object
            Class1 obj = new Class1();
            Console.WriteLine(obj.a);
            //outside project only public variables or public methods we can access
            //(Remaing accessmodiers like  private,protected,internal..we cannot access beacuse permission issue or access issue)
            //public variables and method we can access any anywhere in the current projet classes or outise project classes.
            obj.display();

            Sample obj1 = new Sample();
            Console.WriteLine(obj1.public_a2);//public variable we can access outside class
            Console.WriteLine(obj1.internal_a4);//internal also we can access outside class
            obj1.publicDisplayData();
            obj1.internalDisplayData();
        }//scope end here.
    }
}
