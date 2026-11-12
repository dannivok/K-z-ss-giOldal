using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    internal class ImagePost: Post
    {
        

        private int _imageCount;

        public int ImageCount
        {
            get { return _imageCount; }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    _imageCount = value;
                }
                else
                {
                    _imageCount = 1;
                }
            }
        }

        public ImagePost(string author, int imageCount) : base(author)
        {
            ImageCount = imageCount;
        }

        public override int Score()
        {
            return Likes * 2;
        }

        public override string GetDescription()
        {
            return $"{Author}, {Likes}, {ImageCount} kép";
        }
    }
}
