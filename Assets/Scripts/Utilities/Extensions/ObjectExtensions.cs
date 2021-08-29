using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Utilities.Extensions
{
    public static class ObjectExtensions
    {
        public static T DeepCopy<T>(this T self)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("Deep-copied type must be serializable!");
            }

            var formatter = new BinaryFormatter();
            using var stream = new MemoryStream();
            formatter.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);
            return (T) formatter.Deserialize(stream);
        }
    }
}