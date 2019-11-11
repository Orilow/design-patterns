using Example_04.Homework.Models;

namespace Example_04.Homework.Clients
{
    public class UserClient 
    {
        private IOrmAdapter _ormAdapter;

        public UserClient(IOrmAdapter ormAdapter)
        {
            _ormAdapter = ormAdapter;
        }

        public (DbUserEntity, DbUserInfoEntity) Get(int userId) => _ormAdapter.Get(userId);
        // you should return DbUserEntity via _ormAdapter

        public void Add(DbUserEntity user, DbUserInfoEntity userInfo) => _ormAdapter.Add(user, userInfo);
        // you should create DbUserEntity and DbUserInfoEntity via _ormAdapter

        public void Remove(int userId) => _ormAdapter.Remove(userId);
        // you should remove DbUserEntity and DbUserInfoEntity via _ormAdapter

    }
}
