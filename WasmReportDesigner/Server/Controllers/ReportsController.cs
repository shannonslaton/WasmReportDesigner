using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telerik.Reporting.Services;
using Telerik.Reporting.Services.AspNetCore;

namespace WasmReportDesigner.Server.Controllers
{
    [Route("api/reports")]
    public class ReportsController : ReportsControllerBase
    {
        ReportServiceConfiguration reportServiceConfiguration;
        public ReportsController(IReportServiceConfiguration reportServiceConfiguration)
            : base(reportServiceConfiguration)
        {
        }


    }
}
