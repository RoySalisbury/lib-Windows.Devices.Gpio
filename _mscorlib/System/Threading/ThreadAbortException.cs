//
// Copyright (c) 2017 The nanoFramework project contributors
// Portions Copyright (c) Microsoft Corporation.  All rights reserved.
// See LICENSE file in the project root for full license information.
//

namespace System.Threading
{

    using System;

    [Serializable()]
    public sealed class ThreadAbortException : SystemException
    {
        private ThreadAbortException() { }
    }
}


