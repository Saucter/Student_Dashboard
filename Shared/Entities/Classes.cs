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
        public CLasses(){}
        public CLasses(int Year, string Letter, DateTime EnrollmentDate, DateTime GraduationDate)
        {
            this.Year = Year;
            this.Letter = $"{Year.ToString()}{Letter}";
            this.EnrollmentDate = EnrollmentDate;
            this.GraduationDate = GraduationDate;
            ClassSubjects = Selector.Selector(Year);
        }
        public int id {get; set;}
        public int Year;
        public string Letter;
        public DateTime EnrollmentDate {get; set;}
        public DateTime GraduationDate {get; set;}
        public List<Students> ClassStudents {get; set;}
        public List<Teachers> ClassTeachers {get; set;}
        public List<SubjectsList> ClassSubjects;
        public List<TeachersClasses> TeachersClasses {get; set;} = new List<TeachersClasses>();
    }
}