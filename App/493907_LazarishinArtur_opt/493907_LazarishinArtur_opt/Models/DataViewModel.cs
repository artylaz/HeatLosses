using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _493907_LazarishinArtur_opt.Models
{
    public class DataViewModel
    {
        public bool IsRes { get; set; } = true;

        #region Коэффициент теплопроводности,Вт/(мС)

        public double KoefTeMatTr { get; set; }

        public double KoefTeOneMatIzl { get; set; }
        public double KoefTeTwoMatIzl { get; set; }
        public double KoefTeThreeMatIzl { get; set; }
        #endregion

        #region Стоимость материала изоляции,усл.ед./м3

        public double StoOne { get; set; }
        public double StoTwo { get; set; }
        public double StoThree { get; set; }

        #endregion

        #region Суммарная толщина изоляции,м

        public double SumTolUzl { get; set; }

        #endregion

        #region Диаметр трубы,м

        public double D_vnu { get; set; }

        public double D_vne { get; set; }

        #endregion

        #region Температура,С

        public double T_okr { get; set; }
        public double T_gid { get; set; }
        public double T_nar { get; set; }

        #endregion

        #region Козффициент теплоотдачи,Вт/ м2С

        public double KoefTeplo_vn { get; set; }
        public double KoefTeplo_nar { get; set; }

        #endregion
    }
}
