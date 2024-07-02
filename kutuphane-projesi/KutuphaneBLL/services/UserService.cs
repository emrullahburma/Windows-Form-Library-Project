using KutuphaneBLL.interfaces;
using KutuphaneDAL.interfaces;
using KutuphaneDAL.services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KutuphaneBLL.services
{
    public class UserService : IUser
    {

        private readonly IUserDALInterface _userDALInterface;
        private readonly string ConnectionString = "Data Source=;Initial Catalog=;Integrated Security=True";

        public UserService()
        {
            _userDALInterface = new UserDALService(ConnectionString);
        }

        public Dictionary<string, object> SaveUser(Dictionary<string, object> model)
        {
            var rtnModel = new Dictionary<string, object>();
            try
            {
                var result = _userDALInterface.PostData(@"insert into kullanicilar (kullaniciAd, kullaniciSoyad, kullaniciTel, kullaniciEposta, kullaniciAdres) values 
(@UserName, @UserSurname, @PhoneNumber, @UserMail, @UserAddress)", model);

                if (result > 0)
                    rtnModel.Add("Status", true);
                else
                    rtnModel.Add("Status", false);
            }
            catch (Exception hata)
            {
                rtnModel.Add("Status", false);
            }
            return rtnModel;
        }

        public List<dynamic> GetUsers(Dictionary<string, object> model)
        {
            try
            {
                var result = _userDALInterface.GetData(@"select kullaniciId as 'Kullanıcı Id', kullaniciAd as 'Kullanıcı Ad', kullaniciSoyad as 'Kullanıcı Soyad', kullaniciTel as 'Kullanıcı Tel No', kullaniciEposta as 'Kullanıcı E-posta', kullaniciAdres as 'Kullanıcı Adres' from kullanicilar", model);

                if (result.Count() > 0)
                    return result;
            }
            catch (Exception hata)
            {
                return new List<dynamic>();
            }
            return new List<dynamic>();
        }

        public Dictionary<string, object> DeleteUser(Dictionary<string, object> model)
        {
            var rtnModel = new Dictionary<string, object>();
            try
            {
                var result = _userDALInterface.PostData("delete from kullanicilar where kullaniciId = @KullaniciId", model);

                if (result > 0)
                    rtnModel.Add("Status", true);
                else
                    rtnModel.Add("Status", false);
            }
            catch (Exception hata)
            {
                rtnModel.Add("Status", false);
            }
            return rtnModel;
        }

        public Dictionary<string, object> UpdateUser(Dictionary<string, object> model)
        {
            var rtnModel = new Dictionary<string, object>();
            try
            {
                var result = _userDALInterface.PostData(@"update kullanicilar set kullaniciAd = @KullaniciAd, kullaniciSoyad = @KullaniciSoyad, kullaniciTel = @KullaniciTel, kullaniciEposta = @KullaniciEposta, kullaniciAdres = @KullaniciAdres where kullaniciId = @KullaniciId", model);

                if (result > 0)
                    rtnModel.Add("Status", true);
                else
                    rtnModel.Add("Status", false);
            }
            catch (Exception hata)
            {
                rtnModel.Add("Status", false);
            }
            return rtnModel;
        }

        public List<dynamic> SearchUser(Dictionary<string, object> model)
        {
            try
            {
                var result = _userDALInterface.GetData(@"select kullaniciId as 'Kullanıcı Id', kullaniciAd as 'Kullanıcı Ad', kullaniciSoyad as 'Kullanıcı Soyad', kullaniciTel as 'Kullanıcı Tel No',
kullaniciEposta as 'Kullanıcı E-posta', kullaniciAdres as 'Kullanıcı Adres' from kullanicilar
where kullaniciAd like '%'+@SearchKey+'%' or kullaniciSoyad like '%'+@Searchkey+'%'
or kullaniciTel like '%'+@SearchKey+'%' or kullaniciEposta like '%'+@SearchKey+'%' or
kullaniciAdres like '%'+@SearchKey+'%'", model);

                return result;
            }
            catch (Exception hata)
            {
                return new List<dynamic>();
            }

        }
    }
}
