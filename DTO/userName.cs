using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO
{
    public class userName
    {
        private string _userName;
        private string _password;
        private double _STK;
        private string _NganHang;
        private string _NameAcc;
        public userName()
        {}
        public userName(string userName, string password, double sTK, string nganHang, string nameAcc)
        {
            this._userName = userName;
            this._password = password;
            this._STK = sTK;
            this._NganHang = nganHang;
            this._NameAcc = nameAcc; 

        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }        
        public string NameAcc
        {
            get { return _NameAcc; }
            set { _NameAcc = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public double STK
        {
            get { return _STK; }
            set { _STK = value; }
        }

        public string NganHang
        {
            get { return _NganHang; }
            set { _NganHang = value; }
        }
    }

}
