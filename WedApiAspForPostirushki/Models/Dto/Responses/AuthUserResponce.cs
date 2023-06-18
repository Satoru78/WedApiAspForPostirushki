using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WedApiAspForPostirushki.Models.Dto.Responses
{
    public class AuthUserResponce
    {
        public int ID { get; set; }
        public Role Role { get; set; }
    }
    public enum Role
    {
        User
    }

}