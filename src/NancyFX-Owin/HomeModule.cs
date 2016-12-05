using Nancy;

namespace NancyFX_Owin
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = parameters =>
            {
                return "Hello world!";
            };
        }
    }
}