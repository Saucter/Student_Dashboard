using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_Project.Shared.Entities
{
    public class CLasses
    {
        public int id {get; set;}
        public int Year {get; set;}
        public string Name {get; set;} 
        public DateTime[] AcademicYear {get; set;} = new DateTime[2];
        public List<Students> ClassStudents {get; set;}
        public List<Teachers> ClassTeachers {get; set;}
        public List<Subjects> ClassSubjects {get; set;}
    }
}