﻿using System;

namespace Shouldly
{
    internal static class ShouldlyCoreExtensions
    {
        internal static void AssertAwesomely<T>(this T actual, Func<T, bool> specifiedConstraint, object originalActual, object originalExpected)
        {
            try
            {
                if (specifiedConstraint(actual)) return;
            }
            catch (ArgumentException ex)
            {
                throw new ChuckedAWobbly(ex.Message, ex);
            }

            throw new ChuckedAWobbly(new ExpectedActualShouldlyMessage(originalExpected, originalActual).ToString());
        }

        internal static void AssertAwesomely<T>(this T actual, Func<T, bool> specifiedConstraint, object originalActual, object originalExpected, object tolerance)
        {
            try
            {
                if (specifiedConstraint(actual)) return;
            }
            catch (ArgumentException ex)
            {
                throw new ChuckedAWobbly(ex.Message, ex);
            }

            throw new ChuckedAWobbly(new ExpectedActualToleranceShouldlyMessage(originalExpected, originalActual, tolerance).ToString());
        }
    }
}
