
namespace AuctionService.Dtos
{
    public class UpdateAuctionDto
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int? Year { get; set; }
        public string Color { get; set; }
        public int? Milage { get; set; }
    }
}
