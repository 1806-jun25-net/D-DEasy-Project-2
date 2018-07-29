﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DandDEasy.Services.Repo
{
    public class UserRepo
    {
        private readonly DnDEasyContext _db;

        public UserRepo(DnDEasyContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        //public IEnumerable<string> GetUsertable()
        //{
        //    List<User> user = _db.User.ToList();
        //    var TheUser = user.FirstOrDefault(x => x.FirstName == "Wesley");
        //    return new string[] { $"Name: {TheUser.FirstName}" + $" Last Name: {TheUser.LastName}" + $" Username: {TheUser.Username}"
        //    + $" Registration Date: {TheUser.RegistrationDate}"};
        //}

        public IEnumerable<User> GetUsertable()
        {
            List<User> user = _db.User.ToList();
            return user;

        }
    }
}
