using Example_04.Homework.Clients;
using Example_04.Homework.Models;
using Example_04.Homework.SecondOrmLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter_Homework.SecondOrmLibrary
{
    class SecondOrmAdapter: IOrmAdapter
    {
        private readonly ISecondOrm _secondOrm;

        public SecondOrmAdapter(ISecondOrm secondOrm)
        {
            _secondOrm = secondOrm;
        }

        public void Add(DbUserEntity user, DbUserInfoEntity userInfo)
        {
            _secondOrm.Context.Users.Add(user);
            _secondOrm.Context.UserInfos.Add(userInfo);
        }

        public (DbUserEntity, DbUserInfoEntity) Get(int id)
        {
            var user = _secondOrm.Context.Users.First(u => u.Id == id);
            var userInfo = _secondOrm.Context.UserInfos.First(ui => ui.Id == id);
            return (user, userInfo);
        }

        public void Remove(int id)
        {
            _secondOrm.Context.Users.RemoveWhere(u => u.Id == id);
            _secondOrm.Context.UserInfos.RemoveWhere(ui => ui.Id == id);
        }
    }
}
