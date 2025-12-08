using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4Review
{
    internal abstract class GameObject
    {
        protected int x;
        protected int y;

        protected string image;

        private double id;

        public GameObject(string image)
        {
            this.x = 0;
            this.y = 0;
            this.image = image;
            this.id = DateTime.Now.Millisecond;
        }

        public abstract void Update();

        public virtual void Draw()
        {
            Console.WriteLine(image);
        }

    }
}
