using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace _493907_LazarishinArtur_opt.Models
{
    public class ResultViewModel
    {
        public DataViewModel data;

        public ResultViewModel(DataViewModel dataViewModel)
        {
            this.data = dataViewModel;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }


        public bool SolverRun()
        {
            var fileName = "Book.xlsm";

            var path = Path.Combine(Environment.CurrentDirectory, @"", fileName);

            Excel.Application app = new Excel.Application();

            try
            {

                app.Workbooks.Open(path);
                app.ScreenUpdating = false;
                Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets["Data"];

                app.Run((object)"Оптимизация");
                app.ScreenUpdating = true;

                D3 = (double)sheet.Range["C17"].Value;
                D4 = (double)sheet.Range["C18"].Value;
                D5 = (double)sheet.Range["C19"].Value;

                X1 = (double)sheet.Range["C29"].Value;
                X2 = (double)sheet.Range["C30"].Value;
                X3 = (double)sheet.Range["C31"].Value;

                Sum_X = (double)sheet.Range["C32"].Value;
                Cel = (double)sheet.Range["C34"].Value;
                LinKoefTepl = (double)sheet.Range["C37"].Value;
                TeplPotok = (double)sheet.Range["C38"].Value;
                T_narPovIzl = (double)sheet.Range["C39"].Value;
                RazT = (double)sheet.Range["C40"].Value;


            }
            catch { }
            finally
            {
                app.Quit();
            }

            
            return true;

        }

        public double D3 { get; set; }
        public double D4 { get; set; }
        public double D5 { get; set; }

        public double X1 { get; set; }
        public double X2 { get; set; }
        public double X3 { get; set; }

        public double Sum_X { get; set; }

        public double Cel { get; set; }
        public double LinKoefTepl { get; set; }
        public double TeplPotok { get; set; }
        public double T_narPovIzl { get; set; }
        public double RazT { get; set; }


        //public double D3 { get => data.D_vne + 2 * X1; }
        //public double D4 { get => D3 + 2 * X2; }
        //public double D5 { get => D4 + 2 * X3; }


        //public double Sum_X { get => X1 + X2 + X3; }

        //public double Cel
        //{
        //    get => 3.14 * data.StoOne * X1 * (X1 + data.D_vne) + 3.14 * data.StoTwo * X2 * (X2 + data.D_vne + 2 * X1) + 3.14 * data.StoThree * X3 * (X3 + data.D_vne + 2 * X1 + 2 * X2);


        //}

        //public double LinKoefTepl
        //{
        //    get
        //    {
        //        return 1 / (1 / (data.KoefTeplo_vn * data.D_vnu) + 1 * Math.Log(data.D_vne / data.D_vnu) / (2 * data.KoefTeMatTr) + Math.Log(D3 / data.D_vne) / (2 * data.KoefTeOneMatIzl) + Math.Log(D4 / D3) / (2 * data.KoefTeTwoMatIzl) + Math.Log(D5 / D4) / (2 * data.KoefTeThreeMatIzl) + 1 / (data.KoefTeplo_nar * D4));
        //    }
        //}



        //public double TeplPotok
        //{
        //    get
        //    {
        //        return 3.14 * LinKoefTepl * (data.T_gid - data.T_okr);
        //    }
        //}

        //public double T_narPovIzl
        //{
        //    get
        //    {
        //        return data.T_okr + 3.14 / (TeplPotok * data.KoefTeplo_nar * D5);
        //    }
        //}
        //public double RazT
        //{
        //    get
        //    {
        //        return data.T_nar - (data.T_okr + (data.T_gid - data.T_okr) / (data.KoefTeplo_nar * (data.D_vne + 2 * X1 + 2 * X2 + 2 * X3) * (1 / (data.KoefTeplo_vn * data.D_vnu) + Math.Log(data.D_vne / data.D_vnu) / (2 * data.KoefTeMatTr) + Math.Log((data.D_vne + 2 * X1) / data.D_vne) / (2 * data.KoefTeOneMatIzl) + Math.Log((data.D_vne + 2 * X1 + 2 * X2) / (data.D_vne + 2 * X1)) / (2 * data.KoefTeTwoMatIzl) + Math.Log((data.D_vne + 2 * X1 + 2 * X2 + 2 * X3) / (data.D_vne + 2 * X1 + 2 * X2)) / (2 * data.KoefTeThreeMatIzl) + 1 / (data.KoefTeplo_nar * (data.D_vne + 2 * X1 + 2 * X2 + 2 * X3)))));
        //    }
        //}

        //public bool SolverRun2()
        //{

        //    Solver solver = Solver.CreateSolver("GLOP");

        //    Variable x1 = solver.MakeNumVar(0.0, double.PositiveInfinity, "x1");
        //    Variable x2 = solver.MakeNumVar(0.0, double.PositiveInfinity, "x2");
        //    Variable x3 = solver.MakeNumVar(0.0, double.PositiveInfinity, "x3");

        //    solver.Add(x1 + x2 + x3 <= data.SumTolUzl);

        //    solver.Add(data.T_nar - (data.T_okr + (data.T_gid - data.T_okr) / (data.KoefTeplo_nar * (data.D_vne + 2 * x1 + 2 * x2 + 2 * x3) * (1 / (data.KoefTeplo_vn * data.D_vnu) + Math.Log(data.D_vne / data.D_vnu) / (2 * data.KoefTeMatTr) + Math.Log((data.D_vne + 2 * x1.SolutionValue()) / data.D_vne) / (2 * data.KoefTeOneMatIzl) + (Math.Log(data.D_vne + 2 * x1.SolutionValue() + 2 * x2.SolutionValue()) - Math.Log(data.D_vne + 2 * x1.SolutionValue())) / (2 * data.KoefTeTwoMatIzl) + Math.Log((data.D_vne + 2 * x1.SolutionValue() + 2 * x2.SolutionValue() + 2 * x3.SolutionValue()) / (data.D_vne + 2 * x1.SolutionValue() + 2 * x2.SolutionValue())) / (2 * data.KoefTeThreeMatIzl) + 1 / (data.KoefTeplo_nar * (data.D_vne + 2 * x1.SolutionValue() + 2 * x2.SolutionValue() + 2 * x3.SolutionValue()))))) >= 0);

        //    solver.Minimize((3.14 * data.StoOne * x1 * 2 + 3.14 * data.StoOne * x1 * data.D_vne) + x2 * (3.14 * data.StoTwo * 2 + 3.14 * data.StoTwo * data.D_vne + x1 * 3.14 * data.StoTwo * 2) + 3.14 * data.StoThree * x3 * (x3 + data.D_vne + 2 * x1 + 2 * x2));

        //    Solver.ResultStatus resultStatus = solver.Solve();

        //    //Cel = Math.Round(solver.Objective().Value(), 0);

        //    X1 = Math.Round(x1.SolutionValue(), 0);
        //    X2 = Math.Round(x2.SolutionValue(), 0);
        //    X3 = Math.Round(x3.SolutionValue(), 0);

        //    //if (resultStatus == Solver.ResultStatus.OPTIMAL)
        //    //{
        //    //    dataViewModel.IsRes = true;
        //    //    return true;
        //    //}

        //    //else
        //    //{
        //    //    dataViewModel.IsRes = false;
        //    //    return false;
        //    //}



        //    //    return true;

        //    //}
    }
}
