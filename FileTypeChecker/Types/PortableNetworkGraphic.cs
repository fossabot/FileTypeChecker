﻿namespace FileTypeChecker.Types
{
    using FileTypeChecker.Abstracts;

    public class PortableNetworkGraphic : FileType, IFileType
    {
        public const string TypeName = "Portable Network Graphic";
        public const string TypeExtension = "png";
        private static readonly byte[] magicBytes = new byte[] { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A };

        public PortableNetworkGraphic() : base(TypeName, TypeExtension, magicBytes)
        {
        }
    }
}
