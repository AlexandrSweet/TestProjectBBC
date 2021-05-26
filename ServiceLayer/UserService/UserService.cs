using ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer.UserService
{
    public class UserService : IUserService
    {
        private Dictionary<int, UserModel> _usersDictionary { get; set; }
        public UserService()
        {
            _usersDictionary = new Dictionary<int, UserModel> // вместо базы захаркодим словарик
            {
                {1, new UserModel {Role = Role.Guest, Token = Guid.NewGuid().ToString()} },
                {2, new UserModel {Role = Role.Admin, Token = Guid.NewGuid().ToString()} },
            };
        }
        public UserModel GetUserToken(int id)
        {
            var result = _usersDictionary.FirstOrDefault(u => u.Key == id);
            if (result.Value != null)
            {
                return new UserModel
                {
                    Role = result.Value.Role,
                    Token = result.Value.Token
                };
            }
            return null;   // не придумал что вернуть 
        }
    }
}
