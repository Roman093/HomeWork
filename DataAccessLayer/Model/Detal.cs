namespace DataAccessLayer
{
    public class Detal
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public int DetalTypeId { get; set; }
        public virtual DetalType DetalType { get; set; }
    }
}