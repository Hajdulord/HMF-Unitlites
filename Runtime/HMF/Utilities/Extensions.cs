using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HMF.HMFUtilities.Utilities{
    public static class Extensions
    {
        public static Vector3 ToVector3(this Vector2 vector, float z = 0) => new Vector3(vector.x , vector.y, z);
        public static Vector2 ToVector2(this Vector3 vector) => new Vector2(vector.x , vector.y);
    }
}