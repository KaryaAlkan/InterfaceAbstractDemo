﻿using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
     public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
