using System.Collections.Generic;

namespace KutuphaneBLL.interfaces
{
    public interface IBook
    {
        Dictionary<string, object> AddBook(Dictionary<string, object> model);
        Dictionary<string, object> DeleteBook(Dictionary<string, object> model);
        Dictionary<string, object> UpdateBook(Dictionary<string, object> model);
        List<dynamic> GetBook(Dictionary<string, object> model);
        
        ///
        List<dynamic> SearchBook(Dictionary<string, object> model);
    }
}
