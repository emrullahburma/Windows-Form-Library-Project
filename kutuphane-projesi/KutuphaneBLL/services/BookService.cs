using KutuphaneBLL.interfaces;
using KutuphaneDAL.interfaces;
using KutuphaneDAL.services;
using System;
using System.Collections.Generic;

namespace KutuphaneBLL.services
{
    public class BookService : IBook, IBookIdendification
    {
        private readonly IBookDALInterface _BookDALInterface;
        private readonly string ConnectionString = "Data Source=;Initial Catalog=;Integrated Security=True";

        public BookService()
        {
            _BookDALInterface = new BookDALService(ConnectionString);
        }

        public Dictionary<string, object> AddBook(Dictionary<string, object> model)
        {
            var rtnModel = new Dictionary<string, object>();

            try
            {
                _BookDALInterface.PostData(@"insert into kitaplar.dbo.kitaplar (kitapIsim, kitapYazar, kitapSayfaSayisi, kitapYayinEvi)
values (@KitapIsim, @KitapYazar, @KitapSayfaSayisi, @KitapYayinEvi)", model);

                rtnModel.Add("Status", true);
            }
            catch (Exception hata)
            {
                rtnModel.Add("Status", false);
            }
            return rtnModel;
        }

        public Dictionary<string, object> DeleteBook(Dictionary<string, object> model)
        {
            var rtnModel = new Dictionary<string, object>();
            try
            {
                _BookDALInterface.PostData("delete from kitaplar.dbo.kitaplar where kitapId = @KitapId", model);
                rtnModel.Add("Status", true);
            }
            catch (Exception hata)
            {
                rtnModel.Add("Status", false);
            }
            return rtnModel;
        }

        public Dictionary<string, object> UpdateBook(Dictionary<string, object> model)
        {
            var rtnModel = new Dictionary<string, object>();
            try
            {
                var result = _BookDALInterface.PostData(@"update kitaplar set kitapIsim = @KitapIsim, kitapYazar = @KitapYazar, kitapSayfaSayisi = @KitapSayfaSayisi, kitapYayinEvi = @KitapYayinEvi where kitapId = @KitapId", model);

                rtnModel.Add("Status", true);
            }
            catch (Exception hata)
            {
                rtnModel.Add("Status", false);
            }
            return rtnModel;
        }

        public List<dynamic> GetBook(Dictionary<string, object> model)
        {
            try
            {
                var result = _BookDALInterface.GetData("select kitapId as 'Kitap ID', kitapIsim as 'Kitap İsmi', kitapYazar as 'Kitap Yazarı', kitapSayfaSayisi as 'Kitap Sayfa Sayısı', KitapYayinEvi as 'Kitap Yayın Evi' from kitaplar", model);
                return result;
            }
            catch (Exception hata)
            {
                return new List<dynamic>();
            }
        }

        public List<dynamic> SearchBook(Dictionary<string, object> model)
        {
            try
            {
                var result = _BookDALInterface.GetData(@"select kitapId as 'Kitap ID', kitapIsim as 'Kitap İsmi', kitapYazar as 'Kitap Yazarı', kitapSayfaSayisi as 'Kitap Sayfa Sayısı', KitapYayinEvi as 'Kitap Yayın Evi' from kitaplar.dbo.kitaplar where kitapIsim like '%'+@SearhKey+'%' or kitapYazar like '%'+@SearhKey+'%' or 
kitapSayfaSayisi like '%'+@SearhKey+'%' or kitapYayinEvi like '%'+@SearhKey+'%'", model);
                return result;
            }
            catch (Exception hata)
            {
                return new List<dynamic>();
            }
        }

        public List<dynamic> GetBookIdendification(Dictionary<string, object> model)
        {
            try
            {
                var result = _BookDALInterface.GetData(@"select kitapAlmaId as 'Id', kitapAlanKullanici as 'Teslim Alan Kullanıcı', kitapAlmaBaslangic as 'Başlangıç Tarihi',
kitapAlmaBitis as 'Bitiş Tarihi', aldigiKitap as 'Aldığı Kitap'
from kitapAlma", model);

                return result;
            }
            catch (Exception hata)
            {
                return new List<dynamic>();
            }
        }

        public Dictionary<string, object> AddBookIdendification(Dictionary<string, object> model)
        {
            var rtnModel = new Dictionary<string, object>();
            try
            {
                var result = _BookDALInterface.GetData(@"insert into kitapAlma (kitapAlanKullanici, kitapAlmaBaslangic, kitapAlmaBitis, aldigiKitap) values (@KitapAlanKullanici, @KitapAlmaBaslangic, @KitapAlmaBitis, @AldigiKitap)", model);
                rtnModel.Add("Status", true);
            }
            catch (Exception hata)
            {
                rtnModel.Add("Status", false);
            }
            return rtnModel;
        }

        public List<dynamic> GetPastIdendification(Dictionary<string, object> model)
        {
            try
            {
                var result = _BookDALInterface.GetData(@"select kitapAlanKullanici as 'Kitap Alan Kullanıcı', kitapAlmaBaslangic as 'Başlangıç Tarihi', kitapAlmaBitis as 'Bitiş Tarihi', aldigiKitap as 'Aldığı Kitap', 
case 
	when convert(date, getdate()) = kitapAlmaBitis 
		then 'Gün İçerisinde Teslim' 
	when convert(date, getdate()) > kitapAlmaBitis 
		then 'Tarih Geçmiş' end as Durum 
from kitapAlma 
where convert(date, getdate()) = kitapAlmaBitis or convert(date, getdate()) > kitapAlmaBitis", model);

                return result;
            }
            catch (Exception hata)
            {
                return new List<dynamic>();
            }
        }

        public Dictionary<string, object> DeleteBookIdendification(Dictionary<string, object> model)
        {
            var rtnModel = new Dictionary<string, object>();
            try
            {
                var result = _BookDALInterface.PostData("delete from kitapAlma where kitapAlmaId = @Id", model);

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

        public List<dynamic> SerachBookIdendification(Dictionary<string, object> model)
        {
            try
            {
                var result = _BookDALInterface.GetData(@"select kitapAlmaId as 'Id', kitapAlanKullanici as 'Teslim Alan Kullanıcı', kitapAlmaBaslangic as 'Başlangıç Tarihi',
kitapAlmaBitis as 'Bitiş Tarihi', aldigiKitap as 'Aldığı Kitap'
from kitapAlma where kitapAlanKullanici like '%'+@SearchKey+'%'
or kitapAlmaBaslangic like '%'+@SearchKey+'%' or
kitapAlmaBitis like '%'+@SearchKey+'%' or
aldigiKitap like '%'+@SearchKey+'%'", model); 
                
                return result;
            }
            catch (Exception hata)
            {
                return new List<dynamic>();
            }
        }
    }
}
