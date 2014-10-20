using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace DLfileFromInternet
{
    class DLfileFromInternet
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    string path = Environment.ExpandEnvironmentVariables(@"C:\Users\Desktop\logo-basd.jpg");
                    client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", path);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("You entered an empty address.");
                }
                catch (WebException)
                {
                    Console.Error.WriteLine("The address is invalid.");
                }
                catch (NotSupportedException we)
                {
                    Console.Error.WriteLine(we.Message);
                }
                catch (InvalidOperationException)
                {
                    Console.Error.WriteLine("File already is downloaded once");
                }
            } 

        }
    }
}
