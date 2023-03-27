using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dashboard_Project.Shared.Helpers;

namespace Dashboard_Project.Shared.Entities
{
    public class Students
    {
        public Students()
        {
            Grades = GradesInitilizor(Class);
        }
        public int id {get; set;}
        public int CandidateNumber {get; set;}
        public string Name {get; set;}
        public DateTime Birthdate {get; set;}
        private string Username {get; set;}
        private string Password {get; set;} = "rgotc123";
        public CLasses Class {get; set;} = new CLasses();
        public Dictionary<SubjectsList, Subjects> Grades {get; set;}

        public Dictionary<SubjectsList, Subjects> GradesInitilizor(CLasses Class)
        {
            SubjectSelector Selector = new SubjectSelector();
            Dictionary<SubjectsList, Subjects> grades = new Dictionary<SubjectsList, Subjects>();
            foreach(var subject in Selector.Selector(Class))
            {
                grades.Add(subject, new Subjects());
            }
            return grades;
        }
    }
}