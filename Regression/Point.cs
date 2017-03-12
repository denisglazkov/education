using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json.Linq;

namespace Regression
{
    public class Point
    {
        public int x { get; set; }
        public int Y { get; set; }

        public static List<Point> GetPoint(string fileObj)
        {
            JArray arrObj = JArray.Parse(fileObj);
            List<Point> points = arrObj.ToObject<List<Point>>();
            return points;
        }
    }
}