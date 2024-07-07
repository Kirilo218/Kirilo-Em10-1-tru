using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok.Entity
{
    public class Message
    {
        private int id;
        private string author;
        private string text;
        private string pictureLink;
        private DateTime creationTime;

        public Message(string author, string text, string pictureLink)
        {
            this.author = author;
            this.text = text;
            this.pictureLink = pictureLink;
        }
        public string getAuthor () { return author; }
        public string getText() { return text; }
        public string getPictureLink() { return pictureLink; }
    }
}
