using System;
using System.Collections.Generic;
using System.Text;

namespace TestWPF.Models
{
    public static class NameAndNumberExercisesbyqualities
    {

        #region Force
        private static List<Name_Exercises> _ForceExercisesNameAndNumber = new List<Name_Exercises>()
        {
            new Name_Exercises() {Number="1",Name="Сгибание рагибание рук в упоре лежа" },
               new Name_Exercises() {Number="2",Name="Наклоны туловища вперед" },
               new Name_Exercises() {Number="4",Name= "Подтягивание на перекладине" },
               new Name_Exercises() {Number="5",Name= "Поднимание ног к перекладине" },
              new Name_Exercises() {Number= "6",Name= "Подъем переворотом на перекладине" },
               new Name_Exercises() {Number="7",Name= "Подъем силой на перекладине" },
                new Name_Exercises() {Number="8(1)",Name= "Жим штанги лежа,вес штанги 70 кг \n до 70 кг" },
                 new Name_Exercises() {Number="8(2)",Name= "Жим штанги лежа,вес штанги 70 кг \n свыше 70 кг" },
                 new Name_Exercises() {Number="9",Name = "Сгибание и разгибание рук в упоре на брусьях" },
                 new Name_Exercises() {Number="10",Name= "Угол в упоре на брусьях" },
                 new Name_Exercises() {Number="11(1)",Name= "Рывок гири, вес 24 кг \n до 70 кг" },
                 new Name_Exercises() {Number="11(2)",Name= "рывок гири, вес 24 кг \n свыше 70 кг" },
                 new Name_Exercises() {Number="12(1)",Name= "толчок двух гирь, вес 24 кг \n до 70 кг" },
                 new Name_Exercises() {Number="12(2)",Name= "толчок двух гирь, вес 24 кг \n свыше 70 кг" },
                 new Name_Exercises() {Number="13(1)",Name= "толчок двух гирь, вес 24 кг \n до 70 кг" },
                 new Name_Exercises() {Number="13(2)",Name= "толчок двух гирь, вес 24 кг \n свыше 70 кг" }
        };
       

        /// <summary>
        /// Название упражнений на СИЛУ. номер и название
        /// </summary>
        public static List<Name_Exercises> ForceExercisesNameAndNumber { get => _ForceExercisesNameAndNumber; }
        #endregion


        #region Speed
        private static List<Name_Exercises> _SpeedExercisesNameAndNumber = new List<Name_Exercises>()
        {
             new Name_Exercises() {Number="40",Name= "Бег на 60 м" },
             new Name_Exercises() {Number="41",Name= "Бег на 100 м" },
             new Name_Exercises() {Number="42",Name="Челночный бег 10 х 10 м" },
             new Name_Exercises() {Number="43",Name= "Бег на 400 м" },
             new Name_Exercises() {Number="57",Name="Плавание на 100 м вольным стилем" },
             new Name_Exercises() {Number="57(a)",Name= "Плавание на 50 м вольным стилем" },
             new Name_Exercises() {Number="58",Name="Плавание на 100 м способом брасс" },
        };

        /// <summary>
        /// Название упражнений на БЫСТРОТУ. номер и название
        /// </summary>
        public static List<Name_Exercises> SpeedExercisesNameAndNumber { get => _SpeedExercisesNameAndNumber; }
        #endregion

        #region Endurance
        private static List<Name_Exercises> _EnduranceExercisesNameAndNumber = new List<Name_Exercises>()
        {
            new Name_Exercises() {Number="45(1)",Name="Бег на 1 км \n до 35 лет" },
            new Name_Exercises() {Number="45(2)",Name="Бег на 1 км \n свыше 35 лет" },
            new Name_Exercises() {Number="46(1)",Name="Бег на 3 км \n до 35 лет" },
            new Name_Exercises() {Number="46(2)",Name="Бег на 3 км \n свыше 35 лет" },
            new Name_Exercises() {Number="47",Name="Бег на 5 км" },
            new Name_Exercises() {Number="48",Name="Марш-бросок на 5 км"},
            new Name_Exercises() {Number="49",Name="Марш-бросок на 10 км" },
            new Name_Exercises() {Number="53",Name="Лыжная гонка на 5 км" },
        };

        /// <summary>
        /// Название упражнений на ВЫНОСЛИВОСТЬ. номер и название
        /// </summary>
        public static List<Name_Exercises> EnduranceExercisesNameAndNumber { get => _EnduranceExercisesNameAndNumber; }
        #endregion

    }
}
