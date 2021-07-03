using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BapBlazor.Contracts
{
    public interface IAppManager
    {
        Task<int> Create(StoreApp app);
        Task<int> Delete(int Id);
        Task<int> Update(StoreApp app);
        Task<StoreApp> GetById(int Id);
        Task<List<StoreApp>> ListAll();
    }
}
