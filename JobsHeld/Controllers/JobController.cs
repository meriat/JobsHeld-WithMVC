using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobsHeld.Models;

namespace JobsHeld.Controllers
{
  public class JobsController : Controller
  {
    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<Job> allJobs = Job.GetAll();
      return View(allJobs);
    }

    [HttpGet("/jobs/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/jobs")]
    public ActionResult Create()
    {
      Job newJob = new Job(Request.Form["new-company"], Request.Form["new-position"], Request.Form["new-startDate"],Request.Form["new-endDate"],Request.Form["new-description"]);
      List<Job> allJobs = Job.GetAll();
      return View("Index",allJobs);
    }

    [HttpGet("/jobs/{id}")]
    public ActionResult Details(int id)
    {
      Job job = Job.Find(id);
      return View(job);
    }

    [HttpGet("/jobs/delete/{companyToBeDeleted}")]
    public ActionResult Delete(string companyToBeDeleted)
    {
      return View(companyToBeDeleted);
    }

    [HttpPost("/jobs/delete/{id}")]
    public ActionResult DeleteJob(int id)
    {
      Job newJob = Job.Find(id);
      string companyToBeDeleted = newJob.company;
      Job.Delete(newJob);
      return View("Delete", companyToBeDeleted);
    }

  }
}
