using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dashboard_Project.Shared.Helpers;

namespace Dashboard_Project.Shared.Entities
{
    public class Grades
    {
        public Grades(SubjectsList SubjectName, Subjects Subject)
        {
            this.SubjectName = SubjectName;
            this.Subject = Subject;
        }
        public int id {get; set;}
        public SubjectsList SubjectName {get; set;}
        public Subjects Subject {get; set;}
    }
}