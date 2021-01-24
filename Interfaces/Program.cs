using System.Security.Cryptography.X509Certificates;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new CourseManager();
            courseManager.Add(new Student(){Id = 1, Name = "Yiğit", Surname = "Arpacıoğlu", Address = "Küçükyalı"});
            courseManager.Add(new Student(){Id = 2, Name = "Cihat", Surname = "Zoroğlu", Address = "Kadıköy"});
            courseManager.Add(new Lecturer(){Id = 3, Name = "Claudia", Surname = "Yaşar", Department = "Control and Automation"});
            
            courseManager.GetAll();
            courseManager.GetById(1);
        }
    }
}
