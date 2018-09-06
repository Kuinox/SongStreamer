using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace StorageManagement
{
    public interface IFileSystem
    {
        Task Store(Stream file, CancellationToken cancellationToken);
        Task<Stream> Get(string fileLocation);
        Task Remove(string fileLocation);
    }
}
