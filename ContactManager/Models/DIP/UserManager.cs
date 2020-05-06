using System;

namespace ContactManager.Models.DIP
{
    public class UserManager
    {
        public INotifier Notifier { get; set; }

        public UserManager(INotifier notifier)
        {
            this.Notifier = notifier;
        }

        public void ChangePassword(string usermane, string oldpwd, string newpwd)
        {
            // change password here

            // notify the user
            Notifier.Notify("Password was changed on " + DateTime.Now);
        }
    }
}
