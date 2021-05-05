using System;

namespace OnBoardingAPI.Dtos
{
    public class EducationCertificationsSummary
    {
        public string NameOfCertifcation { get; set;}
        public int Year { get; set; }
        public string CertificateNumber { get; set; }
        public string ExpiryDateOfCertificate { get; set; }

    }
}