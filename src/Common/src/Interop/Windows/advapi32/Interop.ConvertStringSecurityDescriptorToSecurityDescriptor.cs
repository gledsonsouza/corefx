// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class Advapi32
    {
        [DllImport(Interop.Libraries.Advapi32, CharSet=System.Runtime.InteropServices.CharSet.Auto, SetLastError=true, BestFitMapping=false)]
        internal static extern unsafe bool ConvertStringSecurityDescriptorToSecurityDescriptor(string StringSecurityDescriptor, int StringSDRevision, out SafeLocalMemHandle pSecurityDescriptor, IntPtr SecurityDescriptorSize);
    }
}
