using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    internal class MailModel
    {
        public string FileName {  get; set; }
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsRead { get; set; }
        public DateTime DateTime { get; set; }

        public MailModel(string fileName, string sender,string reciever, string subject, string body, string isread, DateTime dateTime)
        {
            FileName = fileName;
            Reciever = reciever;
            Sender = sender;
            Subject = subject;
            Body = body;
            DateTime = dateTime;

            if(isread == "r")
                IsRead = true;
            else IsRead = false;
        }

       
    }
}
