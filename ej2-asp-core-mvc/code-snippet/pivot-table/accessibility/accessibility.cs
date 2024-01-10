public ActionResult Index()
{
    ViewBag.data = GetPivot_Data();
    ViewBag.drilledMembersProduct = new string[] { "Bike", "Car" };
    ViewBag.drilledMembersGender = new string[] { "male" };
    ViewBag.filterSettingsEyeColor = new string[] { "blue" };
    ViewBag.toolbar = new string[]
    {
        "New", "Save", "SaveAs", "Rename", "Remove", "Load", "Grid", "Chart", "Export", "SubTotal", "GrandTotal", "ConditionalFormatting", "NumberFormatting", "FieldList"
    };
    ViewBag.contextMenuItems = new string[]
    {
        "Aggregate", "CalculatedField", "Drillthrough", "Excel Export", "Pdf Export", "Csv Export", "Expand", "Collapse", "Sort Ascending", "Sort Descending"
    };
    return View();
}

public class Pivot_Data
{
    public string _id { get; set; }
    public int index { get; set; }
    public string guid { get; set; }
    public Boolean isActive { get; set; }
    public Double balance { get; set; }
    public int advance { get; set; }
    public int quantity { get; set; }
    public int age { get; set; }
    public string eyeColor { get; set; }
    public string name { get; set; }
    public string gender { get; set; }
    public string company { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string date { get; set; }
    public string product { get; set; }
    public string state { get; set; }
    public string pno { get; set; }
}

public List<Pivot_Data> GetPivot_Data()
{
    List<Pivot_Data> pivot_Data = new List<Pivot_Data>();
    pivot_Data.Add(new Pivot_Data{ _id = "5a940692c2d185d9fde50e5e", index = 0, guid = "810a1191-81bd-4c18-ac73-d16ad3fc80eb", isActive = false, balance = 2430.87, advance = 7658, quantity = 11, age = 21, eyeColor = "blue", name = "Skinner Ward", gender = "male", company = "GROK", email = "skinnerward@grok.com", phone = "+1 (931) 600-3042", date = "Wed Feb 16 2000 15:01:01 GMT+0530 (India Standard Time)", product = "Flight", state = "New Jercy", pno = "FEDD2340" });
    pivot_Data.Add(new Pivot_Data{ _id = "5a940692c5752f1ed81bbb3d", index = 1, guid = "41c9986b-ccef-459e-a22d-5458bbdca9c7", isActive = true, balance = 3192.7, advance = 6124, quantity = 15, age = 27, eyeColor = "brown", name = "Gwen Dixon", gender = "female", company = "ICOLOGY", email = "gwendixon@icology.com", phone = "+1 (951) 589-2187", date = "Sun Feb 10 1991 20:28:59 GMT+0530 (India Standard Time)", product = "Jet", state = "Vetaikan", pno = "ERTS4512" });
    pivot_Data.Add(new Pivot_Data{ _id = "5a9406924c0e7f4c98a82ca7", index = 2, guid = "50d2bf16-9092-4202-84f6-e892721fe5a5", isActive = true, balance = 1663.84, advance = 7631, quantity = 14, age = 28, eyeColor = "green", name = "Deena Gillespie", gender = "female", company = "OVERPLEX", email = "deenagillespie@overplex.com", phone = "+1 (826) 588-3430", date = "Thu Mar 18 1993 17:07:48 GMT+0530 (India Standard Time)", product = "Car", state = "New Jercy", pno = "ERTS4512" });
    pivot_Data.Add(new Pivot_Data{ _id = "5a940692dd9db638eee09828", index = 3, guid = "b8bdc65e-4338-440f-a731-810186ce0b3a", isActive = true, balance = 1601.82, advance = 6519, quantity = 18, age = 33, eyeColor = "green", name = "Susanne Peterson", gender = "female", company = "KROG", email = "susannepeterson@krog.com", phone = "+1 (868) 499-3292", date = "Sat Feb 09 2002 04:28:45 GMT+0530 (India Standard Time)", product = "Jet", state = "Vetaikan", pno = "CCOP1239" });
    pivot_Data.Add(new Pivot_Data{ _id = "5a9406926f9971a87eae51af", index = 4, guid = "3f4c79ec-a227-4210-940f-162ca0c293de", isActive = false, balance = 1855.77, advance = 7333, quantity = 20, age = 33, eyeColor = "green", name = "Stokes Hicks", gender = "male", company = "SIGNITY", email = "stokeshicks@signity.com", phone = "+1 (927) 585-2980", date = "Fri Mar 12 2004 11:08:06 GMT+0530 (India Standard Time)", product = "Van", state = "Tamilnadu", pno = "MEWD9812" });
    pivot_Data.Add(new Pivot_Data{ _id = "5a940692bcbbcdde08fcf7ec", index = 5, guid = "1d0ee387-14d4-403e-9a0c-3a8514a64281", isActive = true, balance = 1372.23, advance = 5668, quantity = 16, age = 39, eyeColor = "green", name = "Sandoval Nicholson", gender = "male", company = "IDEALIS", email = "sandovalnicholson@idealis.com", phone = "+1 (951) 438-3539", date = "Sat Aug 30 1975 22:02:15 GMT+0530 (India Standard Time)", product = "Bike", state = "Tamilnadu", pno = "CCOP1239" });
    pivot_Data.Add(new Pivot_Data{ _id = "5a940692ff31a6e1cdd10487", index = 6, guid = "58417d45-f279-4e21-ba61-16943d0f11c1", isActive = false, balance = 2008.28, advance = 7107, quantity = 14, age = 20, eyeColor = "brown", name = "Blake Thornton", gender = "male", company = "IMMUNICS", email = "blakethornton@immunics.com", phone = "+1 (852) 462-3571", date = "Mon Oct 03 2005 05:16:53 GMT+0530 (India Standard Time)", product = "Jet", state = "New Jercy", pno = "CCOP1239" });
    pivot_Data.Add(new Pivot_Data{ _id = "5a9406928f2f2598c7ac7809", index = 7, guid = "d16299e3-e243-4e57-90fb-52446c4c0275", isActive = false, balance = 2052.58, advance = 7431, quantity = 20, age = 22, eyeColor = "blue", name = "Dillard Sharpe", gender = "male", company = "INEAR", email = "dillardsharpe@inear.com", phone = "+1 (963) 473-2308", date = "Thu May 25 1978 04:57:00 GMT+0530 (India Standard Time)", product = "Jet", state = "Rajkot", pno = "ERTS4512" });
    pivot_Data.Add(new Pivot_Data{ _id = "5a940692195f82585af58362", index = 8, guid = "a8662b61-9d66-4b99-8a47-c0375ffff4ce", isActive = true, balance = 2784.64, advance = 7948, quantity = 18, age = 22, eyeColor = "blue", name = "Davidson Brewer", gender = "male", company = "PROXSOFT", email = "davidsonbrewer@proxsoft.com", phone = "+1 (958) 592-3948", date = "Wed Jul 14 1982 19:49:29 GMT+0530 (India Standard Time)", product = "Van", state = "Vetaikan", pno = "FEDD2340" });
    return pivot_Data;
}