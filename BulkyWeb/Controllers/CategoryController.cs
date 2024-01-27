using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers;
[Authorize]
public class CategoryController(ApplicationDbContext _context) : Controller
{
    public  IActionResult Index()
    {
        var categoryList =  _context.Categories.ToList();
        return View(categoryList);
    }

    public IActionResult Create() 
    { 
        return View();
    }

    [HttpPost]
    public IActionResult Create(Category category)
    {
        if(ModelState.IsValid)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            TempData["Success"] = " Catgory Created SuccessFully!";
             return RedirectToAction("Index");
        }
        return View();
    }

    public IActionResult Edit(int id)
    {
        if(id is 0)
        {
            return NotFound();
        }
        Category? category =_context.Categories.Find(id);
        if(category == null)
        {
            return NotFound();
        }
        return View(category);
    }

    [HttpPost]
    public IActionResult Edit(Category category)
    {
        if (ModelState.IsValid)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            TempData["Success"] = " Catgory Updated SuccessFully!";

            return RedirectToAction("Index");
        }
        return View();
    }

    public IActionResult Delete(int id)
    {

        if (id is 0)
        {
            return NotFound();
        }
        Category? category = _context.Categories.Find(id);
        if (category == null)
        {
            return NotFound();
        }

        _context.Categories.Remove(category);
        _context.SaveChanges();
        TempData["Success"] = " Catgory Deleted SuccessFully!";

        return RedirectToAction("Index");

    }
}
