using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus10
{
    class Varis : Animal, ICanFly
    {
        public float WingSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public Varis(float wingSize)
        {
            WingSize = wingSize;
        }
        public void Fly()
        {
            Console.WriteLine("Varis lentää. Variksen siipien koko on" + WingSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("Kakaaw Kakaaw");
        }
    }
}
