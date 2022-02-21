﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add( int m, int n)
        {
            return m+n;
        }
        [WebMethod]
        public int Mul(int m, int n)
        {
            return m*n;
        }
        [WebMethod]
        public int Div(int m, int n)
        {
            return m/n;
        }
        [WebMethod]
        public int Factorial(int n)
        {
            int fact = 1;
            for(int i = 0; i < n; i++)
            {
               fact*=i;
            }
            return fact;
        }

    }
}
