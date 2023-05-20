﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T> 
    {
        public ErrorDataResult(T data, string message) : base(data, false, message) //işlem mesajını default true verdik
        {

        }
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        public ErrorDataResult(string message) : base(default, false, message) //default demek data'ya karşılık geliyor.
        {

        }
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
