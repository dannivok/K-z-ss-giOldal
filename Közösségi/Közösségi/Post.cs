using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Hozd létre a Post.cs fájlt, benne a Post osztályt. Legyen abstract: az oldalon minden bejegyzés
/// szöveges, képes vagy szavazós
/// • Hozz létre két privát változót: _author(string), _likes(int), hozzájuk két publikus property-t
/// (Author, Likes). Az Author get blokkja adja vissza a privát megfelelőt, a set blokk a privát
/// változónak állítja be az értéket. A Likes-nak csak get blokkja legyen
///  Konstruktor egy paraméterrel: author.A szerzőt a property-n keresztül állítsd be, a kedvelések
//száma 0-ról induljon

namespace feladat
{
   abstract class Post
    {
        private string _author;
        private int _likes;
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public int Likes
        {
            get { return _likes; }
        }
        public Post(string author)
        {
            Author = author;
            _likes = 0;
        }

        public virtual bool Like()
        {
            _likes++;
            return true;
        }

        public virtual string GetDescription()
        {
            return $"{Author}, {Likes} kedvelés";
        }

        public abstract int Score();


        
    }


}