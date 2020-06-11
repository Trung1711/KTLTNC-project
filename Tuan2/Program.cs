using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    class Program
    {
        /* static void GetUserBankAccountInformation(out BankAccount account)
         {

             Console.WriteLine("Nhap ten: ");
             var UserName = Console.ReadLine();
             Console.WriteLine("Nhap tuoi: ");
             var userAge = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Nhap ID: ");
             var UserID = Convert.ToUInt32(Console.ReadLine());
             Console.WriteLine("Nhap pass: ");
             var PassWord = Console.ReadLine();
             Console.WriteLine("Nhap Balance: ");
             var balance = Convert.ToInt32(Console.ReadLine());
             account = new BankAccount(UserName, userAge, UserID, balance, PassWord);


         }*/
        public static void AccessDeniedEventHandle(BankAccount account)
        {
            var i = 0;
            while (i < 4)
            {
                Console.WriteLine("Please type your password");
                account.VerifyPassWord(Console.ReadLine());
                if (account.IsPasswordVerified == true)
                {
                    account.CheckAccessPermission();
                    break;
                }
                else
                {
                    i++;
                    if (i == 3)
                    {
                        throw new AccessDeniedException("error");
                    }

                }
            }
                

        }
        static void Main(string[] args)
        {

            /* UserInformation s = new UserInformation("trung", 19 ,1999);
            Console.WriteLine ("{0}",s.ToString());
             Console.ReadLine();


             BankAccount alexAccount = new BankAccount("alex", 20, 11111, 1000, "alex123");
             Console.WriteLine("Please type your password");
             alexAccount.VerifyPassWord(Console.ReadLine());
             Console.WriteLine(alexAccount.CalculateInterstMoney());*/
            try
            {
                BankAccount alexAccount = new BankAccount("alex", 22, 1234, 1000, "alex123");

                // GetUserBankAccountInformation(out alexAccount);
                AccessDeniedEventHandle(alexAccount);

                alexAccount.AccessDeniedEvent += AccessDeniedEventHandle;
                Console.WriteLine(alexAccount.CalculateInterstMoney());
                Console.WriteLine(alexAccount.ToString());
                Console.WriteLine();

                List<UserInformation> user = new List<UserInformation>(5);
                user.Add(new Employee("t", 20, 1230, 100));
                user.Add(new Employee("t", 20, 1230, 200));
                user.Add(new Manager("t", 20, 1230, 100));
                user.Add(new Manager("t", 20, 1230, 200));
                user.Add(new Director("t", 20, 1230, 100));
                user.Add(new Director("t", 20, 1230, 200));

                for (var i = 0; i < 6; i++)
                {
                    Console.WriteLine("{0}", user[i].GetSalary());
                }
                List<double> t = new List<double>(5);
                for (var i = 0; i < 6; i++)
                {
                    t.Add(user[i].GetSalary());
                }
                Sapxep gg = new Sapxep();
                t.Sort(gg);
                Console.WriteLine("sau khi sap xep: ");
                foreach (var g in t)
                {
                    Console.WriteLine("{0}", g);
                }
               
            }
            catch (AccessDeniedException)
            {
                Console.WriteLine("Wrong PassWord 3 times");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.StackTrace);

            }
            catch (Exception k)
            {
                Console.WriteLine(k.Message);
            }
            Console.ReadLine();
        }
    }
}