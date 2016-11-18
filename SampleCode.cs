public async Task<bool> IsTestWithinTerms(TestDefinition test, DateTimeOffset desiredTestDate, Guid schoolId)
{
    var terms = (await _repositoryManager.SchoolRepository.GetSchool(schoolId)).Terms;
	
    foreach (var term in terms)
    {
        if (term.StartDate.Date <= desiredTestDate.Date && term.EndDate.Date >= desiredTestDate.Date)
        {
              return true;       
        }
    }    
    return false;
}