// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace VisualObjects.Web.Controllers
{
    using System.IO;

    using Microsoft.AspNetCore.Mvc;

    using VisualObjects.Common;
    

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IVisualObjectsBox objectBox;

        public ValuesController(IVisualObjectsBox objectBox)
        {
            this.objectBox = objectBox;
        }

        // GET api/values/getjson
        [HttpGet("{id}")]
        public string getjson()
        {
            return this.objectBox.GetJson();
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromQuery]string id)
        {
            var host = this.HttpContext.Request.Host;
            var req = this.HttpContext.Request;
            var jsonData = string.Empty;

            using (StreamReader reader = new StreamReader(req.Body))
            {
                jsonData = reader.ReadToEnd();
            }

            this.objectBox.SetObject(id, jsonData);
            return Ok();
        }
    }
}
