using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.GPA
{
    public class RGPA
    {
        #region fields 
        int iErrorCode;             //Код ошибки
        int isDynamic;              //Режим - 0 стационар, 1 - нестационар
        bool bLocal = false;        //Режим лок. задач - true
                                    //Параметры связи с GUI
        string? sPrefix;            //Префикс для определения ГПА в цеху
        RDGPA D;
        #endregion
        #region constructors
        public RGPA()
        {
            D = new RDGPA(); //создаем объект данных GPA
		    sPrefix="";
		    iErrorCode=0;
		    isDynamic=0;
        }
    #endregion
}
}
