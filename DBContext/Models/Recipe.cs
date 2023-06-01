using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContext.Models;
public class Recipe
{
    public string Title { get; set; }
    public List<string> Ingredients { get; set; }
    public string Instructions { get; set; }
    public List<Categories> Category { get; set; }
}
