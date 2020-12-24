using UnityEngine;

namespace HMF.HMFUtilities.Utilities
{
    public class HMFUtilities
    {
        public static float DirectionTo(float from, float to) => to - from;
        public static float AngelToRad(float angel) => angel * (Mathf.PI / 180);
        public static float RadToAngel(float rad) =>  180 / (rad * Mathf.PI);
        public static Vector2 AngleToVector2(float angel) => new Vector2(Mathf.Cos(RadToAngel(angel)), Mathf.Sin(RadToAngel(angel)));
        public static Vector3 AngleToVector3(float angel) => new Vector3(Mathf.Cos(RadToAngel(angel)), Mathf.Sin(RadToAngel(angel)));
        public static Vector2 RadToVector2(float rad) => new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
        public static Vector2 RadToVector3(float rad) => new Vector3(Mathf.Cos(rad), Mathf.Sin(rad));
    }
}

