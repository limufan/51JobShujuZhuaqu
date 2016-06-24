using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobShujuZhuaquConsoleApplication.Data
{
    public class ZhiweiDataModel
    {
        public virtual string Id { set; get; }

        public virtual string Name { set; get; }

        public virtual string GongsiName { set; get; }

        public virtual string GongzuoDidian { set; get; }

        public virtual int ZuidiGongzi { set; get; }

        public virtual int ZuigaoGongzi { set; get; }

        public virtual DateTime CreatedTime { set; get; }

        public virtual DateTime FabuTime { set; get; }

        public virtual string Lianjie { set; get; }

        public virtual string Mingxi { set; get; }
    }
}
