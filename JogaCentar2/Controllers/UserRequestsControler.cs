using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YogaDBLibrary;
using YogaDBLibrary.Models;

namespace JogaCentar.Controllers
{
    public class UserRequestsControler
    {
        public static List<Pending_Accounts> GetPendingAccounts()
        {
            List<Pending_Accounts> accounts = new List<Pending_Accounts>();

            using (YogaDBContext db = new YogaDBContext())
            {
                accounts = db.Pending_Accounts.ToList();
            }

            return accounts;
        }

        public static Account GetAccount(int accountId)
        {
            Account account = new Account();

            using (YogaDBContext db = new YogaDBContext())
            {
                account = db.Accounts.Where(x => x.AccountId == accountId).FirstOrDefault();
            }

            return account;
        }

        public static List<Account> ApproveRequests(List<Pending_Accounts>  requests , out string msg)
        {
            List<Account> approved = new List<Account>();
            msg = "";

            using (YogaDBContext db = new YogaDBContext())
            {
                approved = db.ApproveRequests(requests, out msg); 
            }

            return approved;
        }

    }
}
