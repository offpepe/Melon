﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Melon.Properties {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Melon.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a {
        ///    &quot;presets&quot;: [&quot;@babel/preset-env&quot;]
        ///}.
        /// </summary>
        internal static string NewProjectJsBabelRc {
            get {
                return ResourceManager.GetString("NewProjectJsBabelRc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a console.log(&quot;Hello world&quot;);.
        /// </summary>
        internal static string NewProjectJsIndex {
            get {
                return ResourceManager.GetString("NewProjectJsIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a {
        ///  &quot;scripts&quot;: {
        ///    &quot;dev&quot;: &quot;babel ./src/ --out-dir ./babel &amp;&amp; webpack ./babel/index.js --config ./webpack.config.development.js &amp;&amp; npx melon load ./dist/main.js&quot;,
        ///    &quot;build&quot;: &quot;babel ./src/ --out-dir ./babel &amp;&amp; webpack ./babel/index.js --config ./webpack.config.production.js&quot;,
        ///    &quot;go&quot;: &quot;npx melon load ./dist/main.js&quot;
        ///  },
        ///  &quot;devDependencies&quot;: {
        ///    &quot;@babel/cli&quot;: &quot;latest&quot;,
        ///    &quot;@babel/core&quot;: &quot;latest&quot;,
        ///    &quot;@babel/preset-env&quot;: &quot;latest&quot;,
        ///    &quot;webpack-cli&quot;: &quot;latest&quot;
        ///  }
        ///}.
        /// </summary>
        internal static string NewProjectJsPackageInfo {
            get {
                return ResourceManager.GetString("NewProjectJsPackageInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a {
        ///    &quot;presets&quot;: [&quot;@babel/preset-typescript&quot;, &quot;@babel/preset-env&quot;]
        ///}.
        /// </summary>
        internal static string NewProjectTsBabelRc {
            get {
                return ResourceManager.GetString("NewProjectTsBabelRc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a {
        ///    &quot;compilerOptions&quot;: {
        ///      &quot;outDir&quot;: &quot;build&quot;,
        ///      &quot;types&quot;: [
        ///        &quot;melon-types&quot;
        ///      ],
        ///      &quot;lib&quot;: [ &quot;es2022&quot; ]
        ///    }
        ///}.
        /// </summary>
        internal static string NewProjectTsconfig {
            get {
                return ResourceManager.GetString("NewProjectTsconfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a # Logs
        ///logs
        ///*.log
        ///npm-debug.log*
        ///yarn-debug.log*
        ///yarn-error.log*
        ///lerna-debug.log*
        ///.pnpm-debug.log*
        ///
        ///# Diagnostic reports (https://nodejs.org/api/report.html)
        ///report.[0-9]*.[0-9]*.[0-9]*.[0-9]*.json
        ///
        ///# Runtime data
        ///pids
        ///*.pid
        ///*.seed
        ///*.pid.lock
        ///
        ///# Directory for instrumented libs generated by jscoverage/JSCover
        ///lib-cov
        ///
        ///# Coverage directory used by tools like istanbul
        ///coverage
        ///*.lcov
        ///
        ///# nyc test coverage
        ///.nyc_output
        ///
        ///# Grunt intermediate storage (https://gruntjs.com/creating-plugins [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string NewProjectTsGitIgnore {
            get {
                return ResourceManager.GetString("NewProjectTsGitIgnore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a console.log(&quot;Hello world&quot;);.
        /// </summary>
        internal static string NewProjectTsIndex {
            get {
                return ResourceManager.GetString("NewProjectTsIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a {
        ///    &quot;scripts&quot;: {
        ///      &quot;dev&quot;: &quot;babel --extensions .ts ./src/ --out-dir ./babel &amp;&amp; webpack ./babel/index.js --config ./webpack.config.development.js &amp;&amp; npx melon load ./dist/main.js&quot;,
        ///      &quot;build&quot;: &quot;babel --extensions .ts ./src/ --out-dir ./babel &amp;&amp; webpack ./babel/index.js --config ./webpack.config.production.js&quot;,
        ///      &quot;go&quot;: &quot;npx melon load ./dist/main.js&quot;
        ///    },
        ///    &quot;devDependencies&quot;: {
        ///      &quot;@babel/cli&quot;: &quot;latest&quot;,
        ///      &quot;@babel/core&quot;: &quot;latest&quot;,
        ///      &quot;@babel/preset-env&quot;: &quot;latest&quot;,
        ///      &quot;@b [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string NewProjectTsPackageInfo {
            get {
                return ResourceManager.GetString("NewProjectTsPackageInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a module.exports = {
        ///  mode: &apos;development&apos;
        ///};.
        /// </summary>
        internal static string NewProjectWebpackConfigDevelopment {
            get {
                return ResourceManager.GetString("NewProjectWebpackConfigDevelopment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a module.exports = {
        ///  mode: &apos;production&apos;
        ///};.
        /// </summary>
        internal static string NewProjectWebpackConfigProduction {
            get {
                return ResourceManager.GetString("NewProjectWebpackConfigProduction", resourceCulture);
            }
        }
    }
}
