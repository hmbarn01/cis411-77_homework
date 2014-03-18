using System.Web;
using System.Web.Mvc;

namespace PetStore.Controllers
{
    public class InventoryController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}