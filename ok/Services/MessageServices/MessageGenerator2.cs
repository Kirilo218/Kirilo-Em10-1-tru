using ok.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok.Services.MessageServices
{
    internal class MessageGenerator2
    {
        public void GenerateMsg()
        {
            Message msg = new Message("Автор", "", "Посилання");
        }

        public void ShowMsg(Message msg)
        {
            Console.WriteLine(msg.getAuthor(), msg.getPictureLink());
        }
    }
}
