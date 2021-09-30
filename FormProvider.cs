using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRisingSun
{
    class FormProvider
    {
        private static FrmMain _frmMain;
        public static FrmMain FrmMain
        {
            get
            {
                if (_frmMain == null)
                {
                    _frmMain = new FrmMain();
                }
                return _frmMain;
            }
        }

        private static FrmDrinks _frmDrinks;
        public static FrmDrinks FrmDrinks
        {
            get
            {
                if (_frmDrinks == null)
                {
                    _frmDrinks = new FrmDrinks();
                }

                return _frmDrinks;
            }
        }

        private static FrmDisplayDrinks _frmDisplayDrinks;
        public static FrmDisplayDrinks FrmDisplayDrinks
        {
            get
            {
                if (_frmDisplayDrinks == null)
                {
                    _frmDisplayDrinks = new FrmDisplayDrinks();
                }
                return _frmDisplayDrinks;
            }
        }
    }
}