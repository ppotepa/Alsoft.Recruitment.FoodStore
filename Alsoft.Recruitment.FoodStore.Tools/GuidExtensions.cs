using System;

namespace Alsoft.Recruitment.FoodStore.Tools
{
    public static class GuidExtensions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0018:Inline variable declaration", Justification = "OK")]
        public static Guid AsGuid(this string @string)
        {
            Guid result;

            Guid.TryParse(@string, out result);

            if (result == Guid.Empty)
                throw new InvalidOperationException("Invalid string passed");

            return result;
        }
    }
}
