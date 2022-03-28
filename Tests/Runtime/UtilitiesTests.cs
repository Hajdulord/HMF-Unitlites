using NUnit.Framework;
using UnityEngine;

namespace HMF.Tests.Runtime
{
    public class UtilitiesTests
    {
        
        /// Tests for the method DirectionTo
        [Test]
        public void DirectionToTest()
        {
            var from = 5f;
            var to = 2f;

            Assert.AreEqual(-3, Utilities.HMFUtilities.DirectionTo(from, to));

            Assert.AreNotEqual(-3, Utilities.HMFUtilities.DirectionTo(to, from));
        }

        /// Tests for AngleToRad
        [Test]
        public void AngleToRadTest()
        {
            var angle = 180f;

            Assert.AreEqual(Mathf.PI, Utilities.HMFUtilities.AngleToRad(angle));

            Assert.AreEqual(2 * Mathf.PI, Utilities.HMFUtilities.AngleToRad(2 * angle));
        }

        /// Tests for RadToAngle
        [Test]
        public void RadToAngleTest()
        {
            var rad = Mathf.PI;

            Assert.AreEqual(180f, Utilities.HMFUtilities.RadToAngle(rad));


            Assert.AreEqual(360f, Utilities.HMFUtilities.RadToAngle(2 * rad));
        }

        /// Tests for Angle to Vector2 with a margin of 1f
        [Test]
        public void AngleToVector2()
        {
            var expected = new Vector2(0f, 1f);
            var real = Utilities.HMFUtilities.AngleToVector2(90f);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector2(1f, 1f);
            real = Utilities.HMFUtilities.AngleToVector2(360f);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector2(0f, -1f);
            real = Utilities.HMFUtilities.AngleToVector2(180f);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector2(0.7f, 0.7f);
            real = Utilities.HMFUtilities.AngleToVector2(45f);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

        }

        /// Tests for Angle to Vector3 with a margin of 1f
        [Test]
        public void AngleToVector3()
        {
            var expected = new Vector3(0f, 1f);
            var real = Utilities.HMFUtilities.AngleToVector3(90f);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector3(1f, 1f);
            real = Utilities.HMFUtilities.AngleToVector3(360f);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector3(0f, -1f);
            real = Utilities.HMFUtilities.AngleToVector3(180f);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector3(0.7f, 0.7f);
            real = Utilities.HMFUtilities.AngleToVector3(45f);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

        }

        /// Tests for Radian to Vector2
        [Test]
        public void RadToVector2()
        {
            var expected = new Vector2(0f, 1f);
            var real = Utilities.HMFUtilities.RadToVector2(Mathf.PI / 2);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector2(1f, 1f);
            real = Utilities.HMFUtilities.RadToVector2(2 * Mathf.PI);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector2(0f, -1f);
            real = Utilities.HMFUtilities.RadToVector2(Mathf.PI);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector2(0.7f, 0.7f);
            real = Utilities.HMFUtilities.RadToVector2(Mathf.PI / 4);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

        }

        /// Tests for Radian to Vector3
        [Test]
        public void RadToVector3()
        {
            var expected = new Vector3(0f, 1f);
            var real = Utilities.HMFUtilities.RadToVector3(Mathf.PI / 2);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector3(1f, 1f);
            real = Utilities.HMFUtilities.RadToVector3(2 * Mathf.PI);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector3(0f, -1f);
            real = Utilities.HMFUtilities.RadToVector3(Mathf.PI);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector3(0.7f, 0.7f);
            real = Utilities.HMFUtilities.RadToVector3(Mathf.PI / 4);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

        }
    }

}
