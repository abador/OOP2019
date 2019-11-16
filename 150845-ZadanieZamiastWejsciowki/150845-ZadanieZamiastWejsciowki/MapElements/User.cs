using _150845_ZadanieZamiastWejsciowki.MapClass;
using System;
namespace _150845_ZadanieZamiastWejsciowki.MapElements
{
    class User : MapElement
    {
        string name;
        int level;

        public string Name 
        { 
            get
            {
                return this.name;
            }
            
        }
        public int Level 
        { 
            get
            {
                return this.level;
            }
            
        }

        public User(string name, int x, int y) : base(x, y, 'U')
        {
            this.name = name;
            this.level = 1;
        }

        public override void Print() => Console.WriteLine($"User {this.Name} - {this.Icon}\n" +
            $"x = {this.x}, y = {this.y}");
        

    }
}
