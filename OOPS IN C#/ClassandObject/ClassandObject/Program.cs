namespace ClassandObject
{
    class Student
    {
        public int Studentid { get; set; }
        public string Studentname { get; set; }
        public int Studentage { get; set; }

        public void Show()
        {
            Console.WriteLine("The Student Details are:");
            Console.WriteLine("Stduent Id : {0} , Student Name: {1} , Student Age : {2}", Studentid, Studentname, Studentage);
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            Student student = new Student();    
            student.Studentid = 1;  
            student.Studentname = "Raju";
            student.Studentage = 23;
            student.Show();
            Console.ReadKey();
        }
    }

}

