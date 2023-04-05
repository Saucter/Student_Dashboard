using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_Project.Shared.Entities
{
    public class Subjects
    {
        public int id {get; set;}
        public string Name {get; set;}
        public int? Classwork {get; set;}
        public int? Behaviour {get; set;}
        public int? Assignments {get; set;}
        public int? Homework {get; set;}
        public int? Tests {get; set;}
        public int? Exams {get; set;}
    }
}