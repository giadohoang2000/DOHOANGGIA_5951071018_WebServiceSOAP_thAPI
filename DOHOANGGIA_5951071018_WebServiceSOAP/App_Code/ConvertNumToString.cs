using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for ConvertNumToString
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ConvertNumToString : System.Web.Services.WebService
{

    public ConvertNumToString()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
    [WebMethod]
    public string NumtoString(int Number)
    {
        //Mang 1
        string[] Ones = {"Mot", "Hai", "Ba", "Bon", "Nam", "Sau", "Bay", "Tam",
        "Chin", "Muoi", "Muoi Mot", "Muoi Hai", "Muoi ba", "Muoi bon", "Muoi lam", 
        "Muoi sau", "Muoi bay", "Muoi tam", "Muoi chin"};
        //Mang 2
        string[] Tens = {"Muoi", "Hai muoi", "Ba muoi", "Bon muoi", "Nam muoi",
        "Sau muoi", "Bay muoi", "Tam muoi", "Chin muoi"};

        string strWords = "";

        if (Number > 999 && Number < 10000)
        {
            int i = Number / 1000;
            strWords = strWords + Ones[i - 1] + " Ngan";
            Number = Number % 10000;
        }

        if (Number > 99 && Number < 1000)
        {
            int i = Number / 100;
            strWords = strWords + Ones[i - 1] + " Tram";
            Number = Number % 100;
        }

        if (Number > 19 && Number < 100)
        {
            int i = Number / 10;
            strWords = strWords + Tens[i - 1] + " ";
            Number = Number % 10;
        }

        if (Number >0 && Number < 20)
        {
            strWords = strWords + Ones[Number - 1] ;
        }
        strWords = Convert.ToString(strWords);
        return strWords;
    }
}
