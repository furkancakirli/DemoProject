using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
  public class Employees
  {
    [Key]
    public int EmployeeId
    {
      get;
      set;
    }
    public string EmployeeFirstName
    {
      get;
      set;
    }
    public string EmployeeLastName
    {
      get;
      set;
    }
    public string EmployeeEmail
     {
      get;
      set;
     }

    public string EmployeePassword
        {
            get;
            set;
        }

    }


}
