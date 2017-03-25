using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ProjectTracking.Domain.Interfaces.Repositories;
using ProjectTrackingServices.Entities;

namespace ProjectTrackingServices.Controllers
{
    [EnableCors(origins: "http://localhost:57680", headers: "*", methods: "*")]
    public class ManagerCommentsController : ApiController
    {
        private readonly IManagerCommentRepository _repository;

        public ManagerCommentsController(IManagerCommentRepository repository)
        {
            _repository = repository;
        }

        // GET api/managercomments
        [Route("api/managercomments")]
        public HttpResponseMessage Get()
        {
            var managerComments = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, managerComments);
            return response;
        }

        // GET api/managercomments/5
        [Route("api/managercomments/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var managerComments = _repository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, managerComments);
            return response;
        }

        
        // POST api/managercomments
        [Route("api/managercomments")]
        public HttpResponseMessage Post(ManagerComment managerComment)
        {
            _repository.Insert(managerComment);
            var managerComments = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, managerComments);
            return response;
        }

        // PUT api/managercomments/5
        [Route("api/managercomments/{id}")]
        public HttpResponseMessage Put(ManagerComment managerComment)
        {
            _repository.Update(managerComment);
            var managerComments = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, managerComments);
            return response;
        }

        // DELETE api/managercomments/5
        [Route("api/managercomments/{id}")]
        public HttpResponseMessage Delete(ManagerComment managerComment)
        {
            _repository.Delete(managerComment);
            var managerComments = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, managerComments);
            return response;
        }
    }
}
