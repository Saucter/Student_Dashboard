using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dashboard_Project.Shared.Helpers;

namespace Dashboard_Project.Shared.Entities
{
    public class CLasses
    {
        protected readonly SubjectSelector Selector = new SubjectSelector();
        public CLasses(int Year, string Name, DateTime[] AcademicYear)
        {
            this.Year = Year;
            this.Name = Name;
            this.AcademicYear = AcademicYear;
            ClassSubjects = Selector.Selector(Year);
        }
        public int id {get; set;}
        public int Year;
        public string Name;
        public DateTime[] AcademicYear {get; set;} = new DateTime[2];
        public List<Students> ClassStudents {get; set;}
        public List<Teachers> ClassTeachers {get; set;}
        public List<SubjectsList> ClassSubjects;
    }
}