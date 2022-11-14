using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Services
{
    
    public class EmployeeService : IEmployeeService
    {
        private EmpContext _context;
        public  EmployeeService(EmpContext context)
        {
            _context = context;
        }
        public Employees GetEmployeeDetailsById(int empId)
        {
            Employees emp;
            try
            {
                emp = _context.Find<Employees>(empId);
            }
            catch (Exception)
            {
                throw;
            }
            return emp;
        }

        public List<Employees> GetEmployeesList()
        {
            List<Employees> empList;
            try
            {
                empList = _context.Set<Employees>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return empList;
        }



        public ResponseModel SaveEmployee(Employees employeeModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Employees _temp = GetEmployeeDetailsById(employeeModel.EmployeeId);
                if (_temp != null)
                {
                    _temp.EmployeeEmail = employeeModel.EmployeeEmail;
                    _temp.EmployeeFirstName = employeeModel.EmployeeFirstName;
                    _temp.EmployeeLastName = employeeModel.EmployeeLastName;
                    _temp.EmployeePassword = employeeModel.EmployeePassword;
                    _context.Update<Employees>(_temp);
                    model.Messsage = "Employee Update Successfully";
                }
                else
                {
                    _context.Add<Employees>(employeeModel);
                    model.Messsage = "Employee Inserted Successfully";
                }
                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }


    }
}
