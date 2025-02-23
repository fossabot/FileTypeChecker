﻿namespace FileTypeChecker.Types
{
    using FileTypeChecker.Abstracts;

    public class LZipFile : FileType, IFileType
    {
        public const string TypeName = "LZIP file";
        public const string TypeExtension = "lz";
        private static readonly byte[][] magicBytesJaggedArray = { new [] { (byte)'L', (byte)'Z', (byte)'I', (byte)'P', (byte)1 } };

        public LZipFile() : base(TypeName, TypeExtension, magicBytesJaggedArray)
        {
        }
    }
}
