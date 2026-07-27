using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerCommLib
{
    public interface IMailSender
    {
        bool SendMail(string toAddress, string message);
    }
}
