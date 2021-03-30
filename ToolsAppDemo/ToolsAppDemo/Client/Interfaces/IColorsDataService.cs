using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolsAppDemo.Shared;

namespace ToolsAppDemo.Client.Interfaces
{
  public interface IColorsDataService
  {
    Task<IEnumerable<Color>> All();
    Task AddColor(Color color);
  }
}
