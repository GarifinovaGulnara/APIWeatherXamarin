using APIWeatherXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FirstApiLesson.Services
{
    public interface IRestService
    {
        Task<Rootobject> GetTodoItemAsync(string item);
    }
}
