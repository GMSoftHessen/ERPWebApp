

namespace BusinessLayer.Customize
{
    public class EmployeeBO
    {
        EmployeeRepository _EmployeeRepository;
        
        public EmployeeBO(EmployeeRepository EmployeeRepository) 
        {
            _EmployeeRepository = EmployeeRepository;
        }
    }
}