using btl_se05.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_se05.BusinessLogicLayer
{
    class QuyenBLL
    {
        QuyenDAL quyenDAL = new QuyenDAL();

        public DataTable findAll()
        {
            return quyenDAL.findAll();
        }
    }
}
