using feladat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    internal class PollPost : Post
    {
        private int _votes;
        private bool _isClosed;


        public int Votes
        {
            get { return _votes; }
            
        }

        public bool IsClosed
        {
            get { return _isClosed; }
          
        }

        public PollPost(string author) : base(author)
        {
            _votes = 0;
            
        }

        public bool Vote()
        {
            if (!_isClosed)
            {
                _votes++;
                return true;
            }
            return false;
        }


         public bool Closed()
        {
            _isClosed = true;
            return _isClosed;
        }
        public override int Score()
        {
            return Likes + Votes;
        }


        public override string GetDescription()
        {
            return $"{Author}, {Likes} kedvelés, {Votes} szavazat" + (_isClosed ? ", lezárva" : "");

        }

        public override bool Like()
        {            
            if (!_isClosed)
            {
                base.Like();
                return true;
            }
            return false;
        }


    }
}
