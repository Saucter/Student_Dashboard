using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Dashboard_Project.Shared.Helpers;

namespace Dashboard_Project.Shared.Entities
{
    public class Students
    {
        public Students(){}
        public Students(int CandidateNumber, string Name, DateTime BirthOfDate, CLasses Class)
        {
            this.CandidateNumber = CandidateNumber;
            this.Name = Name;
            this.BirthOfDate = BirthOfDate;
            this.Class = Class;
            Grades = GradesInitilizor(Class);
            Username = CandidateNumber.ToString();
        }
        
        public int id {get; set;}
        public int CandidateNumber {get; set;}
        public string Name {get; set;}
        public DateTime BirthOfDate {get; set;}
        private string Username {get; set;}
        private string Password {get; set;} = "rgotc123";
        public CLasses Class {get; set;} = new CLasses();
        [NotMapped]
        public List<Grades> Grades {get; set;}
        
        public List<Grades> GradesInitilizor(CLasses Class)
        {
            List<Grades> grades = new List<Grades>();
            for(int i = 0; i < Class.ClassSubjects.Count(); i++)
            {
                grades.Add(new Grades(Class.ClassSubjects[i], new Subjects()));
            }
            return grades;
        }
    }
}