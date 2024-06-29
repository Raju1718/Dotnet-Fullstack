using System.Xml.Linq;

namespace MyNamespace
{
    public class Assembly1BaseClass
    {
        private string myName = "private";
        protected string myNamespace = "Protected";
        internal string mystrig = "internal";
        protected internal string myname = "protected internal";
        public string hello = "public";

        public void Assembly1method()
        {
            Console.WriteLine(myName);
            Console.WriteLine(myNamespace);
            Console.WriteLine(mystrig);
            Console.WriteLine(myname);
            Console.WriteLine(hello);
        }
       

    }
    public class Assembly1DerivedClass : Assembly1BaseClass
    {  
        public void Method2()
        {
            // private variable Not Accesble in derived class
            //Console.WriteLine(myName);
            Console.WriteLine(myNamespace);
            Console.WriteLine(mystrig);
            Console.WriteLine(myname);
            Console.WriteLine(hello);
        }
    }
    public class Other
    {
        Assembly1BaseClass assembly1BaseClass = new Assembly1BaseClass();
        public void method()
        {
            //private and protected are inaccessible in other class in same assembly
            //Console.WriteLine(assembly1BaseClass.myName);
            //Console.WriteLine(assembly1BaseClass.myNamespace);
            Console.WriteLine(assembly1BaseClass.mystrig);
            Console.WriteLine(assembly1BaseClass.myname);
            Console.WriteLine(assembly1BaseClass.hello);
        }

    }

    class program 
    {
        static void Main(string[] args)
        {
            //Assembly1BaseClass assembly1BaseClass = new Assembly1BaseClass();
            //assembly1BaseClass.Assembly1method();
            //Assembly1DerivedClass assembly1DerivedClass = new Assembly1DerivedClass();
            //assembly1DerivedClass.Method2();
            Other other = new Other();
            other.method();
            Console.ReadKey();
        }
    }


}