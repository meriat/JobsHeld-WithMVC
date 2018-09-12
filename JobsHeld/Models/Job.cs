
using System;
using System.Collections.Generic;
// using JobsHeld.Models;

namespace JobsHeld.Models
{
  public class Job
  {
    public string company {get; set;}
    public string position {get; set;}
    public string startDate {get; set;}
    public string endDate {get; set;}
    public string description {get; set;}
    public int id {get;}
    private static List<Job> _instances = new List<Job> {};

    public Job (string newCompany, string newPosition, string newStartDate, string newEndDate, string newDescription)
    {
      company = newCompany;
      position = newPosition;
      startDate = newStartDate;
      endDate = newEndDate;
      description = newDescription;
      _instances.Add(this);
      id = _instances.Count;
    }
    public static void Delete(Job newJob)
    {
      _instances.Remove(newJob);
    }
    public static Job Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static List<Job> GetAll()
    {
      return _instances;
    }
  }
}
