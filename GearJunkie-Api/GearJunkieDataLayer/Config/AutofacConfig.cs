using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace GearJunkie.DataLayer.Config
{
    public class AutofacConfig : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(this.ThisAssembly).Where(x => x.Name.EndsWith("DataLayer"))
                .AsImplementedInterfaces().InstancePerDependency();
        }
    }
}
