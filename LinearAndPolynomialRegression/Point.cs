using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using Newtonsoft.Json.Linq;

namespace LinearAndPolynomialRegression
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public List<Point> jsonToObject(string fileObj_)
        {
            JArray arrObj = JArray.Parse(fileObj_);
            List<Point> list_ = arrObj.ToObject<List<Point>>();
            return list_;
        }

    }
}