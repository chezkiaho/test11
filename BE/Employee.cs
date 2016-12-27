using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Employee
    {
        public Employee(int temp = 0 , int gotid = 0)//this is temp ctor
        {
            Id = gotid;
            specializationID = temp;
        }
        private int key;
        public int Key
        {
            get { return key; }
            set { key = value; }
        }


        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private DateTime birthDate;

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        private int phone;

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private Address address;

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        private education education;

        public education Education
        {
            get { return education; }
            set { education = value; }
        }

        private bool militaryGraduate;

        public bool MilitaryGraduate
        {
            get { return militaryGraduate; }
            set { militaryGraduate = value; }
        }

        private BankAccount bankAccount;

        public BankAccount BankAccount
        {
            get { return bankAccount; }
            set { bankAccount = value; }
        }

        private int specializationID;
                
        public int SpecializationID
        {
            get { return specializationID; }
            set { specializationID = value; }
        }

        public override string ToString()
        {
            string temp = "ID : " + Id;
            temp += "\nLast Name : " + LastName;
            temp += "\nFirst Name : " + FirstName;
            temp += "\nAddress :\n " + Address;
            temp += "\nPhone : " + Phone;
            temp += "\nBirth Date : " + BirthDate;
            temp += "\nEducation : " + Education;
            temp += "\nMilitary Graduate : " + MilitaryGraduate;
            temp += "\nBank Account : " + BankAccount;
            temp += "specialization ID" + SpecializationID;   //need to improve 
            return temp;
        }
    }
}
