using ok.Entity;
using ok.Services.MessageServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ok
{
    internal class Program
    {
   
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Message msg = new Message("Я", "Навіщо текст?", "В інтернеті своє пасилання найди");
            
            MessageGenerator1 msgGen1 = new MessageGenerator1();
            MessageGenerator2 msgGen2 = new MessageGenerator2();

            msgGen1.GenerateMsg();
            msgGen2.GenerateMsg();

            msgGen1.ShowMsg(msg);
            msgGen2.ShowMsg(msg);
        }
    }
}