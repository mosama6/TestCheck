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

    public static double CalculateSimilarity(Bitmap bmpImage1, Bitmap bmpImage2)
    {
        int correct = 0;
        int width= bmpImage1.Width> bmpImage2.Width? bmpImage2.Width: bmpImage1.Width;
        int height = bmpImage1.Height > bmpImage2.Height ? bmpImage2.Height : bmpImage1.Height;
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Color c1 = bmpImage1.GetPixel(i, j);
                Color c2 = bmpImage2.GetPixel(i, j);
                if (c1.ToArgb() == c2.ToArgb())
                    correct++;
            }
        }
        int maxPixels = width*height;
        double SimilarityPercent = (100.0 * correct) / maxPixels;
        return SimilarityPercent;
    }
    public static void Main(string[] args)
    {
        Bitmap bitmap1 = new Bitmap(@"C:\Users\Administrator.RIGEL\Desktop\x.jpg");
        Bitmap bitmap2 = new Bitmap(@"C:\Users\Administrator.RIGEL\Desktop\y.jpg");
        var result=CalculateSimilarity(bitmap1, bitmap2);
    }
}