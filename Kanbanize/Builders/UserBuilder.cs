using System;
using System.Collections.Generic;
using System.Text;
using Kanbanize.DTOs;

namespace Kanbanize.Builders
{
    public class UserBuilder
    {
        private User _user;

        public UserBuilder()
        {
            _user = new User();
        }
        public UserBuilder DefaultUser()
        {
            _user = new User();
            _user.Email = "tester2001in2022@email.com";
            _user.Pass = "Password123!";

            return this;
        }
        public User Build()
        {
            return _user;
        }
    }
}
