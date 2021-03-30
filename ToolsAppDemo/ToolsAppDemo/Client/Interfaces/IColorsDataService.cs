using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolsAppDemo.Shared;

namespace ToolsAppDemo.Client.Interfaces
{
  public interface IColorsDataService
  {
    IEnumerable<Color> Colors { get; }
    Task AddColor(Color color);
  }
}
