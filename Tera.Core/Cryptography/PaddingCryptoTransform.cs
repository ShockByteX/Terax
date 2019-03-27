using System;
using System.Security.Cryptography;

namespace Tera.Core.Cryptography
{
    public sealed class PaddingCryptoTransform : ICryptoTransform
    {
        #region Properties
        public ICryptoTransform Transform { get; }
        public int InputBlockSize => Transform.InputBlockSize;
        public int OutputBlockSize => Transform.OutputBlockSize;
        public bool CanTransformMultipleBlocks => Transform.CanTransformMultipleBlocks;
        public bool CanReuseTransform => Transform.CanReuseTransform;
        #endregion
        #region Constructors
        public PaddingCryptoTransform(ICryptoTransform transform) { Transform = transform; }
        #endregion
        #region [PUBLIC]Methods
        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) => Transform.TransformBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset);
        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
        {
            int blockSize = Transform.InputBlockSize;
            byte[] block = new byte[inputCount / blockSize + blockSize];
            Buffer.BlockCopy(inputBuffer, inputOffset, block, 0, inputCount);
            byte[] result = Transform.TransformFinalBlock(block, 0, block.Length);
            Array.Resize(ref result, inputCount);
            return result;
        }
        public void Dispose() => Transform.Dispose();
        #endregion
    }
}