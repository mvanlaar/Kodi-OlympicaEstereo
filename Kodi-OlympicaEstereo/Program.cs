using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi_OlympicaEstereo
{
    class Program
    {

        public static List<OlympicaUrls> _OlympicaUrls = new List<OlympicaUrls>
    {
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=7&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Armenia"},
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=6&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Barranquilla"},
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=8&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Bogotá"},
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=9&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Bucaramanga"},
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=10&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Cali"},
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=11&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Cartagena"},
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=12&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Cucuta"},
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=13&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Ibagué"},
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=14&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Manizales"},
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=15&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Medellin"},
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=16&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Monteria"},
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=17&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Neiva"},
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=18&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Pereira"},
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=19&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Santa Marta"},
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=20&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Sincelejo"},
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=21&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Valledupar"},
        new OlympicaUrls {Url = "http://olimpicastereo.com.co/wp-pics/themes/olimpica/changeCity.php?city=22&amp;url_to_go=http%3A%2F%2Folimpicastereo.com.co%2F", City = "Villavicencio"}
    };
        static void Main(string[] args)
        {
            // Loop through list
            // Add to SRTM file
        }
    
    }

    public class OlympicaUrls
    {
        // Auto-implemented properties.        
        public string Url { get; set; }
        public string City { get; set; }
    }

   
}
