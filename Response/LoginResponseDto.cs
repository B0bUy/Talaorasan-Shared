namespace Talaorasan.Shared.Response
{
    public sealed record class LoginResponseDto (string tokenStr, DateTime expires, string? userName, string[] roles);
}
