using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace QuickEmailer
{
    public class Logic
    {
        public static QuickEmailerDBEntities context = new QuickEmailerDBEntities();

        public static List<string> agencyList()
        {
            List<Agencies> agencies = context.Agencies.ToList();

            List<string> aList = new List<string>();

            foreach (var a in agencies)
            {
                aList.Add(a.AgencyName);
            }

            aList = aList.OrderBy(q => q).ToList(); ;

            return aList;

        }

        public static void sendMail(string to, string ccList, string subjectTitle, string emailBody)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"); // find the host name and place here
            mail.From = new MailAddress("joelfong@gmail.com");
            mail.To.Add(to);
            mail.CC.Add(ccList);
            mail.Subject = subjectTitle;
            mail.Body = emailBody;

            smtpClient.Port = 587; //enter the port
            smtpClient.Credentials = new System.Net.NetworkCredential("joelfong@gmail.com", "fonganama"); 
            smtpClient.EnableSsl = true;

            smtpClient.Send(mail);

        }


    }
}