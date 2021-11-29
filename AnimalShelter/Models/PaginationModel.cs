using System.Collections.Generic;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  public class PaginationModel
  {
    public List<Animal> Data { get; set; }
    public int Total { get; set; }
    public int PerPage { get; set; }
    public int Page { get; set; }
    public string PreviousPage { get; set; }
    public string NextPage { get; set; }
  }
}