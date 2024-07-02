using System.Collections.Generic;

namespace KutuphaneBLL.interfaces
{
    public interface IUser
    {
        Dictionary<string, object> SaveUser(Dictionary<string, object> model);
        List<dynamic> GetUsers(Dictionary<string, object> model);
        Dictionary<string, object> DeleteUser(Dictionary<string, object> model);
        Dictionary<string, object> UpdateUser(Dictionary<string, object> model);
        
        //
        List<dynamic> SearchUser(Dictionary<string, object> model);
    }
}
