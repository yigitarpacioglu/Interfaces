namespace Interfaces
{
    class Student:IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
    }
}