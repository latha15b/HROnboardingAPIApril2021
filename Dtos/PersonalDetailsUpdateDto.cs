
using System;
using System.ComponentModel.DataAnnotations;

namespace OnBoardingAPI.Dtos
{
    public class PersonalDetailsUpdateDto
    {   
        [Required]
        [MaxLength(10)]
        public string Title { get; set; }

        [Required]
        [MaxLength(250)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(250)]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(50)]
        public string CellNumber { get; set; }

        [Required]
        [MaxLength(1000)]
        public string CurrentAddress { get; set; }
        
          [Required]
        [MaxLength(250)]
        public string CityId { get; set; }
        
        [Required]
        public int Pincode { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string StateId { get; set; }
        
        [Required]
        [MaxLength(10)]
        public string Gender { get; set; }
    
        [Required]
        [MaxLength(10)]
        public string BloodGroup { get; set; }
    
        [Required]
        public string EmergencyContactNumber { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string PersonalEmailId { get; set; }
        
        public bool IsDeclarationStatus { get; set; }

        [Required]
        public int TotalYearsOfExperience { get; set; }

        public int? GroupMedicalCoverGroupMedicalId { get; set; }

        public int? OtherDetailsId { get; set; }

        public int? OtherProfessionalDetailsId { get; set; }
        public int? UploadDocumentId { get; set; }

        public string PermanentAddress { get; set; }
        public int PermanentAddressCityId { get; set; }
        public int PermanentAddressPincode { get; set; }
        public int PermanentAddressStateId { get; set; }
    }
}