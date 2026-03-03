namespace Talaorasan.Shared.Response
{
    public class TransactionResponseDto<T>
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public T Output { get; set; } = default!;
    }
    public class TransactionResponseDto
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
    }
}
