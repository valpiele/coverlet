using System.Collections.Generic;
using Coverlet.Core.Helpers;

namespace Coverlet.Core.Abstractions
{
    internal interface ISourceRootTranslator
    {
        string ResolveFilePath(string originalFileName, string modulePath = null);
        IReadOnlyList<SourceRootMapping> ResolvePathRoot(string pathRoot);
    }
}
