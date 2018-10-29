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
            var deleted = ArrayManipService.DeletePart(productIds, position);
            if (deleted == null)
                return Content("");
            return Content(string.Format("[{0}]", string.Join(",", deleted)));
        }
    }
}
