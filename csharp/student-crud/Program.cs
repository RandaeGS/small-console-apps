namespace Crud
{
    class Program
    {
        static List<Student> studentList = new();

        static void Main()
        {
            bool runProgram = true;
            int choice = 0;
            Console.WriteLine("Welcome to the student CRUD!");
            while (runProgram)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1-Create 2-Read 3-Update 4-Delete 5-Exit");
                Console.WriteLine("Choose an option: ");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreateStudent();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        runProgram = false;
                        break;
                }
            }
        }
        static void CreateStudent()
        {
            string name, lastName, Id;
            byte age;

            Console.Write("Insert Id: ");
            Id = Console.ReadLine();
            Console.Write("Insert name: ");
            name = Console.ReadLine();
            Console.Write("Insert last name: ");
            lastName = Console.ReadLine();
            Console.Write("Insert age: ");
            age = Convert.ToByte(Console.ReadLine());

            Student student = new(Id, name, lastName, age);
            studentList.Add(student);

            Console.WriteLine("Student added succesfully!");
        }

    }
}
