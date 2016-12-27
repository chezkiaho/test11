using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    interface IBL
    {
        void specializationAdd(Specialization tempSpecialization);
        void specializationRemove(Specialization tempSpecialization);
        void specializationUpdate(Specialization tempSpecialization);

        void employeeAdd(Employee tempEmployee);
        void employeeRemove(Employee tempEmployee);
        void employeeUpdate(Employee tempEmployee);

        void employerAdd(Employer tempEmployer);
        void employerRemove(Employer tempEmployer);
        void employerUpdate(Employer tempEmployer);

        void contractAdd(Contract tempContract);
        void contractRemove(Contract tempContract);
        void contractUpdate(Contract tempContract);

        //ICollection<Specialization> getAllSpecialization();
        //ICollection<Employee> getAllEmployee();
        //ICollection<Employer> getAllEmployer();
        //ICollection<Contract> getAllContract();

        ICollection<Specialization> getContractsBySpecialty(bool sorted = false);
        ICollection<Contract> getContractsByAdress(bool sorted = false);
    }
}
