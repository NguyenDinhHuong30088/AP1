namespace T2008M_AP.Practical.Example_2
{
    public class Program {
        public static void Main(string[] args){
            Tiger tg = new Tiger();
            Lion li = new Lion();
            tg.Setme(100,"tiger");
            li.Setme(200,"lion");
            tg.Show();
            li.Show();
        }
    }
}