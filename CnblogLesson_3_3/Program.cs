using System;

namespace CnblogLesson_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /**  CnblogLesson_3_3 是使用传统方式创建应用程序*/
            IReaderService service = new ReaderService();
            service.GetArticle();

            Console.ReadKey();

        }
    }
}
