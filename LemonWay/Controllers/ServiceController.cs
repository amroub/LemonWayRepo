using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;

namespace LemonWay.Controllers
{
    public class ServiceController : ApiController
    {
        private static readonly log4net.ILog LOGGER = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [HttpGet]
        public int Fibonacci(int n)
        {
            LOGGER.Info(String.Format("/Fibonacci?n={0}", n));

            if (n < 1 || n > 100)
                return -1;

            int firstnumber = 0, secondnumber = 1, result = 0;

            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   

            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }

            LOGGER.Info(String.Format("Fibonacci({0}) = {1}", n, result));

            return result;
        }

        [HttpGet]
        public string XmlToJson(string xml)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(xml))
                    return "Bad Xml Format";

                LOGGER.Info("/XmlToJson?xml=" + xml);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                LOGGER.Info("/XmlToJson?xml=" + xml);
                return JsonConvert.SerializeXmlNode(doc);
            }
            catch (XmlException ex)
            {
                LOGGER.Error(String.Format(ex.Message));
                return "Bad Xml Format";
            }
        }
    }
}