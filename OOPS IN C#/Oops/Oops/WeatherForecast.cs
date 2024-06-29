namespace Oops
{
    class Student
    {
        public int Studentid { get; set; }
        public string Studentname { get; set;}
        public int Studentage { get; set;} 

        public void Show()
        {
            Console.WriteLine("The Student Details are:");
            Console.WriteLine("Stduent Id : {0} , Student Name: {1} , Student Age : {2}",Studentid,Studentname,Studentage);
        }
    }
    
    public class WeatherForecast
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Studentage = 24;
            student.Studentname = "Raju";
            student.Studentid = 1;
            student.Show();
            Console.ReadKey();

        }
    }
}