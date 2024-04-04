namespace SUT23_ÖVningGenrics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           StudentCollection studentList = new StudentCollection();

            studentList.Add(new Student(1, 75, 80));
            studentList.Add(new Student(2, 77, 92));
            studentList.Add(new Student(3, 60, 85));
            studentList.Add(new Student(4, 75, 88));
            studentList.Add(new Student(4, 75, 88));


            Display(studentList);
            Console.WriteLine("------------------");

            //studentList.Remove(new Student(4, 75, 88));
            //Console.WriteLine("-----------------------------");

            //Display(studentList);



            // Test Containes method 

            Student studentToCheck = new Student(2, 77, 92);

            Console.WriteLine("Containes  ID :{0} , Grade :{1} , Total :{2}", 
                studentToCheck.ID.ToString(),studentToCheck.Grade.ToString(),studentToCheck.Total.ToString(), 
                studentList.Contains(studentToCheck));



            Console.ReadKey();
        }





        public static void Display(StudentCollection students)
        {
            Console.WriteLine("\nID \tGrade \tTotal");

            foreach (Student student in students)
            {
                Console.WriteLine("{0}\t{1}\t{2}",
                student.ID.ToString(),student.Grade.ToString(),student.Total.ToString());
            }
        }
    }
}
