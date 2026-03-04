namespace Talaorasan.Shared.Transaction
{
    public class DeviceDto
    {
        public Guid DeviceId { get; set; } = Guid.NewGuid();
        public string StationCode { get; set; } = string.Empty;
        public string? DeviceName { get; set; }
        public string? Platform { get; set; } // Android, Windows, etc.
    }
}
