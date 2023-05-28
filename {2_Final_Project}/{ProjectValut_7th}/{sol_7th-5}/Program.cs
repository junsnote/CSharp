using Excel = Microsoft.Office.Interop.Excel;

string savePath = System.IO.Directory.GetCurrentDirectory();

string[,] array = new string[,]
{
	{"Visual C++ 2022 MFC 프로그래밍", "2022" },
	{"이것이 C# 프로그래밍이다.", "2021" }
};

Console.WriteLine("Creating Excel document in old way...");
OldWay(array, savePath);

Console.WriteLine("Creating Excel document in New way...");
NewWay(array, savePath);

partial class Program
{
	public static void OldWay(string[,] data, string savePath)
	{
		Excel.Application excelApp = new Excel.Application();

		excelApp.Workbooks.Add(Type.Missing);

		Excel.Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

		for (int i = 0; i < data.GetLength(0); i++)
		{
			((Excel.Range)workSheet.Cells[i + 1, 1]).Value2 = data[i, 0];
			((Excel.Range)workSheet.Cells[i + 1, 2]).Value2 = data[i, 1];
		}
		workSheet.SaveAs(savePath +  "\\old.xlsx",
			Type.Missing,
			Type.Missing,
			Type.Missing,
			Type.Missing,
			Type.Missing,
			Type.Missing,
			Type.Missing,
			Type.Missing);
		excelApp.Quit();
	}
	public static void NewWay(string[,] data, string savePath)
	{
		Excel.Application excelApp = new Excel.Application();
		excelApp.Workbooks.Add();
		Excel._Worksheet workSheet = excelApp.ActiveSheet;

		for (int i = 0; i < data.GetLength(0); i++)
		{
			workSheet.Cells[i + 1, 1] = data[i, 0];
			workSheet.Cells[i + 1, 2] = data[i, 1];
		}
		workSheet.SaveAs(savePath + "\\dynamic.xlsx");
		excelApp.Quit();
	}
}