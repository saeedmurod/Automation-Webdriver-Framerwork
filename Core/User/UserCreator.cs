using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.User
{
    public class UserCreator
    {
        public static readonly string firstUserName = "saidmurodtestepam@gmail.com";
        public static readonly string firstUserPassword = "x@iysu27";
        public static readonly string secondUserName = "saidmurodmuhitdinov@gmail.com";
        public static readonly string secondPassword = "Xzs@iu77";


        public static User FirstUserCredentials()
        {
            return new User(firstUserName, firstUserPassword);
        }


        public static User SecondUserCredentials() 
        {
            return new User(secondUserName, secondPassword);
        }
    }
}
