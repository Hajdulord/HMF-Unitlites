using UnityEngine;

namespace HMF.HMFUtilities.Utilities
{
    public class HMFutilities
    {
        public static float DirectionTo(float from, float to) => to - from;
        public static float AngleToRad(float angle) => angle * (Mathf.PI / 180);
        public static float RadToAngle(float rad) => rad * (180 / Mathf.PI);
        public static Vector2 AngleToVector2(float angle) => new Vector2(Mathf.Cos(AngleToRad(angle)), Mathf.Sin(AngleToRad(angle)));
        public static Vector3 AngleToVector3(float angle) => new Vector3(Mathf.Cos(AngleToRad(angle)), Mathf.Sin(AngleToRad(angle)));
        public static Vector2 RadToVector2(float rad) => new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
        public static Vector2 RadToVector3(float rad) => new Vector3(Mathf.Cos(rad), Mathf.Sin(rad));
    }
}

