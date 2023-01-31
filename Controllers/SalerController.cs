using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using trilha_tech_test_api_tech.Context;

namespace trilha_tech_test_api_tech.Controllers
{
    public class SalerController: ControllerBase
    {
        private readonly SalerContext Context;

        public SalerController(SalerContext context)
        {
            Context = context;
        }
    }
}
