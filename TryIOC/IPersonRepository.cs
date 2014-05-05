using System;
namespace TryIOC
{
    public interface IPersonRepository
    {
        Person GetItem(int id);
    }
}
