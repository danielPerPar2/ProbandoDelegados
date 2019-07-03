﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using FacturasGridView;

namespace FacturasGridViewTests
{
    public class FacturaRepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FacturaRepository>().As<IRepository>();
        }
    }
}
