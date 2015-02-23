using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;
using CricketersWebApi.DAL;
using CricketersWebApi.Models;
using WebApplication3.DAL;

namespace WebApplication3.Controllers
{
    public class BaseApiController :ApiController
    {
        private IModelFactory _modelFactory;
        private readonly IStatsService _service;

        public BaseApiController(IStatsService statsService)
        {
            _service = statsService;
        }

        protected IModelFactory ModelFactory
        {
            get { if(_modelFactory == null)
                _modelFactory = new ModelFactory(Request);
                
               return _modelFactory; }
        }

        protected IStatsService StatsService
        {
            get { return _service; }
        }

    }
}
