using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Jobs
/// </summary>
public class Jobs
{
    public int JobCode { get; set; }
    public string JobDescription { get; set; }
    public Jobs()
    {}
    public Jobs(int jobCode, string jobDescription)
    {
        JobCode = jobCode;
        JobDescription = jobDescription;
    }
    public List<Jobs> SelectAll()
    {
        List<Jobs> jobs = new List<Jobs>();
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=bisiisdev;Initial Catalog=dbEmp2;Persist Security Info=True;User ID=bisstudent;Password=bobby2013";
        SqlCommand cmd = new SqlCommand("Select JobCode, JobDescription From Jobs");

        cmd.Connection = con;
        con.Open();
        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        while (reader.Read())
        {
            jobs.Add(new Jobs(Convert.ToInt32(reader["JobCode"].ToString()), reader["JobDescription"].ToString()));
        }
        con.Close();
        return jobs;
    }
}