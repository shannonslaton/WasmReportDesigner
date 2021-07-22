using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telerik.WebReportDesigner.Services;
using WasmReportDesigner.Server.Data;
using WasmReportDesigner.Shared;

namespace WasmReportDesigner.Server
{
    public class DbDefinitionStorage : IDefinitionStorage
    {
        public string BaseDir => throw new NotImplementedException();

        private readonly WasmReportContext _context;

        public DbDefinitionStorage(IConfiguration configuration)
        {
            var conStringUser = configuration.GetConnectionString("WasmReportsConn");
            var optionsBuilder = new DbContextOptionsBuilder<WasmReportContext>();
            optionsBuilder.UseSqlServer(conStringUser);
            var context = new WasmReportContext(optionsBuilder.Options);

            _context = context;
        }

        /// <summary>
        /// Lists all report definitions.
        /// </summary>
        /// <returns>A list of all report definitions present in the storage.</returns>
        public IEnumerable<string> ListDefinitions()
        {
            // Retrieve all available reports in the database and return their unique identifiers.
            var returnList = new List<string>();
            var foundList = _context.ReportTemplates;
            foreach (var item in foundList)
            {
                returnList.Add(item.ReportTemplateName);
            }
            return returnList;
        }

        /// <summary>
        /// Finds a report definition by its id.
        /// </summary>
        /// <param name="definitionId">The report definition identifier.</param>
        /// <returns>The bytes of the report definition.</returns>
        public byte[] GetDefinition(string definitionId)
        {
            // Retrieve the report definition bytes from the database.

            var returnTemplate = new byte[7000];
            var foundTemplate = _context.ReportTemplates.FirstOrDefault(c => c.ReportTemplateName == definitionId);
            if (foundTemplate != null)
            {
                return foundTemplate.Layout;
            }
            else
            {
                return returnTemplate;
            }
        }

        /// <summary>
        /// Creates new or overwrites an existing report definition with the provided definition bytes.
        /// </summary>
        /// <param name="definitionId">The report definition identifier.</param>
        /// <param name="definition">The new bytes of the report definition.</param>
        public void SaveDefinition(string definitionId, byte[] definition)
        {
            var existing = _context.ReportTemplates.FirstOrDefault(c => c.ReportTemplateName == definitionId);

            if (existing != null)
            {
                existing.Layout = definition;
            }
            else
            {
                // Save the report definiton bytes to the database.
                var saveTemplate = new ReportTemplate()
                {
                    Layout = definition,
                    ReportTemplateName = definitionId,
                    LastModifiedOnDt = DateTime.Now,
                    OwnerContactRecId = 1
                };

                _context.Add(saveTemplate);
            }
            _context.SaveChanges();
        }

        /// <summary>
        /// Deletes an existing report definition.
        /// </summary>
        /// <param name="definitionId">The report definition identifier.</param>
        public void DeleteDefinition(string definitionId)
        {
            // Delete the report definition from the database.
        }
    }
}
