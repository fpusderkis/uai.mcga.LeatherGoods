﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using ASF.Entities;
using ASF.Services.Contracts;
using ASF.UI.Process;

namespace ASF.UI.Process
{
    public class CategoryProcess : ProcessComponent
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Category> SelectList()
        {
            var response = HttpGet<AllResponse>("rest/Category/All", new Dictionary<string, object>(), MediaType.Json);
            return response.Result;
        }

        public Category GetCategory(int id)
        {
            var resp = HttpGet<AllResponse>("rest/Category/Find/" + id, new Dictionary<string, object>(),MediaType.Json);

            return resp.Result[0];

        }


        public void SaveCategory(Category category)
        {

        }

        public void DeleteCategory(int id)
        {
            var resp = HttpDelete("rest/Category/Remove/" + id);

            var test = resp != null;
            
        }
    }
}