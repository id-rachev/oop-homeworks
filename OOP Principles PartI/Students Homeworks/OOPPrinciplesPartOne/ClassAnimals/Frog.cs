using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class Frog : Animal
{

    public Frog(string name, byte age, Sex sex)
        : base(name, age, sex)
    {

    }
    public override string ToString()
    {
        StringBuilder froginfo = new StringBuilder();
        froginfo.AppendFormat("{0} i am a {1}", base.ToString(), this.GetType().Name);
        return Convert.ToString(froginfo);
    }
    public  override void MakeSound()
    {
        Console.WriteLine("Quack");
    }
}

