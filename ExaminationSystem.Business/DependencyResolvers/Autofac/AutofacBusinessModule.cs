using Autofac;
using Autofac.Extras.DynamicProxy;
using ExaminationSystem.Business.Abstract;
using ExaminationSystem.Business.Concrete;
using Castle.DynamicProxy;
using ExaminationSystem.Core.Utilities.Interceptors;
using ExaminationSystem.Core.Utilities.Security.JWT;
using ExaminationSystem.DataAccess.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using ExaminationSystem.DataAccess.Concrete;

namespace ExaminationSystem.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<ExamManager>().As<IExamService>();
            builder.RegisterType<EfExamDal>().As<IExamDal>();

            builder.RegisterType<UserExamManager>().As<IUserExamService>();
            builder.RegisterType<EfUserExamDal>().As<IUserExamDal>();

            builder.RegisterType<QuestionManager>().As<IQuestionService>();
            builder.RegisterType<EfQuestionDal>().As<IQuestionDal>();

            builder.RegisterType<ChoiceManager>().As<IChoiceService>();
            builder.RegisterType<EfChoiceDal>().As<IChoiceDal>();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
