using System;

namespace CnblogLesson_3_3
{
    class Program
    {
        /// <summary>
        /// 测试
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /**  CnblogLesson_3_3 是使用传统方式创建应用程序*/
            IReaderService service = new ReaderService();
            service.GetArticle();

            Console.ReadKey();

        }
    }
}
