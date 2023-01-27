namespace Task7
{
    internal class Program
    {
        private static List<Student> students;

        static void Main(string[] args)
        {
            students = new List<Student>();

            string result = "";

            while (result != "q") {
                AddStudent();
                ShowStudentsList();

                Console.WriteLine("Enter q to stop adding student info, c - to continue adding:");

                result = Console.ReadLine();     
            }
        }

        static void AddStudent() {
            Console.WriteLine("Enter student's first name:");

            var firstName = Console.ReadLine();

            Console.WriteLine("Enter student's last name:");

            var lastName = Console.ReadLine();

            Console.WriteLine("Enter student's grades (2, 3, 4, 5):");

            var grades = Console.ReadLine()?.Split(" ").Select(g => Int32.Parse(g)).ToList();

            var newStudent = CreateStudent(firstName, lastName, grades);

            students.Add(newStudent);

            Console.WriteLine("New student has been added.");
        }

        static Student CreateStudent(string firstName, string lastName, List<int> grades) {
            return new Student {
                FirstName = firstName,
                LastName = lastName,
                Grades = grades
            };
        }

        static void ShowStudentsList() {
            Console.WriteLine("Students list with only excellent grades:");

            students.FindAll(s => s.Grades.TrueForAll(g => g == 5)).ForEach(s =>
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}");
            });


            Console.WriteLine("Students list with unsatisfactory grades:");

            students.FindAll(s => s.Grades.Any(g => g == 3)).ForEach(s =>
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}");
            });
        }
    }
}