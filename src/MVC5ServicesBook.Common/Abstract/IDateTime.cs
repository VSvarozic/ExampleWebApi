using System;

namespace MVC5ServicesBook.Common.Abstract
{
    public interface IDateTime
    {
        DateTime UtcNow { get; }
    }
}
