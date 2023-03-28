using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dashboard_Project.Shared.Entities;

namespace Dashboard_Project.Shared.Helpers
{
    public class SubjectSelector
    {
        List<SubjectsList> subjectsList = new List<SubjectsList>();
        public List<SubjectsList> Selector(int? Year)
        {
            switch(Year)
            {
                case 1:
                    subjectsList.AddRange(new List<SubjectsList>
                    {
                        SubjectsList.Arabic, SubjectsList.Islamic, SubjectsList.English, SubjectsList.Science, SubjectsList.Life_Skills, SubjectsList.Social_Studies, SubjectsList.Candidates, SubjectsList.Math, SubjectsList.ICT
                    });
                    return subjectsList;
                case <= 4:
                    subjectsList.AddRange(new List<SubjectsList>
                    {
                        SubjectsList.Arabic, SubjectsList.Islamic, SubjectsList.English, SubjectsList.Science, SubjectsList.Workshop, SubjectsList.Social_Studies, SubjectsList.Candidates, SubjectsList.Math, SubjectsList.ICT
                    });
                    return subjectsList;
                case 5:
                    subjectsList.AddRange(new List<SubjectsList>
                    {
                        SubjectsList.Arabic, SubjectsList.Islamic, SubjectsList.English, SubjectsList.Physics, SubjectsList.Chemistry, SubjectsList.Electronics, SubjectsList.Workshop, SubjectsList.Candidates, SubjectsList.Math, SubjectsList.ICT
                    });
                    return subjectsList;
                case 6:
                    subjectsList.AddRange(new List<SubjectsList>
                    {
                        SubjectsList.Arabic, SubjectsList.Islamic, SubjectsList.English, SubjectsList.Physics, SubjectsList.Chemistry, SubjectsList.Electronics, SubjectsList.Product_Design, SubjectsList.Material_Science, SubjectsList.Candidates, SubjectsList.Math, SubjectsList.ICT
                    });
                    return subjectsList;
                case 7:
                    subjectsList.AddRange(new List<SubjectsList>
                    {
                        SubjectsList.Arabic, SubjectsList.Islamic, SubjectsList.English, SubjectsList.Physics, SubjectsList.Chemistry, SubjectsList.Math, SubjectsList.BTEC_Electronics, SubjectsList.BTEC_Additive_Manufacturing, SubjectsList.BTEC_Thermodynamics, SubjectsList.BTEC_Microcontrollers, SubjectsList.BTEC_Delivery
                    });
                    return subjectsList;
                case 8:
                    subjectsList.AddRange(new List<SubjectsList>
                    {
                        SubjectsList.Arabic, SubjectsList.Islamic, SubjectsList.English, SubjectsList.Physics, SubjectsList.Chemistry, SubjectsList.Math, SubjectsList.BTEC_ICT, SubjectsList.BTEC_Product_Design, SubjectsList.BTEC_Project
                    });
                    return subjectsList;
                default:
                    return null;
            }
        }
    }
}