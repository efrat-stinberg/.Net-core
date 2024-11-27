namespace My_Project
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Driver> Drivers{ get; set; }

        public Admin(int id, string name, List<Driver> drivers)
        {
            Id = id;
            Name = name;
            Drivers = drivers;
        }

        public Admin(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Admin()
        {
            
        }
    }
}
