using CbarService.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CbarService.Core
{
   public class CbarExchangeService<T> : IExchangeService<T> where T:class
    {
       
        public async Task<T> GetExchangeDatasByDate(DateTime dateTime)
        {
            T c = default;

            //building url for cbar
            string url = new ServiceUrlBuilder()
                                .AddBaseUrl(ConfigurationManager.AppSettings["baseUrl"])
                                 .AddUrlSegment(dateTime.ToString("dd.MM.yyyy"))
                                  .AddServiceExtension("xml")
                                     .Build();

            //preparing to serialize..
            XmlSerializer _xmlSerializer = new XmlSerializer(typeof(T));
            using (var serviceData = await new HttpClient().GetStreamAsync(url))
            {
                c = (T)_xmlSerializer.Deserialize(serviceData);
            }
            return c;
          
        }
    }
}
