using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    internal class UserStorage
    {
        private Dictionary<AuthorizeInfo, UserInfo> data;

        public UserStorage()
        {
            data= new Dictionary<AuthorizeInfo, UserInfo>();
            data.Add(new AuthorizeInfo("Зайгов", "111"), new UserInfo("Зайгов А.М.", "Zaigov@mail.ru", "Stavropol"));
            data.Add(new AuthorizeInfo("Новиков", "222"), new UserInfo("Новинок Р.А.", "Novikov@mail.ru", "Stavropol"));
            data.Add(new AuthorizeInfo("Ершов", "333"), new UserInfo("Ершов Т.И.", "Ershov@mail.ru", "Stavropol"));
        }

        public UserInfo GetUser(AuthorizeInfo ob)
        {
            if(data.ContainsKey(ob)) return data[ob];
            else return null;
        }
    }
}
