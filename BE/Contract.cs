using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Contract
    {
        public Contract(Employee emplee, Employer empler)
        {
            EmployerId = empler.CompanyId;
            EmployeeID = emplee.Id;
        }
       
        private int? contractNumber;
        public int? ContractNumber
        {
            get { return contractNumber; }
            set { contractNumber = value; }
        }

        private int employerID;
        public int EmployerId
        {
            get { return employerID; }
            set { employerID = value; }
        }

        private int employeeID;
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        private bool? wasInterview;
        public bool? WasInterview
        {
            get { return wasInterview; }
            set { wasInterview = value; }
        }

        private bool? signedContract;
        public bool? SignedContract
        {
            get { return signedContract; }
            set { signedContract = value; }
        }


        private int? grossHourlySalary;
        public int? GrossHourlySalary
        {
            get { return grossHourlySalary; }
            set { grossHourlySalary = value; }
        }

        private int? netSalaryHourly;
        public int? NetSalaryHourly
        {
            get { return netSalaryHourly; }
            set { netSalaryHourly = value; }
        }

        private DateTime? startEmployment;
        public DateTime? StartEmployment
        {
            get { return startEmployment; }
            set { startEmployment = value; }
        }

        private DateTime? endEmployment;
        public DateTime? EndEmployment
        {
            get { return endEmployment; }
            set { endEmployment = value; }
        }

        private int? contractHoursPerMonth;
        public int? ContractHoursPerMonth
        {
            get { return contractHoursPerMonth; }
            set { contractHoursPerMonth = value; }
        }


        public override string ToString()
        {
            string temp = "ContractNumber : " + ContractNumber + "\nemployer ID" + employerID + "\nemployee ID" + employeeID;             
            if (wasInterview != null)
            {
                if (wasInterview == true)
                {
                    temp += "\nwas Interview";
                }
                else
                {
                    temp += "Interview not was";
                }
            }
            if (signedContract != null)
            {
                if (signedContract == false)
                {
                   return temp += "\nThe contract not  signed";
                }
                temp += "\nThe contract signed";
                if (grossHourlySalary != null)
                {
                    temp += "\nthe Salary per Houre gross : " + GrossHourlySalary;
                }
                if (NetSalaryHourly != null)
                {
                    temp += "\n the Net Salary Hourly : " + NetSalaryHourly;
                }
                if (startEmployment != null)
                {
                    temp += "\n start Employment" + startEmployment;
                }
                if (startEmployment != null)
                {
                    temp += "\nEndEmployment" + EndEmployment;
                }
                if (contractHoursPerMonth != null)
                {
                    temp += "\nthe Hours Per Month in contract" + contractHoursPerMonth;
                }
            }
            return temp;
        }














    }
}
