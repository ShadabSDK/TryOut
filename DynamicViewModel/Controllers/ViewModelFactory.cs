using Autofac;
using DynamicViewModel.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicViewModel.Controllers
{
    public class ViewModelFactory : IViewModelFactory
    {
        private readonly ILifetimeScope _scope;

        public ViewModelFactory(ILifetimeScope scope)
        {
            _scope = scope;
        }

        public IViewModel Create(string typeName, IDictionary<string, string> args)
        {
            return _scope.ResolveNamed<IViewModel>(typeName,args.ToList().Select(Kvp=>new NamedParameter(Kvp.Key,Kvp.Value)).ToArray());
        }
    }
}
