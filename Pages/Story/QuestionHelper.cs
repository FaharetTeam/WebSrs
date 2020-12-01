using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSRS.Pages.Story
{
    public static class QuestionHelper
    {
        public static HtmlString TextBox(this IHtmlHelper html, string idname, string method)
        {
            string result = "<form method=\"" + method + "\">";
            result += "<input type=\"text\"name\"" + idname + "Name\"/><br>";
            result += "<input type=\"text\"name\"" + idname + "Email\"/><br>";
            result += "</form>";
            HtmlString htmlString = new HtmlString(result);
            return htmlString;
        }
        public static HtmlString TextArea(this IHtmlHelper html, string idname, string value, string method, int cols, int rows)
        {
            string result = "<form method=\"" + method + "\">";
            result += "<input type=\"textarea cols=15 rows=15\"name\"" + idname + "Your_story\"/><br>";
            result += "</form>";
            HtmlString htmlString = new HtmlString(result);
            return htmlString;
        }
        public static HtmlString DropDownList(this IHtmlHelper html, string idname, string method)
        {
            string result = "<form method=\"" + method + "\">";
            result += "<selesct id=\"phone\"name\"" + idname + "phone\"/> <br>";
            result += "<option> with the transition to another page </option>";
            result += "<option>with the transition to another page </option>";
            result += "<option> can't leave a comment </option>";
            result += "<option>I can not delete my history</option>";
            result += "<option> another problem</option>";
            result += "</select>";
            result += "</form>";
            HtmlString htmlString = new HtmlString(result);
            return htmlString;
        }

    }
}
