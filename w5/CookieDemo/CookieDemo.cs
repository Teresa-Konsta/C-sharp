using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinaCookie
{
    class CookieDemo
    {
        static void Main(string[] args)
        {
            CookieOrder cookie1 = new CookieOrder();
            SpecialCookieOrder cookie2 = new SpecialCookieOrder();

            cookie1.OrderNum = 123;
            cookie1.RecipientName = "VanGog";
            cookie1.CookieType = "chocolate";
            cookie1.DozenNum = 3;

            Console.WriteLine(cookie1.ToString());

            cookie2.OrderNum = 124;
            cookie2.RecipientName = "Beethoven";
            cookie2.CookieType = "white chocolate";
            cookie2.DozenNum = 2;
            cookie2.SpecialReason = "gluten free";

            Console.WriteLine(cookie2.ToString());
        }
    }
}
