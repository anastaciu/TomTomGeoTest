using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace TomTom
{
    public class TomTomAPIMain
    {
        public string GetResults(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }

        public dynamic ReturnJsonObject(string address)
        {
            string fullUriString = TomTomStrings.BaseURL + TomTomStrings.Fslash +
                TomTomStrings.Service + TomTomStrings.Fslash + TomTomStrings.Version + TomTomStrings.Fslash +
                TomTomStrings.ServiceType + TomTomStrings.Fslash + address + TomTomStrings.Format + TomTomStrings.Keyheader +
                TomTomStrings.Key + TomTomStrings.Latitude + TomTomStrings.Longitude + TomTomStrings.Radius;
            string uriResults = GetResults(fullUriString);
            dynamic results = JsonConvert.DeserializeObject<dynamic>(uriResults);
            return results;
        }

    }
}
