using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSRS.Helpers
{
    public static class MyHelper
    {
        public static HtmlString CreateList(this IHtmlHelper html, string[] items)
        {
            string result = "<ul>";
            foreach (string item in items)
            {
                result = $"{result}<li><a href=\"/{item}\">{item}</a></li>";
            }
            result = $"{result}</ul>";
            return new HtmlString(result);
        }

        public static HtmlString CreateH1(this IHtmlHelper html, string text, string style)
        {
            string result = $"<h1 style=\"{style}\">{text}<h1>";
            return new HtmlString(result);
        }

        public static HtmlString CreateAnchor(this IHtmlHelper html, string text,string clas,string link) 
        {
            string result = $"<a class=\"{clas}\" href=\"{link}\">{text}</a>";
            return new HtmlString(result);
        }

        public static HtmlString CreateLink(this IHtmlHelper html, string rel, string href)
        {
            string result = $"<link rel=\"{rel}\" href=\"{href}\"/>";
            return new HtmlString(result);
        }
    }
}
