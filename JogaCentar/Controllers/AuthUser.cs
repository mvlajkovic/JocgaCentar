using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using YogaDBLibrary.Models;
using YogaDBLibrary;

namespace JogaCentar.Controllers
{
    public class AuthUser
    {
        public static Account GetAccount(String username, String password)
        {
            Account account = new Account();
            using (YogaDBContext db = new YogaDBContext())
            {
                account = db.Accounts.Where(x =>
                        x.Username == username &&
                        x.Password == password &&
                        x.StatusId != (int) AccountStatus_Enum.Closed
                        )
                    .Include(i => i.Employees)
                    .Include(i => i.Users)
                    .FirstOrDefault();
            }

            return account;
        }

        public static Account RegisterNew(Account newAccount, out string msg)
        {
            msg = "";
            string firstName = newAccount.FirstName;
            string lastName = newAccount.LastName;
            string phoneNumber = newAccount.PhoneNumber;
            string email = newAccount.Email;
            string password = newAccount.Password;

            newAccount.Username = newAccount.Email;
            newAccount.StatusId = (int)AccountStatus_Enum.Pending;
            newAccount.TypeId = (int)AccountType_Enum.User;
            newAccount.ChangePassword = false;

            Account account = null;
            using (YogaDBContext db = new YogaDBContext())
            {
                account = db.Register_NewAccount(newAccount, out msg);
            }
            return account;
        }

        public static Boolean IsValidLogin(String username, String password)
        {
            using (YogaDBContext db = new YogaDBContext())
            {
                Boolean isValidLogin = db.Accounts.Any(x =>
                        x.Username == username &&
                        x.Password == password &&
                        x.StatusId == 1                        
                        );

                return isValidLogin;
            }
        }

        public static Boolean IsValidLogin(Account account)
        {
            if (account == null) return false;

                Boolean isValidLogin = false;

            if (account != null && account.AccountId > 0)
            {
               if(account.StatusId == (int) AccountStatus_Enum.Active)
                {
                    isValidLogin = true;
                }
            }

                return isValidLogin;
        }

    }
}
