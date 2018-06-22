using System.Collections.Generic;
using System.Linq;

namespace CarBMW
{
  public class SorterByModel
  {
    public List<Car> SortByDescendingNumberModels(List<Car> list)
    {
      var sortedNumberModelList = list.OrderByDescending(model => model.ModelNumber);
      return sortedNumberModelList.ToList();
    }
  }
}