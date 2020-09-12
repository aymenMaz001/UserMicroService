﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserMicroService.UseCases.Authentification
{
    public class AuthParameters
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public AuthParameters()
        {
                
        }
        public AuthParameters(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
