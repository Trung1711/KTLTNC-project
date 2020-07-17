using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
   public class UserInformation
    {
        private  string userName;
        private  int userAge;
        private  uint userID;
        private double baseSalary;
        public UserInformation(string username, int userage, uint useriD)
        {
            UserName = username;
            UserAge = userage;
            UserID = useriD;
        }
         public UserInformation(string username,int userage,uint useriD, double baseSalary): this(username,userage,useriD)
        {
            
            BaseSalary = baseSalary;
        }        
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
        public int UserAge
        {
            get
            {
                return userAge;
            }
            set
            {
                if(value <= 18)
                {
                    throw new UserAccountException("Error! User’s age must be larger than 18");
                }
                else
                {
                    userAge = value;
                }
               
            }
        }
        public uint UserID
        {
            get
            {
                return userID;
            }
            set
            {
                if(value <1000 || value >9999)
                {
                    throw new UserAccountException("Error! ID must be between 1000 and 9999");
                }
                else
                {
                   userID = value;
                }
            }
        }
        public double BaseSalary
        {
            get
            {
                return this.baseSalary;
            }
            set
            {
                this.baseSalary = value;
            }
        }
        public override string ToString()
        {
            return "Ten: " + UserName + ", Tuoi: " + UserAge + ", ID: "+ UserID;
        }

        public virtual double GetSalary()
        {
            return BaseSalary;
        }
        
    }
}
