using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    class Bl_imp : IBL
    {
        DAL.Dal_imp dal;
        public void contractAdd(Contract tempContract)
        {
            employEmployerExistence(tempContract);
            isNewComp(tempContract);
            dal.contractAdd(tempContract);
        }

        public void contractRemove(Contract tempContract)
        {
            throw new NotImplementedException();
        }

        public void contractUpdate(Contract tempContract)
        {
            employEmployerExistence(tempContract);
            isNewComp(tempContract);
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
                throw new Exception("Employee must be at least 18 years old!");
            }
        }

        void employEmployerExistence(Contract tempContract)
        {
            var employee = getAllEmployee().FirstOrDefault(Employee => Employee.Id == tempContract.EmployeeID);
            var employer = getAllEmployer().FirstOrDefault(Employer => Employer.CompanyId == tempContract.EmployerId);
            if (employee == null)
            {
                throw new Exception("the Employee isnt exsit! ");
            }
            if (employer == null)
            {
                throw new Exception("the Employer isnt exsit! ");
            }
        }

        void isNewComp(Contract tempContract)
        {
            if (tempContract.SignedContract == true)
            {
                var employer = getAllEmployer().FirstOrDefault(Employer => Employer.CompanyId == tempContract.EmployerId);
                //if (employer == null)
                //{
                //    throw new Exception("Strange error, the Employer isnt exist! ");
                //}
                var today = DateTime.Today;
                if (employer.SinceDate > today.AddYears(-1))
                {
                    throw new Exception("The company is too new to sign a contract!");
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

        //IEnumerable<IGrouping<int, Contract>> getAllCcontractOrderBySpecialization(bool order = false) // need to improve
        //{
        //    if (order == true)
        //    {
        //        var obj = from item in getAllContract()
        //                  group item by item.SpecializationId;

        //        return obj;

        //    }
        //    else
        //    {
        //        var obj = from item in getAllContract()
        //                  group item by (int)item.ContractNumber;
        //        return obj;
        //    }
        //}
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
        //IEnumerable<IGrouping<bool, Contract>> getAllCcontractOrderByAddress(bool order = false) // need to improve
        //{
        //    if (order == true)
        //    {
        //        var obj = from item in getAllContract()
        //                  orderby ((Employee)getAllEmployee().First(Employee => Employee.Id == item.EmployeeID)).Address
        //                  group item by order;

        //        return obj;

        //    }
        //    else
        //    {
        //        var obj = from item in getAllContract()
        //                  group item by (int)item.ContractNumber;
        //        return obj;
        //    }
        //}

        //public ICollection<Contract> getContractsBySpecialty(bool sorted = false)
        //{ 
        //    var contsList = getcontList();
        //    if (sorted)
        //    {
        //        contsList.GroupBy(x => x.SpecializationId);
        //        return contsList;
        //        //var contSpecs =
        //        //    from Contract in contsList
        //        //    group Contract by Contract.GrossHourlySalary into contSpecList
        //        //    orderby contSpecList.Key  //sorted
        //        //    select contSpecList;
        //    }
        //    else
        //    {
        //        var contSpecs =
        //            from Contract in contsList
        //            group Contract by Contract.GrossHourlySalary into contSpecList
        //            select contSpecList;
        //        return (ICollection<Contract>)contSpecs;
        //    }
        //}
        //public List<Contract> getcontList() //aid function to the func above ^^^
        //{
        //    return (List<Contract>)(dal.getAllContract());
        //}


        //public ICollection<Contract> getContractsByAdress(bool sorted = false)
        //{
        //    var contsList = getcontList();
        //    if (sorted)
        //    {
        //        contsList.GroupBy(x => x); //how to order by adress? adress of whom?
        //        return contsList;
        //    }
        //    else
        //    {
        //        var contSpecs =
        //            from Contract in contsList
        //            group Contract by Contract.GrossHourlySalary into contSpecList
        //            select contSpecList;
        //    }
        //}




        IEnumerable<IGrouping<Specialization.fieldEnum, Contract>> getContractsBySpec(bool sorted = false)
        {
            if (sorted)
            {
                var obj = from contract in getAllContract()
                          orderby contract.StartEmployment
                          group contract by ((getAllSpecialization().First(Specialization => Specialization.SpecialtyNum ==
                          (getAllEmployee().First(Employee => Employee.Id == contract.EmployeeID).SpecializationID)).Field)) ;
                return obj;
            }
            else
            {
                var obj = from contract in getAllContract()
                          group contract by ((getAllSpecialization().First(Specialization => Specialization.SpecialtyNum ==
                          (getAllEmployee().First(Employee => Employee.Id == contract.EmployeeID).SpecializationID)).Field));
                return obj;
            }
        }

        public ICollection<Specialization> getContractsBySpecialty(bool sorted = false)
        {
            throw new NotImplementedException();
        }

        public ICollection<Contract> getContractsByAdress(bool sorted = false)
        {
            throw new NotImplementedException();
        }
    }
}
