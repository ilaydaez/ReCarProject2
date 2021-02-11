using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult: Result
    {
        public ErrorResult(string massage) : base(false, massage)
        {

        }
        public ErrorResult() : base(false)
        {

        }
    }
}
