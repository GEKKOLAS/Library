using System;
using System.Collections.Generic;
using Core.Models;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class ListService : IListService
{
    private readonly LibraryDbContext _context;

    public  ListService(LibraryDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<SelectListItem>> GetListAuthors()
    {
        List<SelectListItem> list = await _context.Authors.Select(a => new SelectListItem
        {
            Value = a.Id.ToString(),
            Text = a.Name
        })
        .OrderBy(a => a.Text).ToListAsync();

        list.Insert(0, new SelectListItem
        {
            Value = "0",
            Text = "Select Author"
        });
        return list;
    }

    public async Task<IEnumerable<SelectListItem>> GetListUserGallery(int id)
    {
        List<SelectListItem> list = await _context.Authors.Select(a => new SelectListItem
        {
            Value = a.Id.ToString(),
            Text = a.Name
        })
        .OrderBy(a => a.Text).ToListAsync();

        list.Insert(0, new SelectListItem
        {
            Value = "0",
            Text = "Select Books"
        });
        return list;
    }
}

