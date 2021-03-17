using PortfolioCategorize_WinForm.Model;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioCategorize_WinForm.Control
{
    class PortfolioCategorizer
    {
        public CategoryCollection Categories { get; set; }

        public List<string> Categorize(List<ITrade> portfolio)
        {
            List<string> ret = new List<string>();

            foreach (ITrade trade in portfolio)
            {
                Category category = Categories?.FirstOrDefault(item => item.ClientSector.ToLower() == trade.ClientSector.ToLower()
                                                                    && item.MaximumValue >= trade.Value
                                                                    && item.MinimumValue <= trade.Value);
                
                ret.Add(category == null ? "Undefined" : category.Name);
            }

            return ret;
        }
    }
}
