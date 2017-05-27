using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobShujuZhuaquConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string cmd = Console.ReadLine();
                if(cmd == "zq")
                {

                    ZhiweiZhuaquqi zhuaquqi = new ZhiweiZhuaquqi();

                    string url = "http://search.51job.com/jobsearch/search_result.php?fromJs=1&jobarea=060000%2C00&district=000000&funtype=0000&industrytype=00&issuedate=9&providesalary=99&keyword=c%23&keywordtype=2&curr_page={0}&lang=c&stype=1&postchannel=0000&workyear=99&cotype=99&degreefrom=99&jobterm=99&companysize=99&lonlat=0%2C0&radius=-1&ord_field=0&list_type=0&fromType=14&dibiaoid=0&confirmdate=9";
                    zhuaquqi.Zhuaqu(12, url);

                    //url = "http://search.51job.com/jobsearch/search_result.php?fromJs=1&jobarea=090200%2C00&district=000000&funtype=0000&industrytype=00&issuedate=9&providesalary=99&keyword=c%23&keywordtype=2&curr_page={0}&lang=c&stype=1&postchannel=0000&workyear=99&cotype=99&degreefrom=99&jobterm=99&companysize=99&lonlat=0%2C0&radius=-1&ord_field=0&list_type=0&fromType=14&dibiaoid=0&confirmdate=9";
                    //zhuaquqi.Zhuaqu(43, url);
                }
                else if(cmd == "f")
                {
                    Filter f = new Filter();
                    f.Filte();
                }
            }
        }
    }
}
