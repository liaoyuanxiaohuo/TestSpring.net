using System;

namespace CnblogLesson_3_3
{
    /// <summary>
    /// 读取文章的数据访问类
    /// </summary>
    public class ReaderDAL : IReaderDAL
    {
        /// <summary>
        /// 读取文章的方法
        /// </summary>
        public void GetArticle()
        {
            Console.WriteLine("使用传统方式来取得博客园Spring.Net系列的博文");
        }
    }
}
