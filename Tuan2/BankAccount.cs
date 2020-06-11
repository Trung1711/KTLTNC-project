using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    class BankAccount
    {
        private string passWord;
        private   bool isPasswordVerified;
        private  int balance;
        public string PassWord
        {
            get
            {
                return passWord;
            }
            set
            {
                passWord = value;
            }

        }
        public  bool IsPasswordVerified
        {
            get
            {
                return isPasswordVerified;
            }
        }
        public int Balance
        {
            get
            {
                CheckAccessPermission();
                return balance;     
            }
            set
            {
                CheckAccessPermission();
                balance = value;
            }
        }

        public static double InterestRate { get; set; }
        public UserInformation UserInf { get; set; }
        public BankAccount(string username,int userage, uint userID, int balance, string passWord )
        {
            UserInformation.UserName = username;
            UserInformation.UserAge = userage;
            UserInformation.UserID = userID;
            this.balance = balance;
            this.passWord = passWord; 

        }
        static BankAccount()
        {
            InterestRate = 0.05;
        }
        public double CalculateInterstMoney()
        {
            return Balance * InterestRate;
        }

        public  void  VerifyPassWord(string password)
        {
            int a;
            a = String.Compare(password, PassWord);
            if (a == 0)
                isPasswordVerified = true;
            else
                isPasswordVerified = false;
        }
        public  void CheckAccessPermission()
        {
            if (IsPasswordVerified == false)
            {
                //throw new AccessDeniedException("Nhap sai");  

                AccessDeniedEvent(this);
            }

        }
        
        public delegate void AccessDeniedDelegate(BankAccount account);
        public  event AccessDeniedDelegate AccessDeniedEvent;
        public override string ToString()
        {
            return "Ten: " + UserInformation.UserName + ", Tuoi: " +UserInformation.UserAge + ", ID: " +UserInformation.UserID;
        }
    }
}
