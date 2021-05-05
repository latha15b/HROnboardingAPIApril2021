
using System;
using System.Collections.Generic;
using OnBoardingAPI.Models;

namespace OnBoardingAPI.Dtos
{
    public class PersonalDetailsSummary
    {
        public int EmployeeId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string CellNumber { get; set; }
        public string CurrentAddress { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public string State { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string PersonalEmailId { get; set; }
        public bool IsDeclarationStatus { get; set; }
        public int TotalYearsOfExperience { get; set; }

        public string PermanentAddress { get; set; }
        
        public string  PermanentAddressCity { get; set; }
        public string PermanentAddressPincode { get; set; }
        public string PermanentAddressState { get; set; }

        public List<EducationQualificationsSummary> EducationQualificationsSummaries { get; set; }

        public List<EducationCertificationsSummary> EducationCertificationsSummaries { get; set; }

        public List<PreviousEmployersSummary> PreviousEmployersSummaries { get; set; }

        public GroupMedicalCoverSummary GroupMedicalCoverSummary { get; set; }

        public OtherDetailsSummary OtherDetailsSummary { get; set; }

        public OtherProfessionalDetailsSummary OtherProfessionalDetailsSummary { get; set;}

        public List<UploadDocumentsSummary> UploadDocumentsSummary { get; set; }
    }
}