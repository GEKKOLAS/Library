using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infrastructure.Services;

public interface IListService
{
    Task<IEnumerable<SelectListItem>> GetListAuthors();
    Task<IEnumerable<SelectListItem>> GetListUserGallery(int id);

}
