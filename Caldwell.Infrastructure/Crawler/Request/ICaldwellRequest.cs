﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Caldwell.Infrastructure.Crawler.Request
{
    public interface ICaldwellRequest
    {
        string TimeOut { get; set; }
    }
}
