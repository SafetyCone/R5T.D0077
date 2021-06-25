using System;

using R5T.T0021;


namespace R5T.D0077.Configuration
{
    public static class IFileNamesExtension
    {
#pragma warning disable IDE0060 // Remove unused parameter
        
        public static string DotnetSecretsConfiguration(this IFileName fileNames)
        {
            return "Configuration-Dotnet.json";
        }

#pragma warning restore IDE0060 // Remove unused parameter
    }
}
