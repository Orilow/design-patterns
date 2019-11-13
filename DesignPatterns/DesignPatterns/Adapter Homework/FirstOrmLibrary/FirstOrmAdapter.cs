using Example_04.Homework.Clients;
using Example_04.Homework.FirstOrmLibrary;
using Example_04.Homework.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter_Homework.FirstOrmLibrary
{
    class FirstOrmAdapter : IOrmAdapter
    {
        private readonly IFirstOrm<DbUserEntity> _firstOrm1;
        private readonly IFirstOrm<DbUserInfoEntity> _firstOrm2;

        public FirstOrmAdapter(IFirstOrm<DbUserEntity> firstOrm1, IFirstOrm<DbUserInfoEntity> firstOrm2)
        {
            _firstOrm1 = firstOrm1;
            _firstOrm2 = firstOrm2;
        }

        public void Add(DbUserEntity user, DbUserInfoEntity userInfo)
        {
            _firstOrm1.Add(user);
            _firstOrm2.Add(userInfo);
        }

        public (DbUserEntity, DbUserInfoEntity) Get(int id)
        {
            var user = _firstOrm1.Read(id);
            var userInfo = _firstOrm2.Read(id);
            return (user, userInfo);
        }

        public void Remove(int id)
        {
            var user = _firstOrm1.Read(id);
            var userInfo = _firstOrm2.Read(id);

            _firstOrm1.Delete(user);
            _firstOrm2.Delete(userInfo);
        }
    }
}
