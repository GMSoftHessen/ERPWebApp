
using BusinessLayer.BO;
using DataAccessLayer.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Base
{
    public  class EmployeeBaseViewModel
    {
        #region private members
        private EmployeeBaseBO _EmployeeBaseBO;
        #endregion private members

        #region abfragen
        public EmployeeBaseViewModel(EmployeeBaseBO EmployeeBO)
        {
            _EmployeeBaseBO = EmployeeBO;
        }

        public List<Employee> GetAll()
        {
            return _EmployeeBaseBO.GetAll();
        }
        public Employee Find(int id)
        {
            return _EmployeeBaseBO.Find(id);
        }

        public int Insert(Employee Employee)
        {
            return _EmployeeBaseBO.Insert(Employee);
        }

        public void Update(Employee Employee)
        {
            _EmployeeBaseBO.Update(Employee);
        }

        public void Delete(int id)
        {
            _EmployeeBaseBO.Delete(id);
        }
        #endregion abfragen

       
    }
}
