

enum options 
{
    Aggregate = 1,
    MinMark = 2,
    MaximumMark = 3,
    Grade = 4
};
namespace Practical_4
{
    class Student
    {
        public string Name;
        public decimal[] Marks= new decimal[5];
        public static decimal AverageMarks=0;
      /// <summary>
      /// this function is for calculating average marks
      /// </summary>
      /// <returns></returns>
        public decimal CalculateAverageMarks()
        {
            decimal sum = 0;
            foreach (int i in Marks)
            {
                sum += i;
            }
            AverageMarks = sum / Marks.Length;
            return AverageMarks;
        }
        /// <summary>
        /// this function is for calculating Grade
        /// </summary>
        /// <param name="avg"></param>
        /// <returns>Grade</returns>
        public string CalculateGrade(decimal avg)
        {
            string grade = "";
                        if (avg > 90)
                        {
                            grade = "A";  
                        }
                        else if (avg < 90 && avg > 80)
                        {
                            grade = "B";  
                         
                        }
                        else if (avg < 80 && avg > 70)
                        {
                            grade = "C";  
                        }
                        else if (avg < 70 && avg > 60)
                        {
                            
                            grade = "D";  
                        }
                    return grade;     
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            Console.WriteLine("Enter Student Name :- ");
            stu.Name = Console.ReadLine();
            Console.WriteLine($"Enter Marks of each Subject for {stu.Name} :- ");
            //taking input from user for subject marks
            for(int i = 0; i < stu.Marks.Length; i++)
            {
                stu.Marks[i] = decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Average Marks of {stu.Name} is {stu.CalculateAverageMarks()}");
            string choice; // variable declared for taking choice of user whether to continue menu or not
            do
            {
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("*   Press 1 - Aggregate: Displays the Name: Average marks                 *");
                Console.WriteLine("*   Press 2 - MinMark: Displays the minimum marks of the student          *");
                Console.WriteLine("*   Press 3 - MaximumMark: Displays the maximum mark                      *");
                Console.WriteLine("*   Press 4 - Grade: Displays grade                                       *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("Press any one Option to get detail: ");

                decimal x = decimal.Parse(Console.ReadLine()); //input for choosing option
                switch (x)
                {

                    case ((decimal)options.Aggregate):
                        Console.WriteLine($"Student Name is {stu.Name} and  Average marks is {Student.AverageMarks}");
                        break;
                    case ((decimal)options.MinMark):
                        Console.WriteLine("Minimum Marks = " + stu.Marks.Min());
                        break;
                    case ((decimal)options.MaximumMark):
                        Console.WriteLine("Maximum Marks = " + stu.Marks.Max());
                        break;
                    case ((decimal)options.Grade):
                        decimal av = stu.CalculateAverageMarks();
                        Console.WriteLine("GRADE is " + stu.CalculateGrade(av));
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong Option Choosen");
                        break;
                }
                Console.WriteLine("Do you want to Continue--? Y/N ");
                choice = Console.ReadLine();
            } while (choice == "Y");//continue till user press 'N'
        }
    }
}
