using System;

namespace OnBoardingAPI.Dtos
{
    public class PreviousEmployersSummary
    {
        public string PreviousEmployerName { get; set; }

        public string DateOfJoining { get; set; }

        public string LastWorkingDay { get; set; }

        public string ReasonForLeaving { get; set; }

        public bool AreTheExitFormalitiesCompleted { get; set;}

        public string UniversalAccountNo { get; set; }

        public string ProvidentFundNo { get; set; }

        public string TypeOfPFAccount { get; set; }

        public bool IsLatestLastEmployer { get; set; }
        public string HrName { get; set; }
        
        public string HrContactNumber { get; set; }

        public string HrEmailID { get; set; }

        public int PersonalDetailEmployeeId { get; set; }
    }
}