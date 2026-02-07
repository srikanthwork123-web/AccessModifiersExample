using System;//predefined namespaces which is provided by microsft team.
using System.Collections.Generic;//predefined namespaces which is provided by microsft team.
using System.Linq;//predefined namespaces which is provided by microsft team.
using System.Text;//predefined namespaces which is provided by microsft team.
using System.Threading.Tasks;//predefined namespaces which is provided by microsft team.
using RepositoryLayer;//to add any project to another project use like(using yourpojectname;)
namespace AccessModifierExampleMain
{
    internal class Program
    {
        static void Main(string[] args)
        {//scope starts here
         //To access outside non static classmembers we need to create a object
         //======Trying to access Public accessmodier related classe outise assembly or outside project===//
            Class1 obj = new Class1();
            Console.WriteLine(obj.public_a);
           // Console.WriteLine(obj.);//juts remove . and check the access of variables here
            //Console.WriteLine(obj.);here only public related things will come.beacuse public can access any where.
            //outside project only public variables or public methods we can access
            //(Remaing accessmodiers like  private,protected,internal..we cannot access beacuse permission issue or access issue)
            //public variables and method we can access any anywhere in the current projet classes or outise project classes.
            obj.Public_display();

            Sample obj1 = new Sample();
            Console.WriteLine(obj1.public_a2);//public variable we can access outside class and within current project and outside project also access.
            Console.WriteLine(obj1.internal_a4);//internal also we can access outside class and within the current prject only
            obj1.publicDisplayData();
            obj1.internalDisplayData();
            //==========Trying to access private accessmodier related classe outise assembly or outside project==//

            //==========Trying to access internal accessmodier related classe outise assembly or outside project==//
            // sipdashboard obj4 = new sipdashboard();
            //error:sipdashboard is inaccessible due to it's protectio level
            Console.ReadKey();
        }//scope end here.
    }
}
