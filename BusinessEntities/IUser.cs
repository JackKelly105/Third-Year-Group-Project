﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
   public interface IUser
    {
        string FirstName { get; set; }
        string Surname { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string UserType { get; set; }
    }
}
