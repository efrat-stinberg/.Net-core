namespace My_Project
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Driver(int id, string name, string city)
        {
            Id = id;
            Name = name;
            City = city;
        }

      
    }
}
