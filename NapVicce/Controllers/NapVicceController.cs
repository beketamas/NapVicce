using Microsoft.AspNetCore.Mvc;

namespace NapVicce.Controllers
{
    public class NapVicceController : Controller
    {
        Dictionary<string, string> viccikek = new Dictionary<string, string>()
        {
            {"Monday" , "xd"} ,
            {"Tuseday", "lol"} ,
            {"Wednesday", "why"} ,
            {"Thursday", "kekw"} ,
            {"Friday", "ok"} ,
            {"Saturday", "no"} ,
            {"Sunday", "yes"} 
        };
        string date = DateTime.Now.DayOfWeek.ToString();
        [HttpGet]
        [Route("[controller]")]

        public String Get() => $"{viccikek.Where(x => x.Key == date).First().Key} : {viccikek.Where(x => x.Key == date).First().Value}";
    }
}
