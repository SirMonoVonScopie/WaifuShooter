using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;
using wsGraphics;

namespace WaifuShooter
{
    class Program
    {
        static void Main(string[] args)
        {
            gameWindow app = new gameWindow();
            app.Run(60, 60);
        }
    }
}
