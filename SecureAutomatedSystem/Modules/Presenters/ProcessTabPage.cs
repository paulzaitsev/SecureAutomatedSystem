using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureAutomatedSystem.Modules.Presenters {
    class ProcessTabPage<TModel> : PageBase<IProcessTabView, TModel> where TModel: Model {
        public ProcessTabPage(IProcessTabView view) : base(view) {
        }

        public override void Begin() {
            throw new NotImplementedException();
        }

        public override void Commit() {
            throw new NotImplementedException();
        }
    }
}
