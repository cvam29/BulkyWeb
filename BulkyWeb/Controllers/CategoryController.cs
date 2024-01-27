using Bulky.DataAccess.Repository.Interfaces;
using Bulky.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers;
[Authorize]
public class CategoryController(IUnitOfWork _unitOfWork) : Controller
{
    public  IActionResult Index()
    {
        var categoryList = _unitOfWork.CategoryRepository.GetAll().ToList();
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
            _unitOfWork.CategoryRepository.Add(category);
            _unitOfWork.Save();
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
        Category? category = _unitOfWork.CategoryRepository.Get(c => c.Id == id);
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
            _unitOfWork.CategoryRepository.Update(category);
            _unitOfWork.Save();
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
        Category? category = _unitOfWork.CategoryRepository.Get( cat => cat.Id == id);
        if (category == null)
        {
            return NotFound();
        }

        _unitOfWork.CategoryRepository.Remove(category);
        _unitOfWork.Save();
        TempData["Success"] = " Catgory Deleted SuccessFully!";

        return RedirectToAction("Index");

    }
}
