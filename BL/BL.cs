using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    class BL : IBL
    {
        DAL.Dal_imp dal;
        public void contractAdd(Contract tempContract)
        {
            empoyEmployerExistece(tempContract);
            isNewComp(tempContract);
            dal.contractAdd(tempContract);
        }

        public void contractRemove(Contract tempContract)
        {
            throw new NotImplementedException();
        }

        public void contractUpdate(Contract tempContract)
        {
            empoyEmployerExistece(tempContract);
            isNewComp(tempContract);
            throw new NotImplementedException();
        }

        public void employeeAdd(Employee tempEmployee)
        {
            checkEmployee18(tempEmployee);
            dal.employeeAdd(tempEmployee);
        }

        public void employeeRemove(Employee tempEmployee)
        {
            throw new NotImplementedException();
        }

        public void employeeUpdate(Employee tempEmployee)
        {
            checkEmployee18(tempEmployee);
            throw new NotImplementedException();
        }

        public void employerAdd(Employer tempEmployer)
        {
            throw new NotImplementedException();
        }

        public void employerRemove(Employer tempEmployer)
        {
            throw new NotImplementedException();
        }

        public void employerUpdate(Employer tempEmployer)
        {
            throw new NotImplementedException();
        }

        public ICollection<Contract> getAllContract()
        {
            throw new NotImplementedException();
        }

        public ICollection<Employee> getAllEmployee()
        {
            throw new NotImplementedException();
        }

        public ICollection<Employer> getAllEmployer()
        {
            throw new NotImplementedException();
        }

        public ICollection<Specialization> getAllSpecialization()
        {
            throw new NotImplementedException();
        }

        public void specializationAdd(Specialization tempSpecialization)
        {
            throw new NotImplementedException();
        }

        public void specializationRemove(Specialization tempSpecialization)
        {
            throw new NotImplementedException();
        }

        public void specializationUpdate(Specialization tempSpecialization)
        {
            throw new NotImplementedException();
        }
        void checkEmployee18(Employee tempEmployee)
        {
            var today = DateTime.Today;
            if (tempEmployee.BirthDate > today.AddYears(-18))
            {
                throw new Exception("Employee most be minimom 18 year");
            }
        }
        void empoyEmployerExistece(Contract tempContract)
        {
            var employee = getAllEmployee().FirstOrDefault(Employee => Employee.Id == tempContract.EmployeeID);
            var employer = getAllEmployer().FirstOrDefault(Employer => Employer.CompanyId == tempContract.EmployerId);
            if (employee == null)
            {
                throw new Exception("the Employee not exsit ");
            }
            if (employer == null)
            {
                throw new Exception("the Employer not exsit ");
            }
        }

        void isNewComp(Contract tempContract)
        {
            if (tempContract.SignedContract == true)
            {

                var employer = getAllEmployer().FirstOrDefault(Employer => Employer.CompanyId == tempContract.EmployerId);
                if (employer == null)
                {
                    throw new Exception("Strange error  the Employer not exsit ");
                }
                var today = DateTime.Today;
                if (employer.SinceDate > today.AddYears(-1))
                {
                    throw new Exception("This new company cant sign her");
                }

            }
        }

        int commission(Contract contract)
        {

            var sumJob = from item in getAllContract()
                         where item.EmployeeID == contract.EmployeeID
                         select item;
            int sum = 0;
            foreach (var item in sumJob)
            {
                sum++;
            }
            return ((int)contract.GrossHourlySalary / 10) / sum;

        }

        IEnumerable<Contract> getAllCcontractInConditions(Func<Contract, bool> Conditions)
        {
            var obj = getAllContract().Where(Conditions);
            return obj;
        }

        int sumAllCcontractInConditions(Func<Contract, bool> Conditions)
        {
            var obj = getAllContract().Where(Conditions);
            int sum = 0;
            foreach (var item in obj)
            {
                sum++;
            }
            return sum;
        }

        IEnumerable<IGrouping<int, Contract>> getAllCcontractOrderBySpecialization(bool order = false) // need to improve
        {
            if (order == true)
            {
                var obj = from item in getAllContract()
                          group item by item.SpecializationId;

                return obj;

            }
            else
            {
                var obj = from item in getAllContract()
                          group item by (int)item.ContractNumber;
                return obj;
            }
        }
        //IEnumerable<IGrouping<Address, Contract>> getAllCcontractOrderByAddress(bool order = false) // need to improve
        //{
        //    if (order == true)
        //    {
        //        var obj = from item in getAllContract()
        //                  group item by ((Employee)getAllEmployee().First(Employee => Employee.Id == item.EmployeeID)).Address;

        //        return obj;

        //    }
        //    else
        //    {
        //        var obj = from item in getAllContract()
        //                  group item by (int)item.ContractNumber;
        //        return obj;
        //    }
        //}
        IEnumerable<IGrouping<bool, Contract>> getAllCcontractOrderByAddress(bool order = false) // need to improve
        {
            if (order == true)
            {
                var obj = from item in getAllContract()
                          orderby ((Employee)getAllEmployee().First(Employee => Employee.Id == item.EmployeeID)).Address
                          group item by order;

                return obj;

            }
            else
            {
                var obj = from item in getAllContract()
                          group item by (int)item.ContractNumber;
                return obj;
            }
        }


    }
}
