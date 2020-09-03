using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDDD.Infra.CrossCutting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIoc.Load(builder);
        }
    }
}
