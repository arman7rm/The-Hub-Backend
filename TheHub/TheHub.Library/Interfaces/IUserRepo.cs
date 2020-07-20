﻿using System;
using System.Collections.Generic;
using TheHub.Library.Model;

namespace TheHub.Library.Interfaces
{
    public interface IUserRepo
    {
        User GetById(int id);

        User GetByUserName(string username);

        List<User> GetFollowers(int id); 

        List<User> GetFollowing(int id); 

        void Add(User user);

        void Update(User user);

        void Delete(int id);
    }
}
