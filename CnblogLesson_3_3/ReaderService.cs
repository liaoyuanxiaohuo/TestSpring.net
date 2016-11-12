using System;
using Spring.Context;
using Spring.Context.Support;
using Spring.Core.IO;
using Spring.Objects.Factory.Xml;
using Spring.Objects.Factory;

namespace CnblogLesson_3_3
{
    /// <summary>
    /// 读取文章的业务逻辑类
    /// </summary>
    public class ReaderService : IReaderService
    {
        /// <summary>
        /// 读取文章的数据访问类对象
        /// </summary>
        private IReaderDAL dal;

        public ReaderService()
        {
            /*是通过XmlObjectFactory或者是IApplicationContext来配置可以二者选其一*/

            //或者是通过XmlObjectFactory配置
            //IResource input = new FileSystemResource("file:///C:/Objects.xml");
            //IObjectFactory factory = new XmlObjectFactory(input);
            //dal = (IReaderDAL)factory.GetObject("readerDal");

            //通过IApplicationContext来配置
            IApplicationContext context = ContextRegistry.GetContext();
            dal = (IReaderDAL)context.GetObject("readerDal");
        }

        /// <summary>
        /// 读者的名字
        /// </summary>
        private string Name { get; set; }

        /// <summary>
        /// 读取文章的方法
        /// </summary>
        public void GetArticle()
        {
            dal.GetArticle();
        }
    }
}
