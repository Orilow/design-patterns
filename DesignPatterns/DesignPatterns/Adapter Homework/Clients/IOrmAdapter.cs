﻿using Example_04.Homework.Models;

namespace Example_04.Homework.Clients
{
    public interface IOrmAdapter // ITarget
    {
        (DbUserEntity, DbUserInfoEntity) Get(int id);
        void Add(DbUserEntity user, DbUserInfoEntity userInfo);
        void Remove(int id);
    }
}
