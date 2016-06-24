using JobShujuZhuaquConsoleApplication.Data;
using NHibernate;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JobShujuZhuaquConsoleApplication
{
    public class Filter
    {
        public void Filte()
        {
            List<ZhiweiDataModel> models = null;
            using (ISession session = NHibernateHelper.OpenSession())
            {
                models = session.QueryOver<ZhiweiDataModel>()
                    .Where(z => z.ZuigaoGongzi >14000 && z.ZuigaoGongzi < 20000 )
                    .List().ToList() ;
            }
            models = this.Filte(models);

            this.Write(models);
        }
        
        private List<ZhiweiDataModel> Filte(List<ZhiweiDataModel> models)
        {
            List<ZhiweiDataModel> filteList = new List<ZhiweiDataModel>();
            Regex regex = new Regex("食堂");
            foreach (ZhiweiDataModel model in models)
            {
                if (model.ZuigaoGongzi < 14000)
                {
                    continue;
                }
                if (model.ZuigaoGongzi > 20000)
                {
                    continue;
                }
                if (!regex.IsMatch(model.Mingxi))
                {
                    continue;
                }
                filteList.Add(model);
            }
            filteList = filteList.OrderByDescending(z => z.ZuigaoGongzi).ToList();

            return filteList;
        }

        protected virtual void Write(List<ZhiweiDataModel> models)
        {
            StreamWriter sw = File.CreateText(@"C:\Users\Administrator\Desktop\zhiwei.txt");

            foreach (ZhiweiDataModel model in models)
            {
                string zhiwei = string.Format("{0}-----{1}------{2}-------{3}", model.Name, model.GongsiName, model.ZuigaoGongzi, model.Lianjie);
                sw.WriteLine(zhiwei);
            }

            sw.Flush();
            sw.Close();
        }
    }
}
