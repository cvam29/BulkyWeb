using Bulky.DataAccess;
using Bulky.DataAccess.Repository.Interfaces;
using Bulky.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers;
[Authorize]
public class CategoryController(ICategoryRepository _categoryRepo) : Controller
{
    public  IActionResult Index()
    {
        var categoryList = _categoryRepo.GetAll().ToList();
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
            _categoryRepo.Add(category);
            _categoryRepo.Save();
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
        Category? category = _categoryRepo.Get(c => c.Id == id);
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
            _categoryRepo.Update(category);
            _categoryRepo.Save();
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
        Category? category = _categoryRepo.Get( cat => cat.Id == id);
        if (category == null)
        {
            return NotFound();
        }

        _categoryRepo.Remove(category);
        _categoryRepo.Save();
        TempData["Success"] = " Catgory Deleted SuccessFully!";

        return RedirectToAction("Index");

    }
}
