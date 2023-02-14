﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;
using SistemaVenta.DBContext;
//using SistemaVenta.DAL.Implementacion;
//using SistemaVenta.DAL.Interfaces;
//using SistemaVenta.BLL.Implementacion;
//using SistemaVenta.BLL.interfaces;

namespace SistemaVenta.IOC
{
    public static class Dependencia
    {

        public static void InyectarDependencia(this IServiceCollection services, IConfiguration Configuration) {

            services.AddDbContext<DbventaContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("CadenaSQL"));
            });
        
        }
    }
}
