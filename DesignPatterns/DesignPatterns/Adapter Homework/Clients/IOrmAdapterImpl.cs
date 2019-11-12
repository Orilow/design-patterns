using Example_04.Homework.Clients;
using Example_04.Homework.FirstOrmLibrary;
using Example_04.Homework.Models;
using Example_04.Homework.SecondOrmLibrary;
using System.Linq;

namespace DesignPatterns.Adapter_Homework.Clients
{
    class IOrmAdapterImpl: IOrmAdapter
    {
        private IFirstOrm<DbUserEntity> _firstOrm1;
        private IFirstOrm<DbUserInfoEntity> _firstOrm2;

        private ISecondOrm _secondOrm;

        private bool _useFirstOrm = true;

        public IOrmAdapterImpl()
        {
        }

        public void Add(DbUserEntity user, DbUserInfoEntity userInfo)
        {
            if (_useFirstOrm)
            {
                _firstOrm1.Add(user);
                _firstOrm2.Add(userInfo);
            }
            else
            {
                _secondOrm.Context.Users.Add(user);
                _secondOrm.Context.UserInfos.Add(userInfo);
            }
        }

        public (DbUserEntity, DbUserInfoEntity) Get(int id)
        {
            if (_useFirstOrm)
            {
                var user = _firstOrm1.Read(id);
                var userInfo = _firstOrm2.Read(user.InfoId);
                return (user, userInfo);
            }
            else
            {
                var user = _secondOrm.Context.Users.First(i => i.Id == id);
                var userInfo = _secondOrm.Context.UserInfos.First(i => i.Id == user.InfoId);
                return (user, userInfo);
            }
        }

        public void Remove(int id)
        {
            if (_useFirstOrm)
            {
                var user = _firstOrm1.Read(id);
                var userInfo = _firstOrm2.Read(user.InfoId);

                _firstOrm2.Delete(userInfo);
                _firstOrm1.Delete(user);
            }
            else
            {
                var user = _secondOrm.Context.Users.First(i => i.Id == id);
                var userInfo = _secondOrm.Context.UserInfos.First(i => i.Id == user.InfoId);

                _secondOrm.Context.UserInfos.Remove(userInfo);
                _secondOrm.Context.Users.Remove(user);
            }
        }
    }
}
