﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLayer
{
    public interface IModel
    {

        bool addNewUser(string FirstName, string Surname, string Username, string Password, string userType);

        bool addNewGuest(string FirstName, string Surname, string ContactNumber, string Address, string Email, bool SendMarketingInfo);

        bool addNewReservation(DateTime CheckInDate, DateTime CheckOutDate, int Adults, int Children, double ReservationPrice, bool PayedDeposit, bool PayedInFull, int GuestID, int RoomNumber);

        BusinessEntities.User CurrentUser { get; set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
        string getUserTypeForCurrentuser();
        bool login(string username, string password);

        bool deleteUser(IUser user);

        void tearDown();
        System.Collections.ArrayList UserList { get; }
        bool PasswordCheck(string password);

        List<IRoom> RoomsList { get; set; }
        void GetAllRooms();

        List<IGuest> GuestsList { get; set; }
        void GetAllGuests();

        List<IReservation> ReservationsList { get; set; }

        void GetAllReservations();

    }
}
