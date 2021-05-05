using System;
using System.Collections.Generic;
using System.Linq;
using OnBoardingAPI.Dtos;

namespace OnBoardingAPI.Data
{
    public class SqlSummaryRepo : ISummary
    {
        private static OnBoardingContext _context;        

        public SqlSummaryRepo(OnBoardingContext context)
        {
            _context = context;
        }
        public PersonalDetailsSummary GetDetailsSummary(int employeeId)
        {
            PersonalDetailsSummary personalDetailsSummary  = new PersonalDetailsSummary();

            personalDetailsSummary = _context.PersonalDetails
                .Where(data => data.EmployeeId == employeeId)
                .Select(
                data => new PersonalDetailsSummary
                {
                    EmployeeId = data.EmployeeId,
                    Title = data.Title,
                    FirstName = data.FirstName,
                    LastName = data.LastName,
                    DateOfBirth = data.DateOfBirth.ToShortDateString(),
                    CellNumber = data.CellNumber,
                    CurrentAddress= data.CurrentAddress,
                    City = data.City.CityName,
                    Pincode = data.Pincode,
                    State = data.State.StateName,
                    Gender = data.Gender,
                    BloodGroup = data.BloodGroup,
                    EmergencyContactNumber = data.EmergencyContactNumber,
                    PersonalEmailId = data.PersonalEmailId,
                    IsDeclarationStatus = data.IsDeclarationStatus,
                    TotalYearsOfExperience = data.TotalYearsOfExperience,
                    PermanentAddress =  data.PermanentAddress,
                    PermanentAddressCity = GetCityName(data.PermanentAddressCityId),
                    PermanentAddressState = GetStateName(data.PermanentAddressStateId),
                    PermanentAddressPincode = data.PermanentAddressPincode.ToString(),
                }
            ).SingleOrDefault();

            personalDetailsSummary.EducationQualificationsSummaries = 
            GetEducationQualificationsSummaries(employeeId);

            personalDetailsSummary.EducationCertificationsSummaries =
            GetEducationCertificationsSummaries(employeeId);

            personalDetailsSummary.PreviousEmployersSummaries =
            GetPreviousEmployersSummaries(employeeId);
                 
            personalDetailsSummary.GroupMedicalCoverSummary =
            GetGroupMedicalCoverSummary(employeeId);

            personalDetailsSummary.OtherDetailsSummary =
            GetOtherDetailsSummary(employeeId);

            personalDetailsSummary.OtherProfessionalDetailsSummary =
            GetOtherProfessionalDetailsSummary(employeeId);

            personalDetailsSummary.UploadDocumentsSummary =
            GetUploadDocumentsSummaries(employeeId);

            return personalDetailsSummary;
        }

        private List<EducationQualificationsSummary> 
                          GetEducationQualificationsSummaries(int employeeId)
        {
            return  _context.EducationQualifications
                    .Where(data => data.PersonalDetailEmployeeId == employeeId)
                    .Select(
                        data => new EducationQualificationsSummary
                        {
                            Qualification = data.Qualification,
                            YearOfPassing = data.YearOfPassing,
                            NameOfUniversity = data.NameOfUniversity,
                            Specialization = data.Specialization,
                            IsHighestQualification = data.IsHighestQualification
                        }
                    ).ToList<EducationQualificationsSummary>();
        }
        
        private List<EducationCertificationsSummary> GetEducationCertificationsSummaries
        (int employeeId)
        {
            return  _context.EducationCertifications
                        .Where(data => data.PersonalDetailEmployeeId == employeeId)
                        .Select(
                        data => new EducationCertificationsSummary {
                            NameOfCertifcation = data.NameOfCertifcation,
                            Year = data.Year,
                            CertificateNumber = data.CertificateNumber,
                            ExpiryDateOfCertificate = data.ExpiryDateOfCertificate.ToShortDateString()
                        }
                    ).ToList<EducationCertificationsSummary>();
        }

        public List<PreviousEmployersSummary> GetPreviousEmployersSummaries(int employeeId)
        {
            return    _context.PreviousEmployers
                     .Where(data => data.PersonalDetailEmployeeId == employeeId)
                     .Select(data => new PreviousEmployersSummary {
                            PreviousEmployerName = data.PreviousEmployerName,
                            DateOfJoining = data.DateOfJoining.ToShortDateString(),
                            LastWorkingDay = data.LastWorkingDay.ToShortDateString(),
                            ReasonForLeaving = data.ReasonForLeaving,
                            AreTheExitFormalitiesCompleted = data.AreTheExitFormalitiesCompleted,
                            UniversalAccountNo = data.UniversalAccountNo,
                            ProvidentFundNo = data.ProvidentFundNo,
                            TypeOfPFAccount = data.TypeOfPFAccount,
                            IsLatestLastEmployer = data.IsLatestLastEmployer,
                            HrName = data.HrName,
                            HrContactNumber = data.HrContactNumber,
                            HrEmailID = data.HrEmailID
                     }).ToList<PreviousEmployersSummary>();
        }

