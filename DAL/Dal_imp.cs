using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    public class Dal_imp : DAL.Idal
    {
        private static int countContractKey = 12340000;
        private static int countSpecializationKey = 12340000;
        private static int countEmployeeKey = 12340000;
        private static int countEmployerKey = 12340000;
        public void contractAdd(Contract tempContract)
        {
            if (tempContract.ContractNumber == null || tempContract.ContractNumber == 0)
            {
                tempContract.ContractNumber = countContractKey++;
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
            if (tempEmployee.Key == 0 )
            {
                dynamic temp;
                do
                {
                    temp = DataSource.employeeList.FirstOrDefault(Employee => Employee.Key == ++countEmployeeKey);
                } while (temp != null);
                tempEmployee.Key = countEmployeeKey ;
            }
            else
            {
                var obj = DataSource.employeeList.FirstOrDefault(Employee => Employee.Key == tempEmployee.Key);
                if (obj != null)
                {
                    throw new Exception(String.Format("the employee key {0}  alredy exsist", tempEmployee.Key));
                }
            }
            DataSource.employeeList.Add(tempEmployee);
        }

        public void employeeRemove(Employee tempEmployee)
        {
            var obj = DataSource.employeeList.FirstOrDefault(Employee => Employee.Key == tempEmployee.Key);
            if (obj == null)
            {
                throw new Exception(String.Format("the employee key {0} not found", tempEmployee.Key));
            }
            else
            {
                DataSource.employeeList.Remove(tempEmployee);
            }
        }

        public void employeeUpdate(Employee tempEmployee)
        {
            var obj = DataSource.employeeList.FirstOrDefault(Employee => Employee.Key == tempEmployee.Key);
            if (obj == null)
            {
                throw new Exception(String.Format("the employee key {0} not found", tempEmployee.Key));
            }
            else
            {
                obj = tempEmployee;
            }
        }

        public void employerAdd(Employer tempEmployer)
        {
            if (tempEmployer.Key == 0 || tempEmployer.Key == null)
            {
                dynamic temp;
                do
                {
                    temp = DataSource.employerList.FirstOrDefault(Employer => Employer.Key == countEmployerKey++);
                } while (temp != null && temp != 0);
                tempEmployer.Key = countEmployerKey - 1;
            }
            else
            {
                var obj = DataSource.employerList.FirstOrDefault(Employer => Employer.Key == tempEmployer.Key);
                if (obj != null)
                {
                    throw new Exception(String.Format("the employer key {0}  alredy exsist", tempEmployer.Key));
                }
            }
            DataSource.employerList.Add(tempEmployer);
        }

        public void employerRemove(Employer tempEmployer)
        {
            var obj = DataSource.employerList.FirstOrDefault(Employer => Employer.Key == tempEmployer.Key);
            if (obj == null)
            {
                throw new Exception(String.Format("the employer key {0}  not found", tempEmployer.Key));
            }
            else
            {
                DataSource.employerList.Remove(tempEmployer);
            }
        }

        public void employerUpdate(Employer tempEmployer)
        {
            var obj = DataSource.employerList.FirstOrDefault(Employer => Employer.Key == tempEmployer.Key);
            if (obj == null)
            {
                throw new Exception(String.Format("the employer key {0}  not found", tempEmployer.Key));
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
            if (tempSpecialization.SpecialtyNum == null)
            {
                tempSpecialization.SpecialtyNum = countContractKey++;
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
