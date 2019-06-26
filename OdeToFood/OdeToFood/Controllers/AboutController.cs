using System;
using Microsoft.AspNetCore.Mvc;
namespace OdeToFood.Controllers
{
    // use brackets so you can just change the class
    // name without changing this field
    [Route("[controller]")]
    public class AboutController
    {
        // default action for controller
        [Route("")]
        public string Phone()
        {
            return "1+555+555+555";
        }

        [Route("[action]")]
        public string Address()
        {
            return "UTSA";
        }
    }
}
