using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace DS
{
    class Dal_imp : DAL.Idal
    {
        private int countContract = 12340000;
        private int countSpecialization = 12340000;
        public void contractAdd(Contract tempContract)
        {
            if (tempContract.ContractNumber == null)
            {
                tempContract.ContractNumber = countContract++;
            }
            var obj = DataSource.contractList.FirstOrDefault(Contract => Contract.ContractNumber == tempContract.ContractNumber);
            if (obj != null)
            {
                throw new Exception(String.Format("the id Contract {0} alredy exsist", tempContract.ContractNumber));
            }
            else
            {
                DataSource.contractList.Add(tempContract);
            }
        }

        public void contractRemove(Contract tempContract)
        {
            if (tempContract.ContractNumber == null)
            {
                throw new Exception(String.Format("error the  id is null"));
            }
            var obj = DataSource.contractList.FirstOrDefault(Contract => Contract.ContractNumber == tempContract.ContractNumber);
            if (obj == null)
            {
                throw new Exception(String.Format("the Contract id {0} not found", tempContract.ContractNumber));
            }
            else
            {
                DataSource.contractList.Remove(tempContract);
            }
        }

        public void contractUpdate(Contract tempContract)
        {
            if (tempContract.ContractNumber == null)
            {
                throw new Exception(String.Format("error the  id is null"));
            }
            var obj = DataSource.contractList.FirstOrDefault(Contract => Contract.ContractNumber == tempContract.ContractNumber);
            if (obj == null)
            {
                throw new Exception(String.Format("the Contract id {0}  not found", tempContract.ContractNumber));
            }
            else
            {
                obj = tempContract;
            }
        }

        public void employeeAdd(Employee tempEmployee)
        {
            
            var obj = DataSource.employeeList.FirstOrDefault(Employee => Employee.Id == tempEmployee.Id);
            if (obj != null)
            {
                throw new Exception(String.Format("the employee id {0}  alredy exsist", tempEmployee.Id));
            }
            else
            {
                DataSource.employeeList.Add(tempEmployee);
            }
        }

        public void employeeRemove(Employee tempEmployee)
        {
            var obj = DataSource.employeeList.FirstOrDefault(Employee => Employee.Id == tempEmployee.Id);
            if (obj == null)
            {
                throw new Exception(String.Format("the employee id {0} not found", tempEmployee.Id));
            }
            else
            {
                DataSource.employeeList.Remove(tempEmployee);
            }
        }

        public void employeeUpdate(Employee tempEmployee)
        {
            var obj = DataSource.employeeList.FirstOrDefault(Employee => Employee.Id == tempEmployee.Id);
            if (obj == null)
            {
                throw new Exception(String.Format("the employee id {0} not found", tempEmployee.Id));
            }
            else
            {
                obj = tempEmployee;
            }
        }

        public void employerAdd(Employer tempEmployer)
        {
            var obj = DataSource.employerList.FirstOrDefault(Employer => Employer.CompanyId == tempEmployer.CompanyId);
            if (obj != null)
            {
                throw new Exception(String.Format("the employer id {0}  alredy exsist", tempEmployer.CompanyId));
            }
            else
            {
                DataSource.employerList.Add(tempEmployer);
            }
        }

        public void employerRemove(Employer tempEmployer)
        {
            var obj = DataSource.employerList.FirstOrDefault(Employer => Employer.CompanyId == tempEmployer.CompanyId);
            if (obj == null)
            {
                throw new Exception(String.Format("the employer id {0}  not found", tempEmployer.CompanyId));
            }
            else
            {
                DataSource.employerList.Remove(tempEmployer);
            }
        }

        public void employerUpdate(Employer tempEmployer)
        {
            var obj = DataSource.employerList.FirstOrDefault(Employer => Employer.CompanyId == tempEmployer.CompanyId);
            if (obj == null)
            {
                throw new Exception(String.Format("the employer id {0}  not found", tempEmployer.CompanyId));
            }
            else
            {
                obj = tempEmployer;
            }
        }

        public ICollection<Contract> getAllContract()
        {
            return DataSource.contractList;
        }

        public ICollection<Employee> getAllEmployee()
        {
            return DataSource.employeeList;
        }

        public ICollection<Employer> getAllEmployer()
        {
            return DataSource.employerList;
        }

        public ICollection<Specialization> getAllSpecialization()
        {
            return DataSource.specializationList;
        }

        public void specializationAdd(Specialization tempSpecialization)
        {
            if (tempSpecialization.SpecialtyNum == null )
            {
                tempSpecialization.SpecialtyNum = countContract++;
            }
            var obj = DataSource.specializationList.FirstOrDefault(Specialization => Specialization.SpecialtyNum == tempSpecialization.SpecialtyNum);
            if (obj != null)
            {
                throw new Exception(String.Format("the specialization number {0}  alredy exsist", tempSpecialization.SpecialtyNum));
            }
            else
            {
                DataSource.specializationList.Add(tempSpecialization);
            }

        }

        public void specializationRemove(Specialization tempSpecialization)
        {
            if (tempSpecialization.SpecialtyNum == null)
            {
                throw new Exception(String.Format("error the  id is null"));
            }
            var obj = DataSource.specializationList.FirstOrDefault(Specialization => Specialization.SpecialtyNum == tempSpecialization.SpecialtyNum);
            if (obj == null)
            {
                throw new Exception(String.Format("the specialization number {0} not found", tempSpecialization.SpecialtyNum));
            }
            else
            {
                DataSource.specializationList.Remove(tempSpecialization);
            }
           
        }

        public void specializationUpdate(Specialization tempSpecialization)
        {
            if (tempSpecialization.SpecialtyNum == null)
            {
                throw new Exception(String.Format("error the  id is null"));
            }
            var obj = DataSource.specializationList.FirstOrDefault(Specialization => Specialization.SpecialtyNum == tempSpecialization.SpecialtyNum);
            if (obj == null)
            {
                throw new Exception(String.Format("the specialization number {0} not found", tempSpecialization.SpecialtyNum));
            }
            else
            {
                obj = tempSpecialization;
            }
        }
    }
}
