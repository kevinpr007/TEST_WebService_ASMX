using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserDetails
/// </summary>
public class UserDetails : System.Web.Services.Protocols.SoapHeader
{

    public string userName { get; set; }
    public string password { get; set; }

    public bool IsValid()
    {
        return this.userName == "Kevin" && this.password == "1234";
    }
}