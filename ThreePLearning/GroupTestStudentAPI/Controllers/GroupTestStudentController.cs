using GroupTestStudentAPI.Extensions;
using GroupTestStudentAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GroupTestStudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupTestStudentController : ControllerBase
    {
        private readonly IGroupingService _groupingService;
        private readonly IFormattingService _formattingService;

        public GroupTestStudentController(IGroupingService groupingService, IFormattingService formattingService)
        {
            _groupingService = groupingService ?? throw new ArgumentNullException(nameof(groupingService));
            _formattingService = formattingService ?? throw new ArgumentNullException(nameof(formattingService));
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            // get post string from Request
            string rawString = await Request.GetRawBodyStringAsync();

            // convert string to timeMarksMatrix
            string[,] matrix = rawString.ToTimeMarksMatrix();

            // extract groups from timeMarksMatrix
            var groups = _groupingService.GroupingStudents(matrix);

            // format groups as response
            var response = _formattingService.Format(groups);

            // return
            return Ok(response);
        }
    }
}
