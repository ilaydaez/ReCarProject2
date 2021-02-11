using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T>: DataResult<T>
    {
        public ErrorDataResult(T data, string massage) : base(data, false, massage)
        {

        }
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        public ErrorDataResult(string massage) : base(default, false, massage)
        {

        }
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
