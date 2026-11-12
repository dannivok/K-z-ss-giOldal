using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat   
{
    internal class TextPost : Post
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        
        public TextPost(string author, string text) : base(author)
        {
            Text = text;
        }

        public override int Score()
        {
            return Likes;
        }



        public override string GetDescription()
        {
            return base.GetDescription() + ": " + (Text.Length > 20 ? Text.Substring(0, 20) + "..." : Text);
        }
    }
}
