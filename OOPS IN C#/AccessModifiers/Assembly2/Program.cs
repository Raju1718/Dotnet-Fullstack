using System;
using System.Xml.Linq;
using MyNamespace;
namespace Assembly2
{
    public class Assembly2class : Assembly1BaseClass
    {
      public void method()
        {
            //Private and internal are not accessible in other assembly
           // Console.WriteLine(myName);
            Console.WriteLine(myNamespace);
           // Console.WriteLine(mystrig);
            Console.WriteLine(myname);
            Console.WriteLine(hello);
        }
    }
    public class OtherinAssembly2
    {
        Assembly1BaseClass myBaseClass = new Assembly1BaseClass();
        public void method()
        {
            //only public is accessible
            //Console.WriteLine(myBaseClass.myName);
            //Console.WriteLine(myBaseClass.myNamespace);
            //Console.WriteLine(myBaseClass.mystrig);
            //Console.WriteLine(myBaseClass.myname);
            Console.WriteLine(myBaseClass.hello);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             //Assembly2class assembly2Class = new Assembly2class();
            //assembly2Class.method();
            OtherinAssembly2 otherinAssembly2 = new OtherinAssembly2();
            otherinAssembly2.method();
            Console.ReadKey();       
        }
    }



}


