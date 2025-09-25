using EPiServer.Framework.DataAnnotations;
using System.Runtime.InteropServices;

namespace JohannaCMS.Models;

[ContentType(GUID = "FB74A3E9-039B-4BF3-BDE2-55ACE976402E")]
[MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png,webp")]
public class ImageFile : ImageData
{
}
