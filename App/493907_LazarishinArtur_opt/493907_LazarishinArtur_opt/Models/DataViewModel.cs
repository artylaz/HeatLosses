using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace _493907_LazarishinArtur_opt.Models
{
    public class DataViewModel
    {
        public bool IsRes { get; set; } = true;

        #region Коэффициент теплопроводности,Вт/(мС)
        [Required(ErrorMessage = "Не указано значение")]
        [Range(0.001, 1000, ErrorMessage = "Значение должно быть больше 0 и не более 1000")]
        public double KoefTeMatTr { get; set; }
        [Required(ErrorMessage = "Не указано значение")]
        [Range(0.001, 1000, ErrorMessage = "Значение должно быть больше 0 и не более 1000")]
        public double KoefTeOneMatIzl { get; set; }
        [Required(ErrorMessage = "Не указано значение")]
        [Range(0.001, 1000, ErrorMessage = "Значение должно быть больше 0 и не более 1000")]
        public double KoefTeTwoMatIzl { get; set; }
        [Required(ErrorMessage = "Не указано значение")]
        [Range(0.001, 1000, ErrorMessage = "Значение должно быть больше 0 и не более 1000")]
        public double KoefTeThreeMatIzl { get; set; }
        #endregion

        #region Стоимость материала изоляции,усл.ед./м3
        [Required(ErrorMessage = "Не указано значение")]
        [Range(1, 1000000, ErrorMessage = "Значение должно быть не менее 1 и не более 1000000")]
        public double StoOne { get; set; }
        [Required(ErrorMessage = "Не указано значение")]
        [Range(1, 1000000, ErrorMessage = "Значение должно быть не менее 1 и не более 1000000")]
        public double StoTwo { get; set; }
        [Required(ErrorMessage = "Не указано значение")]
        [Range(1, 1000000, ErrorMessage = "Значение должно быть не менее 1 и не более 1000000")]
        public double StoThree { get; set; }

        #endregion

        #region Суммарная толщина изоляции,м
        [Required(ErrorMessage = "Не указано значение")]
        [Range(0.001, 1000000, ErrorMessage = "Значение должно быть не менее 0.001 и не более 1000000")]
        public double SumTolUzl { get; set; }

        #endregion

        #region Диаметр трубы,м
        [Required(ErrorMessage = "Не указано значение")]
        [Range(0.001, 1000000, ErrorMessage = "Значение должно быть не менее 0.001 и не более 1000000")]
        public double D_vnu { get; set; }
        [Required(ErrorMessage = "Не указано значение")]
        [Range(0.001, 1000000, ErrorMessage = "Значение должно быть не менее 0.001 и не более 1000000")]
        public double D_vne { get; set; }

        #endregion

        #region Температура,С
        [Required(ErrorMessage = "Не указано значение")]
        [Range(-273, 1000000, ErrorMessage = "Значение должно быть не менее -273 и не более 1000000")]
        public double T_okr { get; set; }
        [Required(ErrorMessage = "Не указано значение")]
        [Range(-273, 1000000, ErrorMessage = "Значение должно быть не менее -273 и не более 1000000")]
        public double T_gid { get; set; }
        [Required(ErrorMessage = "Не указано значение")]
        [Range(-273, 1000000, ErrorMessage = "Значение должно быть не менее -273 и не более 1000000")]
        public double T_nar { get; set; }

        #endregion

        #region Козффициент теплоотдачи,Вт/ м2С
        [Required(ErrorMessage = "Не указано значение")]
        [Range(0.001, 1000000, ErrorMessage = "Значение должно быть не менее 0.001 и не более 1000000")]
        public double KoefTeplo_vn { get; set; }
        [Required(ErrorMessage = "Не указано значение")]
        [Range(0.001, 1000000, ErrorMessage = "Значение должно быть не менее 0.001 и не более 1000000")]
        public double KoefTeplo_nar { get; set; }

        #endregion
    }
}
