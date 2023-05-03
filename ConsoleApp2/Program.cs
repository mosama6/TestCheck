using IdentityModel.Client;
using MailKit.Net.Smtp;
using MailKit.Security;
using System;
using System.ComponentModel;
using System.DirectoryServices;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

public class OAuth2AuthenticationInfo
{
    public string TokenEndpoint { get; set; }
    public string ClientID { get; set; }
    public string ClientSecret { get; set; }
    public string Scope { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public OAuth2AuthenticationInfo() 
    {
    }
}
public class MergeNames
{

   
    public static void Main()
    {
       
        Console.WriteLine("Osama");
    }
}