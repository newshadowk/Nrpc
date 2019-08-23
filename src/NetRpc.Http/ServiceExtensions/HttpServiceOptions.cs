﻿
namespace NetRpc.Http
{
    public sealed class HttpServiceOptions
    {
        /// <summary>
        /// Api root path, like '/api', default value is null.
        /// </summary>
        public string ApiRootPath { get; set; }

        /// <summary>
        /// If pass StackTrace to client, default value is false.
        /// </summary>
        public bool IsClearStackTrace { get; set; }

        /// <summary>
        /// Set true will pass to next middleware when not match the method, default value is false.
        /// </summary>
        public bool IgnoreWhenNotMatched { get; set; }

        /// <summary>
        /// If support callback/cancel, default value is true.
        /// </summary>
        public bool SupportCallbackAndCancel { get; set; } = true;
    }
}