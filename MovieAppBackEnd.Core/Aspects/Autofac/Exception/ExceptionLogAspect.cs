using System;
using System.Collections.Generic;
using Castle.DynamicProxy;
using MovieAppBackEnd.Core.CrossCuttingConcerns.Logging;
using MovieAppBackEnd.Core.CrossCuttingConcerns.Logging.Log4Net;
using MovieAppBackEnd.Core.Utilities.Interceptors;
using MovieAppBackEnd.Core.Utilities.Messages;

namespace MovieAppBackEnd.Core.Aspects.Autofac.Exception
{
    public class ExceptionLogAspect : MethodInterception
    {
        private LoggerServiceBase _loggerServiceBase;

        public ExceptionLogAspect(Type loggerService)
        {
            if (loggerService.BaseType != typeof(LoggerServiceBase))
            {
                throw new SystemException(AspectMessages.WrongLoggerType);
            }

            _loggerServiceBase = (LoggerServiceBase) Activator.CreateInstance(loggerService);
        }

        protected override void OnException(IInvocation invocation, System.Exception e)
        {
            LogDetailWithException logDetailWithException = GetLogDetail(invocation);
            logDetailWithException.ExceptionMessage = e.Message;
            _loggerServiceBase.Error(logDetailWithException);
        }

        private LogDetailWithException GetLogDetail(IInvocation invocation)
        {
            var logParameters = new List<LogParameter>();
            for (int i = 0; i < invocation.Arguments.Length; i++)
            {
                logParameters.Add(new LogParameter
                {
                    Name = invocation.GetConcreteMethod().GetParameters()[i].Name,
                    Value = invocation.Arguments[i],
                    Type = invocation.Arguments[i].GetType().Name
                });
            }

            var logDetailWithException = new LogDetailWithException
            {
                MethodName = invocation.Method.Name,
                LogParameters = logParameters,
                DateTime = DateTime.Now
            };

            return logDetailWithException;
        }
    }
}