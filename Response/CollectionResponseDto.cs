namespace Talaorasan.Shared.Response
{
    public sealed record class CollectionResponseDto<T>(T[] list, int pages, int records);
}
