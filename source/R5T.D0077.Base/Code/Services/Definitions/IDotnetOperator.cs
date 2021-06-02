using System;
using System.Threading.Tasks;


namespace R5T.D0077
{
    public interface IDotnetOperator
    {
        Task Execute(string command);
    }
}
