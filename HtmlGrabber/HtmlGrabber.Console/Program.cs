using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGrabber.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://github.com/jamietre/CsQuery#accessing-dom-elements-directly";
            var selector = "a";
            var attributeName = "href";
            var owners = HtmlGrabber.Grab(url, selector);
                //.Select(str => str.Substring(9, str.IndexOf('?'))).ToArray();
            System.Console.WriteLine(string.Join("\n", owners));
        }
    }
}
