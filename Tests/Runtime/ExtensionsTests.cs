using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using HMF.HMFUtilities.Utilities;

namespace HMF.HMFUtilities.Tests.Runtime
{
    /// Tests for the extension methods in HMF-Utilities.
    public class ExtensionsTests
    {
        
        /// Simple tests for ToVector3. Where we check if the default value is set correctly,
        /// and check if the given value is also set correctly
        [Test]
        public void ToVector3Test()
        {
            // positive cases
            Assert.AreEqual(Vector3.zero,  Vector2.zero.ToVector3());

            Assert.AreEqual(Vector3.one, Vector2.one.ToVector3(1));
            
            // negative cases

            Assert.AreNotEqual(Vector3.zero, Vector2.zero.ToVector3(1));

            Assert.AreNotEqual(Vector3.one, Vector2.one.ToVector3());

            Assert.AreNotEqual(new Vector3(1, 2, 2), (new Vector2(1, 2)).ToVector3());

            Assert.AreNotEqual(new Vector3(1, 2, 1), (new Vector2(1, 2)).ToVector3());

            Assert.AreNotEqual(new Vector3(2, 2, 2), (new Vector2(1, 2)).ToVector3());

            Assert.AreNotEqual(new Vector3(1, 1, 1), (new Vector2(1, 2)).ToVector3());

            Assert.AreNotEqual(new Vector3(1, 2, 2), (new Vector2(1, 2)).ToVector3(3));

            Assert.AreNotEqual(new Vector3(1, 2, 1), (new Vector2(1, 2)).ToVector3(3));

            Assert.AreNotEqual(new Vector3(2, 2, 2), (new Vector2(1, 2)).ToVector3(3));

            Assert.AreNotEqual(new Vector3(1, 1, 1), (new Vector2(1, 2)).ToVector3(3));

            Assert.AreNotEqual(new Vector3(1, 3, 1), (new Vector2(1, 2)).ToVector3(3));

            Assert.AreNotEqual(new Vector3(3, 1, 1), (new Vector2(1, 2)).ToVector3(3));

            Assert.AreNotEqual(new Vector3(1, 3, 3), (new Vector2(1, 2)).ToVector3(3));

            Assert.AreNotEqual(new Vector3(3, 1, 3), (new Vector2(1, 2)).ToVector3(3));

            Assert.AreNotEqual(new Vector3(3, 3, 3), (new Vector2(1, 2)).ToVector3(3));

        }

        /// Simple tests for ToVector2. Where we check if the z value of the vec3 is the one cut from it.
        [Test]
        public void ToVector2Test()
        {
            // positive cases
            Assert.AreEqual(Vector2.one, Vector3.one.ToVector2());

            Assert.AreEqual(new Vector2(1, 2), (new Vector3(1, 2, 3).ToVector2()));

            // negative cases
            Assert.AreNotEqual(new Vector2(1, 3), (new Vector3(1, 2, 3).ToVector2()));

            Assert.AreNotEqual(new Vector2(3, 2), (new Vector3(1, 2, 3).ToVector2()));

            Assert.AreNotEqual(new Vector2(1, 1), (new Vector3(1, 2, 3).ToVector2()));

            Assert.AreNotEqual(new Vector2(3, 3), (new Vector3(1, 2, 3).ToVector2()));

            Assert.AreNotEqual(new Vector2(2, 2), (new Vector3(1, 2, 3).ToVector2()));


        }

    }

}
