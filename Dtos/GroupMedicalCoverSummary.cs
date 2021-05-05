using System;
using System.Collections.Generic;

namespace OnBoardingAPI.Dtos
{
    public class GroupMedicalCoverSummary
    {
        public string DateOfJoining { get; set; }

        public string ParentOrInLawsName1 { get; set; }

        public string ParentOrInLawsName2 { get; set; }

        public string ParentOrInLawsName1Relationship { get; set; }

        public string ParentOrInLawsName2Relationship { get; set; }

        public bool Married { get; set; }

        public string DateOfMarriage { get; set; }

        public string SpouseName { get; set; }

        public string SpouseDateOfBirth { get; set; }

        public string SpouseGender { get; set; }

        public bool DoYouHaveKids { get; set; }
        public List<KidsSummary> Kids { get; set; }
    }
}