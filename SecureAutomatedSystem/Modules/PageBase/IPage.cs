using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureAutomatedSystem.Modules {
    interface IPage<TModel> {
        event EventHandler Changed;
        void Begin();
        void Commit();
        Type GetNextPageType();
        bool MoveNextEnabled { get; }
    }
}
