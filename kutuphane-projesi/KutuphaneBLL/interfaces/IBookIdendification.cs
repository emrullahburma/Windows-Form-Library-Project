using System.Collections.Generic;

namespace KutuphaneBLL.interfaces
{
    public interface IBookIdendification : IBook
    {
        List<dynamic> GetBookIdendification(Dictionary<string, object> model);
        List<dynamic> GetPastIdendification(Dictionary<string, object> model);
        Dictionary<string, object> AddBookIdendification(Dictionary<string, object> model);
        Dictionary<string, object> DeleteBookIdendification(Dictionary<string, object> model);
        List <dynamic> SerachBookIdendification(Dictionary<string, object> model);
    }
}
