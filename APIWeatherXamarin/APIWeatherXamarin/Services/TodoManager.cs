using APIWeatherXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FirstApiLesson.Services
{
    public class TodoManager
    {
        IRestService service;

        public TodoManager(IRestService restService)
        {
            service = restService;
        }
        public Task<Rootobject> GetTodoItemModels(string item)
        {
            return service.GetTodoItemAsync(item);
        }
    }
}
