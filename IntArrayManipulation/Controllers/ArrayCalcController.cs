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

            //The array is reversed in place
            ArrayManipService.Reverse(productIds);

            //Format as string
            return Content(string.Format("[{0}]", string.Join(",", productIds)));
        }

        // GET api/ArrayCalc/DeletePart
        [HttpGet]
        [Route("[action]")]
        public ActionResult<string> DeletePart(uint position, int[] productIds)
        {
            //since the position provided is 1-based, use (position - 1) for 0-based arrays
            if (position == 0)
                return Content("");              
            var deleted = ArrayManipService.DeletePart(productIds, position - 1);

            if (deleted == null)
                return Content("");

            //Format as string
            return Content(string.Format("[{0}]", string.Join(",", deleted)));
        }
    }
}
