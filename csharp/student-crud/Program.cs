namespace Crud
{
    class Program
    {
        static void Main()
        {
            bool runProgram = true;
            int choice = 0;
            Console.WriteLine("Welcome to the student CRUD!");
            while (runProgram)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1-Create 2-Read 3-Update 4-Delete 5-Exit");

                switch (choice)
                {
                    case 1:
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

    }
}
