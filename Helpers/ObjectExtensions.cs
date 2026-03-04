namespace Talaorasan.Shared.Helpers
{
    public static class ObjectExtensions
    {
        public static string ToTitleCase(this string value)
        {
            if(string.IsNullOrEmpty(value)) return string.Empty;
            return value.ToLower();
        }
    }
}
