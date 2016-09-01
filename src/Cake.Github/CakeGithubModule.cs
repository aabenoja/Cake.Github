using Cake.Core.Composition;
using Cake.Core.Packaging;

namespace Cake.Github
{
    public class CakeGithubModule : ICakeModule
    {
        public void Register(ICakeContainerRegistry registry)
        {
            registry.RegisterType<GithubPackageInstaller>().As<IPackageInstaller>().Singleton();
        }
    }
}
