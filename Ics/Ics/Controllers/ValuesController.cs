using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Ical.Net;
using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;
using Ics.Calendar;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Repository.SqlRepository;

namespace Ics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ISqlQuery _sqlQuery { get; set; }
        private readonly IMapper _mapper;

        public ValuesController(ISqlQuery sqlQuery, IMapper mapper)
        {
            _sqlQuery = sqlQuery;
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("ics")]
        public IActionResult GetIcs()
        {
            var matchPocos = _sqlQuery.ListOfMatches(new DateTime(2020,01,01));

            if (matchPocos != null && matchPocos.Any())
            {
                matchPocos = matchPocos.ToList();

            }

            IEnumerable<CalendarItem> calendarItems = _mapper.Map<IEnumerable<CalendarItem>>(matchPocos);
            IEnumerable<CalendarEvent> calendarEvent = _mapper.Map<IEnumerable<CalendarEvent>>(calendarItems);

            var provider = new FileExtensionContentTypeProvider();
            //provider.Mappings.Add(".ics", "application/dotnetcoretutorials");
            string contentType;

            var cal = new CalendarWrapper();

            cal.AddRange(calendarEvent);

            var stream = new MemoryStream(Encoding.ASCII.GetBytes(cal.Get));

            if (!provider.TryGetContentType("test.ics", out contentType))
            {
                contentType = "text/calendar";
            }
            return File(stream, contentType);

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
