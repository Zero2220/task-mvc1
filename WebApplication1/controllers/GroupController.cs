using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.models;

namespace WebApplication1.controllers
{
    [Route("Groups")]
    public class GroupController:Controller
    {
        [Route("Get")]
        public Group Get(int id,string no)
        {
            return new Group()
            {
                Id = id,
                No = no,
                Limit = 10
            };
        }


        public List<Group> GetAll()
        {
            return new List<Group>();
        }
    }
}
