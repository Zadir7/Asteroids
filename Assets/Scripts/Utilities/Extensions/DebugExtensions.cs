using UnityEngine;

namespace Utilities.Extensions
{
    public static class DebugExtensions
    {
        public static string CoordinatesAsString(this Vector3 vector) => $"[{vector.x}, {vector.y}, {vector.z}]";
    }
}