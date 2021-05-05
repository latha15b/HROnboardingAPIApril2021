using System.Collections.Generic;
using OnBoardingAPI.Dtos;

public interface ISummary
{
    PersonalDetailsSummary GetDetailsSummary(int employeeId);
}