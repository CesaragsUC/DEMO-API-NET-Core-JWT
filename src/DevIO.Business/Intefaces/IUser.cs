using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace DevIO.Business.Intefaces
{
    public interface IUser
    {
        string Name { get;  }
        Guid GetUserId(); 
        string Email { get;}
        bool IsAuthenticated();
        string GetUserEmail();
        bool IsInRole(string role);

        IEnumerable<Claim> GetClaimsIdentity();

    }
}
