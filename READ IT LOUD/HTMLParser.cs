using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace READ_IT_LOUD
{
    class HTMLParser
    {
        public string HTMLParserFucnion(string url)
        {
            string _url = url;
            if (!(_url.StartsWith("http://")))
            {
                _url = "http://" + _url;
            }
            WebClient wc = new WebClient();
            byte[] data = wc.DownloadData(_url);
            string htmlbody = Encoding.ASCII.GetString(data);

            return htmlbody;
         }
    }
}
