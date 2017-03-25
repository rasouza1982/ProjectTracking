using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ProjectTracking.Domain.Interfaces.Repositories;
using ProjectTrackingServices.Entities;

namespace ProjectTrackingServices.Controllers
{
    [EnableCors(origins: "http://localhost:57680", headers: "*", methods: "*")]
    public class UserStoryController : ApiController
    {
        private readonly IUserStoryRepository _repository;

        public UserStoryController(IUserStoryRepository repository)
        {
            _repository = repository;
        }

        // GET api/userstory
        [Route("api/userstories")]
        public HttpResponseMessage Get()
        {
            var userStories = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, userStories);
            return response;
        }

        // GET api/userstory/5
        [Route("api/userstories/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var userStories = _repository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, userStories);
            return response;
        }

        [Route("api/userstories/{name:alpha}")]
        public HttpResponseMessage Get(string name)
        {
            var userStories = _repository.FindByName(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, userStories);
            return response;
        }

        // POST api/userstory
        [Route("api/userstories")]
        public HttpResponseMessage Post(UserStory userStory)
        {
            _repository.Insert(userStory);
            var userStories = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, userStories);
            return response;
        }

        [Route("api/userstories/{id}")]
        public HttpResponseMessage Put(UserStory userStory)
        {
            _repository.Update(userStory);
            var userStories = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, userStories);
            return response;
        }

        // DELETE api/userstory/5
        [Route("api/userstories/{id}")]
        public HttpResponseMessage Delete(UserStory userStory)
        {
            _repository.Delete(userStory);
            var userStories = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, userStories);
            return response;
        }
    }
}
