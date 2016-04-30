using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureAutomatedSystem.Modules {
    public abstract class PageBase<TView, TModel> : IPage<TModel> {
        readonly TView view;
        protected PageBase(TView view) {
            this.view = view;
        }

        public virtual bool MoveNextEnabled {
            get { return false; }
        }

        protected TView View {
            get { return view; }
        }

        public virtual Type GetNextPageType() {
            return null;
        }

        public abstract void Begin();
        public abstract void Commit();

        public event EventHandler Changed;
        protected void RaiseChanged() {
            if (Changed != null) {
                Changed(this, EventArgs.Empty);
            }
        }

    }
}
