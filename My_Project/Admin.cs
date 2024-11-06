namespace My_Project
{
    public class Admin
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Admin(int id, int level, string firstName, string lastName)
        {
            Id = id;
            Level = level;
            FirstName = firstName;
            LastName = lastName;
        }

        public Admin()
        {
            
        }
    }
}
