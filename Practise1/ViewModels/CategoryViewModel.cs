using Practise1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practise1.ViewModels
{
    public class CategoryViewModel
    {
        public Category SelectedCategory { get; set; }
        public List<Category> Categories { get; set; }

    }
}
