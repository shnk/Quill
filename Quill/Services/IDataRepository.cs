using System.Collections.Generic;

namespace Quill.Services
{
    public interface IDataRepository
    {
        List<string> GetFeatures();
        string GetUserEnteredData();
        void SetUserEnteredData(string data);
    }
}
