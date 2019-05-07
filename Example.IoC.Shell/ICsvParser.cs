using System.Collections.Generic;
using System.IO;

namespace Example.IoC.Shell
{
    public interface ICsvParser
    {
        List<User> ParseUsers(TextReader textReader);
    }
}
