using System;

namespace OnBoardingAPI.Dtos
{
    public class OtherDetailsSummary
    {
   
        public string PANNumber { get; set; }
        public string NameAsOnPANCard { get; set; }
        public string AadhaarNumber { get; set; }
        public string NameAsOnAadhaar { get; set; }
        public string PassportNumber { get; set; }
        public string NameAsOnPassport { get; set; }
        public string Nationality { get; set; }
        public string PlaceOfIssue { get; set; }
        public string ValidFrom { get; set; }
        public string ValidTo { get; set; }
        public string BankName {get; set;}
        public string AccountNumber { get; set; }
        public string IFSCCode { get; set; }
        public string NameAsInBankAccount { get; set; }
        public string Branch { get; set; }
        public string PermanentAddress { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }
    }
}