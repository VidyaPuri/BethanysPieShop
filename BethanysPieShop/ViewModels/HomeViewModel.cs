using BethanysPieShop.Models;
using System.Collections.Generic;

namespace BethanysPieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PieOfTheWeek { get; set; }
    }
}
