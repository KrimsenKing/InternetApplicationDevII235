using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for EmployeeManager
/// </summary>
public class EmployeeManager
{
    public string connectionString;
    public EmployeeManager()
    {
        connectionString = "Data Source=bisiisdev;Initial Catalog=dbEmp2;Persist Security Info=True;User ID=bisstudent;Password=bobby2013";
    }

    public List<Employee> getEmployees()
    {
        List<Employee> employees = new List<Employee>();
        SqlConnection con = new SqlConnection();
        con.ConnectionString = connectionString;
        SqlCommand cmd = new SqlCommand("Select EmployeeId, FirstName, LastName, JobCode From Employees");
        cmd.Connection = con;
        con.Open();
        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            employees.Add(new Employee(Convert.ToInt32(reader["EmployeeID"].ToString()), reader["FirstName"].ToString(), reader["LastName"].ToString(), Convert.ToInt32(reader["JobCode"].ToString())));
        }
        con.Close();
        return employees;
    }

    public List<Employee> getEmployeesByJobeCode(int jCode)
    {
        List<Employee> employees = new List<Employee>();
        SqlConnection con = new SqlConnection();
        con.ConnectionString = connectionString;
        SqlCommand cmd = new SqlCommand("Select EmployeeID, FirstName, LastName, JobCode From Employees Where JobCode=@JobCode");
        cmd.Parameters.AddWithValue("@JobCode", jCode);

        cmd.Connection = con;
        con.Open();
        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            employees.Add(new Employee(Convert.ToInt32(reader["EmployeeID"].ToString()), reader["FirstName"].ToString(), reader["LastName"].ToString(), Convert.ToInt32(reader["JobCode"].ToString())));
        }
        con.Close();
        return employees;
    }
    public void updateEmployee(int employeeID, string firstName, string lastName, int jobCode)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = connectionString;
        SqlCommand cmd = new SqlCommand("Update Employees set FirstName=@firstName, LastName=@lastName, JobeCode=@jobCode Where EmployeeId=@employeeId");
        cmd.Parameters.AddWithValue("@FirstName", firstName);
        cmd.Parameters.AddWithValue("@LastName", lastName);
        cmd.Parameters.AddWithValue("@JobCode", jobCode);
        cmd.Parameters.AddWithValue("@EmployeeId", employeeID);

        cmd.Connection = con;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void insertEmployee(int employeeID, string firstName, string lastName, int jobCode)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = connectionString;
        SqlCommand cmd = new SqlCommand("Insert into Employees set EmployeeId=@employeeId, FirstName=@firstName, LastName=@lastName, JobCode=@jobCode");
        cmd.Parameters.AddWithValue("@FirstName", firstName);
        cmd.Parameters.AddWithValue("@LastName", lastName);
        cmd.Parameters.AddWithValue("@JobCode", jobCode);
        cmd.Parameters.AddWithValue("@EmployeeId", employeeID);

        cmd.Connection = con;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
}
