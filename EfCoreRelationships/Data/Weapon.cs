namespace EfCoreRelationships.Data
{
    public class Weapon
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public int Characterid { get; set; }
        public Character character { get; set; }
    }
}
