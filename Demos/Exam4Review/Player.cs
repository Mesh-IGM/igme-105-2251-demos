using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4Review
{
    internal class Player : GameObject
    {
        public Player(string image) 
            : this(10,10,image)
        {
        }

        public Player(int x, int y, string image)
            : base(image)
        {
            this.x = x;
            this.y = y;
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            Console.WriteLine("I'M A PLAYER!");
            base.Draw();
        }
    }
}
