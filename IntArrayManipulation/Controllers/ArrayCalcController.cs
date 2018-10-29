using IntArrayManipulation.Operations;
using Microsoft.AspNetCore.Mvc;

namespace IntArrayManipulation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrayCalcController : ControllerBase
    {
        // GET api/ArrayCalc/Reverse
        [HttpGet]
        [Route("[action]")]
        public ActionResult<string> Reverse(int[] productIds)
        {
            if (productIds == null)
                return Content("");
            ArrayManipService.Reverse(productIds);
            return Content(string.Format("[{0}]", string.Join(",", productIds)));
        }

        // GET api/ArrayCalc/DeletePart
        [HttpGet]
        [Route("[action]")]
        public ActionResult<string> DeletePart(int position, int[] productIds)
        {
            //since the position provided is 1-based, use (position - 1) for 0-based arrays
            var deleted = ArrayManipService.DeletePart(productIds, position - 1);
            if (deleted == null)
                return Content("");
            return Content(string.Format("[{0}]", string.Join(",", deleted)));
        }
    }
}
