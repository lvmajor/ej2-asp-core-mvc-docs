public IActionResult ServerSideExporting()
{
    var order = TreeData.GetDefaultData();
    ViewBag.dataSource = order;
    return View();
}

public IActionResult ExcelExport(string treeGridModel)
{
    if (treeGridModel == null)
    {
        return View();
    }
    TreeGridExcelExport exp = new TreeGridExcelExport();
    Syncfusion.EJ2.TreeGrid.TreeGrid gridProperty = ConvertTreeGridObject(treeGridModel);
    return exp.ExportToExcel<TreeData>(gridProperty, TreeData.GetDefaultData());
}
private Syncfusion.EJ2.TreeGrid.TreeGrid ConvertTreeGridObject(string gridProperty)
{
    Syncfusion.EJ2.TreeGrid.TreeGrid TreeGridModel = (Syncfusion.EJ2.TreeGrid.TreeGrid)Newtonsoft.Json.JsonConvert.DeserializeObject(gridProperty, typeof(Syncfusion.EJ2.TreeGrid.TreeGrid));
    TreeGridColumnModel cols = (TreeGridColumnModel)Newtonsoft.Json.JsonConvert.DeserializeObject(gridProperty, typeof(TreeGridColumnModel));
    TreeGridModel.Columns = cols.columns;
    return TreeGridModel;
}

public class TreeGridColumnModel
{
    public List<TreeGridColumn> columns { get; set; }
}