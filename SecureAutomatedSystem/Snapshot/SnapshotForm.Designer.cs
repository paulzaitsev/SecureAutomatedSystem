using SecureAutomatedSystem.Charts.LineCurves;

namespace SecureAutomatedSystem.Snapshot {
    partial class SnapshotForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnapshotForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.diameterMetricsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.outer_diameter_chart = new SecureAutomatedSystem.Charts.LineCurves.LineCurvesChart();
            this.inner_diameter_chart = new SecureAutomatedSystem.Charts.LineCurves.LineCurvesChart();
            this.radiusMetricsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.outer_radius_chart = new SecureAutomatedSystem.Charts.LineCurves.LineCurvesChart();
            this.inner_radius_chart = new SecureAutomatedSystem.Charts.LineCurves.LineCurvesChart();
            this.ogivePartMetricsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ogive_pairing_radius_chart = new SecureAutomatedSystem.Charts.LineCurves.LineCurvesChart();
            this.wall_thickness_chart = new SecureAutomatedSystem.Charts.LineCurves.LineCurvesChart();
            this.topMetricsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.top_thickness_chart = new SecureAutomatedSystem.Charts.LineCurves.LineCurvesChart();
            this.top_diameter_chart = new SecureAutomatedSystem.Charts.LineCurves.LineCurvesChart();
            this.metricsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.bottom_lowersection_height_chart = new SecureAutomatedSystem.Charts.LineCurves.LineCurvesChart();
            this.outer_pairing_radius_cyl_chart = new SecureAutomatedSystem.Charts.LineCurves.LineCurvesChart();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.diameterMetricsTabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.radiusMetricsTabPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.ogivePartMetricsTabPage.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.topMetricsTabPage.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.metricsTabPage.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.metroTabControl1, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.diameterMetricsTabPage);
            this.metroTabControl1.Controls.Add(this.radiusMetricsTabPage);
            this.metroTabControl1.Controls.Add(this.ogivePartMetricsTabPage);
            this.metroTabControl1.Controls.Add(this.topMetricsTabPage);
            this.metroTabControl1.Controls.Add(this.metricsTabPage);
            resources.ApplyResources(this.metroTabControl1, "metroTabControl1");
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // diameterMetricsTabPage
            // 
            this.diameterMetricsTabPage.Controls.Add(this.tableLayoutPanel2);
            this.diameterMetricsTabPage.HorizontalScrollbarBarColor = true;
            this.diameterMetricsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.diameterMetricsTabPage.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.diameterMetricsTabPage, "diameterMetricsTabPage");
            this.diameterMetricsTabPage.Name = "diameterMetricsTabPage";
            this.diameterMetricsTabPage.VerticalScrollbarBarColor = true;
            this.diameterMetricsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.diameterMetricsTabPage.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.outer_diameter_chart, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.inner_diameter_chart, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // outer_diameter_chart
            // 
            this.outer_diameter_chart.BackColor = System.Drawing.Color.White;
            this.outer_diameter_chart.Caption = "Outer diameter";
            resources.ApplyResources(this.outer_diameter_chart, "outer_diameter_chart");
            this.outer_diameter_chart.Name = "outer_diameter_chart";
            this.outer_diameter_chart.UseSelectable = true;
            // 
            // inner_diameter_chart
            // 
            this.inner_diameter_chart.BackColor = System.Drawing.Color.White;
            this.inner_diameter_chart.Caption = "Inner diameter";
            resources.ApplyResources(this.inner_diameter_chart, "inner_diameter_chart");
            this.inner_diameter_chart.Name = "inner_diameter_chart";
            this.inner_diameter_chart.UseSelectable = true;
            // 
            // radiusMetricsTabPage
            // 
            this.radiusMetricsTabPage.Controls.Add(this.tableLayoutPanel3);
            this.radiusMetricsTabPage.HorizontalScrollbarBarColor = true;
            this.radiusMetricsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.radiusMetricsTabPage.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.radiusMetricsTabPage, "radiusMetricsTabPage");
            this.radiusMetricsTabPage.Name = "radiusMetricsTabPage";
            this.radiusMetricsTabPage.VerticalScrollbarBarColor = true;
            this.radiusMetricsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.radiusMetricsTabPage.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.outer_radius_chart, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.inner_radius_chart, 0, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // outer_radius_chart
            // 
            this.outer_radius_chart.BackColor = System.Drawing.Color.White;
            this.outer_radius_chart.Caption = "Outer radius";
            resources.ApplyResources(this.outer_radius_chart, "outer_radius_chart");
            this.outer_radius_chart.Name = "outer_radius_chart";
            this.outer_radius_chart.UseSelectable = true;
            // 
            // inner_radius_chart
            // 
            this.inner_radius_chart.BackColor = System.Drawing.Color.White;
            this.inner_radius_chart.Caption = "Inner radius";
            resources.ApplyResources(this.inner_radius_chart, "inner_radius_chart");
            this.inner_radius_chart.Name = "inner_radius_chart";
            this.inner_radius_chart.UseSelectable = true;
            // 
            // ogivePartMetricsTabPage
            // 
            this.ogivePartMetricsTabPage.Controls.Add(this.tableLayoutPanel4);
            this.ogivePartMetricsTabPage.HorizontalScrollbarBarColor = true;
            this.ogivePartMetricsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.ogivePartMetricsTabPage.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.ogivePartMetricsTabPage, "ogivePartMetricsTabPage");
            this.ogivePartMetricsTabPage.Name = "ogivePartMetricsTabPage";
            this.ogivePartMetricsTabPage.VerticalScrollbarBarColor = true;
            this.ogivePartMetricsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.ogivePartMetricsTabPage.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.ogive_pairing_radius_chart, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.wall_thickness_chart, 0, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // ogive_pairing_radius_chart
            // 
            this.ogive_pairing_radius_chart.BackColor = System.Drawing.Color.White;
            this.ogive_pairing_radius_chart.Caption = "Outer pairing radius";
            resources.ApplyResources(this.ogive_pairing_radius_chart, "ogive_pairing_radius_chart");
            this.ogive_pairing_radius_chart.Name = "ogive_pairing_radius_chart";
            this.ogive_pairing_radius_chart.UseSelectable = true;
            // 
            // wall_thickness_chart
            // 
            this.wall_thickness_chart.BackColor = System.Drawing.Color.White;
            this.wall_thickness_chart.Caption = "Wall thickness";
            resources.ApplyResources(this.wall_thickness_chart, "wall_thickness_chart");
            this.wall_thickness_chart.Name = "wall_thickness_chart";
            this.wall_thickness_chart.UseSelectable = true;
            // 
            // topMetricsTabPage
            // 
            this.topMetricsTabPage.Controls.Add(this.tableLayoutPanel5);
            this.topMetricsTabPage.HorizontalScrollbarBarColor = true;
            this.topMetricsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.topMetricsTabPage.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.topMetricsTabPage, "topMetricsTabPage");
            this.topMetricsTabPage.Name = "topMetricsTabPage";
            this.topMetricsTabPage.VerticalScrollbarBarColor = true;
            this.topMetricsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.topMetricsTabPage.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.top_thickness_chart, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.top_diameter_chart, 0, 1);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // top_thickness_chart
            // 
            this.top_thickness_chart.BackColor = System.Drawing.Color.White;
            this.top_thickness_chart.Caption = "Top thickness";
            resources.ApplyResources(this.top_thickness_chart, "top_thickness_chart");
            this.top_thickness_chart.Name = "top_thickness_chart";
            this.top_thickness_chart.UseSelectable = true;
            // 
            // top_diameter_chart
            // 
            this.top_diameter_chart.BackColor = System.Drawing.Color.White;
            this.top_diameter_chart.Caption = "Top diameter";
            resources.ApplyResources(this.top_diameter_chart, "top_diameter_chart");
            this.top_diameter_chart.Name = "top_diameter_chart";
            this.top_diameter_chart.UseSelectable = true;
            // 
            // metricsTabPage
            // 
            this.metricsTabPage.Controls.Add(this.tableLayoutPanel6);
            this.metricsTabPage.HorizontalScrollbarBarColor = true;
            this.metricsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.metricsTabPage.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metricsTabPage, "metricsTabPage");
            this.metricsTabPage.Name = "metricsTabPage";
            this.metricsTabPage.VerticalScrollbarBarColor = true;
            this.metricsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.metricsTabPage.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.bottom_lowersection_height_chart, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.outer_pairing_radius_cyl_chart, 0, 1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // bottom_lowersection_height_chart
            // 
            this.bottom_lowersection_height_chart.BackColor = System.Drawing.Color.White;
            this.bottom_lowersection_height_chart.Caption = "Bottom lowersection height";
            resources.ApplyResources(this.bottom_lowersection_height_chart, "bottom_lowersection_height_chart");
            this.bottom_lowersection_height_chart.Name = "bottom_lowersection_height_chart";
            this.bottom_lowersection_height_chart.UseSelectable = true;
            // 
            // outer_pairing_radius_cyl_chart
            // 
            this.outer_pairing_radius_cyl_chart.BackColor = System.Drawing.Color.White;
            this.outer_pairing_radius_cyl_chart.Caption = "Outer pairing radius cyl";
            resources.ApplyResources(this.outer_pairing_radius_cyl_chart, "outer_pairing_radius_cyl_chart");
            this.outer_pairing_radius_cyl_chart.Name = "outer_pairing_radius_cyl_chart";
            this.outer_pairing_radius_cyl_chart.UseSelectable = true;
            // 
            // SnapshotForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SnapshotForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.diameterMetricsTabPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.radiusMetricsTabPage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ogivePartMetricsTabPage.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.topMetricsTabPage.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.metricsTabPage.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage diameterMetricsTabPage;
        private MetroFramework.Controls.MetroTabPage radiusMetricsTabPage;
        private MetroFramework.Controls.MetroTabPage ogivePartMetricsTabPage;
        private MetroFramework.Controls.MetroTabPage topMetricsTabPage;
        private MetroFramework.Controls.MetroTabPage metricsTabPage;
        private System. Windows. Forms. TableLayoutPanel tableLayoutPanel2;
        private System. Windows. Forms. TableLayoutPanel tableLayoutPanel3;
        private System. Windows. Forms. TableLayoutPanel tableLayoutPanel4;
        private System. Windows. Forms. TableLayoutPanel tableLayoutPanel5;
        private System. Windows. Forms. TableLayoutPanel tableLayoutPanel6;
        private LineCurvesChart bottom_lowersection_height_chart;
        private LineCurvesChart outer_pairing_radius_cyl_chart;
        private LineCurvesChart top_thickness_chart;
        private LineCurvesChart top_diameter_chart;
        private LineCurvesChart ogive_pairing_radius_chart;
        private LineCurvesChart wall_thickness_chart;
        private LineCurvesChart outer_radius_chart;
        private LineCurvesChart inner_radius_chart;
        private LineCurvesChart outer_diameter_chart;
        private LineCurvesChart inner_diameter_chart;
    }
}