        private GroupMedicalCoverSummary GetGroupMedicalCoverSummary(int employeeId)
        {
            GroupMedicalCoverSummary groupMedicalCoverSummary =
            new GroupMedicalCoverSummary();
            
            var personalDetails = _context.PersonalDetails.
            Where(data => data.EmployeeId == employeeId).SingleOrDefault();

            groupMedicalCoverSummary = _context.GroupMedicalCovers.
            Where(data => 
            data.GroupMedicalId == personalDetails.GroupMedicalCoverGroupMedicalId)
            .Select(data => new GroupMedicalCoverSummary{
                DateOfJoining = data.DateOfJoining.ToShortDateString(),
                ParentOrInLawsName1= data.ParentOrInLawsName1,
                ParentOrInLawsName2 = data.ParentOrInLawsName2,
                ParentOrInLawsName1Relationship = data.ParentOrInLawsName1Relationship,
                ParentOrInLawsName2Relationship = data.ParentOrInLawsName2Relationship,
                Married = data.Married,
                DateOfMarriage = data.DateOfMarriage != null ? data.DateOfMarriage.Value.ToShortDateString() : string.Empty,
                SpouseName = data.SpouseName,
                SpouseDateOfBirth = data.SpouseDateOfBirth != null ? data.SpouseDateOfBirth.Value.ToShortDateString() : string.Empty,
                SpouseGender = data.SpouseGender,
                DoYouHaveKids = data.DoYouHaveKids
            }).SingleOrDefault<GroupMedicalCoverSummary>();


            groupMedicalCoverSummary.Kids = _context.Kids.Where
            (data => data.GroupMedicalCoverGroupMedicalId == personalDetails.GroupMedicalCoverGroupMedicalId)
            .Select(data => new KidsSummary{
                KidName = data.KidName,
                KidDateOfBirth = data.KidDateOfBirth.ToShortDateString(),
                KidGender = data.KidGender
            }).ToList<KidsSummary>();

            return groupMedicalCoverSummary;
        }

        private OtherDetailsSummary GetOtherDetailsSummary(int employeeId)
        {
            var personalDetails = _context.PersonalDetails.
            Where(data => data.EmployeeId == employeeId).SingleOrDefault();

            return  _context.OtherDetails.
                    Where(data => data.OtherDetailsId == personalDetails.OtherDetailsId)
                    .Select(data => new OtherDetailsSummary{
                        PANNumber = data.PANNumber,
                        NameAsOnPANCard = data.NameAsOnPANCard,
                        AadhaarNumber = data.AadhaarNumber,
                        NameAsOnAadhaar = data.NameAsOnAadhaar,
                        PassportNumber = data.PassportNumber,
                        NameAsOnPassport = data.NameAsOnPassport,
                        Nationality = data.Nationality,
                        PlaceOfIssue = data.PlaceOfIssue,
                        ValidFrom = data.ValidFrom.ToShortDateString(),
                        ValidTo = data.ValidTo.ToShortDateString(),
                        AccountNumber = data.AccountNumber,
                        IFSCCode = data.IFSCCode,
                        NameAsInBankAccount = data.NameAsInBankAccount,
                        Branch = data.Branch,
                        PermanentAddress = data.PermanentAddress,
                        State = data.State,
                        Pincode = data.Pincode,
                        BankName = data.BankName
                    }).SingleOrDefault<OtherDetailsSummary>();
        }

        public OtherProfessionalDetailsSummary GetOtherProfessionalDetailsSummary(int employeeId)
        {
            var personalDetails = _context.PersonalDetails.
            Where(data => data.EmployeeId == employeeId).SingleOrDefault();

            return _context.OtherProfessionalDetails
                    .Where(data => data.OtherProfessionalDetailsId == personalDetails.OtherProfessionalDetailsId)
                    .Select(data => new OtherProfessionalDetailsSummary {
                        PrimarySkills = data.PrimarySkills,
                        PrimarySkillsLevel = data.PrimarySkillsLevel,
                        SecondarySkills = data.SecondarySkills,
                        SecondarySkillLevel = data.SecondarySkillLevel,
                        VerbalCommunicationLevel = data.VerbalCommunicationLevel,
                        WrittenCommunicationLevel = data.WrittenCommunicationLevel,
                        PresentationSkillsLevel = data.PresentationSkillsLevel,
                        CustomerInterfactingLevel = data.CustomerInterfactingLevel,
                    }).SingleOrDefault<OtherProfessionalDetailsSummary>();           
        }

        public List<UploadDocumentsSummary> GetUploadDocumentsSummaries(int employeeId)
        {
           return _context.UploadDocuments.
                    Where(data => data.PersonalDetailEmployeeId == employeeId)
                    .Select(data => new UploadDocumentsSummary{
                        FileName = data.FileName,
                        ModifiedDate = data.ModifiedDate,
                        DocumentType = data.DocumentType.DocumentTypeName
                    }).ToList<UploadDocumentsSummary>();
        }

        public static string GetCityName(int cityID)
        {
            return _context.City.Where(c => c.CityId == cityID).Select(c => c.CityName).FirstOrDefault();
        }

        public static string GetStateName(int stateID)
        {
            return _context.State.Where(s => s.StateId == stateID).Select(s => s.StateName).SingleOrDefault();
        }

    }
}