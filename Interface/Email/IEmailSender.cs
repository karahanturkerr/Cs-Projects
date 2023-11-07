using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Email
{
    public interface IEmailSender
    {
        void GetMails();
        void SendEmail(string email);
    }
}
