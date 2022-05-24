using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.Base.Exceptions
{
    public class SlugIsDuplicateException : BaseDomainException
    {
        public SlugIsDuplicateException() : base("slug Repeat")
        {
        }

        public SlugIsDuplicateException(string message) : base(message)
        {
        }
    }
}