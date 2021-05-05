using System;

namespace OnBoardingAPI.Dtos
{
    public class UploadDocumentsSummary
    {   
        public string FileName {get;set;}
        public DateTime  ModifiedDate {get; set;}
        public string DocumentType { get; set; }
    }
}