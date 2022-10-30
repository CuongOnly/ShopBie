using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBie.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
       public DateTime? CreatDate { set; get; }
        [MaxLength(256)]
       public string CreateBy { set; get; }
       public DateTime? UpdatedDate { set; get; }
        [MaxLength(256)]
        public string UpdateBy { set; get; }

        //ISeo
        [MaxLength(256)]
        public string MetaKeyword { set; get; }
        [MaxLength(256)]

        public string MetaDescription { set; get; }

        // ISwitch
        public bool Status { set; get; }
    }
}
