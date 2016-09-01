using System;
using System.Collections.Generic;
using Cake.Core.IO;
using Cake.Core.Packaging;

namespace Cake.Github
{
    public class GithubPackageInstaller : IPackageInstaller
    {
        public bool CanInstall(PackageReference package, PackageType type)
        {
            if (package == null)
            {
                throw new ArgumentNullException(nameof(package));
            }

            return package.Scheme.Equals("github", StringComparison.OrdinalIgnoreCase);
        }

        public IReadOnlyCollection<IFile> Install(PackageReference package, PackageType type, DirectoryPath path)
        {
            throw new NotImplementedException();
        }
    }
}
