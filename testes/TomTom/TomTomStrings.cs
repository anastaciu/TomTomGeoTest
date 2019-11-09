
namespace TomTom
{
    public static class TomTomStrings
    {
        private const string baseURL = "https://api.tomtom.com";
        private const string service = "search";
        private const string version = "2";
        private const string serviceType = "geocode";      
        private const string fslash = "/";
        private const string format = ".json";
        private const string keyheader = "?key=";    
        private const string key = "***";      

        //Coimbra - raio 100 Km
        private const string latitude = "&lat=40.2287547";
        private const string longitude = "&lon=-8.4512937";
        private const string radius = "&radius=100000";


        public static string BaseURL => baseURL;
        public static string Service => service;
        public static string Version => version;
        public static string ServiceType => serviceType;
        public static string Fslash => fslash;
        public static string Format => format;
        public static string Keyheader => keyheader;
        public static string Key => key;
        public static string Latitude  => latitude;
        public static string Longitude => longitude;
        public static string Radius => radius;

    } 
}
