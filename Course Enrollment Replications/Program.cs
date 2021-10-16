using System;
using System.Collections.Generic;
using System.Linq;



public class _361_final_Q2
{
    public static void Main()
    {
        List<course> courses = new List<course>();
        courses.Add(new course("CS150", 180, 200));
        courses.Add(new course("CS250", 21, 30));
        courses.Add(new course("CS270", 9, 20));
        courses.Add(new course("CS300", 4, 20));
        courses.Add(new course("CS350", 20, 20));
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(courses[i].ToString());
        }
    }
}

public class course
{
    private string className;
    private int currentEnrollment;
    private int maxEnrollment;

    public string name
    {
        get
        {
            return className;
        }
        set
        {
            className = value;
        }
    }

    public int cEnroll
    {
        get
        {
            return currentEnrollment;
        }
        set
        {
            currentEnrollment = value;
        }
    }

    public int mEnroll
    {
        get
        {
            return maxEnrollment;
        }
        set
        {
            maxEnrollment = value;
        }
    }

    public int leftOver()
    {
        int left = maxEnrollment - currentEnrollment;
        return left;
    }

    public override string ToString()
    {
        return "\nCourse Name: " + name + "\nCurrent Enrollment: " + cEnroll + "\nOpenings left: " + leftOver();
    }

    public course(string n, int e, int m)
    {
        className = n;
        currentEnrollment = e;
        maxEnrollment = m;
    }
}

