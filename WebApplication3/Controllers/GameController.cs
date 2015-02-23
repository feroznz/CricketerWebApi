using System;
using System.Linq;
using System.Web.Http;
using CricketersWebApi.DAL;
using CricketersWebApi.Filters;
using CricketersWebApi.Models;
using WebApplication3.Controllers;

namespace CricketersWebApi.Controllers
{
    public class GameController : BaseApiController
    {
        public GameController():
            base(new StatsService())
        {
        }

        public IHttpActionResult Get()
        {
            try
            {
                var gamesEntities = StatsService.Games.Get();
                var models = gamesEntities.Select(ModelFactory.Create);

                return Ok(models);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                var gameEntity = StatsService.Games.Get(id);
                var model = ModelFactory.Create(gameEntity);

                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

       }
}
