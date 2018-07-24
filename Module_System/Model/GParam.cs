using log4net;
using Moon.Orm;
using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Componet;
using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.ConstDef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign.Module_System.Model
{
    public class GParam : IDataBaseFactory
    {
        #region 单例模式
        private static GParam m_Param;

        public static GParam Create()
        {
            if (m_Param == null)
                m_Param = new GParam();
            return m_Param;
        }

        #endregion

        /// <summary>
        /// 获取用于输出系统日志的Logger
        /// </summary>
        public ILog SystemLogger
        {
            get
            {
                return log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            }
        }
        /// <summary>
        /// 写入异常日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="ex">异常信息</param>
        public void WriteSystemLog(string message, Exception ex)
        {
            SystemLogger.Debug(message, ex);
        }

        public void WriteSystemLog(string message)
        {
            SystemLogger.Debug(message);
        }
        /// <summary>
        /// 开启默认数据库连接
        /// </summary>
        /// <returns></returns>
        public Db OpenDefalutDataBase()
        {
            return Db.CreateDbByConfigName(DBConst.DBConfigName);
        }

        //调停者，用于统一管理UI组件的相互操作
        private UIMediator mMediator;
        /// <summary>
        /// 调停者，用于统一管理UI组件的相互操作
        /// </summary>
        public UIMediator Mediator
        {
            get
            {
                if (mMediator == null)
                    mMediator = new UIMediator();
                return mMediator;
            }
        }
    }
}
