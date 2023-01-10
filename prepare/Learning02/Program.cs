using System;

class Program
{
    static void Main(string[] args)
    {
        
        Job j = new Job();
        j._company = "Bob's fish house";
        j._jobTitle = "Head Crab Shell Crusher";
        j._startYear = 1837;
        j._endYear = 2023;
        
        Job j1 = new Job();
        j1._company = "Walmart";
        j1._jobTitle = "Greeter";
        j1._startYear = 2023;
        j1._endYear = 3047;

        Resume r = new Resume();
        r._name ="Bill Blandman";
        r._employment.Add(j);
        r._employment.Add(j1);
        
        r.displayResume();
        

        
        
    }
    public class Job
    {
        // Member varibles
        public string _company = "";
        public string _jobTitle = "";
        public int _startYear = 0;
        public int _endYear =0;
        
        // Constructor
        public Job()
        {
        }
        
        // functions 
        public void displayJob()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }

    public class Resume
    {
        //Member Varibles
        public string _name ="";
        public List <Job> _employment = new List <Job>();

        //Constructor 
        public Resume()
        {
        }

        //functions 
        
        public void displayResume()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Jobs:");
           foreach (Job j in _employment)
           {
                j.displayJob();
           } 
        }

    }




}