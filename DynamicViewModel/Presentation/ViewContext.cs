using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DynamicViewModel.Presentation
{
    // The purpose of this class is to allow passing temporary data among controllers and middlewares by wrapping
    // HttpContext.Current for runtime environment, and falling back to CallContext in test environment.
    public class ViewContext
    {
        private readonly HttpContext _context;
        public ViewContext(HttpContext context)
        {
            _context = context;
            
        }

        public static class CallContext
        {
            private static ConcurrentDictionary<string, AsyncLocal<object>> state = new ConcurrentDictionary<string, AsyncLocal<object>>();

            public static void SetData(string name, object data) => state.GetOrAdd(name, _ => new AsyncLocal<object>()).Value = data;

            public static object GetData(string name) => state.TryGetValue(name, out AsyncLocal<object> data) ? data.Value : null;

        }

        public IDictionary<object,object> Items
        {
            get
            {
                if (_context != null)
                    return _context.Items;
                else
                {
                    var items = (IDictionary<object, object>)CallContext.GetData(nameof(ViewContext));
                    if (items == null)
                        CallContext.SetData(nameof(ViewContext), new Dictionary<string, object>());

                    return (IDictionary<object, object>)CallContext.GetData(nameof(ViewContext));
                }
            }
        }

    }
}
