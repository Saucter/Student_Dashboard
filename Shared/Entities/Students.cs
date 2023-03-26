using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_Project.Shared.Entities
{
    public class Students
    {
        public int id {get; set;}
        public int CandidateNumber {get; set;}
        public string Name {get; set;}
        private string Username {get; set;}
        private string Password {get; set;} = "rgotc123";
        public CLasses Class {get; set;}
        public Dictionary<string, int> Grades {get; set;}
    }
}