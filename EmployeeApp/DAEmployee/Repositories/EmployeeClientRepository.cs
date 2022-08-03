using Core.Interfaces.DL;
using Core.Interfaces.DTO;
using Core.Model.Entity;
using DL.Data;
using DL.DTO;
using DL.Repositories;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;


namespace Data.Repositories
{
    public class EmployeeClientRepository : BaseRepository<Employee>, IEmployeeClientRepository
    {
        IConfiguration configuration;
        public EmployeeClientRepository(EmployeeDbContext context, IConfiguration _configuration) : base(context)
        {
            configuration = _configuration;
        }

        public List<IEmployeeDTO> GetEmployeeList()
        {
            try
            {
                List<EmployeeDTO> jsonResult;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(configuration.GetSection("EmployeeApiUrl").Value);
                //request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    jsonResult = JsonConvert.DeserializeObject<List<EmployeeDTO>>(reader.ReadToEnd());
                }
                return jsonResult.Cast<IEmployeeDTO>().ToList();
            }
            catch (Exception ex)
            {
                // Log exception
                ex.Data.Add("EmployeeClientRepository", "GetEmployeeList()");
                throw ex;
            }
        }
    }
}
