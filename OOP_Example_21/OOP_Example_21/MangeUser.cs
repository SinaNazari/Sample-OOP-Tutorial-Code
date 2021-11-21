using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example_21
{
    public class MangeUser
    {
        private IEmailSender _sender;
        public MangeUser(IEmailSender sender)
        {
            this._sender = sender;
        }
        public void RecoveryPassword()
        {
            _sender.SendEmail("2322@gmail.com");
        }
        public void Register()
        {

        }

        public void Login()
        {

        }

        public void UserName()
        {

        }

        public void Password()
        {

        }
    }
}
