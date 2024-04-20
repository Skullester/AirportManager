using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport;

public class Service
{
    [Key]
    public int id { get; set; }
    [Required]
    public string name { get; set; }
    public Service(string name)
    {
        this.name = name;
    }
}
