namespace Talaorasan.Shared.Transaction
{
    public class PersonDto
    {
        public Guid PersonId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? MiddleName { get; set; } = null;
        public string? ExtensionName { get; set; } = null;
        public string? Prefix { get; set; } = null;
        public string? Suffix { get; set; } = null;
    }
}
