using System;

namespace T2008M_AP.Practical.Example_2
{
    public class Tiger : Base
    {
        public Tiger() : base() {
        }
        public override void Show() {
            Console.WriteLine("Name:"+this.Name+",Weight"+this.Weight);
        }
        public override void SetMe(double weight,string name) {
            this.Weight = weight;
            this.Name = name;
        }
    }
}