namespace Talaorasan.Shared.Requests
{
    public class CollectionRequest
    {
        public string? Search { get; set; } = null;
        public int Skip { get; set; } = 0;
        public int Take { get; set; } = 0;
    }
}
