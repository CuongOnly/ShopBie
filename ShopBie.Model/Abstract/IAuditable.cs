using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBie.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatDate { set; get; }
        string CreateBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdateBy { set; get; }

        //ISeo
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        //Iswitch
        bool Status { set; get; }
    }
}
