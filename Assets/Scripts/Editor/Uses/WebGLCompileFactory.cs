using UnityEditor;
using UnityEngine;

namespace Compiles
{
    public class WebGLCompileFactory : ICompileFactory
    {
        private readonly ICompileFactory factory;

        public WebGLCompileFactory()
        {
            factory = new SimpleCompileFactory(BuildTarget.WebGL);
        }

        public void Compile(string path, BuildOptions buildOptions)
        {
            //EDITOR?
            factory.Compile(path, buildOptions);
        }

    }

}