using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace GearJunkie.BusinessLayer.Config
{
    public class AutofacConfig : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(this.ThisAssembly).Where(x => x.Name.EndsWith("BusinessLayer"))
                .AsImplementedInterfaces().InstancePerDependency();
        }
    }
}
