using System;

namespace Interface_CustomerInfo
{
    public interface ICustomerInfo
    {
        void Init(string username, string password);
        bool ExecuteSelectCommand(string selCommand);
        string GetRow();
    }
}
