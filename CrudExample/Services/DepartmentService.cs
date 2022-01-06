using CrudExample.DBContext;
using CrudExample.Entities;
using CrudExample.Exceptions;
using CrudExample.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CrudExample.Services
{
    public class DepartmentService : IDepartmentService
    {
        IExceptions _exceptions;

        public DepartmentService(IExceptions exceptions)
        {
            _exceptions = exceptions;
        }
        public List<Department> GetAllData()
        {
            using (var context=new EmployeeDBContext())
            {
                var result = (List<Department>)context.Departments.ToList();
                var ex = _exceptions.Null(result);
                return ex;
            }
        }

        public Department GetById(int Id)
        {
            using (var context = new EmployeeDBContext())
            {
                var result =context.Departments.SingleOrDefault(x => x.DepartmentId == Id);
                var ex = _exceptions.Null(result);
                return ex;
            }
        }

        public string InsertNewDepartment(string Department)
        {
            using (var context = new EmployeeDBContext())
            {
                var ex = _exceptions.Null(Department);
                if (!String.IsNullOrEmpty(ex))
                {
                    var data = context.Departments.Add(new Department { DepartmentName = Department });
                    context.SaveChanges();
                    return ex;
                }
                else return ex;
            }
        }

        public Department UpdateDepartmentById(int Id,string DepartmentName)
        {
            using (var context = new EmployeeDBContext())
            {
                var query = context.Departments.SingleOrDefault(x => x.DepartmentId == Id);
                var ex = _exceptions.Null(query);
                if (ex != null && !String.IsNullOrEmpty(DepartmentName))
                {
                    query.DepartmentName= DepartmentName;
                    context.SaveChanges();
                    return ex;
                }
                return ex;
            }
        }

        public Department DeleteById(int Id)
        {
            using (var context = new EmployeeDBContext())
            {
                var query= context.Departments.SingleOrDefault(x=> x.DepartmentId==Id);
                var ex = _exceptions.Null(query);
                if(ex != null)
                {
                    context.Remove(query);
                    context.SaveChanges();
                    return ex;
                }
                return ex;
            }
        }
    }
}
