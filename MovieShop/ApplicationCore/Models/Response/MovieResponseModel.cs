using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response
{
    public class MovieResponseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Budget { get; set; }
    }
}
