using System;
using System.Diagnostics;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static void IsTrue(bool value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (!value)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_IsNotTrue,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void IsFalse(bool value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (value)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_IsNotFalse,
                    paramName);
        }
    }
}