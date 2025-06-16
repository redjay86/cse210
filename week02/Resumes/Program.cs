using System;

Job job1 = new Job();
job1._jobTitle = "Software Engineer";
job1._company = "Microsoft";
job1._startYear = 2019;
job1._endYear = 2022;

Job job2 = new Job();
job2._jobTitle = "Manager";
job2._company = "Apple";
job2._startYear = 2022;
job2._endYear = 2023;

Resume my_resume = new Resume();
my_resume._jobs.Add(job1);
my_resume._jobs.Add(job2);
my_resume._name = "Rex Wight";

my_resume.Display();