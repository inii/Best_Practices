//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated. To update the generation of this file, modify and re-run Unity.Mathematics.CodeGen.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
#pragma warning disable CS8981

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    /// <summary>A 3x4 matrix of bools.</summary>
    [System.Serializable]
    [Il2CppEagerStaticClassConstruction]
    public partial struct bool3x4 : System.IEquatable<bool3x4>
    {
        /// <summary>Column 0 of the matrix.</summary>
        public bool3 c0;
        /// <summary>Column 1 of the matrix.</summary>
        public bool3 c1;
        /// <summary>Column 2 of the matrix.</summary>
        public bool3 c2;
        /// <summary>Column 3 of the matrix.</summary>
        public bool3 c3;


        /// <summary>Constructs a bool3x4 matrix from four bool3 vectors.</summary>
        /// <param name="c0">The matrix column c0 will be set to this value.</param>
        /// <param name="c1">The matrix column c1 will be set to this value.</param>
        /// <param name="c2">The matrix column c2 will be set to this value.</param>
        /// <param name="c3">The matrix column c3 will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3x4(bool3 c0, bool3 c1, bool3 c2, bool3 c3)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a bool3x4 matrix from 12 bool values given in row-major order.</summary>
        /// <param name="m00">The matrix at row 0, column 0 will be set to this value.</param>
        /// <param name="m01">The matrix at row 0, column 1 will be set to this value.</param>
        /// <param name="m02">The matrix at row 0, column 2 will be set to this value.</param>
        /// <param name="m03">The matrix at row 0, column 3 will be set to this value.</param>
        /// <param name="m10">The matrix at row 1, column 0 will be set to this value.</param>
        /// <param name="m11">The matrix at row 1, column 1 will be set to this value.</param>
        /// <param name="m12">The matrix at row 1, column 2 will be set to this value.</param>
        /// <param name="m13">The matrix at row 1, column 3 will be set to this value.</param>
        /// <param name="m20">The matrix at row 2, column 0 will be set to this value.</param>
        /// <param name="m21">The matrix at row 2, column 1 will be set to this value.</param>
        /// <param name="m22">The matrix at row 2, column 2 will be set to this value.</param>
        /// <param name="m23">The matrix at row 2, column 3 will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3x4(bool m00, bool m01, bool m02, bool m03,
                       bool m10, bool m11, bool m12, bool m13,
                       bool m20, bool m21, bool m22, bool m23)
        {
            this.c0 = new bool3(m00, m10, m20);
            this.c1 = new bool3(m01, m11, m21);
            this.c2 = new bool3(m02, m12, m22);
            this.c3 = new bool3(m03, m13, m23);
        }

        /// <summary>Constructs a bool3x4 matrix from a single bool value by assigning it to every component.</summary>
        /// <param name="v">bool to convert to bool3x4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3x4(bool v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }


        /// <summary>Implicitly converts a single bool value to a bool3x4 matrix by assigning it to every component.</summary>
        /// <param name="v">bool to convert to bool3x4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool3x4(bool v) { return new bool3x4(v); }


        /// <summary>Returns the result of a componentwise equality operation on two bool3x4 matrices.</summary>
        /// <param name="lhs">Left hand side bool3x4 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side bool3x4 to use to compute componentwise equality.</param>
        /// <returns>bool3x4 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (bool3x4 lhs, bool3x4 rhs) { return new bool3x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }

        /// <summary>Returns the result of a componentwise equality operation on a bool3x4 matrix and a bool value.</summary>
        /// <param name="lhs">Left hand side bool3x4 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise equality.</param>
        /// <returns>bool3x4 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (bool3x4 lhs, bool rhs) { return new bool3x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a bool3x4 matrix.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side bool3x4 to use to compute componentwise equality.</param>
        /// <returns>bool3x4 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (bool lhs, bool3x4 rhs) { return new bool3x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }


        /// <summary>Returns the result of a componentwise not equal operation on two bool3x4 matrices.</summary>
        /// <param name="lhs">Left hand side bool3x4 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side bool3x4 to use to compute componentwise not equal.</param>
        /// <returns>bool3x4 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (bool3x4 lhs, bool3x4 rhs) { return new bool3x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }

        /// <summary>Returns the result of a componentwise not equal operation on a bool3x4 matrix and a bool value.</summary>
        /// <param name="lhs">Left hand side bool3x4 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise not equal.</param>
        /// <returns>bool3x4 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (bool3x4 lhs, bool rhs) { return new bool3x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a bool3x4 matrix.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side bool3x4 to use to compute componentwise not equal.</param>
        /// <returns>bool3x4 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (bool lhs, bool3x4 rhs) { return new bool3x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }


        /// <summary>Returns the result of a componentwise not operation on a bool3x4 matrix.</summary>
        /// <param name="val">Value to use when computing the componentwise not.</param>
        /// <returns>bool3x4 result of the componentwise not.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator ! (bool3x4 val) { return new bool3x4 (!val.c0, !val.c1, !val.c2, !val.c3); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two bool3x4 matrices.</summary>
        /// <param name="lhs">Left hand side bool3x4 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side bool3x4 to use to compute componentwise bitwise and.</param>
        /// <returns>bool3x4 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator & (bool3x4 lhs, bool3x4 rhs) { return new bool3x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool3x4 matrix and a bool value.</summary>
        /// <param name="lhs">Left hand side bool3x4 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise bitwise and.</param>
        /// <returns>bool3x4 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator & (bool3x4 lhs, bool rhs) { return new bool3x4 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a bool3x4 matrix.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side bool3x4 to use to compute componentwise bitwise and.</param>
        /// <returns>bool3x4 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator & (bool lhs, bool3x4 rhs) { return new bool3x4 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two bool3x4 matrices.</summary>
        /// <param name="lhs">Left hand side bool3x4 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side bool3x4 to use to compute componentwise bitwise or.</param>
        /// <returns>bool3x4 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator | (bool3x4 lhs, bool3x4 rhs) { return new bool3x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool3x4 matrix and a bool value.</summary>
        /// <param name="lhs">Left hand side bool3x4 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise bitwise or.</param>
        /// <returns>bool3x4 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator | (bool3x4 lhs, bool rhs) { return new bool3x4 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a bool3x4 matrix.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side bool3x4 to use to compute componentwise bitwise or.</param>
        /// <returns>bool3x4 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator | (bool lhs, bool3x4 rhs) { return new bool3x4 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two bool3x4 matrices.</summary>
        /// <param name="lhs">Left hand side bool3x4 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side bool3x4 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>bool3x4 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator ^ (bool3x4 lhs, bool3x4 rhs) { return new bool3x4 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool3x4 matrix and a bool value.</summary>
        /// <param name="lhs">Left hand side bool3x4 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>bool3x4 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator ^ (bool3x4 lhs, bool rhs) { return new bool3x4 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a bool3x4 matrix.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side bool3x4 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>bool3x4 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator ^ (bool lhs, bool3x4 rhs) { return new bool3x4 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3); }



        /// <summary>Returns the bool3 element at a specified index.</summary>
        unsafe public ref bool3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (bool3x4* array = &this) { return ref ((bool3*)array)[index]; }
            }
        }

        /// <summary>Returns true if the bool3x4 is equal to a given bool3x4, false otherwise.</summary>
        /// <param name="rhs">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(bool3x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }

        /// <summary>Returns true if the bool3x4 is equal to a given bool3x4, false otherwise.</summary>
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) { return o is bool3x4 converted && Equals(converted); }


        /// <summary>Returns a hash code for the bool3x4.</summary>
        /// <returns>The computed hash code.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the bool3x4.</summary>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("bool3x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y, c0.z, c1.z, c2.z, c3.z);
        }

    }

    public static partial class math
    {
        /// <summary>Returns a bool3x4 matrix constructed from four bool3 vectors.</summary>
        /// <param name="c0">The matrix column c0 will be set to this value.</param>
        /// <param name="c1">The matrix column c1 will be set to this value.</param>
        /// <param name="c2">The matrix column c2 will be set to this value.</param>
        /// <param name="c3">The matrix column c3 will be set to this value.</param>
        /// <returns>bool3x4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 bool3x4(bool3 c0, bool3 c1, bool3 c2, bool3 c3) { return new bool3x4(c0, c1, c2, c3); }

        /// <summary>Returns a bool3x4 matrix constructed from from 12 bool values given in row-major order.</summary>
        /// <param name="m00">The matrix at row 0, column 0 will be set to this value.</param>
        /// <param name="m01">The matrix at row 0, column 1 will be set to this value.</param>
        /// <param name="m02">The matrix at row 0, column 2 will be set to this value.</param>
        /// <param name="m03">The matrix at row 0, column 3 will be set to this value.</param>
        /// <param name="m10">The matrix at row 1, column 0 will be set to this value.</param>
        /// <param name="m11">The matrix at row 1, column 1 will be set to this value.</param>
        /// <param name="m12">The matrix at row 1, column 2 will be set to this value.</param>
        /// <param name="m13">The matrix at row 1, column 3 will be set to this value.</param>
        /// <param name="m20">The matrix at row 2, column 0 will be set to this value.</param>
        /// <param name="m21">The matrix at row 2, column 1 will be set to this value.</param>
        /// <param name="m22">The matrix at row 2, column 2 will be set to this value.</param>
        /// <param name="m23">The matrix at row 2, column 3 will be set to this value.</param>
        /// <returns>bool3x4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 bool3x4(bool m00, bool m01, bool m02, bool m03,
                                      bool m10, bool m11, bool m12, bool m13,
                                      bool m20, bool m21, bool m22, bool m23)
        {
            return new bool3x4(m00, m01, m02, m03,
                               m10, m11, m12, m13,
                               m20, m21, m22, m23);
        }

        /// <summary>Returns a bool3x4 matrix constructed from a single bool value by assigning it to every component.</summary>
        /// <param name="v">bool to convert to bool3x4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 bool3x4(bool v) { return new bool3x4(v); }

        /// <summary>Return the bool4x3 transpose of a bool3x4 matrix.</summary>
        /// <param name="v">Value to transpose.</param>
        /// <returns>Transposed value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 transpose(bool3x4 v)
        {
            return bool4x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z,
                v.c3.x, v.c3.y, v.c3.z);
        }

        /// <summary>Returns a uint hash code of a bool3x4 matrix.</summary>
        /// <param name="v">Matrix value to hash.</param>
        /// <returns>uint hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(bool3x4 v)
        {
            return csum(select(uint3(0x83B58237u, 0x833E3E29u, 0xA9D919BFu), uint3(0xC3EC1D97u, 0xB8B208C7u, 0x5D3ED947u), v.c0) +
                        select(uint3(0x4473BBB1u, 0xCBA11D5Fu, 0x685835CFu), uint3(0xC3D32AE1u, 0xB966942Fu, 0xFE9856B3u), v.c1) +
                        select(uint3(0xFA3A3285u, 0xAD55999Du, 0xDCDD5341u), uint3(0x94DDD769u, 0xA1E92D39u, 0x4583C801u), v.c2) +
                        select(uint3(0x9536A0F5u, 0xAF816615u, 0x9AF8D62Du), uint3(0xE3600729u, 0x5F17300Du, 0x670D6809u), v.c3));
        }

        /// <summary>
        /// Returns a uint3 vector hash code of a bool3x4 matrix.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Matrix value to hash.</param>
        /// <returns>uint3 hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hashwide(bool3x4 v)
        {
            return (select(uint3(0x7AF32C49u, 0xAE131389u, 0x5D1B165Bu), uint3(0x87096CD7u, 0x4C7F6DD1u, 0x4822A3E9u), v.c0) +
                    select(uint3(0xAAC3C25Du, 0xD21D0945u, 0x88FCAB2Du), uint3(0x614DA60Du, 0x5BA2C50Bu, 0x8C455ACBu), v.c1) +
                    select(uint3(0xCD266C89u, 0xF1852A33u, 0x77E35E77u), uint3(0x863E3729u, 0xE191B035u, 0x68586FAFu), v.c2) +
                    select(uint3(0xD4DFF6D3u, 0xCB634F4Du, 0x9B13B92Du), uint3(0x4ABF0813u, 0x86068063u, 0xD75513F9u), v.c3));
        }

    }
}
