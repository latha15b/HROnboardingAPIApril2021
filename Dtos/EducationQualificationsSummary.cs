namespace OnBoardingAPI.Dtos
{
    public class EducationQualificationsSummary
    {
        public string Qualification { get; set;}

        public int YearOfPassing { get; set; }

        public string NameOfUniversity { get; set; }

        public string Specialization { get; set; }

        public bool IsHighestQualification { get; set; }    
        
    }
}