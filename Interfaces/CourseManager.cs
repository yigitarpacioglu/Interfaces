using System;
using System.Collections.Generic;

namespace Interfaces
{
    class CourseManager
    {
        private List<IPerson> _courseList;

        public CourseManager()
        {
            var courseList = new List<IPerson>();
            _courseList = courseList;
        }
        public void Add(IPerson person)
        {
            _courseList.Add(person);
        }

        public void GetAll()
        {
            foreach (var person in _courseList)
            {
                Console.WriteLine(person.Id + "- " + person.Name+" "+person.Surname+" "+person.GetType().Name);
            }
        }

        public void GetById(int Id)
        {
            var member = _courseList.Find(person => person.Id == Id);
            Console.WriteLine(member.Id + "- " + member.Name+" "+member.Surname+" "+member.GetType().Name);
        }
    }
}