using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManagerStarbucks = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManagerStarbucks.Save(new Customer
            {
                //mernis sistemin calışabimesi için dogru veriler girilmelidir
                DateOfBirth = new DateTime(2000),
                FirstName = "Karya",
                LastName = "Alkan",
                NationalityId = "627294829492"
            });

            BaseCustomerManager customerManagerNero = new NeroCustomerManager();
            customerManagerNero.Save(new Customer
            {
                DateOfBirth = new DateTime(1995, 8, 4),
                FirstName = "Karya",
                LastName = "Alkan",
                NationalityId = "12345678901"
            });
            Console.ReadLine();
        }

       
    }
}
