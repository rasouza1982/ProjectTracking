﻿using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ProjectTracking.Domain.Interfaces.Repositories;
using ProjectTrackingServices.Entities;

namespace ProjectTrackingServices.Controllers
{
    [EnableCors(origins: "http://localhost:57680", headers: "*", methods: "*")]
    public class ProjectTasksController : ApiController
    {
        private readonly IProjectTaskRepository _repository;

        public ProjectTasksController(IProjectTaskRepository repository) 
        {
            _repository = repository;
        }

        // GET api/projecttasks
        [Route("api/projecttasks")]
        public HttpResponseMessage Get()
        {
            var projectTasks = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, projectTasks);
            return response;
        }

        // GET api/projecttasks/5
        [Route("api/projecttasks/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var projectTasks = _repository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, projectTasks);
            return response;
        }

        // POST api/projecttasks
        [Route("api/projecttasks")]
        public HttpResponseMessage Post(ProjectTask projectTask)
        {
            _repository.Insert(projectTask);
            var projectTasks = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, projectTasks);
            return response;
        }

        [Route("api/projecttasks")]
        public HttpResponseMessage Put(ProjectTask projectTask)
        {
            _repository.Update(projectTask);
            var projectTasks = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, projectTasks);
            return response;
        }

        [Route("api/projecttasks")]
        public HttpResponseMessage Delete(ProjectTask projectTask)
        {
            _repository.Delete(projectTask);
            var projectTasks = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, projectTasks);
            return response;
        }
    }
}
