using KutuphaneDAL.interfaces;

namespace KutuphaneDAL.services
{
    public class UserDALService : BaseService, IUserDALInterface
    {
        private readonly string _conStr;
        
        public UserDALService(string conStr) : base(conStr)
        {

        }
    }
}
