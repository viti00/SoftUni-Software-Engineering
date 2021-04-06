using System;
using System.Collections.Generic;
using System.Text;

namespace _03.OldestFamilyMember
{
    public class Family
    {
        public List<string> ListPeople { get; set; }

        public void AddMember (string name, int age)
        {
            List<string> peopleNames = new List<string>();
            List<int> peopleYears = new List<int>();

            peopleNames.Add(name);
            peopleYears.Add(age);
        }

        public string GetOldestMember(List<string> peopleNames, List<int> peopleYears)
        {
            int maxAge = int.MinValue;
            string personName = "";
            for (int i = 0; i < peopleYears.Count; i++)
            {
                int currAge = peopleYears[i];
                if(currAge > maxAge)
                {
                    maxAge = currAge;
                    personName = peopleNames[i];
                }
            }
            string result = $"{personName} {maxAge}";
            return result;
        }
    }
}
