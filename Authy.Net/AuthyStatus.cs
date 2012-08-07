﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authy.Net
{
    /// <summary>
    /// The status of an authy call 
    /// </summary>
    public enum AuthyStatus
    {
        Success,
        InvalidApiKey,
        InvalidToken,
        InvalidUser,
        InvalidEmail,
        InvalidPhoneNumber,
        ServiceUnavailable,
    }
}
