using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class AllDocuments
    {
        public List<ComputerReader> computerReaders = new List<ComputerReader>();

        List<string> dates = new List<string>(){ "November 2019", "June 2019", "November 2018",
                           "June 2018", "November 2017", "June 2017",
                           "November 2016", "June 2016", "November 2015",
                           "June 2015", "November 2014", "June 2014" };

        public AllDocuments()
        {
            int cnt = 0;
            foreach(string date in dates)
            {
                computerReaders.Add(new ComputerReader(FileParser.Parse(date), date));
                if (cnt++ == 3) break;
            }
        }
    }
}
