using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Header
    {
        private string mime;
        private string charset;
        private string encoding;
        private string langage;
        private string methods;
        private string authorizations;
        private string cookie;
        private string from;
        private string host;

        public Header(HttpListenerRequest request)
        {
            mime = request.Headers.Get(HttpRequestHeader.Accept.ToString());
            charset = request.Headers.Get(HttpRequestHeader.AcceptCharset.ToString());
            encoding = request.Headers.Get(HttpRequestHeader.AcceptEncoding.ToString());
            langage = request.Headers.Get(HttpRequestHeader.AcceptLanguage.ToString());
            methods = request.Headers.Get(HttpRequestHeader.Allow.ToString());
            authorizations = request.Headers.Get(HttpRequestHeader.Authorization.ToString());
            cookie = request.Headers.Get(HttpRequestHeader.Cookie.ToString());
            from = request.Headers.Get(HttpRequestHeader.From.ToString());
            host = request.Headers.Get(HttpRequestHeader.Host.ToString());
        }


        public void display()
        {
            Console.WriteLine($"MIME : {mime}");
            Console.WriteLine($"Charset: {charset}");
            Console.WriteLine($"Encoding: {encoding}");
            Console.WriteLine($"Langage: {langage}");
            Console.WriteLine($"Methods: {methods}");
            Console.WriteLine($"Authorizations: {authorizations}");
            Console.WriteLine($"Cookie: {cookie}");
            Console.WriteLine($"From: {from}");
            Console.WriteLine($"Host: {host}");
        }

    }
}
