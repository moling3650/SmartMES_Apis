using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SmartMES_Apis.Models
{
    public partial class dbContext : DbContext
    {
        public dbContext()
        {
        }

        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BAccessories> BAccessories { get; set; }
        public virtual DbSet<BAccessoriesType> BAccessoriesType { get; set; }
        public virtual DbSet<BBoard> BBoard { get; set; }
        public virtual DbSet<BBom> BBom { get; set; }
        public virtual DbSet<BBomDetail> BBomDetail { get; set; }
        public virtual DbSet<BChart> BChart { get; set; }
        public virtual DbSet<BChartType> BChartType { get; set; }
        public virtual DbSet<BDisposalProcess> BDisposalProcess { get; set; }
        public virtual DbSet<BDriveType> BDriveType { get; set; }
        public virtual DbSet<BEquipment> BEquipment { get; set; }
        public virtual DbSet<BEquipmentType> BEquipmentType { get; set; }
        public virtual DbSet<BFormula> BFormula { get; set; }
        public virtual DbSet<BFormulaDetail> BFormulaDetail { get; set; }
        public virtual DbSet<BLine> BLine { get; set; }
        public virtual DbSet<BMachine> BMachine { get; set; }
        public virtual DbSet<BMachineAccessories> BMachineAccessories { get; set; }
        public virtual DbSet<BMachineDataPoint> BMachineDataPoint { get; set; }
        public virtual DbSet<BMachineFaultphenomenon> BMachineFaultphenomenon { get; set; }
        public virtual DbSet<BMachineFaultreason> BMachineFaultreason { get; set; }
        public virtual DbSet<BMachineKindProperty> BMachineKindProperty { get; set; }
        public virtual DbSet<BMachineKinds> BMachineKinds { get; set; }
        public virtual DbSet<BMachineModel> BMachineModel { get; set; }
        public virtual DbSet<BMachineMouldKinds> BMachineMouldKinds { get; set; }
        public virtual DbSet<BMachinePropertyDetail> BMachinePropertyDetail { get; set; }
        public virtual DbSet<BMachineStandardPoints> BMachineStandardPoints { get; set; }
        public virtual DbSet<BMachineStopreason> BMachineStopreason { get; set; }
        public virtual DbSet<BMachineType> BMachineType { get; set; }
        public virtual DbSet<BMachineWorkToolsKinds> BMachineWorkToolsKinds { get; set; }
        public virtual DbSet<BMaintenance> BMaintenance { get; set; }
        public virtual DbSet<BMaterial> BMaterial { get; set; }
        public virtual DbSet<BMaterialType> BMaterialType { get; set; }
        public virtual DbSet<BMatManagement> BMatManagement { get; set; }
        public virtual DbSet<BMatSubstitute> BMatSubstitute { get; set; }
        public virtual DbSet<BMouldCavity> BMouldCavity { get; set; }
        public virtual DbSet<BMouldKindProperty> BMouldKindProperty { get; set; }
        public virtual DbSet<BMouldKinds> BMouldKinds { get; set; }
        public virtual DbSet<BMouldModel> BMouldModel { get; set; }
        public virtual DbSet<BMouldPropertyDetail> BMouldPropertyDetail { get; set; }
        public virtual DbSet<BMoulds> BMoulds { get; set; }
        public virtual DbSet<BMouldType> BMouldType { get; set; }
        public virtual DbSet<BNgCode> BNgCode { get; set; }
        public virtual DbSet<BNgReason> BNgReason { get; set; }
        public virtual DbSet<BNgReasonType> BNgReasonType { get; set; }
        public virtual DbSet<BNgType> BNgType { get; set; }
        public virtual DbSet<BPackLevel> BPackLevel { get; set; }
        public virtual DbSet<BPedigree> BPedigree { get; set; }
        public virtual DbSet<BPointTranslation> BPointTranslation { get; set; }
        public virtual DbSet<BPointType> BPointType { get; set; }
        public virtual DbSet<BPreStep> BPreStep { get; set; }
        public virtual DbSet<BProcessControl> BProcessControl { get; set; }
        public virtual DbSet<BProcessFlow> BProcessFlow { get; set; }
        public virtual DbSet<BProcessFlowDetail> BProcessFlowDetail { get; set; }
        public virtual DbSet<BProcessList> BProcessList { get; set; }
        public virtual DbSet<BProcessSonStep> BProcessSonStep { get; set; }
        public virtual DbSet<BProcessSonStepList> BProcessSonStepList { get; set; }
        public virtual DbSet<BProcessStep> BProcessStep { get; set; }
        public virtual DbSet<BProcessStepA> BProcessStepA { get; set; }
        public virtual DbSet<BProcessType> BProcessType { get; set; }
        public virtual DbSet<BProcRequirement> BProcRequirement { get; set; }
        public virtual DbSet<BProduct> BProduct { get; set; }
        public virtual DbSet<BProductGrade> BProductGrade { get; set; }
        public virtual DbSet<BProductModel> BProductModel { get; set; }
        public virtual DbSet<BProductType> BProductType { get; set; }
        public virtual DbSet<BReport> BReport { get; set; }
        public virtual DbSet<BReportField> BReportField { get; set; }
        public virtual DbSet<BReportQueryControl> BReportQueryControl { get; set; }
        public virtual DbSet<BSearchManagement> BSearchManagement { get; set; }
        public virtual DbSet<BSopimage> BSopimage { get; set; }
        public virtual DbSet<BSparepart> BSparepart { get; set; }
        public virtual DbSet<BStationList> BStationList { get; set; }
        public virtual DbSet<BStationMachine> BStationMachine { get; set; }
        public virtual DbSet<BStationMatPoint> BStationMatPoint { get; set; }
        public virtual DbSet<BStationMountPoint> BStationMountPoint { get; set; }
        public virtual DbSet<BSubReport> BSubReport { get; set; }
        public virtual DbSet<BTool> BTool { get; set; }
        public virtual DbSet<BToolParameter> BToolParameter { get; set; }
        public virtual DbSet<BToolType> BToolType { get; set; }
        public virtual DbSet<BTranslation> BTranslation { get; set; }
        public virtual DbSet<BTranslationDetail> BTranslationDetail { get; set; }
        public virtual DbSet<BTranslationType> BTranslationType { get; set; }
        public virtual DbSet<BWorkGroup> BWorkGroup { get; set; }
        public virtual DbSet<BWorkGroupClass> BWorkGroupClass { get; set; }
        public virtual DbSet<BWorkShop> BWorkShop { get; set; }
        public virtual DbSet<BWorkTool> BWorkTool { get; set; }
        public virtual DbSet<BWorkToolKindProperty> BWorkToolKindProperty { get; set; }
        public virtual DbSet<BWorkToolKinds> BWorkToolKinds { get; set; }
        public virtual DbSet<BWorkToolModel> BWorkToolModel { get; set; }
        public virtual DbSet<BWorkToolPropertyDetail> BWorkToolPropertyDetail { get; set; }
        public virtual DbSet<BWorkToolType> BWorkToolType { get; set; }
        public virtual DbSet<PAbnormalDetail> PAbnormalDetail { get; set; }
        public virtual DbSet<PAbnormalList> PAbnormalList { get; set; }
        public virtual DbSet<PAccessorisLoad> PAccessorisLoad { get; set; }
        public virtual DbSet<PAccessoryRecords> PAccessoryRecords { get; set; }
        public virtual DbSet<PBarCodeBing> PBarCodeBing { get; set; }
        public virtual DbSet<PBlog> PBlog { get; set; }
        public virtual DbSet<PDrateCollect> PDrateCollect { get; set; }
        public virtual DbSet<PEmpKpiCollect> PEmpKpiCollect { get; set; }
        public virtual DbSet<PFailDetail> PFailDetail { get; set; }
        public virtual DbSet<PFailDetailNgCodeCollect> PFailDetailNgCodeCollect { get; set; }
        public virtual DbSet<PFailDetailNgReasonCollect> PFailDetailNgReasonCollect { get; set; }
        public virtual DbSet<PFailLog> PFailLog { get; set; }
        public virtual DbSet<PIpqcData> PIpqcData { get; set; }
        public virtual DbSet<PIpqcDataDetail> PIpqcDataDetail { get; set; }
        public virtual DbSet<PIpqcItem> PIpqcItem { get; set; }
        public virtual DbSet<PIpqcTemplate> PIpqcTemplate { get; set; }
        public virtual DbSet<PMachineException> PMachineException { get; set; }
        public virtual DbSet<PMachineMaintainrecords> PMachineMaintainrecords { get; set; }
        public virtual DbSet<PMachineMouldInstall> PMachineMouldInstall { get; set; }
        public virtual DbSet<PMachineRepairrecords> PMachineRepairrecords { get; set; }
        public virtual DbSet<PMachineStopRecords> PMachineStopRecords { get; set; }
        public virtual DbSet<PMaintenanceDetail> PMaintenanceDetail { get; set; }
        public virtual DbSet<PMainWorkOrder> PMainWorkOrder { get; set; }
        public virtual DbSet<PMatAutoSend> PMatAutoSend { get; set; }
        public virtual DbSet<PMaterialWip> PMaterialWip { get; set; }
        public virtual DbSet<PMatManagementDetail> PMatManagementDetail { get; set; }
        public virtual DbSet<PMatTransferDetail> PMatTransferDetail { get; set; }
        public virtual DbSet<PMatWipSeed> PMatWipSeed { get; set; }
        public virtual DbSet<PNgScrap> PNgScrap { get; set; }
        public virtual DbSet<PNphCollect> PNphCollect { get; set; }
        public virtual DbSet<POnLineMaterial> POnLineMaterial { get; set; }
        public virtual DbSet<POrderMachine> POrderMachine { get; set; }
        public virtual DbSet<POrderStation> POrderStation { get; set; }
        public virtual DbSet<PPddData> PPddData { get; set; }
        public virtual DbSet<PPrintCurrentSn> PPrintCurrentSn { get; set; }
        public virtual DbSet<PProcRequirementDetail> PProcRequirementDetail { get; set; }
        public virtual DbSet<PProductEfficiencyCollect> PProductEfficiencyCollect { get; set; }
        public virtual DbSet<PProductionPlan> PProductionPlan { get; set; }
        public virtual DbSet<PQcTemplate> PQcTemplate { get; set; }
        public virtual DbSet<PRework> PRework { get; set; }
        public virtual DbSet<PSfcAccessories> PSfcAccessories { get; set; }
        public virtual DbSet<PSfcJude> PSfcJude { get; set; }
        public virtual DbSet<PSfcMachine> PSfcMachine { get; set; }
        public virtual DbSet<PSfcProcessData> PSfcProcessData { get; set; }
        public virtual DbSet<PSfcProcessDataBack> PSfcProcessDataBack { get; set; }
        public virtual DbSet<PSfcProcessIolog> PSfcProcessIolog { get; set; }
        public virtual DbSet<PSfcProcessSonData> PSfcProcessSonData { get; set; }
        public virtual DbSet<PSfcRank> PSfcRank { get; set; }
        public virtual DbSet<PSfcSparepart> PSfcSparepart { get; set; }
        public virtual DbSet<PSfcState> PSfcState { get; set; }
        public virtual DbSet<PSfcStateCollect> PSfcStateCollect { get; set; }
        public virtual DbSet<PSfcStateCp> PSfcStateCp { get; set; }
        public virtual DbSet<PSparepartRecords> PSparepartRecords { get; set; }
        public virtual DbSet<PSswPrintList> PSswPrintList { get; set; }
        public virtual DbSet<PSswTemplateList> PSswTemplateList { get; set; }
        public virtual DbSet<PTrayDetail> PTrayDetail { get; set; }
        public virtual DbSet<PWipTransfer> PWipTransfer { get; set; }
        public virtual DbSet<PWorkDispatching> PWorkDispatching { get; set; }
        public virtual DbSet<PWorkOrder> PWorkOrder { get; set; }
        public virtual DbSet<PWorkOrderCollect> PWorkOrderCollect { get; set; }
        public virtual DbSet<SDepartment> SDepartment { get; set; }
        public virtual DbSet<SDriveList> SDriveList { get; set; }
        public virtual DbSet<SEmpInRole> SEmpInRole { get; set; }
        public virtual DbSet<SEmployee> SEmployee { get; set; }
        public virtual DbSet<SMenuDetail> SMenuDetail { get; set; }
        public virtual DbSet<SModule> SModule { get; set; }
        public virtual DbSet<SModuleInRole> SModuleInRole { get; set; }
        public virtual DbSet<SPreStep> SPreStep { get; set; }
        public virtual DbSet<SRole> SRole { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=192.168.0.26;Database=SMART_MES;UID=sa;Pwd=1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BAccessories>(entity =>
            {
                entity.HasKey(e => e.AccessoryCode);

                entity.ToTable("B_Accessories");

                entity.Property(e => e.AccessoryCode)
                    .HasColumnName("accessory_code")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessoryName)
                    .HasColumnName("accessory_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Arrivaldate)
                    .HasColumnName("arrivaldate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MaintainCycle).HasColumnName("maintain_cycle");

                entity.Property(e => e.MaintainNexttime)
                    .HasColumnName("maintain_nexttime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaintainQuality).HasColumnName("maintain_quality");

                entity.Property(e => e.MaintianType).HasColumnName("maintian_type");

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("manufacturer")
                    .HasMaxLength(50);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(50);

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Userqty)
                    .HasColumnType("decimal(10, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WsCode)
                    .HasColumnName("ws_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BAccessoriesType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("B_Accessories_Type");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeName)
                    .HasColumnName("type_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BBoard>(entity =>
            {
                entity.ToTable("B_Board");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BoardCode)
                    .HasColumnName("board_code")
                    .HasMaxLength(50);

                entity.Property(e => e.BoardIp)
                    .HasColumnName("board_ip")
                    .HasMaxLength(20);

                entity.Property(e => e.BoardName)
                    .HasColumnName("board_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasColumnName("process_code")
                    .HasMaxLength(50);

                entity.Property(e => e.WsCode)
                    .HasColumnName("ws_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BBom>(entity =>
            {
                entity.HasKey(e => e.BomId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("B_Bom");

                entity.HasIndex(e => e.BomId)
                    .HasName("IX_B_Bom");

                entity.Property(e => e.BomId).HasColumnName("bom_id");

                entity.Property(e => e.BaseQty).HasColumnName("base_qty");

                entity.Property(e => e.BomCode)
                    .IsRequired()
                    .HasColumnName("bom_code")
                    .HasMaxLength(30);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Designator)
                    .HasColumnName("designator")
                    .HasMaxLength(30);

                entity.Property(e => e.Discription)
                    .HasColumnName("discription")
                    .HasMaxLength(50);

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.IsSplit).HasColumnName("is_split");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasColumnName("product_code")
                    .HasMaxLength(30);

                entity.Property(e => e.VersionCode)
                    .HasColumnName("version_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BBomDetail>(entity =>
            {
                entity.HasKey(e => e.BomDetailId);

                entity.ToTable("B_Bom_Detail");

                entity.Property(e => e.BomDetailId).HasColumnName("bom_detail_id");

                entity.Property(e => e.BaseQty).HasColumnName("base_qty");

                entity.Property(e => e.BeCtrl).HasColumnName("be_ctrl");

                entity.Property(e => e.BomCode)
                    .HasColumnName("bom_code")
                    .HasMaxLength(30);

                entity.Property(e => e.EnableBeyond).HasColumnName("enable_beyond");

                entity.Property(e => e.EnableSubstitute).HasColumnName("enable_Substitute");

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasMaxLength(40);

                entity.Property(e => e.MatType).HasColumnName("mat_type");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Wastage)
                    .HasColumnName("wastage")
                    .HasColumnType("decimal(5, 4)");
            });

            modelBuilder.Entity<BChart>(entity =>
            {
                entity.ToTable("B_Chart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChartTypeCode)
                    .IsRequired()
                    .HasColumnName("chart_type_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnName("label")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportCode)
                    .IsRequired()
                    .HasColumnName("report_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<BChartType>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("B_Chart_Type");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(30);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(50);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<BDisposalProcess>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("B_Disposal_Process");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.DisposalCode)
                    .HasColumnName("disposal_code")
                    .HasMaxLength(30);

                entity.Property(e => e.DisposalName)
                    .HasColumnName("disposal_name")
                    .HasMaxLength(30);

                entity.Property(e => e.ProcName)
                    .HasColumnName("proc_name")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BDriveType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("B_Drive_Type");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.DriveClass).HasColumnName("drive_class");

                entity.Property(e => e.TypeCode)
                    .HasColumnName("type_code")
                    .HasMaxLength(30);

                entity.Property(e => e.TypeName)
                    .HasColumnName("type_name")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BEquipment>(entity =>
            {
                entity.HasKey(e => e.EquipmentId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("B_Equipment");

                entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpCode)
                    .HasColumnName("emp_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.EquipmentCode)
                    .IsRequired()
                    .HasColumnName("equipment_code")
                    .HasMaxLength(30);

                entity.Property(e => e.EquipmentName)
                    .HasColumnName("equipment_name")
                    .HasMaxLength(30);

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BEquipmentType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("B_Equipment_Type");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeName)
                    .HasColumnName("type_name")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BFormula>(entity =>
            {
                entity.ToTable("B_Formula");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaseQty)
                    .HasColumnName("base_qty")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BomCode)
                    .IsRequired()
                    .HasColumnName("bom_code")
                    .HasMaxLength(30);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.Designator)
                    .HasColumnName("designator")
                    .HasMaxLength(20);

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.FormulaCode)
                    .IsRequired()
                    .HasColumnName("formula_code")
                    .HasMaxLength(30);

                entity.Property(e => e.FormulaName)
                    .IsRequired()
                    .HasColumnName("formula_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BFormulaDetail>(entity =>
            {
                entity.ToTable("B_Formula_Detail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deviate)
                    .HasColumnName("deviate")
                    .HasColumnType("decimal(6, 3)");

                entity.Property(e => e.FeedIdx).HasColumnName("feed_idx");

                entity.Property(e => e.FeedQty)
                    .HasColumnName("feed_qty")
                    .HasColumnType("decimal(12, 3)");

                entity.Property(e => e.FormulaCode)
                    .IsRequired()
                    .HasColumnName("formula_code")
                    .HasMaxLength(30);

                entity.Property(e => e.FormulaItem)
                    .IsRequired()
                    .HasColumnName("formula_item")
                    .HasMaxLength(30);

                entity.Property(e => e.MaterialCode)
                    .IsRequired()
                    .HasColumnName("material_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BLine>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("B_Line");

                entity.Property(e => e.LineId).HasColumnName("line_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.LineCode)
                    .HasColumnName("line_code")
                    .HasMaxLength(30);

                entity.Property(e => e.LineName)
                    .HasColumnName("line_name")
                    .HasMaxLength(30);

                entity.Property(e => e.Wsid).HasColumnName("wsid");
            });

            modelBuilder.Entity<BMachine>(entity =>
            {
                entity.ToTable("B_Machine");

                entity.HasIndex(e => e.MachineCode)
                    .HasName("IX_B_Machine")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Arrivaldate)
                    .HasColumnName("arrivaldate")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ExpectNexttime)
                    .HasColumnName("expect_nexttime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("img_url")
                    .HasMaxLength(100);

                entity.Property(e => e.MachineCode)
                    .IsRequired()
                    .HasColumnName("machine_code")
                    .HasMaxLength(50);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machine_name")
                    .HasMaxLength(50);

                entity.Property(e => e.MaintainCycle).HasColumnName("maintain_cycle");

                entity.Property(e => e.MaintainQuantity).HasColumnName("maintain_quantity");

                entity.Property(e => e.MaintainType).HasColumnName("maintain_type");

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("manufacturer")
                    .HasMaxLength(50);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(50);

                entity.Property(e => e.ModelCode)
                    .HasColumnName("model_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Ofstation)
                    .HasColumnName("ofstation")
                    .HasMaxLength(50);

                entity.Property(e => e.SimpleName)
                    .HasColumnName("simple_name")
                    .HasMaxLength(50);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.UseState)
                    .IsRequired()
                    .HasColumnName("use_state")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Userdepartment)
                    .HasColumnName("userdepartment")
                    .HasMaxLength(50);

                entity.Property(e => e.Userqty)
                    .HasColumnType("decimal(10, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WsCode)
                    .HasColumnName("ws_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BMachineAccessories>(entity =>
            {
                entity.ToTable("B_Machine_Accessories");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessoryCode)
                    .HasColumnName("accessory_code")
                    .HasMaxLength(50);

                entity.Property(e => e.AccessoryCount).HasColumnName("accessory_count");

                entity.Property(e => e.AccessoryIsload)
                    .HasColumnName("accessory_isload")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AccessoryState).HasColumnName("accessory_state");

                entity.Property(e => e.AccessoryType).HasColumnName("accessory_type");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BMachineDataPoint>(entity =>
            {
                entity.HasKey(e => e.PointId);

                entity.ToTable("B_Machine_DataPoint");

                entity.Property(e => e.PointId).HasColumnName("point_id");

                entity.Property(e => e.DataPointName)
                    .HasColumnName("dataPoint_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.DriveCode)
                    .HasColumnName("drive_code")
                    .HasMaxLength(30);

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Parameter)
                    .HasColumnName("parameter")
                    .HasMaxLength(50);

                entity.Property(e => e.PointType).HasColumnName("point_type");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.TransCode)
                    .HasColumnName("trans_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BMachineFaultphenomenon>(entity =>
            {
                entity.HasKey(e => e.FaultphenomenonCode);

                entity.ToTable("B_Machine_Faultphenomenon");

                entity.Property(e => e.FaultphenomenonCode)
                    .HasColumnName("faultphenomenon_code")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.FaultphenomenonName)
                    .HasColumnName("faultphenomenon_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<BMachineFaultreason>(entity =>
            {
                entity.ToTable("B_Machine_Faultreason");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FaultReasoncode)
                    .HasColumnName("fault_reasoncode")
                    .HasMaxLength(50);

                entity.Property(e => e.FaultReasonname)
                    .HasColumnName("fault_reasonname")
                    .HasMaxLength(50);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BMachineKindProperty>(entity =>
            {
                entity.HasKey(e => e.PptId);

                entity.ToTable("B_Machine_Kind_Property");

                entity.Property(e => e.PptId).HasColumnName("ppt_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.KindId).HasColumnName("kind_id");

                entity.Property(e => e.PptName)
                    .HasColumnName("ppt_name")
                    .HasMaxLength(20);

                entity.Property(e => e.PptType).HasColumnName("ppt_type");
            });

            modelBuilder.Entity<BMachineKinds>(entity =>
            {
                entity.HasKey(e => e.KindId);

                entity.ToTable("B_Machine_Kinds");

                entity.Property(e => e.KindId).HasColumnName("kind_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.KindName)
                    .HasColumnName("kind_name")
                    .HasMaxLength(20);

                entity.Property(e => e.TypeId).HasColumnName("type_id");
            });

            modelBuilder.Entity<BMachineModel>(entity =>
            {
                entity.ToTable("B_Machine_Model");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.KindId).HasColumnName("kind_id");

                entity.Property(e => e.MadeIn)
                    .HasColumnName("made_in")
                    .HasMaxLength(50);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("manufacturer")
                    .HasMaxLength(50);

                entity.Property(e => e.ModelCode)
                    .HasColumnName("model_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BMachineMouldKinds>(entity =>
            {
                entity.ToTable("B_Machine_Mould_Kinds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineKindId).HasColumnName("machine_kind_id");

                entity.Property(e => e.MouldKindId).HasColumnName("mould_kind_id");

                entity.Property(e => e.Parameter)
                    .HasColumnName("parameter")
                    .HasMaxLength(50);

                entity.Property(e => e.Qty).HasColumnName("qty");
            });

            modelBuilder.Entity<BMachinePropertyDetail>(entity =>
            {
                entity.ToTable("B_Machine_Property_Detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(50);

                entity.Property(e => e.PptCondition)
                    .HasColumnName("ppt_condition")
                    .HasMaxLength(20);

                entity.Property(e => e.PptId).HasColumnName("ppt_id");

                entity.Property(e => e.PptMax)
                    .HasColumnName("ppt_max")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PptMin)
                    .HasColumnName("ppt_min")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PptType).HasColumnName("ppt_type");

                entity.Property(e => e.PptVal)
                    .HasColumnName("ppt_val")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BMachineStandardPoints>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("B_Machine_Standard_Points");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BusinessCode)
                    .HasColumnName("business_code")
                    .HasMaxLength(30);

                entity.Property(e => e.BusinessName)
                    .HasColumnName("business_name")
                    .HasMaxLength(30);

                entity.Property(e => e.DriveCode)
                    .HasColumnName("drive_code")
                    .HasMaxLength(30);

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Parameter)
                    .HasColumnName("parameter")
                    .HasMaxLength(50);

                entity.Property(e => e.PointId).HasColumnName("point_id");

                entity.Property(e => e.TriggerCondition).HasColumnName("trigger_condition");
            });

            modelBuilder.Entity<BMachineStopreason>(entity =>
            {
                entity.ToTable("B_Machine_Stopreason");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(200);

                entity.Property(e => e.StopState).HasColumnName("stop_state");

                entity.Property(e => e.StopreasonCode)
                    .HasColumnName("stopreason_code")
                    .HasMaxLength(10);

                entity.Property(e => e.StopreasonName)
                    .HasColumnName("stopreason_name")
                    .HasMaxLength(50);

                entity.Property(e => e.StopreasonType).HasColumnName("stopreason_type");
            });

            modelBuilder.Entity<BMachineType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("B_Machine_Type");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("type_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BMachineWorkToolsKinds>(entity =>
            {
                entity.ToTable("B_Machine_WorkTools_Kinds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.MachineKindId).HasColumnName("machine_kind_id");

                entity.Property(e => e.Parameter)
                    .HasColumnName("parameter")
                    .HasMaxLength(50);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.WorkToolKindId).HasColumnName("workTool_kind_id");
            });

            modelBuilder.Entity<BMaintenance>(entity =>
            {
                entity.ToTable("B_Maintenance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CloseDate)
                    .HasColumnName("close_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EquipmentCode)
                    .HasColumnName("equipment_code")
                    .HasMaxLength(30);

                entity.Property(e => e.FillingDate)
                    .HasColumnName("filling_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaintenanceId).HasColumnName("maintenance_id");

                entity.Property(e => e.MaintenanceType).HasColumnName("maintenance_type");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(20);

                entity.Property(e => e.Val).HasColumnName("val");
            });

            modelBuilder.Entity<BMaterial>(entity =>
            {
                entity.HasKey(e => e.MatId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("B_Material");

                entity.HasIndex(e => e.MatCode)
                    .HasName("IX_B_Material_matcode")
                    .IsUnique();

                entity.Property(e => e.MatId).HasColumnName("mat_id");

                entity.Property(e => e.CodeRule)
                    .HasColumnName("code_rule")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.InputDate)
                    .HasColumnName("input_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lvl)
                    .HasColumnName("lvl")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MatCode)
                    .IsRequired()
                    .HasColumnName("mat_code")
                    .HasMaxLength(40);

                entity.Property(e => e.MatName)
                    .IsRequired()
                    .HasColumnName("mat_name")
                    .HasMaxLength(30);

                entity.Property(e => e.MaxQty)
                    .HasColumnName("max_qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Mbm).HasColumnName("mbm");

                entity.Property(e => e.PackingStyle)
                    .HasColumnName("packing_style")
                    .HasMaxLength(50);

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.StationValid)
                    .HasColumnName("station_valid")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(20);

                entity.Property(e => e.ValidDate).HasColumnName("valid_date");

                entity.Property(e => e.WipValid)
                    .HasColumnName("wip_valid")
                    .HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<BMaterialType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("B_Material_Type");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeName)
                    .HasColumnName("type_name")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BMatManagement>(entity =>
            {
                entity.ToTable("B_Mat_Management");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FeedHour)
                    .HasColumnName("feed_hour")
                    .HasColumnType("numeric(10, 1)");

                entity.Property(e => e.InputHour)
                    .HasColumnName("input_hour")
                    .HasColumnType("numeric(10, 1)");

                entity.Property(e => e.MatCode)
                    .IsRequired()
                    .HasColumnName("mat_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BMatSubstitute>(entity =>
            {
                entity.ToTable("B_MatSubstitute");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BomCode)
                    .HasColumnName("bom_code")
                    .HasMaxLength(30);

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasMaxLength(40);

                entity.Property(e => e.SubstituteMatCode)
                    .HasColumnName("Substitute_mat_code")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<BMouldCavity>(entity =>
            {
                entity.ToTable("B_Mould_Cavity");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CavityNum).HasColumnName("cavity_num");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.MouldCode)
                    .HasColumnName("mould_code")
                    .HasMaxLength(30);

                entity.Property(e => e.PedigreeCode)
                    .HasColumnName("pedigree_code")
                    .HasMaxLength(40);

                entity.Property(e => e.ProductGrams)
                    .HasColumnName("product_grams")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RunnerGrams)
                    .HasColumnName("runner_grams")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<BMouldKindProperty>(entity =>
            {
                entity.HasKey(e => e.PptId);

                entity.ToTable("B_Mould_Kind_Property");

                entity.Property(e => e.PptId).HasColumnName("ppt_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.KindId).HasColumnName("kind_id");

                entity.Property(e => e.PptName)
                    .HasColumnName("ppt_name")
                    .HasMaxLength(50);

                entity.Property(e => e.PptType).HasColumnName("ppt_type");
            });

            modelBuilder.Entity<BMouldKinds>(entity =>
            {
                entity.HasKey(e => e.KindId);

                entity.ToTable("B_Mould_Kinds");

                entity.Property(e => e.KindId).HasColumnName("kind_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.KindName)
                    .HasColumnName("kind_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeId).HasColumnName("type_id");
            });

            modelBuilder.Entity<BMouldModel>(entity =>
            {
                entity.ToTable("B_Mould_Model");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.KindId).HasColumnName("kind_id");

                entity.Property(e => e.MadeIn)
                    .HasColumnName("made_in")
                    .HasMaxLength(50);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("manufacturer")
                    .HasMaxLength(50);

                entity.Property(e => e.ModelCode)
                    .HasColumnName("model_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BMouldPropertyDetail>(entity =>
            {
                entity.ToTable("B_Mould_Property_Detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.MouldCode)
                    .HasColumnName("mould_code")
                    .HasMaxLength(50);

                entity.Property(e => e.PptCondition)
                    .HasColumnName("ppt_condition")
                    .HasMaxLength(20);

                entity.Property(e => e.PptId).HasColumnName("ppt_id");

                entity.Property(e => e.PptMax)
                    .HasColumnName("ppt_max")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PptMin)
                    .HasColumnName("ppt_min")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PptType).HasColumnName("ppt_type");

                entity.Property(e => e.PptVal)
                    .HasColumnName("ppt_val")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BMoulds>(entity =>
            {
                entity.ToTable("B_Moulds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ModelCode)
                    .HasColumnName("model_code")
                    .HasMaxLength(50);

                entity.Property(e => e.MouldCode)
                    .HasColumnName("mould_code")
                    .HasMaxLength(30);

                entity.Property(e => e.MouldName)
                    .HasColumnName("mould_name")
                    .HasMaxLength(50);

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.StationCode)
                    .HasColumnName("station_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Supplier)
                    .HasColumnName("supplier")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeId).HasColumnName("type_id");
            });

            modelBuilder.Entity<BMouldType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("B_Mould_Type");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeName)
                    .HasColumnName("type_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BNgCode>(entity =>
            {
                entity.HasKey(e => e.NgId);

                entity.ToTable("B_NG_Code");

                entity.Property(e => e.NgId).HasColumnName("ng_id");

                entity.Property(e => e.Decription)
                    .HasColumnName("decription")
                    .HasMaxLength(30);

                entity.Property(e => e.ExecProc).HasColumnName("exec_proc");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.NgCode)
                    .IsRequired()
                    .HasColumnName("ng_code")
                    .HasMaxLength(30);

                entity.Property(e => e.NgName)
                    .HasColumnName("ng_name")
                    .HasMaxLength(30);

                entity.Property(e => e.TypeCode1)
                    .HasColumnName("type_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Typecode)
                    .IsRequired()
                    .HasColumnName("typecode")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BNgReason>(entity =>
            {
                entity.ToTable("B_NG_Reason");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(30);

                entity.Property(e => e.ReasonCode)
                    .HasColumnName("reason_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ReasonName)
                    .HasColumnName("reason_name")
                    .HasMaxLength(30);

                entity.Property(e => e.Typecode)
                    .IsRequired()
                    .HasColumnName("typecode")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BNgReasonType>(entity =>
            {
                entity.HasKey(e => e.ReasonTypeId);

                entity.ToTable("B_NG_ReasonType");

                entity.Property(e => e.ReasonTypeId).HasColumnName("ReasonType_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(30);

                entity.Property(e => e.ReasontypeCode)
                    .HasColumnName("reasontype_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ReasontypeName)
                    .HasColumnName("reasontype_name")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BNgType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("B_NG_Type");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(30);

                entity.Property(e => e.TypeCode)
                    .HasColumnName("type_code")
                    .HasMaxLength(30);

                entity.Property(e => e.TypeName)
                    .HasColumnName("type_name")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BPackLevel>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("B_Pack_Level");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeType).HasColumnName("code_type");

                entity.Property(e => e.DoPrint).HasColumnName("do_print");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LvlName)
                    .HasColumnName("lvl_name")
                    .HasMaxLength(30);

                entity.Property(e => e.PackNum)
                    .HasColumnName("pack_num")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PackRole)
                    .HasColumnName("pack_role")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PrintTempLate)
                    .HasColumnName("print_tempLate")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.WholePack).HasColumnName("whole_pack");
            });

            modelBuilder.Entity<BPedigree>(entity =>
            {
                entity.ToTable("B_Pedigree");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.PedigreeCode)
                    .IsRequired()
                    .HasColumnName("pedigree_code")
                    .HasMaxLength(50);

                entity.Property(e => e.PedigreeName)
                    .IsRequired()
                    .HasColumnName("pedigree_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductTypeId).HasColumnName("product_type_id");
            });

            modelBuilder.Entity<BPointTranslation>(entity =>
            {
                entity.ToTable("B_PointTranslation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PointId).HasColumnName("point_id");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Val)
                    .HasColumnName("val")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BPointType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("B_PointType");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeName)
                    .HasColumnName("type_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BPreStep>(entity =>
            {
                entity.HasKey(e => e.PreId);

                entity.ToTable("B_PreStep");

                entity.Property(e => e.PreId).HasColumnName("pre_id");

                entity.Property(e => e.AllowReuse).HasColumnName("allow_reuse");

                entity.Property(e => e.AutoRestart).HasColumnName("auto_restart");

                entity.Property(e => e.Autorun).HasColumnName("autorun");

                entity.Property(e => e.DriveCode)
                    .HasColumnName("drive_code")
                    .HasMaxLength(30);

                entity.Property(e => e.FlowCode)
                    .HasColumnName("flow_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Format)
                    .HasColumnName("format")
                    .HasMaxLength(100);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.IsRecord)
                    .HasColumnName("is_record")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Parameter)
                    .HasColumnName("parameter")
                    .HasMaxLength(100);

                entity.Property(e => e.Parameter2)
                    .HasColumnName("parameter2")
                    .HasMaxLength(30);

                entity.Property(e => e.ProcessCode)
                    .HasColumnName("process_code")
                    .HasMaxLength(30);

                entity.Property(e => e.StepCode)
                    .HasColumnName("step_code")
                    .HasMaxLength(20);

                entity.Property(e => e.StepName)
                    .HasColumnName("step_name")
                    .HasMaxLength(30);

                entity.Property(e => e.StepType)
                    .HasColumnName("step_type")
                    .HasMaxLength(30);

                entity.Property(e => e.TimeOut)
                    .HasColumnName("time_out")
                    .HasMaxLength(30);

                entity.Property(e => e.Triger)
                    .HasColumnName("triger")
                    .HasMaxLength(30);

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<BProcessControl>(entity =>
            {
                entity.ToTable("B_ProcessControl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ControlName)
                    .HasColumnName("control_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcessCode)
                    .HasColumnName("process_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BProcessFlow>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("B_Process_Flow");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BomId).HasColumnName("bom_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlowCode)
                    .IsRequired()
                    .HasColumnName("flow_code")
                    .HasMaxLength(30);

                entity.Property(e => e.FlowName)
                    .HasColumnName("flow_name")
                    .HasMaxLength(30);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(30);

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.VersionCode)
                    .HasColumnName("version_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BProcessFlowDetail>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("B_Process_Flow_Detail");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.DisposalCode)
                    .HasColumnName("disposal_code")
                    .HasMaxLength(30);

                entity.Property(e => e.FlowCode)
                    .IsRequired()
                    .HasColumnName("flow_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("imageUrl")
                    .HasColumnType("image");

                entity.Property(e => e.ProcessFrom)
                    .IsRequired()
                    .HasColumnName("process_from")
                    .HasMaxLength(30);

                entity.Property(e => e.ProcessFromGroup)
                    .IsRequired()
                    .HasColumnName("process_from_group")
                    .HasMaxLength(50);

                entity.Property(e => e.ProcessMinTime).HasColumnName("process_min_time");

                entity.Property(e => e.ProcessNext)
                    .HasColumnName("process_next")
                    .HasMaxLength(30);

                entity.Property(e => e.ProcessNextGroup)
                    .HasColumnName("process_next_group")
                    .HasMaxLength(30);

                entity.Property(e => e.ProcessResult)
                    .IsRequired()
                    .HasColumnName("process_result")
                    .HasMaxLength(20);

                entity.Property(e => e.StandardTime)
                    .HasColumnName("standard_time")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Strict).HasColumnName("strict");
            });

            modelBuilder.Entity<BProcessList>(entity =>
            {
                entity.HasKey(e => e.Processid)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("B_ProcessList");

                entity.Property(e => e.Processid).HasColumnName("processid");

                entity.Property(e => e.AllowPack).HasColumnName("allow_pack");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasColumnName("group_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.ProcessCode)
                    .IsRequired()
                    .HasColumnName("process_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ProcessName)
                    .HasColumnName("process_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductionMode).HasColumnName("production_mode");

                entity.Property(e => e.RouteType)
                    .IsRequired()
                    .HasColumnName("route_type")
                    .HasMaxLength(10);

                entity.Property(e => e.SectionName)
                    .HasColumnName("section_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TaskMode).HasColumnName("task_mode");

                entity.Property(e => e.TypeId).HasColumnName("type_id");
            });

            modelBuilder.Entity<BProcessSonStep>(entity =>
            {
                entity.ToTable("B_ProcessSonStep");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Back1).HasColumnName("back1");

                entity.Property(e => e.Back2)
                    .HasColumnName("back2")
                    .HasMaxLength(50);

                entity.Property(e => e.FlowCode)
                    .HasColumnName("flow_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Parentstepid)
                    .IsRequired()
                    .HasColumnName("parentstepid")
                    .HasMaxLength(50);

                entity.Property(e => e.Steperror)
                    .HasColumnName("steperror")
                    .HasMaxLength(50);

                entity.Property(e => e.Stepid)
                    .IsRequired()
                    .HasColumnName("stepid")
                    .HasMaxLength(50);

                entity.Property(e => e.Stepname)
                    .HasColumnName("stepname")
                    .HasMaxLength(50);

                entity.Property(e => e.Steppre)
                    .HasColumnName("steppre")
                    .HasMaxLength(50);

                entity.Property(e => e.Steptype).HasColumnName("steptype");
            });

            modelBuilder.Entity<BProcessSonStepList>(entity =>
            {
                entity.ToTable("B_ProcessSonStepList");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Back1).HasColumnName("back1");

                entity.Property(e => e.Back2)
                    .HasColumnName("back2")
                    .HasMaxLength(50);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Parentstepid).HasColumnName("parentstepid");

                entity.Property(e => e.Stepid)
                    .HasColumnName("stepid")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Stepname)
                    .HasColumnName("stepname")
                    .HasMaxLength(50);

                entity.Property(e => e.Steptype).HasColumnName("steptype");
            });

            modelBuilder.Entity<BProcessStep>(entity =>
            {
                entity.HasKey(e => e.StepId);

                entity.ToTable("B_ProcessStep");

                entity.HasIndex(e => new { e.FlowCode, e.StepCode })
                    .HasName("ununiqueparentstep")
                    .IsUnique();

                entity.Property(e => e.StepId).HasColumnName("step_id");

                entity.Property(e => e.AllowReuse).HasColumnName("allow_reuse");

                entity.Property(e => e.AutoRestart).HasColumnName("auto_restart");

                entity.Property(e => e.Autorun).HasColumnName("autorun");

                entity.Property(e => e.ConsumePercent).HasColumnName("consume_percent");

                entity.Property(e => e.ConsumeType).HasColumnName("consume_type");

                entity.Property(e => e.CtrlType).HasColumnName("ctrl_type");

                entity.Property(e => e.DriveCode)
                    .HasColumnName("drive_code")
                    .HasMaxLength(30);

                entity.Property(e => e.FlowCode)
                    .HasColumnName("flow_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Format)
                    .HasColumnName("format")
                    .HasMaxLength(100);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.IsRecord)
                    .HasColumnName("is_record")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Parameter)
                    .HasColumnName("parameter")
                    .HasMaxLength(100);

                entity.Property(e => e.Parameter2)
                    .HasColumnName("parameter2")
                    .HasMaxLength(30);

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.ProcessCode)
                    .HasColumnName("process_code")
                    .HasMaxLength(30);

                entity.Property(e => e.StepCode)
                    .HasColumnName("step_code")
                    .HasMaxLength(20);

                entity.Property(e => e.StepName)
                    .HasColumnName("step_name")
                    .HasMaxLength(30);

                entity.Property(e => e.StepType)
                    .HasColumnName("step_type")
                    .HasMaxLength(30);

                entity.Property(e => e.TimeOut)
                    .HasColumnName("time_out")
                    .HasMaxLength(30);

                entity.Property(e => e.Triger)
                    .HasColumnName("triger")
                    .HasMaxLength(30);

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<BProcessStepA>(entity =>
            {
                entity.HasKey(e => e.StepId);

                entity.ToTable("B_processStep_A");

                entity.Property(e => e.StepId).HasColumnName("step_id");

                entity.Property(e => e.AllowReuse).HasColumnName("allow_reuse");

                entity.Property(e => e.AutoRestart).HasColumnName("auto_restart");

                entity.Property(e => e.Autorun).HasColumnName("autorun");

                entity.Property(e => e.ConsumePercent).HasColumnName("consume_percent");

                entity.Property(e => e.ConsumeType).HasColumnName("consume_type");

                entity.Property(e => e.CtrlType).HasColumnName("ctrl_type");

                entity.Property(e => e.DriveCode)
                    .HasColumnName("drive_code")
                    .HasMaxLength(30);

                entity.Property(e => e.FlowCode)
                    .HasColumnName("flow_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Format)
                    .HasColumnName("format")
                    .HasMaxLength(100);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.IsRecord).HasColumnName("is_record");

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Parameter)
                    .HasColumnName("parameter")
                    .HasMaxLength(100);

                entity.Property(e => e.Parameter2)
                    .HasColumnName("parameter2")
                    .HasMaxLength(30);

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.ProcessCode)
                    .HasColumnName("process_code")
                    .HasMaxLength(30);

                entity.Property(e => e.StepCode)
                    .HasColumnName("step_code")
                    .HasMaxLength(20);

                entity.Property(e => e.StepName)
                    .HasColumnName("step_name")
                    .HasMaxLength(30);

                entity.Property(e => e.StepType)
                    .HasColumnName("step_type")
                    .HasMaxLength(30);

                entity.Property(e => e.TimeOut)
                    .HasColumnName("time_out")
                    .HasMaxLength(30);

                entity.Property(e => e.Triger)
                    .HasColumnName("triger")
                    .HasMaxLength(30);

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<BProcessType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("B_ProcessType");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Desccription)
                    .HasColumnName("desccription")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeCode)
                    .HasColumnName("type_code")
                    .HasMaxLength(30);

                entity.Property(e => e.TypeName)
                    .HasColumnName("type_name")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BProcRequirement>(entity =>
            {
                entity.HasKey(e => e.ReqId);

                entity.ToTable("B_Proc_Requirement");

                entity.Property(e => e.ReqId).HasColumnName("req_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasColumnName("product_code")
                    .HasMaxLength(40);

                entity.Property(e => e.ReqName)
                    .HasColumnName("req_name")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("B_Product");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Cmn)
                    .HasColumnName("CMN")
                    .HasMaxLength(40);

                entity.Property(e => e.CodeRule)
                    .HasColumnName("code_rule")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lvl)
                    .HasColumnName("lvl")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ManageType).HasColumnName("manage_type");

                entity.Property(e => e.MaxQty)
                    .HasColumnName("max_qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Mbm).HasColumnName("mbm");

                entity.Property(e => e.ModelCode)
                    .HasColumnName("model_code")
                    .HasMaxLength(50);

                entity.Property(e => e.PedigreeCode)
                    .HasColumnName("pedigree_code")
                    .HasMaxLength(50);

                entity.Property(e => e.PrintBind).HasColumnName("print_bind");

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(40);

                entity.Property(e => e.ProductName)
                    .HasColumnName("product_name")
                    .HasMaxLength(40);

                entity.Property(e => e.RouteType).HasColumnName("route_type");

                entity.Property(e => e.Spt).HasColumnName("spt");

                entity.Property(e => e.StationValid)
                    .HasColumnName("station_valid")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Typecode)
                    .HasColumnName("typecode")
                    .HasMaxLength(30);

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(20);

                entity.Property(e => e.VersionCode)
                    .HasColumnName("version_code")
                    .HasMaxLength(20);

                entity.Property(e => e.WipValid)
                    .HasColumnName("wip_valid")
                    .HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<BProductGrade>(entity =>
            {
                entity.HasKey(e => e.GradeId);

                entity.ToTable("B_Product_Grade");

                entity.Property(e => e.GradeId).HasColumnName("grade_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(30);

                entity.Property(e => e.GradeCode)
                    .HasColumnName("grade_code")
                    .HasMaxLength(50);

                entity.Property(e => e.GradeName)
                    .HasColumnName("grade_name")
                    .HasMaxLength(30);

                entity.Property(e => e.GradeType)
                    .HasColumnName("grade_type")
                    .HasMaxLength(30);

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .HasMaxLength(30);

                entity.Property(e => e.Parameter)
                    .HasColumnName("parameter")
                    .HasMaxLength(50);

                entity.Property(e => e.Typecode)
                    .HasColumnName("typecode")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BProductModel>(entity =>
            {
                entity.ToTable("B_Product_Model");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ModelCode)
                    .HasColumnName("model_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ModelName)
                    .HasColumnName("model_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BProductType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("B_Product_Type");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeName)
                    .HasColumnName("type_name")
                    .HasMaxLength(30);

                entity.Property(e => e.Typecode)
                    .HasColumnName("typecode")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BReport>(entity =>
            {
                entity.HasKey(e => e.ReportCode);

                entity.ToTable("B_Report");

                entity.Property(e => e.ReportCode)
                    .HasColumnName("report_code")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.QuerySql)
                    .IsRequired()
                    .HasColumnName("query_sql")
                    .HasColumnType("text");

                entity.Property(e => e.QueryType).HasColumnName("query_type");

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasColumnName("report_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BReportField>(entity =>
            {
                entity.HasKey(e => new { e.ReportCode, e.Prop });

                entity.ToTable("B_Report_Field");

                entity.Property(e => e.ReportCode)
                    .HasColumnName("report_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prop)
                    .HasColumnName("prop")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Align)
                    .IsRequired()
                    .HasColumnName("align")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('left')");

                entity.Property(e => e.ControlCode)
                    .HasColumnName("control_code")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('mInput')");

                entity.Property(e => e.ControlSpan)
                    .HasColumnName("control_span")
                    .HasDefaultValueSql("((6))");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.IsCheck).HasColumnName("is_check");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnName("label")
                    .HasMaxLength(50);

                entity.Property(e => e.OptionsApi)
                    .HasColumnName("options_api")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Required)
                    .HasColumnName("required")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Width)
                    .IsRequired()
                    .HasColumnName("width")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<BReportQueryControl>(entity =>
            {
                entity.HasKey(e => e.ControlCode);

                entity.ToTable("B_Report_Query_Control");

                entity.Property(e => e.ControlCode)
                    .HasColumnName("control_code")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ControlName)
                    .IsRequired()
                    .HasColumnName("control_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BSearchManagement>(entity =>
            {
                entity.ToTable("B_SearchManagement");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SearchName)
                    .HasColumnName("search_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Val1)
                    .HasColumnName("val1")
                    .HasMaxLength(200);

                entity.Property(e => e.Val10)
                    .HasColumnName("val10")
                    .HasMaxLength(200);

                entity.Property(e => e.Val11)
                    .HasColumnName("val11")
                    .HasMaxLength(200);

                entity.Property(e => e.Val12)
                    .HasColumnName("val12")
                    .HasMaxLength(200);

                entity.Property(e => e.Val13)
                    .HasColumnName("val13")
                    .HasMaxLength(200);

                entity.Property(e => e.Val14)
                    .HasColumnName("val14")
                    .HasMaxLength(200);

                entity.Property(e => e.Val15)
                    .HasColumnName("val15")
                    .HasMaxLength(200);

                entity.Property(e => e.Val2)
                    .HasColumnName("val2")
                    .HasMaxLength(200);

                entity.Property(e => e.Val3)
                    .HasColumnName("val3")
                    .HasMaxLength(200);

                entity.Property(e => e.Val4)
                    .HasColumnName("val4")
                    .HasMaxLength(200);

                entity.Property(e => e.Val5)
                    .HasColumnName("val5")
                    .HasMaxLength(200);

                entity.Property(e => e.Val6)
                    .HasColumnName("val6")
                    .HasMaxLength(200);

                entity.Property(e => e.Val7)
                    .HasColumnName("val7")
                    .HasMaxLength(200);

                entity.Property(e => e.Val8)
                    .HasColumnName("val8")
                    .HasMaxLength(200);

                entity.Property(e => e.Val9)
                    .HasColumnName("val9")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<BSopimage>(entity =>
            {
                entity.ToTable("B_SOPImage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpCode)
                    .HasColumnName("emp_code")
                    .HasMaxLength(50);

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<BSparepart>(entity =>
            {
                entity.HasKey(e => e.SparepartCode);

                entity.ToTable("B_Sparepart");

                entity.Property(e => e.SparepartCode)
                    .HasColumnName("sparepart_code")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Arrivaldate)
                    .HasColumnName("arrivaldate")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("manufacturer")
                    .HasMaxLength(50);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(50);

                entity.Property(e => e.Ofmachine)
                    .HasColumnName("ofmachine")
                    .HasMaxLength(50);

                entity.Property(e => e.SparepartName)
                    .HasColumnName("sparepart_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.WsCode)
                    .HasColumnName("ws_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BStationList>(entity =>
            {
                entity.HasKey(e => e.Stationid);

                entity.ToTable("B_StationList");

                entity.HasIndex(e => e.Stationid)
                    .HasName("IX_B_StationList");

                entity.Property(e => e.Stationid).HasColumnName("stationid");

                entity.Property(e => e.Discription)
                    .HasColumnName("discription")
                    .HasMaxLength(50);

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ip_address")
                    .HasMaxLength(20);

                entity.Property(e => e.IsFormal)
                    .HasColumnName("is_formal")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LineId).HasColumnName("line_id");

                entity.Property(e => e.MacAddress)
                    .HasColumnName("mac_address")
                    .HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .IsRequired()
                    .HasColumnName("process_code")
                    .HasMaxLength(30);

                entity.Property(e => e.StationCode)
                    .IsRequired()
                    .HasColumnName("station_code")
                    .HasMaxLength(30);

                entity.Property(e => e.StationName)
                    .HasColumnName("station_name")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BStationMachine>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("B_StationMachine");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ExpectNexttime)
                    .HasColumnName("expect_nexttime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastMaintaintime)
                    .HasColumnName("last_maintaintime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineCode)
                    .IsRequired()
                    .HasColumnName("machine_code")
                    .HasMaxLength(30);

                entity.Property(e => e.MachineState)
                    .HasColumnName("machine_state")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaintainCycle)
                    .HasColumnName("maintain_cycle")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(128);

                entity.Property(e => e.StationCode)
                    .IsRequired()
                    .HasColumnName("station_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BStationMatPoint>(entity =>
            {
                entity.ToTable("B_Station_Mat_Point");

                entity.HasIndex(e => new { e.MatCode, e.PointId, e.ProductCode })
                    .HasName("IX_B_Station_Mat_Point")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasMaxLength(30);

                entity.Property(e => e.MaxQty)
                    .HasColumnName("max_qty")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PointId).HasColumnName("point_id");

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BStationMountPoint>(entity =>
            {
                entity.HasKey(e => e.PointId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("B_Station_Mount_Point");

                entity.Property(e => e.PointId).HasColumnName("point_id");

                entity.Property(e => e.CodeRule)
                    .HasColumnName("code_rule")
                    .HasMaxLength(30);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.PointCode)
                    .HasColumnName("point_code")
                    .HasMaxLength(30);

                entity.Property(e => e.StationCode)
                    .HasColumnName("station_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<BSubReport>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("B_SubReport");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.BtnText)
                    .IsRequired()
                    .HasColumnName("btn_text")
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportCode)
                    .IsRequired()
                    .HasColumnName("report_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sql)
                    .IsRequired()
                    .HasColumnName("sql")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<BTool>(entity =>
            {
                entity.ToTable("B_Tool");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Arrivaldate)
                    .HasColumnName("arrivaldate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("manufacturer")
                    .HasMaxLength(50);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(50);

                entity.Property(e => e.ToolCode)
                    .HasColumnName("tool_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ToolName)
                    .HasColumnName("tool_name")
                    .HasMaxLength(20);

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.WorkflowId).HasColumnName("workflow_id");
            });

            modelBuilder.Entity<BToolParameter>(entity =>
            {
                entity.ToTable("B_Tool_Parameter");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ParameterName)
                    .HasColumnName("parameter_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ToolCode)
                    .HasColumnName("tool_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BToolType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("B_Tool_Type");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeName)
                    .HasColumnName("type_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BTranslation>(entity =>
            {
                entity.ToTable("B_Translation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.TransCode)
                    .IsRequired()
                    .HasColumnName("trans_code")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeId).HasColumnName("type_id");
            });

            modelBuilder.Entity<BTranslationDetail>(entity =>
            {
                entity.ToTable("B_Translation_Detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FromValue)
                    .HasColumnName("from_value")
                    .HasMaxLength(50);

                entity.Property(e => e.Parameter)
                    .HasColumnName("parameter")
                    .HasMaxLength(50);

                entity.Property(e => e.ToValue)
                    .HasColumnName("to_value")
                    .HasMaxLength(50);

                entity.Property(e => e.TransCode)
                    .IsRequired()
                    .HasColumnName("trans_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BTranslationType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("B_Translation_Type");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.TypeName)
                    .HasColumnName("type_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BWorkGroup>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("B_WorkGroup");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasColumnName("group_code")
                    .HasMaxLength(30);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasMaxLength(30);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Wsid).HasColumnName("wsid");
            });

            modelBuilder.Entity<BWorkGroupClass>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("B_WorkGroup_Class");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.ClassCode)
                    .HasColumnName("class_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ClassName)
                    .HasColumnName("class_name")
                    .HasMaxLength(30);

                entity.Property(e => e.DayEnd).HasColumnName("day_end");

                entity.Property(e => e.DayStart).HasColumnName("day_start");

                entity.Property(e => e.GroupCode)
                    .HasColumnName("group_code")
                    .HasMaxLength(30);

                entity.Property(e => e.TimeEnd)
                    .HasColumnName("time_end")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStart)
                    .HasColumnName("time_start")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BWorkShop>(entity =>
            {
                entity.HasKey(e => e.Wsid)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("B_WorkShop");

                entity.HasIndex(e => e.WsCode)
                    .HasName("IX_B_WorkShop")
                    .IsUnique();

                entity.Property(e => e.Wsid).HasColumnName("wsid");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.WsCode)
                    .HasColumnName("ws_code")
                    .HasMaxLength(30);

                entity.Property(e => e.WsName)
                    .HasColumnName("ws_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BWorkTool>(entity =>
            {
                entity.ToTable("B_WorkTool");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.ModelCode)
                    .HasColumnName("model_code")
                    .HasMaxLength(50);

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.StorageRoom)
                    .HasColumnName("storage_room")
                    .HasMaxLength(50);

                entity.Property(e => e.StorePlace)
                    .HasColumnName("store_place")
                    .HasMaxLength(50);

                entity.Property(e => e.Supplier)
                    .HasColumnName("supplier")
                    .HasMaxLength(50);

                entity.Property(e => e.UsePlace)
                    .HasColumnName("use_place")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkToolCode)
                    .HasColumnName("workTool_code")
                    .HasMaxLength(30);

                entity.Property(e => e.WorkToolName)
                    .HasColumnName("workTool_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BWorkToolKindProperty>(entity =>
            {
                entity.HasKey(e => e.PptId);

                entity.ToTable("B_WorkTool_Kind_Property");

                entity.Property(e => e.PptId).HasColumnName("ppt_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.KindId).HasColumnName("kind_id");

                entity.Property(e => e.PptName)
                    .HasColumnName("ppt_name")
                    .HasMaxLength(20);

                entity.Property(e => e.PptType).HasColumnName("ppt_type");
            });

            modelBuilder.Entity<BWorkToolKinds>(entity =>
            {
                entity.HasKey(e => e.KindId);

                entity.ToTable("B_WorkTool_Kinds");

                entity.Property(e => e.KindId).HasColumnName("kind_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.KindName)
                    .HasColumnName("kind_name")
                    .HasMaxLength(20);

                entity.Property(e => e.TypeId).HasColumnName("type_id");
            });

            modelBuilder.Entity<BWorkToolModel>(entity =>
            {
                entity.ToTable("B_WorkTool_Model");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.KindId).HasColumnName("kind_id");

                entity.Property(e => e.MadeIn)
                    .HasColumnName("made_in")
                    .HasMaxLength(20);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("manufacturer")
                    .HasMaxLength(50);

                entity.Property(e => e.ModelCode)
                    .HasColumnName("model_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BWorkToolPropertyDetail>(entity =>
            {
                entity.ToTable("B_WorkTool_Property_Detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.PptCondition)
                    .HasColumnName("ppt_condition")
                    .HasMaxLength(20);

                entity.Property(e => e.PptId).HasColumnName("ppt_id");

                entity.Property(e => e.PptMax)
                    .HasColumnName("ppt_max")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PptMin)
                    .HasColumnName("ppt_min")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PptType).HasColumnName("ppt_type");

                entity.Property(e => e.PptVal)
                    .HasColumnName("ppt_val")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkToolCode)
                    .HasColumnName("workTool_code")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<BWorkToolType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("B_WorkTool_Type");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeName)
                    .HasColumnName("type_name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<PAbnormalDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_Abnormal_Detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbnormalId).HasColumnName("Abnormal_id");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Prevent)
                    .HasColumnName("prevent")
                    .HasMaxLength(800);

                entity.Property(e => e.PreventDate)
                    .HasColumnName("prevent_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreventDepart)
                    .HasColumnName("prevent_depart")
                    .HasMaxLength(30);

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(800);

                entity.Property(e => e.Soluntion)
                    .HasColumnName("soluntion")
                    .HasMaxLength(800);
            });

            modelBuilder.Entity<PAbnormalList>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_AbnormalList");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbnormalDesc)
                    .HasColumnName("Abnormal_desc")
                    .HasMaxLength(400);

                entity.Property(e => e.AbnormalNo)
                    .HasColumnName("Abnormal_no")
                    .HasMaxLength(30);

                entity.Property(e => e.DepartCode)
                    .HasColumnName("depart_code")
                    .HasMaxLength(30);

                entity.Property(e => e.DutyFrom)
                    .HasColumnName("duty_from")
                    .HasMaxLength(20);

                entity.Property(e => e.DutyFrom2)
                    .HasColumnName("duty_from2")
                    .HasMaxLength(20);

                entity.Property(e => e.DutyType)
                    .HasColumnName("duty_type")
                    .HasMaxLength(8);

                entity.Property(e => e.EffectDesc)
                    .HasColumnName("effect_desc")
                    .HasMaxLength(400);

                entity.Property(e => e.EffectEmp)
                    .HasColumnName("effect_emp")
                    .HasMaxLength(30);

                entity.Property(e => e.FailCount)
                    .HasColumnName("fail_count")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.FinishTime)
                    .HasColumnName("finish_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImpressionCount)
                    .HasColumnName("impression_count")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.InputTime)
                    .HasColumnName("inputTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ProcessCode)
                    .HasColumnName("process_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(40);

                entity.Property(e => e.SendEmp)
                    .HasColumnName("send_emp")
                    .HasMaxLength(15);

                entity.Property(e => e.Sfc)
                    .HasColumnName("sfc")
                    .HasMaxLength(60);

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.ToEmp)
                    .HasColumnName("to_emp")
                    .HasMaxLength(15);

                entity.Property(e => e.ToEmp2)
                    .HasColumnName("to_emp2")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<PAccessorisLoad>(entity =>
            {
                entity.ToTable("P_Accessoris_Load");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccessoryCode)
                    .HasColumnName("accessory_code")
                    .HasMaxLength(50);

                entity.Property(e => e.AccessoryName)
                    .HasColumnName("accessory_name")
                    .HasMaxLength(50);

                entity.Property(e => e.AccessoryType).HasColumnName("accessory_type");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.InverseIdNavigation)
                    .HasForeignKey<PAccessorisLoad>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_P_Accessoris_Load_P_Accessoris_Load");
            });

            modelBuilder.Entity<PAccessoryRecords>(entity =>
            {
                entity.ToTable("P_Accessory_Records");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessoryCode)
                    .HasColumnName("Accessory_code")
                    .HasMaxLength(50);

                entity.Property(e => e.AccessoryPreson)
                    .HasColumnName("Accessory_preson")
                    .HasMaxLength(50);

                entity.Property(e => e.Downtime)
                    .HasColumnName("downtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Loadtime)
                    .HasColumnName("loadtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(200);

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<PBarCodeBing>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_BarCodeBing");

                entity.HasIndex(e => e.Barcode)
                    .HasName("IX_P_BarCodeBing")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.MainOrder)
                    .HasName("IX_P_BarCodeBing_MOrder");

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasMaxLength(50);

                entity.Property(e => e.InputTime).HasColumnType("datetime");

                entity.Property(e => e.MainOrder)
                    .HasColumnName("main_order")
                    .HasMaxLength(50);

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentOrder)
                    .HasColumnName("parent_order")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(50);

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<PBlog>(entity =>
            {
                entity.HasKey(e => e.LogIdt);

                entity.ToTable("P_BLog");

                entity.Property(e => e.LogIdt).HasColumnName("log_idt");

                entity.Property(e => e.LogPosition)
                    .HasColumnName("log_position")
                    .HasMaxLength(20);

                entity.Property(e => e.LogText)
                    .HasColumnName("log_text")
                    .HasColumnType("ntext");

                entity.Property(e => e.LogTime)
                    .HasColumnName("log_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LogType)
                    .HasColumnName("log_type")
                    .HasMaxLength(20);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PDrateCollect>(entity =>
            {
                entity.ToTable("P_Drate_collect");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DRate)
                    .HasColumnName("d_rate")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PCode)
                    .HasColumnName("p_code")
                    .HasMaxLength(50);

                entity.Property(e => e.PDate)
                    .HasColumnName("p_date")
                    .HasColumnType("date");

                entity.Property(e => e.WsCode)
                    .HasColumnName("ws_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PEmpKpiCollect>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_Emp_kpi_collect");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Days)
                    .HasColumnName("days")
                    .HasMaxLength(10);

                entity.Property(e => e.EmpNo)
                    .HasColumnName("emp_no")
                    .HasMaxLength(30);

                entity.Property(e => e.FailQty)
                    .HasColumnName("fail_qty")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.FailTimes).HasColumnName("fail_times");

                entity.Property(e => e.Months)
                    .HasColumnName("months")
                    .HasMaxLength(10);

                entity.Property(e => e.ProcessCode)
                    .HasColumnName("process_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Weeks)
                    .HasColumnName("weeks")
                    .HasMaxLength(10);

                entity.Property(e => e.WorkTime)
                    .HasColumnName("work_time")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Years)
                    .HasColumnName("years")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<PFailDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_Fail_Detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fguid)
                    .HasColumnName("fguid")
                    .HasMaxLength(60);

                entity.Property(e => e.FinishTime)
                    .HasColumnName("finish_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgCode)
                    .HasColumnName("ng_code")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(50);

                entity.Property(e => e.Pass).HasColumnName("pass");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.ReasonCode)
                    .HasColumnName("reason_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ReasontypeCode)
                    .HasColumnName("reasontype_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Sfc)
                    .HasColumnName("sfc")
                    .HasMaxLength(60);

                entity.Property(e => e.WsCode)
                    .HasColumnName("ws_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PFailDetailNgCodeCollect>(entity =>
            {
                entity.HasKey(e => new { e.WorkshopCode, e.ProductCode, e.NgCode, e.Years, e.Months, e.Days })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_Fail_Detail_NgCode_collect");

                entity.Property(e => e.WorkshopCode)
                    .HasColumnName("workshop_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(30);

                entity.Property(e => e.NgCode)
                    .HasColumnName("ng_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Years)
                    .HasColumnName("years")
                    .HasMaxLength(10);

                entity.Property(e => e.Months)
                    .HasColumnName("months")
                    .HasMaxLength(10);

                entity.Property(e => e.Days)
                    .HasColumnName("days")
                    .HasMaxLength(10);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalQty)
                    .HasColumnName("Total_qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Weeks)
                    .HasColumnName("weeks")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<PFailDetailNgReasonCollect>(entity =>
            {
                entity.HasKey(e => new { e.WorkshopCode, e.ProductCode, e.ReasonCode, e.ReasontypeCode, e.Years, e.Months, e.Days })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_Fail_Detail_NgReason_collect");

                entity.Property(e => e.WorkshopCode)
                    .HasColumnName("workshop_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ReasonCode)
                    .HasColumnName("reason_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ReasontypeCode)
                    .HasColumnName("reasontype_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Years)
                    .HasColumnName("years")
                    .HasMaxLength(10);

                entity.Property(e => e.Months)
                    .HasColumnName("months")
                    .HasMaxLength(10);

                entity.Property(e => e.Days)
                    .HasColumnName("days")
                    .HasMaxLength(10);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalQty)
                    .HasColumnName("Total_qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Weeks)
                    .HasColumnName("weeks")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<PFailLog>(entity =>
            {
                entity.HasKey(e => e.Fid)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_FailLog");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.ClassCode)
                    .HasColumnName("class_code")
                    .HasMaxLength(10);

                entity.Property(e => e.DisposalProcess)
                    .HasColumnName("Disposal_Process")
                    .HasMaxLength(30);

                entity.Property(e => e.EmpCode)
                    .HasColumnName("emp_code")
                    .HasMaxLength(30);

                entity.Property(e => e.EquipmentCode)
                    .HasColumnName("equipment_code")
                    .HasMaxLength(30);

                entity.Property(e => e.FailTimes).HasColumnName("fail_times");

                entity.Property(e => e.Fguid)
                    .HasColumnName("fguid")
                    .HasMaxLength(50);

                entity.Property(e => e.FinishTime)
                    .HasColumnName("finish_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromEmp)
                    .HasColumnName("from_emp")
                    .HasMaxLength(30);

                entity.Property(e => e.FromProcess)
                    .HasColumnName("from_process")
                    .HasMaxLength(30);

                entity.Property(e => e.FromStation)
                    .HasColumnName("from_station")
                    .HasMaxLength(30);

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgRemark)
                    .HasColumnName("ng_remark")
                    .HasMaxLength(1024);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(50);

                entity.Property(e => e.PDate)
                    .HasColumnName("p_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcessCode)
                    .HasColumnName("process_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.RepairRemark)
                    .HasColumnName("repair_remark")
                    .HasMaxLength(512);

                entity.Property(e => e.Sfc)
                    .HasColumnName("sfc")
                    .HasMaxLength(60);

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.WsCode)
                    .HasColumnName("ws_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PIpqcData>(entity =>
            {
                entity.HasKey(e => e.QcId);

                entity.ToTable("P_IPQC_Data");

                entity.Property(e => e.QcId).HasColumnName("qc_id");

                entity.Property(e => e.CheckPerson).HasMaxLength(20);

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(200);

                entity.Property(e => e.FlowCode)
                    .HasColumnName("flow_code")
                    .HasMaxLength(50);

                entity.Property(e => e.MachineNum).HasMaxLength(10);

                entity.Property(e => e.ProcessCode)
                    .HasColumnName("process_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ReviewPerson).HasMaxLength(20);

                entity.Property(e => e.Sfc)
                    .HasColumnName("sfc")
                    .HasMaxLength(50);

                entity.Property(e => e.Shift).HasMaxLength(10);

                entity.Property(e => e.StationCode)
                    .HasColumnName("station_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<PIpqcDataDetail>(entity =>
            {
                entity.ToTable("P_IPQC_Data_Detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.QcId).HasColumnName("qc_id");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(50);

                entity.Property(e => e.Result).HasColumnName("result");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PIpqcItem>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("P_IPQC_Item");

                entity.HasIndex(e => new { e.ProcessCode, e.CheckItemCode })
                    .HasName("IX_P_IPQC_Item")
                    .IsUnique();

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.CheckItemCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CheckItemName).HasMaxLength(50);

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .IsRequired()
                    .HasColumnName("process_code")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<PIpqcTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("P_IPQC_Template");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.Allowable).HasMaxLength(15);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.FlowCode)
                    .IsRequired()
                    .HasColumnName("flow_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ProStds).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasColumnName("process_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PMachineException>(entity =>
            {
                entity.HasKey(e => e.ExceptionCode);

                entity.ToTable("P_Machine_Exception");

                entity.Property(e => e.ExceptionCode)
                    .HasColumnName("exception_code")
                    .ValueGeneratedNever();

                entity.Property(e => e.FaultphenomenonCode)
                    .HasColumnName("faultphenomenon_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Isdelete).HasColumnName("isdelete");

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(200);

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.SubmitPerson)
                    .HasColumnName("submit_person")
                    .HasMaxLength(10);

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submit_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PMachineMaintainrecords>(entity =>
            {
                entity.HasKey(e => e.MaintainCode);

                entity.ToTable("P_Machine_Maintainrecords");

                entity.Property(e => e.MaintainCode)
                    .HasColumnName("maintain_code")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(50);

                entity.Property(e => e.MaintainEndtime)
                    .HasColumnName("maintain_endtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaintainPerson)
                    .HasColumnName("maintain_person")
                    .HasMaxLength(10);

                entity.Property(e => e.MaintainStarttime)
                    .HasColumnName("maintain_starttime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaintainType)
                    .HasColumnName("maintain_type")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<PMachineMouldInstall>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_Machine_Mould_Install");

                entity.HasIndex(e => e.MachineCode)
                    .HasName("IX_P_MachineCode");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmpCode)
                    .HasColumnName("emp_code")
                    .HasMaxLength(20);

                entity.Property(e => e.InstallTime)
                    .HasColumnName("install_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(30);

                entity.Property(e => e.MouldCode)
                    .HasColumnName("mould_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PMachineRepairrecords>(entity =>
            {
                entity.HasKey(e => e.RepairCode);

                entity.ToTable("P_Machine_Repairrecords");

                entity.Property(e => e.RepairCode)
                    .HasColumnName("repair_code")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.ExceptionCode)
                    .IsRequired()
                    .HasColumnName("exception_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ExceptionReason)
                    .HasColumnName("exception_reason")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(50);

                entity.Property(e => e.RepairEndtime)
                    .HasColumnName("repair_endtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.RepairPerson)
                    .HasColumnName("repair_person")
                    .HasMaxLength(20);

                entity.Property(e => e.RepairRemarks)
                    .HasColumnName("repair_remarks")
                    .HasMaxLength(200);

                entity.Property(e => e.RepairResult).HasColumnName("repair_result");

                entity.Property(e => e.RepairStarttime)
                    .HasColumnName("repair_starttime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PMachineStopRecords>(entity =>
            {
                entity.ToTable("P_Machine_StopRecords");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Endtime)
                    .HasColumnName("endtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsNew).HasColumnName("isNew");

                entity.Property(e => e.MachineCode)
                    .IsRequired()
                    .HasColumnName("machine_code")
                    .HasMaxLength(30);

                entity.Property(e => e.OperatePerson)
                    .HasColumnName("operate_person")
                    .HasMaxLength(30);

                entity.Property(e => e.ProcessCode)
                    .HasColumnName("process_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Starttime)
                    .HasColumnName("starttime")
                    .HasColumnType("datetime");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.StationCode)
                    .HasColumnName("station_code")
                    .HasMaxLength(30);

                entity.Property(e => e.StopReason)
                    .HasColumnName("stop_reason")
                    .HasMaxLength(30);

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.WsCode)
                    .HasColumnName("ws_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PMaintenanceDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_MaintenanceDetail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaintenanceId).HasColumnName("maintenance_id");

                entity.Property(e => e.OutputTime)
                    .HasColumnName("output_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UseTimes).HasColumnName("use_times");

                entity.Property(e => e.UserDate)
                    .HasColumnName("user_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserOrder)
                    .HasColumnName("user_order")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PMainWorkOrder>(entity =>
            {
                entity.ToTable("P_MainWorkOrder");

                entity.Property(e => e.MainOrder)
                    .HasColumnName("Main_order")
                    .HasMaxLength(50);

                entity.Property(e => e.PlanTime).HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .HasColumnName("Product_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PMatAutoSend>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_Mat_AutoSend");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Condition)
                    .HasColumnName("condition")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasMaxLength(40);

                entity.Property(e => e.ProcessCode)
                    .HasColumnName("process_code")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<PMaterialWip>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_Material_WIP");

                entity.HasIndex(e => e.LotNo)
                    .HasName("IX_P_Material_WIP_LOT")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.ParentOrder)
                    .HasName("IX_P_Material_WIP_ORDER");

                entity.HasIndex(e => new { e.LotNo, e.MatCode, e.OrderNo, e.ParentOrder, e.Workshop })
                    .HasName("UNIQ_P_Material_WIP")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BillNo)
                    .HasColumnName("bill_no")
                    .HasMaxLength(50);

                entity.Property(e => e.FeedTime)
                    .HasColumnName("feed_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.InputQty)
                    .HasColumnName("input_qty")
                    .HasColumnType("decimal(11, 4)");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasColumnName("lot_no")
                    .HasMaxLength(50);

                entity.Property(e => e.LotQty)
                    .HasColumnName("lot_qty")
                    .HasColumnType("decimal(11, 4)");

                entity.Property(e => e.MainOrder)
                    .HasColumnName("main_order")
                    .HasMaxLength(50);

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasMaxLength(30);

                entity.Property(e => e.MatCodeFact)
                    .HasColumnName("mat_code_fact")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentOrder)
                    .HasColumnName("Parent_order")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentStation)
                    .HasColumnName("parent_station")
                    .HasMaxLength(50);

                entity.Property(e => e.PointId).HasColumnName("point_id");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.StationCode)
                    .HasColumnName("station_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Workshop)
                    .HasColumnName("workshop")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PMatManagementDetail>(entity =>
            {
                entity.ToTable("P_Mat_ManagementDetail");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FeedOrder)
                    .HasColumnName("feed_order")
                    .HasMaxLength(30);

                entity.Property(e => e.FeedStation)
                    .HasColumnName("feed_station")
                    .HasMaxLength(30);

                entity.Property(e => e.FeedTime)
                    .HasColumnName("feed_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasColumnName("lot_no")
                    .HasMaxLength(40);

                entity.Property(e => e.ShutTime)
                    .HasColumnName("shut_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PMatTransferDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_Mat_Transfer_Detail");

                entity.HasIndex(e => e.BillNo)
                    .HasName("IX_P_Mat_Transfer_Detail_Bill");

                entity.HasIndex(e => e.LotNo)
                    .HasName("IX_P_Mat_Transfer_Detail_Lot")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.OrderNo)
                    .HasName("IX_P_Mat_Transfer_Detail_Order");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BillNo)
                    .HasColumnName("bill_no")
                    .HasMaxLength(50);

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasColumnName("lot_no")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(50);

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.TransferId)
                    .HasColumnName("transfer_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Workshop)
                    .HasColumnName("workshop")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<PMatWipSeed>(entity =>
            {
                entity.ToTable("P_Mat_WIP_Seed");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmpCode)
                    .HasColumnName("emp_code")
                    .HasMaxLength(50);

                entity.Property(e => e.FeelTime)
                    .HasColumnName("feel_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasColumnName("lot_no")
                    .HasMaxLength(50);

                entity.Property(e => e.LotQty)
                    .HasColumnName("lot_qty")
                    .HasColumnType("decimal(11, 4)");

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderAbove)
                    .HasColumnName("order_above")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(50);

                entity.Property(e => e.PointId).HasColumnName("point_id");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.StationCode)
                    .HasColumnName("station_code")
                    .HasMaxLength(50);

                entity.Property(e => e.UnloadTime)
                    .HasColumnName("unload_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.WipId).HasColumnName("wip_id");
            });

            modelBuilder.Entity<PNgScrap>(entity =>
            {
                entity.ToTable("P_NG_Scrap");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Applicants).HasMaxLength(50);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImprovementMeasures)
                    .HasColumnName("Improvement_Measures")
                    .HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Process).HasMaxLength(10);

                entity.Property(e => e.ProductType)
                    .HasColumnName("Product_type")
                    .HasMaxLength(50);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Reason).HasMaxLength(50);

                entity.Property(e => e.ResponsibilityJudgment)
                    .HasColumnName("Responsibility_Judgment")
                    .HasMaxLength(50);

                entity.Property(e => e.ResponsibleDepartment)
                    .HasColumnName("Responsible_Department")
                    .HasMaxLength(50);

                entity.Property(e => e.Reviewer).HasMaxLength(50);

                entity.Property(e => e.ScrapLot)
                    .HasColumnName("Scrap_lot")
                    .HasMaxLength(50);

                entity.Property(e => e.Workshop).HasMaxLength(50);
            });

            modelBuilder.Entity<PNphCollect>(entity =>
            {
                entity.ToTable("P_nph_collect");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nph)
                    .HasColumnName("nph")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.PCode)
                    .HasColumnName("p_code")
                    .HasMaxLength(50);

                entity.Property(e => e.PDate)
                    .HasColumnName("P_date")
                    .HasColumnType("date");

                entity.Property(e => e.WsCode)
                    .HasColumnName("ws_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<POnLineMaterial>(entity =>
            {
                entity.HasKey(e => e.LotNo);

                entity.ToTable("P_OnLineMaterial");

                entity.Property(e => e.LotNo)
                    .HasColumnName("lot_no")
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasMaxLength(40);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(40);

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.StationCode)
                    .HasColumnName("station_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<POrderMachine>(entity =>
            {
                entity.ToTable("P_Order_Machine");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FatherOrder)
                    .HasColumnName("father_order")
                    .HasMaxLength(50);

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Inputdate)
                    .HasColumnName("inputdate")
                    .HasColumnType("date");

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(50);

                entity.Property(e => e.MainOrder)
                    .HasColumnName("main_order")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Sfc)
                    .HasColumnName("sfc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<POrderStation>(entity =>
            {
                entity.ToTable("P_Order_Station");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmpCode)
                    .HasColumnName("emp_code")
                    .HasMaxLength(30);

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MainOrder)
                    .HasColumnName("main_order")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentOrder)
                    .HasColumnName("parent_order")
                    .HasMaxLength(50);

                entity.Property(e => e.Sfc)
                    .HasColumnName("sfc")
                    .HasMaxLength(50);

                entity.Property(e => e.StationCode)
                    .HasColumnName("station_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PPddData>(entity =>
            {
                entity.HasKey(e => e.Lvl1);

                entity.ToTable("P_PDD_Data");

                entity.Property(e => e.Lvl1)
                    .HasColumnName("lvl1")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Lvl10)
                    .HasColumnName("lvl10")
                    .HasMaxLength(50);

                entity.Property(e => e.Lvl2)
                    .HasColumnName("lvl2")
                    .HasMaxLength(50);

                entity.Property(e => e.Lvl3)
                    .HasColumnName("lvl3")
                    .HasMaxLength(50);

                entity.Property(e => e.Lvl4)
                    .HasColumnName("lvl4")
                    .HasMaxLength(50);

                entity.Property(e => e.Lvl5)
                    .HasColumnName("lvl5")
                    .HasMaxLength(50);

                entity.Property(e => e.Lvl6)
                    .HasColumnName("lvl6")
                    .HasMaxLength(50);

                entity.Property(e => e.Lvl7)
                    .HasColumnName("lvl7")
                    .HasMaxLength(50);

                entity.Property(e => e.Lvl8)
                    .HasColumnName("lvl8")
                    .HasMaxLength(50);

                entity.Property(e => e.Lvl9)
                    .HasColumnName("lvl9")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PPrintCurrentSn>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_Print_CurrentSN");

                entity.HasIndex(e => new { e.Prefix, e.Suffix })
                    .HasName("IX_P_Print_CurrentSN");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CurrentSn).HasColumnName("current_sn");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Prefix)
                    .HasColumnName("prefix")
                    .HasMaxLength(30);

                entity.Property(e => e.Suffix)
                    .HasColumnName("suffix")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PProcRequirementDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_Proc_Requirement_Detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(30);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ReqId).HasColumnName("req_id");

                entity.Property(e => e.Val1)
                    .HasColumnName("val1")
                    .HasMaxLength(50);

                entity.Property(e => e.Val2)
                    .HasColumnName("val2")
                    .HasMaxLength(50);

                entity.Property(e => e.Val3)
                    .HasColumnName("val3")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PProductEfficiencyCollect>(entity =>
            {
                entity.HasKey(e => new { e.WorkshopCode, e.ProductCode, e.Years, e.Months, e.Days })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_Product_Efficiency_collect");

                entity.Property(e => e.WorkshopCode)
                    .HasColumnName("workshop_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Years)
                    .HasColumnName("years")
                    .HasMaxLength(10);

                entity.Property(e => e.Months)
                    .HasColumnName("months")
                    .HasMaxLength(10);

                entity.Property(e => e.Days)
                    .HasColumnName("days")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrSpt).HasColumnName("curr_spt");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(50);

                entity.Property(e => e.Spt).HasColumnName("spt");

                entity.Property(e => e.TotalQty)
                    .HasColumnName("Total_Qty")
                    .HasColumnType("decimal(10, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Weeks)
                    .HasColumnName("weeks")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<PProductionPlan>(entity =>
            {
                entity.ToTable("P_Production_Plan");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpCode)
                    .HasColumnName("emp_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("image");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.PanlTime)
                    .HasColumnName("panl_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PQcTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("P_QC_Template");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.ItemCode)
                    .HasColumnName("item_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasColumnName("process_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Standard)
                    .HasColumnName("standard")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PRework>(entity =>
            {
                entity.ToTable("P_Rework");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Applicants).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.NgItem)
                    .HasColumnName("NG_Item")
                    .HasMaxLength(50);

                entity.Property(e => e.Process).HasMaxLength(50);

                entity.Property(e => e.ProductType)
                    .HasColumnName("Product_type")
                    .HasMaxLength(50);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.ReworkLot)
                    .HasColumnName("Rework_lot")
                    .HasMaxLength(50);

                entity.Property(e => e.ReworkPerson)
                    .HasColumnName("Rework_Person")
                    .HasMaxLength(50);

                entity.Property(e => e.Workshop).HasMaxLength(50);
            });

            modelBuilder.Entity<PSfcAccessories>(entity =>
            {
                entity.ToTable("P_SFC_Accessories");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessoriesCode)
                    .HasColumnName("accessories_code")
                    .HasMaxLength(50);

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Sfc)
                    .HasColumnName("sfc")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<PSfcJude>(entity =>
            {
                entity.ToTable("P_SFC_Jude");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.JudeCode)
                    .HasColumnName("jude_code")
                    .HasMaxLength(50);

                entity.Property(e => e.JudeName)
                    .HasColumnName("jude_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Sfc)
                    .HasColumnName("sfc")
                    .HasMaxLength(60);

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<PSfcMachine>(entity =>
            {
                entity.ToTable("P_SFC_Machine");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(100);

                entity.Property(e => e.Sfc)
                    .HasColumnName("SFC")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PSfcProcessData>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_SFC_ProcessData");

                entity.HasIndex(e => e.OrderNo)
                    .HasName("IX_P_SFC_ORDER");

                entity.HasIndex(e => e.Sfc)
                    .HasName("IX_P_SFC_SN")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.Val);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClassCode)
                    .HasColumnName("class_code")
                    .HasMaxLength(30);

                entity.Property(e => e.EmpCode)
                    .HasColumnName("emp_code")
                    .HasMaxLength(30);

                entity.Property(e => e.FailTimes).HasColumnName("fail_times");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(50);

                entity.Property(e => e.PDate)
                    .HasColumnName("P_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pass).HasColumnName("pass");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Sfc)
                    .HasColumnName("SFC")
                    .HasMaxLength(60);

                entity.Property(e => e.StationCode)
                    .HasColumnName("station_code")
                    .HasMaxLength(30);

                entity.Property(e => e.StepId).HasColumnName("step_id");

                entity.Property(e => e.StepType)
                    .HasColumnName("step_type")
                    .HasMaxLength(20);

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(10);

                entity.Property(e => e.Val)
                    .HasColumnName("val")
                    .HasMaxLength(200);

                entity.Property(e => e.Workshop)
                    .HasColumnName("workshop")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PSfcProcessDataBack>(entity =>
            {
                entity.ToTable("P_SFC_ProcessData_Back");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fguid)
                    .HasColumnName("fguid")
                    .HasMaxLength(50);

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasMaxLength(30);

                entity.Property(e => e.NewVal)
                    .HasColumnName("New_val")
                    .HasMaxLength(40);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(40);

                entity.Property(e => e.PDate)
                    .HasColumnName("P_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(512);

                entity.Property(e => e.Sfc)
                    .HasColumnName("SFC")
                    .HasMaxLength(60);

                entity.Property(e => e.Val)
                    .HasColumnName("val")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PSfcProcessIolog>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_SFC_Process_IOLog");

                entity.HasIndex(e => e.InputTime)
                    .HasName("IX_P_SFC_Process_INPUT")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.OrderNo)
                    .HasName("IX_P_SFC_Process_Orderno");

                entity.HasIndex(e => e.Sfc)
                    .HasName("IX_P_SFC_Process_SFC");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClassCode)
                    .HasColumnName("class_code")
                    .HasMaxLength(30);

                entity.Property(e => e.EmpCode)
                    .HasColumnName("emp_code")
                    .HasMaxLength(30);

                entity.Property(e => e.FailTimes).HasColumnName("fail_times");

                entity.Property(e => e.GroupCode)
                    .HasColumnName("group_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Initqty)
                    .HasColumnName("initqty")
                    .HasColumnType("decimal(10, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(50);

                entity.Property(e => e.OutputTime)
                    .HasColumnName("output_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.PDate)
                    .HasColumnName("p_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pass).HasColumnName("pass");

                entity.Property(e => e.ProcessCode)
                    .HasColumnName("process_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Sfc)
                    .HasColumnName("SFC")
                    .HasMaxLength(60);

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.StationCode)
                    .HasColumnName("station_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Workshop)
                    .HasColumnName("workshop")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PSfcProcessSonData>(entity =>
            {
                entity.ToTable("P_SFC_ProcessSonData");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Back1).HasColumnName("back1");

                entity.Property(e => e.Back2)
                    .HasColumnName("back2")
                    .HasMaxLength(50);

                entity.Property(e => e.Inputtime)
                    .HasColumnName("inputtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isfedbatch).HasColumnName("isfedbatch");

                entity.Property(e => e.Orderno)
                    .IsRequired()
                    .HasColumnName("orderno")
                    .HasMaxLength(50);

                entity.Property(e => e.Parentstepid)
                    .IsRequired()
                    .HasColumnName("parentstepid")
                    .HasMaxLength(50);

                entity.Property(e => e.Sfc)
                    .IsRequired()
                    .HasColumnName("sfc")
                    .HasMaxLength(60);

                entity.Property(e => e.Stepconclude)
                    .HasColumnName("stepconclude")
                    .HasMaxLength(50);

                entity.Property(e => e.Stepid)
                    .IsRequired()
                    .HasColumnName("stepid")
                    .HasMaxLength(50);

                entity.Property(e => e.Steppre)
                    .HasColumnName("steppre")
                    .HasMaxLength(50);

                entity.Property(e => e.Stepval)
                    .HasColumnName("stepval")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PSfcRank>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_SFC_Rank");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChildQty)
                    .HasColumnName("child_qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.ChildSfc)
                    .HasColumnName("child_sfc")
                    .HasMaxLength(40);

                entity.Property(e => e.InputDate)
                    .HasColumnName("input_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotType).HasColumnName("lot_type");

                entity.Property(e => e.MainSfc)
                    .HasColumnName("main_sfc")
                    .HasMaxLength(40);

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(40);

                entity.Property(e => e.ParentQty)
                    .HasColumnName("parent_qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.ParentSfc)
                    .HasColumnName("parent_sfc")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<PSfcSparepart>(entity =>
            {
                entity.ToTable("P_SFC_Sparepart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Sfc)
                    .HasColumnName("SFC")
                    .HasMaxLength(100);

                entity.Property(e => e.SparepartCode)
                    .HasColumnName("sparepart_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PSfcState>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_SFC_State");

                entity.HasIndex(e => e.BeginTime)
                    .HasName("IX_P_SFC_State_date")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.Workshop, e.OrderNo })
                    .HasName("IX_P_SFC_State_order");

                entity.HasIndex(e => new { e.Workshop, e.Sfc })
                    .HasName("IX_P_SFC_State_sfc_shop");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BeginClasscode)
                    .HasColumnName("begin_classcode")
                    .HasMaxLength(30);

                entity.Property(e => e.BeginDate)
                    .HasColumnName("begin_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BeginTime)
                    .HasColumnName("begin_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndClasscode)
                    .HasColumnName("end_classcode")
                    .HasMaxLength(30);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.FailTimes)
                    .HasColumnName("fail_times")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FromProcess)
                    .HasColumnName("from_process")
                    .HasMaxLength(30);

                entity.Property(e => e.GradeId)
                    .HasColumnName("grade_id")
                    .HasMaxLength(50);

                entity.Property(e => e.GradeType)
                    .HasColumnName("grade_type")
                    .HasMaxLength(30);

                entity.Property(e => e.Initqty)
                    .HasColumnName("initqty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.InputStation)
                    .HasColumnName("input_station")
                    .HasMaxLength(30);

                entity.Property(e => e.IsTray).HasColumnName("is_tray");

                entity.Property(e => e.MainOrder)
                    .HasColumnName("main_order")
                    .HasMaxLength(50);

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasMaxLength(30);

                entity.Property(e => e.NowProcess)
                    .HasColumnName("now_process")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentOrder)
                    .HasColumnName("parent_order")
                    .HasMaxLength(50);

                entity.Property(e => e.ProcessTime)
                    .HasColumnName("process_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Sfc)
                    .HasColumnName("SFC")
                    .HasMaxLength(60);

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Workshop)
                    .HasColumnName("workshop")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PSfcStateCollect>(entity =>
            {
                entity.HasKey(e => new { e.WorkshopCode, e.LineId, e.ProductCode, e.Years, e.Months, e.Days })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_SFC_State_collect");

                entity.Property(e => e.WorkshopCode)
                    .HasColumnName("workshop_code")
                    .HasMaxLength(30);

                entity.Property(e => e.LineId).HasColumnName("line_id");

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Years)
                    .HasColumnName("years")
                    .HasMaxLength(10);

                entity.Property(e => e.Months)
                    .HasColumnName("months")
                    .HasMaxLength(10);

                entity.Property(e => e.Days)
                    .HasColumnName("days")
                    .HasMaxLength(10);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OutputQty)
                    .HasColumnName("output_qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(50);

                entity.Property(e => e.Weeks)
                    .HasColumnName("weeks")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<PSfcStateCp>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_SFC_State_cp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BeginTime)
                    .HasColumnName("begin_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.FailTimes).HasColumnName("fail_times");

                entity.Property(e => e.FromProcess)
                    .HasColumnName("from_process")
                    .HasMaxLength(30);

                entity.Property(e => e.GradeId).HasColumnName("grade_id");

                entity.Property(e => e.GradeType)
                    .HasColumnName("grade_type")
                    .HasMaxLength(30);

                entity.Property(e => e.InputStation)
                    .HasColumnName("input_station")
                    .HasMaxLength(30);

                entity.Property(e => e.IsTray).HasColumnName("is_tray");

                entity.Property(e => e.NowProcess)
                    .HasColumnName("now_process")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(30);

                entity.Property(e => e.ProcessTime)
                    .HasColumnName("process_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Sfc)
                    .HasColumnName("SFC")
                    .HasMaxLength(60);

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<PSparepartRecords>(entity =>
            {
                entity.ToTable("P_Sparepart_Records");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Downloadtime)
                    .HasColumnName("downloadtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Loadtime)
                    .HasColumnName("loadtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(50);

                entity.Property(e => e.OperatePerson)
                    .HasColumnName("operate_person")
                    .HasMaxLength(10);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(200);

                entity.Property(e => e.SparepartCode)
                    .HasColumnName("sparepart_code")
                    .HasMaxLength(50);

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<PSswPrintList>(entity =>
            {
                entity.ToTable("P_SSW_PrintList");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Completed)
                    .HasColumnName("completed")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.FinishTime)
                    .HasColumnName("finishTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.InputTime)
                    .HasColumnName("inputTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MainOrder)
                    .HasColumnName("Main_order")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasColumnName("order_no")
                    .HasMaxLength(40);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(40);

                entity.Property(e => e.ProductName)
                    .HasColumnName("product_name")
                    .HasMaxLength(40);

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId)
                    .HasColumnName("Template_id")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<PSswTemplateList>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("P_SSW_TemplateList");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("Template_id")
                    .HasMaxLength(30)
                    .ValueGeneratedNever();

                entity.Property(e => e.CheckCode).HasColumnName("checkCode");

                entity.Property(e => e.CurrentSn).HasColumnName("currentSN");

                entity.Property(e => e.FaxType).HasColumnName("faxType");

                entity.Property(e => e.InputTime)
                    .HasColumnName("inputTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaxSn).HasColumnName("maxSN");

                entity.Property(e => e.PrintCopies).HasColumnName("printCopies");

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ProductName)
                    .HasColumnName("product_name")
                    .HasMaxLength(30);

                entity.Property(e => e.RuleStr).HasMaxLength(50);

                entity.Property(e => e.SetZero)
                    .HasColumnName("setZero")
                    .HasMaxLength(10);

                entity.Property(e => e.TemplateName)
                    .HasColumnName("Template_name")
                    .HasMaxLength(30);

                entity.Property(e => e.TemplatePath).HasMaxLength(50);

                entity.Property(e => e.Variable)
                    .HasColumnName("variable")
                    .HasMaxLength(200);

                entity.Property(e => e.ZeroDate)
                    .HasColumnName("zeroDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PTrayDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_Tray_Detail");

                entity.HasIndex(e => new { e.Sfc, e.TraySfc })
                    .HasName("IX_P_Tray_Detail")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sfc)
                    .HasColumnName("sfc")
                    .HasMaxLength(40);

                entity.Property(e => e.TraySfc)
                    .HasColumnName("tray_sfc")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<PWipTransfer>(entity =>
            {
                entity.ToTable("P_WIP_Transfer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BillNo)
                    .HasColumnName("bill_no")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpCode)
                    .HasColumnName("emp_code")
                    .HasMaxLength(50);

                entity.Property(e => e.InputQty)
                    .HasColumnName("input_qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasColumnName("lot_no")
                    .HasMaxLength(50);

                entity.Property(e => e.LotQty)
                    .HasColumnName("lot_qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MatCode)
                    .HasColumnName("mat_code")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentOrder)
                    .HasColumnName("Parent_order")
                    .HasMaxLength(50);

                entity.Property(e => e.Workshop)
                    .HasColumnName("workshop")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PWorkDispatching>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_WorkDispatching");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CpltQty)
                    .HasColumnName("cplt_qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(40);

                entity.Property(e => e.DispatchingNo)
                    .HasColumnName("dispatching_no")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpCode)
                    .HasColumnName("emp_code")
                    .HasMaxLength(30);

                entity.Property(e => e.LinkNo)
                    .HasColumnName("link_no")
                    .HasMaxLength(40);

                entity.Property(e => e.MouldCode)
                    .HasColumnName("mould_code")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(40);

                entity.Property(e => e.PlannedCpltTime)
                    .HasColumnName("planned_cplt_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlannedStartDate)
                    .HasColumnName("planned_start_date")
                    .HasColumnType("date");

                entity.Property(e => e.PlannedStartTime)
                    .HasColumnName("planned_start_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.StationCode)
                    .HasColumnName("station_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PWorkOrder>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.OrderNo })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_WorkOrder");

                entity.HasIndex(e => e.PlannedTime)
                    .HasName("IX_P_WorkOrder")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(40);

                entity.Property(e => e.Co).HasColumnName("CO");

                entity.Property(e => e.Customer)
                    .HasColumnName("customer")
                    .HasMaxLength(30);

                entity.Property(e => e.EmpCode)
                    .HasColumnName("emp_code")
                    .HasMaxLength(50);

                entity.Property(e => e.FlowCode)
                    .HasColumnName("flow_code")
                    .HasMaxLength(30);

                entity.Property(e => e.FormulaCode)
                    .HasColumnName("formula_code")
                    .HasMaxLength(50);

                entity.Property(e => e.InputTime)
                    .HasColumnName("input_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lvl).HasColumnName("lvl");

                entity.Property(e => e.MainOrder)
                    .HasColumnName("main_order")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentOrder)
                    .HasColumnName("parent_order")
                    .HasMaxLength(40);

                entity.Property(e => e.PlannedTime)
                    .HasColumnName("planned_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Property).HasColumnName("property");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(50);

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Urgency).HasColumnName("urgency");

                entity.Property(e => e.WorkshopCode)
                    .HasColumnName("workshop_code")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PWorkOrderCollect>(entity =>
            {
                entity.HasKey(e => new { e.WorkshopCode, e.ProductCode, e.Years, e.Months, e.Days })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("P_WorkOrder_collect");

                entity.Property(e => e.WorkshopCode)
                    .HasColumnName("workshop_code")
                    .HasMaxLength(30);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("product_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Years)
                    .HasColumnName("years")
                    .HasMaxLength(10);

                entity.Property(e => e.Months)
                    .HasColumnName("months")
                    .HasMaxLength(10);

                entity.Property(e => e.Days)
                    .HasColumnName("days")
                    .HasMaxLength(10);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InputQty)
                    .HasColumnName("input_qty")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(50);

                entity.Property(e => e.Weeks)
                    .HasColumnName("weeks")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<SDepartment>(entity =>
            {
                entity.ToTable("S_Department");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DepartCode)
                    .HasColumnName("depart_code")
                    .HasMaxLength(30);

                entity.Property(e => e.DepartName)
                    .HasColumnName("depart_name")
                    .HasMaxLength(30);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<SDriveList>(entity =>
            {
                entity.HasKey(e => e.DriveId);

                entity.ToTable("S_DriveList");

                entity.Property(e => e.DriveId).HasColumnName("drive_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.DriveCode)
                    .HasColumnName("drive_code")
                    .HasMaxLength(30);

                entity.Property(e => e.DriveName)
                    .HasColumnName("drive_name")
                    .HasMaxLength(30);

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(30);

                entity.Property(e => e.IsPublic).HasColumnName("is_public");

                entity.Property(e => e.Property).HasColumnName("property");

                entity.Property(e => e.TypeId).HasColumnName("type_id");
            });

            modelBuilder.Entity<SEmpInRole>(entity =>
            {
                entity.ToTable("S_Emp_In_Role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmpCode)
                    .IsRequired()
                    .HasColumnName("emp_code")
                    .HasMaxLength(30);

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasColumnName("role_id")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SEmployee>(entity =>
            {
                entity.HasKey(e => e.EmpCode);

                entity.ToTable("S_Employee");

                entity.Property(e => e.EmpCode)
                    .HasColumnName("emp_code")
                    .HasMaxLength(30)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(30);

                entity.Property(e => e.DepartCode)
                    .HasColumnName("depart_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasColumnName("emp_name")
                    .HasMaxLength(10);

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.EntryDate)
                    .HasColumnName("entry_date")
                    .HasMaxLength(10);

                entity.Property(e => e.IsStaff).HasColumnName("is_staff");

                entity.Property(e => e.PassWprd)
                    .HasColumnName("pass_wprd")
                    .HasMaxLength(30);

                entity.Property(e => e.PhoneNum)
                    .HasColumnName("phone_num")
                    .HasMaxLength(20);

                entity.Property(e => e.Sex).HasColumnName("sex");
            });

            modelBuilder.Entity<SMenuDetail>(entity =>
            {
                entity.ToTable("S_MenuDetail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Icon)
                    .HasColumnName("icon")
                    .HasMaxLength(50);

                entity.Property(e => e.IsRoot).HasColumnName("is_root");

                entity.Property(e => e.Leaf).HasColumnName("leaf");

                entity.Property(e => e.LevelCode)
                    .HasColumnName("level_code")
                    .HasMaxLength(50);

                entity.Property(e => e.MenuId).HasColumnName("menu_id");

                entity.Property(e => e.MenuName)
                    .HasColumnName("menu_name")
                    .HasMaxLength(30);

                entity.Property(e => e.MenuType).HasColumnName("menu_type");

                entity.Property(e => e.ModuleCode).HasColumnName("module_code");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.SortVal).HasColumnName("sort_val");
            });

            modelBuilder.Entity<SModule>(entity =>
            {
                entity.HasKey(e => e.ModuleCode);

                entity.ToTable("S_Module");

                entity.Property(e => e.ModuleCode).HasColumnName("module_code");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasColumnName("module_name")
                    .HasMaxLength(30);

                entity.Property(e => e.ModuleType).HasColumnName("module_type");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SModuleInRole>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("S_Module_In_Role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModuleCode).HasColumnName("module_code");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasColumnName("role_id")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SPreStep>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("S_PreStep");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DriveCode)
                    .IsRequired()
                    .HasColumnName("drive_code")
                    .HasMaxLength(30);

                entity.Property(e => e.Parameter)
                    .HasColumnName("parameter")
                    .HasMaxLength(60);

                entity.Property(e => e.ProcessCode)
                    .IsRequired()
                    .HasColumnName("process_code")
                    .HasMaxLength(30);

                entity.Property(e => e.SortVal).HasColumnName("sort_val");
            });

            modelBuilder.Entity<SRole>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("S_Role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasColumnName("role_id")
                    .HasMaxLength(20);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("role_name")
                    .HasMaxLength(20);
            });
        }
    }
}
