﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Parameters
{
    public class RequestParameters
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public RequestParameters(int pageSize, int pageNumber)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}
