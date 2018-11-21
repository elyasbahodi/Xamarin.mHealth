using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.Core
{
    class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            CreatableTypes()
                .EndingWith("Repository")
                .AsInterfaces()
                .RegisterAsLazySingleton();

                CreatableTypes()
                    .EndingWith("Services")
                    .AsInterfaces()
                    .RegisterAsLazySingleton();

            RegisterAppStart(new AppStart());
        }


    }
}
