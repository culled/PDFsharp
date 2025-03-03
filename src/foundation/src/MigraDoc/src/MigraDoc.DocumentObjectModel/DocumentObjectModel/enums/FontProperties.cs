// MigraDoc - Creating Documents on the Fly
// See the LICENSE file in the solution root for more information.

namespace MigraDoc.DocumentObjectModel
{
    /// <summary>
    /// Specifies the properties of a font that are defined in this instance.
    /// Used internally only.
    /// </summary>
    [Flags]
    enum FontProperties
    {
        None = 0x0000,
        Name = 0x0001,
        Size = 0x0002,
        Bold = 0x0004,
        Italic = 0x0008,
        Underline = 0x0010,
        Color = 0x0020,
        Border = 0x0040,
        Superscript = 0x0080,
        Subscript = 0x0100,
        Strikethrough = 0x0200,
        ShadingColor = 0x0400,
    }
}
