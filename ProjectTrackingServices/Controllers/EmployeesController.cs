﻿using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjectTracking.Infra.Data.Repository;
using ProjectTrackingServices.Entities;


namespace ProjectTrackingServices.Controllers
{
    //[EnableCors(origins: "http://localhost:57680", headers: "*", methods: "*")]
    public class EmployeesController : ApiController
    {
        private readonly EmployeeRepository _repository;

        public EmployeesController(EmployeeRepository repository)
        {
            _repository = repository;
        }

        // GET api/ptemployees
        [Route("api/employees")]
        public HttpResponseMessage Get()
        {
            var employees = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }

        // GET api/ptemployees/5
        [Route("api/employees/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var employees = _repository.Get(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }

        [Route("api/employees/{name:alpha}")]
        public HttpResponseMessage Get(string name)
        {
            var employees = _repository.FindByName(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }

        // POST api/ptemployees
        [Route("api/employees")]
        public HttpResponseMessage Post(Employee employee)
        {
            _repository.Insert(employee);
            var employees = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }

        [Route("api/employees")]
        public HttpResponseMessage Put(Employee employee)
        {
            _repository.Update(employee);
            var employees = _repository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }

        // DELETE api/ptemployees/5
        [Route("api/employees")]
        public HttpResponseMessage Delete(Employee employee)
        {
            var employees = _repository.Delete(employee);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, employees);
            return response;
        }
    }
}
