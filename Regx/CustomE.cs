using System;
using System.Collections.Generic;
using System.Text;

namespace Regx
{
    public class CustomE : Exception
    {
        public enum Errors
        {
            InvalidName,
            NullString,
            EmptyString,
            MinLength,
            InvalidNumber,
            InvalidEmail,
            InvalidPassword
        }
        Errors errors;
        public CustomE(Errors errors, String massege) : base(massege)
        {
            this.errors = errors;
        }
    }
}
