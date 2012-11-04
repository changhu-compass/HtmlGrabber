using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsQuery;

namespace HtmlGrabber
{
    public class HtmlGrabber
    {
        public static string[] Grab(string url, string selector, string attributeName = null)
        {
            var dom = CQ.CreateFromUrl(url);
            var elements = dom.Select(selector);

            HashSet<string> res = new HashSet<string>();
            elements.Each((i, e) =>
            {
                var attrib = attributeName == null ? e.InnerHTML : e.GetAttribute(attributeName);
                if (!res.Contains(attrib))
                {
                    res.Add(attrib);
                }
            });

            return res.ToArray();
        }
    }
}
