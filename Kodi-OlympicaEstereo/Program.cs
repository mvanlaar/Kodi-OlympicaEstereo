using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Kodi_OlympicaEstereo
{
    class Program
    {

        
        static void Main(string[] args)
        {
            List<OlympicaUrls> _OlympicaUrls = new List<OlympicaUrls>
            {
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=7", City = "Armenia"},
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=6", City = "Barranquilla"},
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=8", City = "Bogotá"},
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=9", City = "Bucaramanga"},
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=10", City = "Cali"},
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=11", City = "Cartagena"},
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=12", City = "Cucuta"},
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=13", City = "Ibagué"},
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=14", City = "Manizales"},
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=15", City = "Medellin"},
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=16", City = "Monteria"},
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=17", City = "Neiva"},
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=18", City = "Pereira"},
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=19", City = "Santa Marta"},
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=20", City = "Sincelejo"},
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=21", City = "Valledupar"},
                new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=22", City = "Villavicencio"}
            };


            // Loop through list
            foreach (OlympicaUrls OlympicaUrls in _OlympicaUrls)
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "data\\ac-timetable-en.pdf";
                Uri url = new Uri(OlympicaUrls.Url);
                const string ua = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)";
                const string referer = "http://olimpicastereo.com.co/";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                System.Net.WebRequest.DefaultWebProxy = null;                
                request.UserAgent = ua;
                request.Referer = referer;
                request.CookieContainer = new CookieContainer();
                System.Net.WebRequest.DefaultWebProxy = null;
                request.Proxy = System.Net.WebRequest.DefaultWebProxy;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    //StreamReader readStream = null;

                    //if (response.CharacterSet == null)
                    //{
                    //    readStream = new StreamReader(receiveStream);
                    //}
                    //else
                    //{
                    //    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    //}
                    string data = null;

                    using (BufferedStream buffer = new BufferedStream(receiveStream))
                    {
                        using (StreamReader reader = new StreamReader(buffer))
                        {
                            data = reader.ReadToEnd();
                        }
                    }

                   

                    response.Close();
                    //readStream.Close();

                    int first = data.IndexOf("var response_station = '") + "var response_station = '".Length;
                    int last = data.LastIndexOf("?type=.flv';");
                    string streamurl = data.Substring(first, last - first);
                    Console.WriteLine("Streamurl: {0} - City: {1}", streamurl, OlympicaUrls.City);
                    

                }
                 // Add to SRTM file
                
            }
               Console.ReadLine();
        }
    
    }

    public class OlympicaUrls
    {
        // Auto-implemented properties.        
        public string Url { get; set; }
        public string City { get; set; }
    }

   
}
