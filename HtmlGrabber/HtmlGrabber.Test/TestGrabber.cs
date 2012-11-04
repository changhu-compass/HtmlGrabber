using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HtmlGrabber.Test
{
    [TestClass]
    public class TestGrabber
    {
        [TestMethod]
        public void Test_GetAttributeFromUrl_ReturnStrings()
        {
            var url = "http://train.usaco.org/usacogate";
            var selector = "a";
            var attrib = "href";
            var expected = new string[]
            { 
                "/usacoregister", 
                "/usaco/theknack.mp3", 
                "http://www.usaco.org", 
                "mailto:kolstad@ace.delos.com", 
                "/privacy.html"
            };

            var actual = HtmlGrabber.Grab(url, selector, attrib);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
