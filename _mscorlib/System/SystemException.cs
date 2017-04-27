////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////namespace System
namespace System
{

    using System;
    [Serializable()]
    public class SystemException : Exception
    {
        public SystemException()
            : base()
        {
        }

        public SystemException(String message)
            : base(message)
        {
        }

        public SystemException(String message, Exception innerException)
            : base(message, innerException)
        {
        }

    }
}
