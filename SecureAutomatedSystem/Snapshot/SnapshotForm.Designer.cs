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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.diameterMetricsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radiusMetricsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ogivePartMetricsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.topMetricsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.metricsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.outer_diameter_chart = new WinFormsChartSamples.LineCurvesChart();
            this.inner_diameter_chart = new WinFormsChartSamples.LineCurvesChart();
            this.outer_radius_chart = new WinFormsChartSamples.LineCurvesChart();
            this.inner_radius_chart = new WinFormsChartSamples.LineCurvesChart();
            this.ogive_pairing_radius_chart = new WinFormsChartSamples.LineCurvesChart();
            this.wall_thickness_chart = new WinFormsChartSamples.LineCurvesChart();
            this.top_thickness_chart = new WinFormsChartSamples.LineCurvesChart();
            this.top_diameter_chart = new WinFormsChartSamples.LineCurvesChart();
            this.bottom_lowersection_height_chart = new WinFormsChartSamples.LineCurvesChart();
            this.outer_pairing_radius_cyl_chart = new WinFormsChartSamples.LineCurvesChart();
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
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.metroTabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 555);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.diameterMetricsTabPage);
            this.metroTabControl1.Controls.Add(this.radiusMetricsTabPage);
            this.metroTabControl1.Controls.Add(this.ogivePartMetricsTabPage);
            this.metroTabControl1.Controls.Add(this.topMetricsTabPage);
            this.metroTabControl1.Controls.Add(this.metricsTabPage);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 4;
            this.metroTabControl1.Size = new System.Drawing.Size(840, 549);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // diameterMetricsTabPage
            // 
            this.diameterMetricsTabPage.Controls.Add(this.tableLayoutPanel2);
            this.diameterMetricsTabPage.HorizontalScrollbarBarColor = true;
            this.diameterMetricsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.diameterMetricsTabPage.HorizontalScrollbarSize = 10;
            this.diameterMetricsTabPage.Location = new System.Drawing.Point(4, 38);
            this.diameterMetricsTabPage.Name = "diameterMetricsTabPage";
            this.diameterMetricsTabPage.Size = new System.Drawing.Size(832, 507);
            this.diameterMetricsTabPage.TabIndex = 0;
            this.diameterMetricsTabPage.Text = "Diameter";
            this.diameterMetricsTabPage.VerticalScrollbarBarColor = true;
            this.diameterMetricsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.diameterMetricsTabPage.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.outer_diameter_chart, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.inner_diameter_chart, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(832, 507);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // radiusMetricsTabPage
            // 
            this.radiusMetricsTabPage.Controls.Add(this.tableLayoutPanel3);
            this.radiusMetricsTabPage.HorizontalScrollbarBarColor = true;
            this.radiusMetricsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.radiusMetricsTabPage.HorizontalScrollbarSize = 10;
            this.radiusMetricsTabPage.Location = new System.Drawing.Point(4, 38);
            this.radiusMetricsTabPage.Name = "radiusMetricsTabPage";
            this.radiusMetricsTabPage.Size = new System.Drawing.Size(832, 507);
            this.radiusMetricsTabPage.TabIndex = 1;
            this.radiusMetricsTabPage.Text = "Radius";
            this.radiusMetricsTabPage.VerticalScrollbarBarColor = true;
            this.radiusMetricsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.radiusMetricsTabPage.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.outer_radius_chart, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.inner_radius_chart, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(832, 507);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // ogivePartMetricsTabPage
            // 
            this.ogivePartMetricsTabPage.Controls.Add(this.tableLayoutPanel4);
            this.ogivePartMetricsTabPage.HorizontalScrollbarBarColor = true;
            this.ogivePartMetricsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.ogivePartMetricsTabPage.HorizontalScrollbarSize = 10;
            this.ogivePartMetricsTabPage.Location = new System.Drawing.Point(4, 38);
            this.ogivePartMetricsTabPage.Name = "ogivePartMetricsTabPage";
            this.ogivePartMetricsTabPage.Size = new System.Drawing.Size(832, 507);
            this.ogivePartMetricsTabPage.TabIndex = 2;
            this.ogivePartMetricsTabPage.Text = "Ogive part";
            this.ogivePartMetricsTabPage.VerticalScrollbarBarColor = true;
            this.ogivePartMetricsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.ogivePartMetricsTabPage.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.ogive_pairing_radius_chart, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.wall_thickness_chart, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(832, 507);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // topMetricsTabPage
            // 
            this.topMetricsTabPage.Controls.Add(this.tableLayoutPanel5);
            this.topMetricsTabPage.HorizontalScrollbarBarColor = true;
            this.topMetricsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.topMetricsTabPage.HorizontalScrollbarSize = 10;
            this.topMetricsTabPage.Location = new System.Drawing.Point(4, 38);
            this.topMetricsTabPage.Name = "topMetricsTabPage";
            this.topMetricsTabPage.Size = new System.Drawing.Size(832, 507);
            this.topMetricsTabPage.TabIndex = 3;
            this.topMetricsTabPage.Text = "Top";
            this.topMetricsTabPage.VerticalScrollbarBarColor = true;
            this.topMetricsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.topMetricsTabPage.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.top_thickness_chart, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.top_diameter_chart, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(832, 507);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // metricsTabPage
            // 
            this.metricsTabPage.Controls.Add(this.tableLayoutPanel6);
            this.metricsTabPage.HorizontalScrollbarBarColor = true;
            this.metricsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.metricsTabPage.HorizontalScrollbarSize = 10;
            this.metricsTabPage.Location = new System.Drawing.Point(4, 38);
            this.metricsTabPage.Name = "metricsTabPage";
            this.metricsTabPage.Size = new System.Drawing.Size(832, 507);
            this.metricsTabPage.TabIndex = 4;
            this.metricsTabPage.Text = "Other metrics";
            this.metricsTabPage.VerticalScrollbarBarColor = true;
            this.metricsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.metricsTabPage.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.bottom_lowersection_height_chart, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.outer_pairing_radius_cyl_chart, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(832, 507);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // outer_diameter_chart
            // 
            this.outer_diameter_chart.BackColor = System.Drawing.Color.White;
            this.outer_diameter_chart.Caption = "Outer diameter";
            this.outer_diameter_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outer_diameter_chart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outer_diameter_chart.Location = new System.Drawing.Point(3, 3);
            this.outer_diameter_chart.Name = "outer_diameter_chart";
            this.outer_diameter_chart.Size = new System.Drawing.Size(826, 247);
            this.outer_diameter_chart.TabIndex = 0;
            this.outer_diameter_chart.UseSelectable = true;
            // 
            // inner_diameter_chart
            // 
            this.inner_diameter_chart.BackColor = System.Drawing.Color.White;
            this.inner_diameter_chart.Caption = "Inner diameter";
            this.inner_diameter_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inner_diameter_chart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inner_diameter_chart.Location = new System.Drawing.Point(3, 256);
            this.inner_diameter_chart.Name = "inner_diameter_chart";
            this.inner_diameter_chart.Size = new System.Drawing.Size(826, 248);
            this.inner_diameter_chart.TabIndex = 1;
            this.inner_diameter_chart.UseSelectable = true;
            // 
            // outer_radius_chart
            // 
            this.outer_radius_chart.BackColor = System.Drawing.Color.White;
            this.outer_radius_chart.Caption = "Outer radius";
            this.outer_radius_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outer_radius_chart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outer_radius_chart.Location = new System.Drawing.Point(3, 3);
            this.outer_radius_chart.Name = "outer_radius_chart";
            this.outer_radius_chart.Size = new System.Drawing.Size(826, 247);
            this.outer_radius_chart.TabIndex = 0;
            this.outer_radius_chart.UseSelectable = true;
            // 
            // inner_radius_chart
            // 
            this.inner_radius_chart.BackColor = System.Drawing.Color.White;
            this.inner_radius_chart.Caption = "Inner radius";
            this.inner_radius_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inner_radius_chart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inner_radius_chart.Location = new System.Drawing.Point(3, 256);
            this.inner_radius_chart.Name = "inner_radius_chart";
            this.inner_radius_chart.Size = new System.Drawing.Size(826, 248);
            this.inner_radius_chart.TabIndex = 1;
            this.inner_radius_chart.UseSelectable = true;
            // 
            // ogive_pairing_radius_chart
            // 
            this.ogive_pairing_radius_chart.BackColor = System.Drawing.Color.White;
            this.ogive_pairing_radius_chart.Caption = "Outer pairing radius";
            this.ogive_pairing_radius_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ogive_pairing_radius_chart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogive_pairing_radius_chart.Location = new System.Drawing.Point(3, 3);
            this.ogive_pairing_radius_chart.Name = "ogive_pairing_radius_chart";
            this.ogive_pairing_radius_chart.Size = new System.Drawing.Size(826, 247);
            this.ogive_pairing_radius_chart.TabIndex = 0;
            this.ogive_pairing_radius_chart.UseSelectable = true;
            // 
            // wall_thickness_chart
            // 
            this.wall_thickness_chart.BackColor = System.Drawing.Color.White;
            this.wall_thickness_chart.Caption = "Wall thickness";
            this.wall_thickness_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wall_thickness_chart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wall_thickness_chart.Location = new System.Drawing.Point(3, 256);
            this.wall_thickness_chart.Name = "wall_thickness_chart";
            this.wall_thickness_chart.Size = new System.Drawing.Size(826, 248);
            this.wall_thickness_chart.TabIndex = 1;
            this.wall_thickness_chart.UseSelectable = true;
            // 
            // top_thickness_chart
            // 
            this.top_thickness_chart.BackColor = System.Drawing.Color.White;
            this.top_thickness_chart.Caption = "Top thickness";
            this.top_thickness_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.top_thickness_chart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_thickness_chart.Location = new System.Drawing.Point(3, 3);
            this.top_thickness_chart.Name = "top_thickness_chart";
            this.top_thickness_chart.Size = new System.Drawing.Size(826, 247);
            this.top_thickness_chart.TabIndex = 0;
            this.top_thickness_chart.UseSelectable = true;
            // 
            // top_diameter_chart
            // 
            this.top_diameter_chart.BackColor = System.Drawing.Color.White;
            this.top_diameter_chart.Caption = "Top diameter";
            this.top_diameter_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.top_diameter_chart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_diameter_chart.Location = new System.Drawing.Point(3, 256);
            this.top_diameter_chart.Name = "top_diameter_chart";
            this.top_diameter_chart.Size = new System.Drawing.Size(826, 248);
            this.top_diameter_chart.TabIndex = 1;
            this.top_diameter_chart.UseSelectable = true;
            // 
            // bottom_lowersection_height_chart
            // 
            this.bottom_lowersection_height_chart.BackColor = System.Drawing.Color.White;
            this.bottom_lowersection_height_chart.Caption = "Bottom lowersection height";
            this.bottom_lowersection_height_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottom_lowersection_height_chart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottom_lowersection_height_chart.Location = new System.Drawing.Point(3, 3);
            this.bottom_lowersection_height_chart.Name = "bottom_lowersection_height_chart";
            this.bottom_lowersection_height_chart.Size = new System.Drawing.Size(826, 247);
            this.bottom_lowersection_height_chart.TabIndex = 0;
            this.bottom_lowersection_height_chart.UseSelectable = true;
            // 
            // outer_pairing_radius_cyl_chart
            // 
            this.outer_pairing_radius_cyl_chart.BackColor = System.Drawing.Color.White;
            this.outer_pairing_radius_cyl_chart.Caption = "Outer pairing radius cyl";
            this.outer_pairing_radius_cyl_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outer_pairing_radius_cyl_chart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outer_pairing_radius_cyl_chart.Location = new System.Drawing.Point(3, 256);
            this.outer_pairing_radius_cyl_chart.Name = "outer_pairing_radius_cyl_chart";
            this.outer_pairing_radius_cyl_chart.Size = new System.Drawing.Size(826, 248);
            this.outer_pairing_radius_cyl_chart.TabIndex = 1;
            this.outer_pairing_radius_cyl_chart.UseSelectable = true;
            // 
            // SnapshotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 635);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SnapshotForm";
            this.Text = "SnapshotForm";
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
        private WinFormsChartSamples. LineCurvesChart bottom_lowersection_height_chart;
        private WinFormsChartSamples. LineCurvesChart outer_pairing_radius_cyl_chart;
        private WinFormsChartSamples. LineCurvesChart top_thickness_chart;
        private WinFormsChartSamples. LineCurvesChart top_diameter_chart;
        private WinFormsChartSamples. LineCurvesChart ogive_pairing_radius_chart;
        private WinFormsChartSamples. LineCurvesChart wall_thickness_chart;
        private WinFormsChartSamples. LineCurvesChart outer_radius_chart;
        private WinFormsChartSamples. LineCurvesChart inner_radius_chart;
        private WinFormsChartSamples. LineCurvesChart outer_diameter_chart;
        private WinFormsChartSamples. LineCurvesChart inner_diameter_chart;
    }
}