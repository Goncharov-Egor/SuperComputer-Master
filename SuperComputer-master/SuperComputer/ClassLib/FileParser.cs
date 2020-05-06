using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLib
{
    /*
    <TextBlock><Run Text="November 2019"/></TextBlock>
    <TextBlock><Run Text="June 2019"/></TextBlock>
    <TextBlock><Run Text="November 2018"/></TextBlock>
    <TextBlock><Run Text="June 2018"/></TextBlock>
    <TextBlock><Run Text="November 2017"/></TextBlock>
    <TextBlock><Run Text="June 2017"/></TextBlock>
    <TextBlock><Run Text="November 2016"/></TextBlock>
    <TextBlock><Run Text="June 2016"/></TextBlock>
    <TextBlock><Run Text="November 2015"/></TextBlock>
    <TextBlock><Run Text="June 2015"/></TextBlock>
    <TextBlock><Run Text="November 2014"/></TextBlock>
    <TextBlock><Run Text="June 2014"/></TextBlock>
    */
    public static class FileParser
    {
        public static string Parse(string date)
        {
            string fileName = "ComputersXML//TOP500_";
            string[] s = date.Split(' ');
            fileName += s[1];
            fileName += s[0] == "November" ? "11" : "06";
            fileName += "_all.xml";
            return fileName;
        }
    }
}
