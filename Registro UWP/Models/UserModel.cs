using Sales_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Email;

namespace Registro_UWP.Models
{
    public class UserModel : PropertyChangedNotification
    {
        //Email
        public string Email
        {
            get { return GetValue(() => Email); }
            set
            {
                SetValue(() => Email, value);
                EmailMessage = "";
                Message = "";
            }
        }
        //Password
        public string Password
        {
            get { return GetValue(() => Password); }
            set
            {
                SetValue(() => Password, value);
                PasswordMessage = "";
                Message = "";
            }
        }

        //
        public string Message
        {
            get { return GetValue(() => Message); }
            set { SetValue(() => Message, value); }
        }

        //
        public string EmailMessage
        {
            get { return GetValue(() => EmailMessage); }
            set { SetValue(() => EmailMessage, value); }
        }

        //
        public string PasswordMessage
        {
            get { return GetValue(() => PasswordMessage); }
            set { SetValue(() => PasswordMessage, value); }
        }
    }
}
