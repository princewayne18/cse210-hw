public class Job
{
    //variables that will use for the project 
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //this is a constructor with parametres that will be used in the main program wehn creating new instances
    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }


    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} { _company} { _startYear}-{_endYear}");
        
    }
}