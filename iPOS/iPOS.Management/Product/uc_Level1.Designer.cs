﻿namespace iPOS.Management.Product
{
    partial class uc_Level1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.lblEditTime = new DevExpress.XtraBars.BarStaticItem();
            this.lblEditer = new DevExpress.XtraBars.BarStaticItem();
            this.lblCreateTime = new DevExpress.XtraBars.BarStaticItem();
            this.lblCreater = new DevExpress.XtraBars.BarStaticItem();
            this.barFooter = new DevExpress.XtraBars.Bar();
            this.btnClose = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnExport = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnImport = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.btnInsert = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barMain = new DevExpress.XtraBars.BarManager(this.components);
            this.barHeader = new DevExpress.XtraBars.Bar();
            this.gcolStallID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolEditer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolCreateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolCreater = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolRank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolUsedString = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grvLevel1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolStallCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolStallName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolStoreName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolWarehouseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolEditTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLevel1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.barMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLevel1)).BeginInit();
            this.SuspendLayout();
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(806, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 460);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 502);
            this.barDockControlBottom.Size = new System.Drawing.Size(806, 24);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(806, 42);
            // 
            // lblEditTime
            // 
            this.lblEditTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblEditTime.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.lblEditTime.Caption = "Ngày cập nhật: <b><color=RED>.</color></b>";
            this.lblEditTime.Id = 11;
            this.lblEditTime.Name = "lblEditTime";
            this.lblEditTime.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lblEditer
            // 
            this.lblEditer.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblEditer.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.lblEditer.Caption = "Người cập nhật: <b><color=RED>admin</color></b>";
            this.lblEditer.Id = 10;
            this.lblEditer.Name = "lblEditer";
            this.lblEditer.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lblCreateTime
            // 
            this.lblCreateTime.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.lblCreateTime.Caption = "Ngày tạo: <b><color=RED>.</color></b>";
            this.lblCreateTime.Id = 9;
            this.lblCreateTime.Name = "lblCreateTime";
            this.lblCreateTime.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lblCreater
            // 
            this.lblCreater.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.lblCreater.Caption = "Người tạo: <b><color=RED>admin</color></b>";
            this.lblCreater.Id = 8;
            this.lblCreater.Name = "lblCreater";
            this.lblCreater.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barFooter
            // 
            this.barFooter.BarName = "Status bar";
            this.barFooter.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barFooter.DockCol = 0;
            this.barFooter.DockRow = 0;
            this.barFooter.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barFooter.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lblCreater),
            new DevExpress.XtraBars.LinkPersistInfo(this.lblCreateTime),
            new DevExpress.XtraBars.LinkPersistInfo(this.lblEditer),
            new DevExpress.XtraBars.LinkPersistInfo(this.lblEditTime)});
            this.barFooter.OptionsBar.AllowQuickCustomization = false;
            this.barFooter.OptionsBar.DrawDragBorder = false;
            this.barFooter.OptionsBar.UseWholeRow = true;
            this.barFooter.Text = "Status bar";
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 7;
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W));
            this.btnClose.LargeGlyph = global::iPOS.Management.Properties.Resources.close_16;
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // btnExport
            // 
            this.btnExport.Caption = "Xuất";
            this.btnExport.Id = 6;
            this.btnExport.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.btnExport.LargeGlyph = global::iPOS.Management.Properties.Resources.export_16;
            this.btnExport.Name = "btnExport";
            this.btnExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExport_ItemClick);
            // 
            // btnImport
            // 
            this.btnImport.Caption = "Nhập";
            this.btnImport.Id = 5;
            this.btnImport.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I));
            this.btnImport.LargeGlyph = global::iPOS.Management.Properties.Resources.import_16;
            this.btnImport.Name = "btnImport";
            this.btnImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImport_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Tải Lại";
            this.btnReload.Id = 4;
            this.btnReload.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnReload.LargeGlyph = global::iPOS.Management.Properties.Resources.reload_16;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In";
            this.btnPrint.Id = 3;
            this.btnPrint.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.btnPrint.LargeGlyph = global::iPOS.Management.Properties.Resources.print_16;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 2;
            this.btnDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.btnDelete.LargeGlyph = global::iPOS.Management.Properties.Resources.delete_16;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Sửa Chữa";
            this.btnUpdate.Glyph = global::iPOS.Management.Properties.Resources.update_16;
            this.btnUpdate.Id = 1;
            this.btnUpdate.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.btnUpdate.LargeGlyph = global::iPOS.Management.Properties.Resources.update_16;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 460);
            // 
            // btnInsert
            // 
            this.btnInsert.Caption = "Thêm";
            this.btnInsert.Id = 0;
            this.btnInsert.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnInsert.LargeGlyph = global::iPOS.Management.Properties.Resources.add_16;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInsert_ItemClick);
            // 
            // barMain
            // 
            this.barMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barHeader,
            this.barFooter});
            this.barMain.DockControls.Add(this.barDockControlTop);
            this.barMain.DockControls.Add(this.barDockControlBottom);
            this.barMain.DockControls.Add(this.barDockControlLeft);
            this.barMain.DockControls.Add(this.barDockControlRight);
            this.barMain.Form = this;
            this.barMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnInsert,
            this.btnUpdate,
            this.btnDelete,
            this.btnPrint,
            this.btnReload,
            this.btnImport,
            this.btnExport,
            this.btnClose,
            this.lblCreater,
            this.lblCreateTime,
            this.lblEditer,
            this.lblEditTime});
            this.barMain.MainMenu = this.barHeader;
            this.barMain.MaxItemId = 12;
            this.barMain.StatusBar = this.barFooter;
            // 
            // barHeader
            // 
            this.barHeader.BarName = "Main menu";
            this.barHeader.DockCol = 0;
            this.barHeader.DockRow = 0;
            this.barHeader.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barHeader.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnInsert),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdate),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnImport, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose, true)});
            this.barHeader.OptionsBar.AllowQuickCustomization = false;
            this.barHeader.OptionsBar.DrawBorder = false;
            this.barHeader.OptionsBar.DrawDragBorder = false;
            this.barHeader.OptionsBar.UseWholeRow = true;
            this.barHeader.Text = "Main menu";
            // 
            // gcolStallID
            // 
            this.gcolStallID.Caption = "StallID";
            this.gcolStallID.FieldName = "StallID";
            this.gcolStallID.Name = "gcolStallID";
            // 
            // gcolEditer
            // 
            this.gcolEditer.Caption = "Editer";
            this.gcolEditer.FieldName = "Editer";
            this.gcolEditer.Name = "gcolEditer";
            // 
            // gcolCreateTime
            // 
            this.gcolCreateTime.Caption = "CreateTime";
            this.gcolCreateTime.FieldName = "CreateTime";
            this.gcolCreateTime.Name = "gcolCreateTime";
            // 
            // gcolCreater
            // 
            this.gcolCreater.Caption = "Creater";
            this.gcolCreater.FieldName = "Creater";
            this.gcolCreater.Name = "gcolCreater";
            // 
            // gcolNote
            // 
            this.gcolNote.Caption = "Ghi chú";
            this.gcolNote.FieldName = "Note";
            this.gcolNote.Name = "gcolNote";
            this.gcolNote.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gcolNote.Visible = true;
            this.gcolNote.VisibleIndex = 4;
            this.gcolNote.Width = 332;
            // 
            // gcolRank
            // 
            this.gcolRank.AppearanceCell.Options.UseTextOptions = true;
            this.gcolRank.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gcolRank.Caption = "Thứ tự";
            this.gcolRank.DisplayFormat.FormatString = "N0";
            this.gcolRank.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcolRank.FieldName = "Rank";
            this.gcolRank.Name = "gcolRank";
            this.gcolRank.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gcolRank.Visible = true;
            this.gcolRank.VisibleIndex = 2;
            this.gcolRank.Width = 72;
            // 
            // gcolUsedString
            // 
            this.gcolUsedString.AppearanceCell.Options.UseTextOptions = true;
            this.gcolUsedString.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcolUsedString.Caption = "Sử dụng?";
            this.gcolUsedString.FieldName = "UsedString";
            this.gcolUsedString.Name = "gcolUsedString";
            this.gcolUsedString.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gcolUsedString.Visible = true;
            this.gcolUsedString.VisibleIndex = 3;
            this.gcolUsedString.Width = 72;
            // 
            // grvLevel1
            // 
            this.grvLevel1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grvLevel1.Appearance.GroupRow.Options.UseFont = true;
            this.grvLevel1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolStallCode,
            this.gcolStallName,
            this.gcolStoreName,
            this.gcolWarehouseName,
            this.gcolUsedString,
            this.gcolRank,
            this.gcolNote,
            this.gcolCreater,
            this.gcolCreateTime,
            this.gcolEditer,
            this.gcolEditTime,
            this.gcolStallID});
            this.grvLevel1.GridControl = this.gridLevel1;
            this.grvLevel1.GroupCount = 2;
            this.grvLevel1.IndicatorWidth = 40;
            this.grvLevel1.Name = "grvLevel1";
            this.grvLevel1.OptionsBehavior.AutoExpandAllGroups = true;
            this.grvLevel1.OptionsBehavior.Editable = false;
            this.grvLevel1.OptionsSelection.MultiSelect = true;
            this.grvLevel1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcolStoreName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcolWarehouseName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grvLevel1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grvLevel1_CustomDrawRowIndicator);
            this.grvLevel1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.grvLevel1_SelectionChanged);
            this.grvLevel1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvLevel1_FocusedRowChanged);
            this.grvLevel1.FocusedRowLoaded += new DevExpress.XtraGrid.Views.Base.RowEventHandler(this.grvLevel1_FocusedRowLoaded);
            this.grvLevel1.DoubleClick += new System.EventHandler(this.grvLevel1_DoubleClick);
            // 
            // gcolStallCode
            // 
            this.gcolStallCode.Caption = "Mã quầy bán";
            this.gcolStallCode.FieldName = "StallCode";
            this.gcolStallCode.Name = "gcolStallCode";
            this.gcolStallCode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gcolStallCode.Visible = true;
            this.gcolStallCode.VisibleIndex = 0;
            this.gcolStallCode.Width = 116;
            // 
            // gcolStallName
            // 
            this.gcolStallName.Caption = "Tên quầy bán";
            this.gcolStallName.FieldName = "StallName";
            this.gcolStallName.Name = "gcolStallName";
            this.gcolStallName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gcolStallName.Visible = true;
            this.gcolStallName.VisibleIndex = 1;
            this.gcolStallName.Width = 240;
            // 
            // gcolStoreName
            // 
            this.gcolStoreName.Caption = "Cửa hàng";
            this.gcolStoreName.FieldName = "StoreName";
            this.gcolStoreName.Name = "gcolStoreName";
            this.gcolStoreName.Visible = true;
            this.gcolStoreName.VisibleIndex = 2;
            this.gcolStoreName.Width = 181;
            // 
            // gcolWarehouseName
            // 
            this.gcolWarehouseName.Caption = "Kho hàng";
            this.gcolWarehouseName.FieldName = "WarehouseName";
            this.gcolWarehouseName.Name = "gcolWarehouseName";
            this.gcolWarehouseName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gcolWarehouseName.Visible = true;
            this.gcolWarehouseName.VisibleIndex = 2;
            this.gcolWarehouseName.Width = 301;
            // 
            // gcolEditTime
            // 
            this.gcolEditTime.Caption = "EditTime";
            this.gcolEditTime.FieldName = "EditTime";
            this.gcolEditTime.Name = "gcolEditTime";
            // 
            // gridLevel1
            // 
            this.gridLevel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLevel1.Location = new System.Drawing.Point(0, 42);
            this.gridLevel1.MainView = this.grvLevel1;
            this.gridLevel1.MenuManager = this.barMain;
            this.gridLevel1.Name = "gridLevel1";
            this.gridLevel1.Size = new System.Drawing.Size(806, 460);
            this.gridLevel1.TabIndex = 14;
            this.gridLevel1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLevel1});
            // 
            // uc_Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridLevel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "uc_Level1";
            this.Size = new System.Drawing.Size(806, 526);
            this.Load += new System.EventHandler(this.uc_Level1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLevel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarStaticItem lblEditTime;
        private DevExpress.XtraBars.BarStaticItem lblEditer;
        private DevExpress.XtraBars.BarStaticItem lblCreateTime;
        private DevExpress.XtraBars.BarStaticItem lblCreater;
        private DevExpress.XtraBars.Bar barFooter;
        private DevExpress.XtraBars.BarLargeButtonItem btnClose;
        private DevExpress.XtraBars.BarLargeButtonItem btnExport;
        private DevExpress.XtraBars.BarLargeButtonItem btnImport;
        private DevExpress.XtraBars.BarLargeButtonItem btnReload;
        private DevExpress.XtraBars.BarLargeButtonItem btnPrint;
        private DevExpress.XtraBars.BarLargeButtonItem btnDelete;
        private DevExpress.XtraBars.BarLargeButtonItem btnUpdate;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarLargeButtonItem btnInsert;
        private DevExpress.XtraBars.BarManager barMain;
        private DevExpress.XtraBars.Bar barHeader;
        private DevExpress.XtraGrid.GridControl gridLevel1;
        private DevExpress.XtraGrid.Views.Grid.GridView grvLevel1;
        private DevExpress.XtraGrid.Columns.GridColumn gcolStallCode;
        private DevExpress.XtraGrid.Columns.GridColumn gcolStallName;
        private DevExpress.XtraGrid.Columns.GridColumn gcolStoreName;
        private DevExpress.XtraGrid.Columns.GridColumn gcolWarehouseName;
        private DevExpress.XtraGrid.Columns.GridColumn gcolUsedString;
        private DevExpress.XtraGrid.Columns.GridColumn gcolRank;
        private DevExpress.XtraGrid.Columns.GridColumn gcolNote;
        private DevExpress.XtraGrid.Columns.GridColumn gcolCreater;
        private DevExpress.XtraGrid.Columns.GridColumn gcolCreateTime;
        private DevExpress.XtraGrid.Columns.GridColumn gcolEditer;
        private DevExpress.XtraGrid.Columns.GridColumn gcolEditTime;
        private DevExpress.XtraGrid.Columns.GridColumn gcolStallID;
    }
}
