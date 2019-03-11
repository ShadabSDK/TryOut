using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicViewModel.Presentation
{
    public interface IViewModel
    {
    }

    public interface IViewModelGet<TResponse> : IViewModel
    {
        Task<TResponse> GetAsync();
    }

    public interface IViewModelPost<TAction, TResponse> : IViewModel where TAction : class
    {
        Task<TResponse> PostAsync(TAction arg);
    }
}
