// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// ReSharper disable once CheckNamespace
namespace System.Runtime.CompilerServices
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    //TODO: Move this to https://github.com/nanoframework/nanoFramework.System.Runtime
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    public sealed class CallerMemberNameAttribute : Attribute
    {
        public CallerMemberNameAttribute()
        {
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}