namespace T2008M_AP.Lab.s4
{
    public class KhachNuocNgoai : KhachHang
    {
        public string nationality;

        public KhachNuocNgoai(int id, string name, string dateTime, int amount, string nationality) : base(id, name, dateTime, amount)
        {
            this.nationality = nationality;
        }

        public string Nationality
        {
            get => nationality;
            set => nationality = value;
        }

        public override double totalPrice()
        {
            return amount * 2000;
        }
    }
}