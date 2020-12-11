using System;

namespace Polimorfismo_Sobreposição.Classes
{
    public class Player
    {
        public virtual void Correr()
        {
            Console.WriteLine("Correndo em velocidade 10");
        }
    }
}