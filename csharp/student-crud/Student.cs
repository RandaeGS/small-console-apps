namespace Crud
{
    class Student
    {
        private string ID { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private byte age { get; set; }

        public Student(string ID, string firstName, string lastName, byte age)
        {
            this.ID = ID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

    }
}
