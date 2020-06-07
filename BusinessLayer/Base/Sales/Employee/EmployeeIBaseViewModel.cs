
using DataAccessLayer.Sales;
using System.Collections.Generic;

namespace BusinessLayer.Base
{
    public partial interface IEmployeeViewModel
    {
        List<Employee> GetAll();
        Employee Find(int id);
        void Update(Employee employee);
        int Insert(Employee employee);
        void Delete(int id);
     
    }
}