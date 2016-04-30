using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureAutomatedSystem.Modules.Views {
    [ToolboxItem(false)]
    public partial class StatisticsTabPageView : PageViewBase, IStatisticsTabView {
        public StatisticsTabPageView() {
            InitializeComponent();
        }
    }
}
