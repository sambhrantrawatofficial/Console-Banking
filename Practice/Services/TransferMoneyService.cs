using System;
using System.Collections.Generic;
using System.Text;
using Practice.Models;
using Practice.Data;

namespace Practice.Services
{
    internal class TransferMoneyService
    {
        private readonly BankDbContext _context;

        public TransferMoneyService()
        {
            _context = new BankDbContext();
        }

        // Transfer by account number
        public void TransferViaAccountNo(
            string username,
            string receiverAccountNo,
            int amount)
        {

            var senderUser = _context.Users.FirstOrDefault(u => u.Name == username);
            if (senderUser == null)
            {
                Console.WriteLine("Sender user not found.");
                return;
            }

            var senderAccount = _context.AccountDets
                .FirstOrDefault(a => a.Name == senderUser.Name);
            var receiverAccount = _context.AccountDets
                .FirstOrDefault(a => a.Account_No.ToString() == receiverAccountNo.ToString());

            if (senderAccount == null || receiverAccount == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            if (senderAccount.Balance < amount)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            senderAccount.Balance -= amount;
            receiverAccount.Balance += amount;

            var transfer = new Transfer_via_accountno
            {
                Sender_Name = senderAccount.Name,
                Sender_AccountNo = senderAccount.Account_No.ToString(),
                Receiver_Name = receiverAccount.Name,
                Receiver_AccountNo = receiverAccount.Account_No.ToString(),
                Amount = amount.ToString(),
                Transfer_Date = DateTime.Now
            };

            _context.TransferViaAccountnos.Add(transfer);
            _context.SaveChanges();

            Console.WriteLine($"Transferred {amount} from {senderAccount.Name} to {receiverAccount.Name}.");
        }

        // Transfer by phone number
        public void TransferViaPhoneNo(
            string username,
            string receiverPhoneNo,
            int amount)
        {
            var senderUser = _context.Users
                .FirstOrDefault(u => u.Name == username);
            var receiverUser = _context.Users
                .FirstOrDefault(u => u.PhoneNumber == receiverPhoneNo);

            if (senderUser == null || receiverUser == null)
            {
                Console.WriteLine("User / phone not found.");
                return;
            }

            var senderAccount = _context.AccountDets
                .FirstOrDefault(a => a.Name == senderUser.Name);
            var receiverAccount = _context.AccountDets
                .FirstOrDefault(a => a.Name == receiverUser.Name);

            if (senderAccount == null || receiverAccount == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            if (senderAccount.Balance < amount)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            senderAccount.Balance -= amount;
            receiverAccount.Balance += amount;

            var transfer = new Transfer_via_phoneno
            {
                Sender_Name = senderUser.Name,
                Sender_PhoneNo = senderUser.PhoneNumber,
                Receiver_Name = receiverUser.Name,
                Receiver_PhoneNo = receiverUser.PhoneNumber,
                Amount = amount.ToString(),
                Transfer_Date = DateTime.Now
            };

            _context.TransferViaPhonenos.Add(transfer);
            _context.SaveChanges();

            Console.WriteLine($"Transferred {amount} from {senderUser.Name} to {receiverUser.Name}.");
        }
    
    }
}
