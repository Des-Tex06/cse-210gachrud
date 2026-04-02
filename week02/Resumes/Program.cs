
Job job1 = new Job();
job1._company = "Microsoft";
job1._jobTitle = "Software Engineer";
job1._startYear = 2019;
job1._endYear = 2022;
//job1.DisplayJobDescription();
Job job2 = new Job();
job2._company = "Apple";
job2._jobTitle = "Manager";
job2._startYear = 2022;
job2._endYear = 2023;
//job2.DisplayJobDescription();
Resume myResume = new Resume();
myResume._jobs.Add(job1); //When adding things to a list, use the name of the list instead of the instance.
myResume._jobs.Add(job2);
myResume._name = "Allison Rose";
myResume.DisplayResume();
