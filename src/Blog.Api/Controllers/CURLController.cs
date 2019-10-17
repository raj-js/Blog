using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    public abstract class CURLController<TEntity, TKEY, TCreateDTO, TUpdateDTO, TDTO> : ControllerBase
    {

    }
}