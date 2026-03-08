using System.Collections.Generic;
using Oqtane.Models;
using Oqtane.Modules;
using Oqtane.Shared;

namespace Oqtane.Application.Client.Modules.TestModule
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "TestModule",
            Description = "Test Module",
            Version = "1.0.0",
            PackageName = "Oqtane.Application",
            PageTemplates = new List<PageTemplate>
            {
                new PageTemplate
                {
                    AliasName = "*",
                    Path = "test",
                    Name = "Test",
                    PageTemplateModules = new List<PageTemplateModule>
                    {
                        new PageTemplateModule
                        {
                            Header = null,
                            Title = null,
                            Pane = "Default",
                            ModuleDefinitionName = "Oqtane.Application.Client.Modules.TestModule, Oqtane.Application.Client.Oqtane"
                        }
                    },
                    Update = true,
                    IsNavigation = true
                }
            },
        };
    }
}