using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicViewModel.Presentation
{
    public interface IViewModelFactory
    {
        IViewModel Create(string typeName, IDictionary<string, string> args);
    }
}
