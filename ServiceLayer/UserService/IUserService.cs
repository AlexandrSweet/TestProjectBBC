using ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.UserService
{
    public interface IUserService
    {
        UserModel GetUserToken(int id);
    }
}
