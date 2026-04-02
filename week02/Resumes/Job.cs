public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    
    //public Job() //This line of code was unneccessary due to it being absent from the solution version.   
    //{
    //}
    public int _startYear;
    public int _endYear; 
    public void DisplayJobDescription()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}