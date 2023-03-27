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
        public List<SubjectsList> Selector(CLasses Class)
        {
            switch(Class.Year)
            {
                case 1:
                    subjectsList.AddRange(new List<SubjectsList>
                    {
                        SubjectsList.Arabic, SubjectsList.English
                    });
                    return subjectsList;
                    break;
                case 2:
                    subjectsList.AddRange(new List<SubjectsList>
                    {
                        SubjectsList.Arabic, SubjectsList.English
                    });
                    return subjectsList;
                    break;
                case 3:
                    subjectsList.AddRange(new List<SubjectsList>
                    {
                        SubjectsList.Arabic, SubjectsList.English
                    });
                    return subjectsList;
                    break;
                case 4:
                    subjectsList.AddRange(new List<SubjectsList>
                    {
                        SubjectsList.Arabic, SubjectsList.English
                    });
                    return subjectsList;
                    break;
                case 5:
                    subjectsList.AddRange(new List<SubjectsList>
                    {
                        SubjectsList.Arabic, SubjectsList.English
                    });
                    return subjectsList;
                    break;
                case 6:
                    subjectsList.AddRange(new List<SubjectsList>
                    {
                        SubjectsList.Arabic, SubjectsList.English
                    });
                    return subjectsList;
                    break;
                case 7:
                    subjectsList.AddRange(new List<SubjectsList>
                    {
                        SubjectsList.Arabic, SubjectsList.English
                    });
                    return subjectsList;
                    break;
                case 8:
                    subjectsList.AddRange(new List<SubjectsList>
                    {
                        SubjectsList.Arabic, SubjectsList.English
                    });
                    return subjectsList;
                    break;
            }
            return null;
        }
    }
}