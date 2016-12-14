using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Employee
/// </summary>
public class Employee
{
    public int EmployeeNumber { set; get; }
    public string FirstName { set; get; }
    public string LastName { set; get; }
    public int JobCode { set; get; }

    public Employee()
    {}
    public Employee(int eNum, string fName, string lName, int jCode)
    {
        EmployeeNumber = eNum;
        FirstName = fName;
        LastName = lName;
        JobCode = jCode;              
    }
}