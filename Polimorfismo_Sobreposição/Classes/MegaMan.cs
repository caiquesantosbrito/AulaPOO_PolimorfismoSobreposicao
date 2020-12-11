using System;

namespace Polimorfismo_Sobreposição.Classes
{
    public class MegaMan : Player
    {
        public override void Correr()
        {
            Console.WriteLine("Correr em 100X");
        }

    }
}