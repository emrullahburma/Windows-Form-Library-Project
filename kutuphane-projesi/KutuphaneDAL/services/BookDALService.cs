using KutuphaneDAL.interfaces;

namespace KutuphaneDAL.services
{
    public class BookDALService : BaseService, IBookDALInterface
    {
        private readonly string _conStr;
        
        public BookDALService(string conStr) : base(conStr) 
        {

        }
    }
}
