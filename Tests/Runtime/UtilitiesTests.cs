using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using HMF.HMFUtilities.Utilities;

namespace HMF.HMFUtilities.Tests.Runtime
{
    public class UtilitiesTests
    {
        
        /// Tests for the method DirectionTo
        [Test]
        public void DirectionToTest()
        {
            var from = 5f;
            var to = 2f;

            Assert.AreEqual(-3, HMFutilities.DirectionTo(from, to));

            Assert.AreNotEqual(-3, HMFutilities.DirectionTo(to, from));
        }

        /// Tests for AngleToRad
        [Test]
        public void AngleToRadTest()
        {
            var angle = 180f;

            Assert.AreEqual(Mathf.PI, HMFutilities.AngleToRad(angle));

            Assert.AreEqual(2 * Mathf.PI, HMFutilities.AngleToRad(2 * angle));
        }

        /// Tests for RadToAngle
        [Test]
        public void RadToAngleTest()
        {
            var rad = Mathf.PI;

            Assert.AreEqual(180f, HMFutilities.RadToAngle(rad));


            Assert.AreEqual(360f, HMFutilities.RadToAngle(2 * rad));
        }

        /// Tests for Angle to Vector2 with a margin of 1f
        [Test]
        public void AngleToVector2()
        {
            var expected = new Vector2(0f, 1f);
            var real = HMFutilities.AngleToVector2(90f);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector2(1f, 1f);
            real = HMFutilities.AngleToVector2(360f);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector2(0f, -1f);
            real = HMFutilities.AngleToVector2(180f);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector2(0.7f, 0.7f);
            real = HMFutilities.AngleToVector2(45f);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

        }

        /// Tests for Angle to Vector3 with a margin of 1f
        [Test]
        public void AngleToVector3()
        {
            var expected = new Vector3(0f, 1f);
            var real = HMFutilities.AngleToVector3(90f);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector3(1f, 1f);
            real = HMFutilities.AngleToVector3(360f);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector3(0f, -1f);
            real = HMFutilities.AngleToVector3(180f);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector3(0.7f, 0.7f);
            real = HMFutilities.AngleToVector3(45f);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

        }

        /// Tests for Radian to Vector2
        [Test]
        public void RadToVector2()
        {
            var expected = new Vector2(0f, 1f);
            var real = HMFutilities.RadToVector2(Mathf.PI / 2);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector2(1f, 1f);
            real = HMFutilities.RadToVector2(2 * Mathf.PI);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector2(0f, -1f);
            real = HMFutilities.RadToVector2(Mathf.PI);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector2(0.7f, 0.7f);
            real = HMFutilities.RadToVector2(Mathf.PI / 4);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

        }

        /// Tests for Radian to Vector3
        [Test]
        public void RadToVector3()
        {
            var expected = new Vector3(0f, 1f);
            var real = HMFutilities.RadToVector3(Mathf.PI / 2);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector3(1f, 1f);
            real = HMFutilities.RadToVector3(2 * Mathf.PI);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector3(0f, -1f);
            real = HMFutilities.RadToVector3(Mathf.PI);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

            expected = new Vector3(0.7f, 0.7f);
            real = HMFutilities.RadToVector3(Mathf.PI / 4);

            Assert.AreEqual(expected.x, real.x, 1f);
            Assert.AreEqual(expected.y, real.y, 1f);

        }
    }

}
