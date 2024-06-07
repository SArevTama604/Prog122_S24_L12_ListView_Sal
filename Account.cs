using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_S24_L12_ListView_Sal
{
    public class Account
    {
        int userNumber;
        decimal balance;



        // account1.balance -= 50;
        //naccount2.balance =+ 50;

        public static void TransferMonet(Account transferFrom, Account transferTo, decimal amount)
        {

            transferFrom.balance -= amount;
            transferTo.balance += amount;

        }

        public static void ChangeUserNumber(Account account, int newNumber)
        {
            account.userNumber = newNumber;
        }

        internal static void TransferMoney(Account a1, Account a2, int v)
        {
            throw new NotImplementedException();
        }
    }
}
