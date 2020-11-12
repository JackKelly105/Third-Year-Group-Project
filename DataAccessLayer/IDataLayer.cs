﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDataLayer
    {
        void addNewUserToDB(BusinessEntities.IUser theUser);
        void closeConnection();
        System.Collections.ArrayList GetAllUsers();
        System.Data.SqlClient.SqlConnection getConnection();
        void openConnection();
        bool deleteUserFromDB(BusinessEntities.IUser user);


    }
}
