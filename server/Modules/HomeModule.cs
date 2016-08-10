using Nancy;

namespace anemone.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Hello from Nancy!!!");
        }
    }
}

