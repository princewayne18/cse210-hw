using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Software Engineer", "(Microsoft)", 2019, 2022);

        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();


        //INSTICTIATING THE LIST 
        Resume myResume = new Resume();

        //ADDING BY USING THE DOT AND THE VARIABLE FROM RESUME
        myResume._name = "Allison Rose";

        //ADDING THE JOBS INTO THE LIST
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    
    }
}