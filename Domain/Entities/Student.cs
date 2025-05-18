namespace Domain.Entities
{
    public class Student

    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
    

        public Student(string firstName, string lastName, string? email)
        {
            FirstName = firstName;
            LastName = lastName;    
            Email = email;
        }
    }
}
