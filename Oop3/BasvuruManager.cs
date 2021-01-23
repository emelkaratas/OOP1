using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //başvuru bilgilerini degerlendirme
            //
            //kredi hesapla
            
            krediManager.Hesapla();
            loggerService.Log();

        }foreach (var item in collection)
	{

	}

        public void KrediOnBilgilendiremsiYap(List<IKrediManager> krediler)
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        internal void BasvuruYap(object taksitKrediManager, ILoggerService fileLoggerService)
        {
            throw new NotImplementedException();
        }
    }    
}
