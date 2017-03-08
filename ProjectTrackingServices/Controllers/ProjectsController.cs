using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ProjectTracking.Domain.Interfaces.Repositories;
using ProjectTrackingServices.Entities;

namespace ProjectTrackingServices.Controllers
{

    [EnableCors(origins: "http://localhost:57680", headers: "*", methods: "*")]
    public class ProjectsController : ApiController
    {
        private readonly IProjectRepository _repository;

        public ProjectsController(IProjectRepository repository)
        {
            _repository = repository;
        }

        // GET api/projects
        [Route("api/projects")]
        public HttpResponseMessage Get()
        {
            var projects = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, projects);
            return response;
        }

        // GET api/projects/5
        [Route("api/projects/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var projects = _repository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, projects);
            return response;
        }

        [Route("api/projects/{name:alpha}")]
        public HttpResponseMessage Get(string name)
        {
            var projects = _repository.FindByName(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, projects);
            return response;
        }

        // POST api/projects
         [Route("api/projects")]
        public HttpResponseMessage Post(Project project)
        {
            _repository.Insert(project);
            var projects = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, projects);
            return response;
        }

        // PUT api/projects/5
        [Route("api/projects")]
         public HttpResponseMessage Put(Project project)
        {
            _repository.Update(project);
            var projects = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, projects);
            return response;
        }

        // DELETE api/projects/5
        [Route("api/employees")]
        public HttpResponseMessage Delete(Project project)
        {
            _repository.Delete(project);
            var projects = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, projects);
            return response;
        }
    }
}
