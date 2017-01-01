namespace vCube.Web.Controllers
{
    using System.Web.Http;

    using vCube.Data;

    public class BaseApiController : ApiController
    {
        public BaseApiController(IvCubeData data)
        {
            this.Data = data;
        }

        protected IvCubeData Data { get; private set; }
    }
}