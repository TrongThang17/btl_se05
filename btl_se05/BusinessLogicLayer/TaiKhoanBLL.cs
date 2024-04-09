using btl_se05.DataAccessLayer;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace btl_se05.BusinessLogicLayer
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();

        public int login(string tenTK, string matKhau)
        {
            DataTable dt = taiKhoanDAL.findByUsername(tenTK);
            if (dt.Rows.Count == 0)
                return 0; //Tên đăng nhập không tồn tại
            else
            {
                if (String.Equals(dt.Rows[0]["sMK"].ToString(), matKhau))
                {
                    Program.setSession(dt.Rows[0]["PK_sMaTk"].ToString(), dt.Rows[0]["FK_sMaQuyen"].ToString(), dt.Rows[0]["sTenTK"].ToString());

                    return 1;
                } 
                return 2; //Đúng tên dăng nhập nhưng Sai mật khẩu
            }
        }

        public bool checkPassword(string tenTK, string matKhau)
        {
            DataTable dt = taiKhoanDAL.findByUsername(tenTK);
            foreach (DataRow dr in dt.Rows)
            {
                if (String.Equals(dr["Mật khẩu"].ToString(), matKhau))
                {
                    return true;
                }
            }
            return false;
        }

        public bool changePassword(string tenTK, string matKhau)
        {
            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau))
            {
                return false;
            }

            if (checkingPasswordStrength(matKhau) < 3)
            {
                return false;
            }

            return taiKhoanDAL.changePassword(tenTK, matKhau);
        }

        public bool createUser(string tenTk, string MK, string maQuyen)
        {
            return taiKhoanDAL.createUser(tenTk, MK, maQuyen);
        }

        public int checkingPasswordStrength(string password)
        {
            int score = 0;

            //Check xem mật khẩu có số hay không
            if (Regex.IsMatch(password, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript))   //number only //"^\d+$" if you need to match more than one digit.
                score++;

            //Chekc xem mật khẩu có chữ thường không
            if (Regex.IsMatch(password, @"^(?=.*[a-z]).+$", RegexOptions.ECMAScript)) //lower
                score++;

            //Chekc xem mật khẩu có chữ hoa không
            if (Regex.IsMatch(password, @"^(?=.*[A-Z]).+$", RegexOptions.ECMAScript)) //upper case
                score++;

            //Chekc xem mật khẩu có ký tự đặc biệt hay không
            //if (Regex.IsMatch(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript)) //^[A-Z]+$
            //    score++;

            return score;
        }

         
    }
}
