using System;

namespace Assignment6.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        EmpContext Get();
    }
}