using Identity.Domain.Base.Exceptions;
using Identity.Domain.Base.Utils;

namespace Identity.Domain.Base.ValueObjects;

public class PhoneNumber : ValueObject
{
    public PhoneNumber(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.IsText() || value.Length is < 11 or > 11)
            throw new InvalidDomainDataException("Invalid phone");
        Value = value;
    }

    public string Value { get; private set; }
}