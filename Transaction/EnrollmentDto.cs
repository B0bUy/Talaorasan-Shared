namespace Talaorasan.Shared.Transaction
{
    public class EnrollmentDto
    {
        public Guid EnrollmentId { get; set; }
        public Guid PersonId { get; set; }

        public byte[] Image { get; set; } = Array.Empty<byte>(); // Base64-encoded image data
        public string FileName { get; set; } = string.Empty;
        public string? MimeType { get; set; }

        public int? ImageSizeBytes { get; set; }
        public DateTime CapturedAt { get; set; } = default;
        public FacePose Pose { get; set; } = FacePose.Unknown;
    }
    public enum FacePose
    {
        Unknown = 0,
        Front = 1,
        Left = 2,
        Right = 3,
        Up = 4,
        Down = 5
    }
}
