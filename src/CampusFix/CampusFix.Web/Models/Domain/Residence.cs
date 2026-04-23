namespace CampusFix.Web.Models.Domain
{
    public class Residence
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Campus { get; set; } = string.Empty;
        public string Block { get; set; } = string.Empty;
    }
}
