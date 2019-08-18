using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerInquiry.Domain
{
    public static class Helpers
    {
        /// <summary>
        /// Validate email format
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
