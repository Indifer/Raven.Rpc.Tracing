﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Rpc.Tracing
{
    /// <summary>
    /// 
    /// </summary>
    public static class Config
    {
        //public const string TraceClientSRQueueName = "raven_trace_csr";
        //public const string TraceServerRSQueueName = "raven_trace_srs";
        /// <summary>
        /// 
        /// </summary>
        //public const string TraceLogsQueueNameV1 = "raven_trace_logs";
        
        /// <summary>
        /// 
        /// </summary
        public static readonly string TraceLogsQueueName = "raven_trace_logs_v3";

        /// <summary>
        /// 
        /// </summary>
        public static readonly string SystemLogsQueueName = "raven_sys_logs";

        /// <summary>
        /// 
        /// </summary>
        //public const string ServerRSKey = "__raven_ServerRS";

        #region TraceLogs Extensions

        /// <summary>
        /// 
        /// </summary>
        public const string ExceptionKey = "Exception";
        /// <summary>
        /// 
        /// </summary>
        public const string ParamsKey = "Params";

        /// <summary>
        /// 
        /// </summary>
        public const string FormKey = "Form";

        /// <summary>
        /// 
        /// </summary>
        public const string ResultKey = "Result";

        #endregion

        #region ResponseHeader

        /// <summary>
        /// 
        /// </summary>
        public const string ResponseHeaderTraceKey = "R-TraceId";

        /// <summary>
        /// 
        /// </summary>
        public const string ResponseHeaderFolderKey = "R-RootFolder";

        ///// <summary>
        ///// 
        ///// </summary>
        //public const string ResponseHeaderNonTracingKey = "R-NonTracing";

        #endregion

    }
}
