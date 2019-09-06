using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CbarService.Core
{
   public class ServiceUrlBuilder
    {
        private StringBuilder _url;
        public ServiceUrlBuilder()
        {
            _url = new StringBuilder();
        }
        public ServiceUrlBuilder AddBaseUrl(string baseUrl)
        {
            _url.Append(baseUrl);
            return this;
        }

        public ServiceUrlBuilder AddUrlSegment(string formatted)
        {
           string path = Path.Combine(_url.ToString(), formatted);
            _url.Clear();
            _url.Append(path);
            return this;
        }

        public ServiceUrlBuilder AddServiceExtension(string extension)
        {
            _url.Append($".{extension}");
            return this;
        }
        public string Build()
        {
            return _url.ToString();
        }
    }
}
