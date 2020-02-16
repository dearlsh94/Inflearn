using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectNC01.Data.Repositories;

namespace ProjectNC01
{
    public class Startup
    {
        /*
         * appsettings.json에 설정 된 정보를 Startup Class에 setting
         */
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /*
         * IServiceCollection is Container. 의존성 주입. 
         */
        public void ConfigureServices(IServiceCollection services)
        {
            /* 
            services.AddDbContext<ProjectNC01Context>(options => {
                options.UseSqlServer(configuration.GetConnectionString("ProjectNC01Context"));
            });
            */

            /*
             * DbSeeder Class를 IServiceCollection에 추가하는 작업
             * AddTransient : 필요할 때 마다 생성되는 서비스. 캐시 등에 저장되어 있지 않음. 보존되지 않음.
             *      DbSeeder의 경우 Web App 생명 주기 중 한 번만 실행되기 때문에 해당 사용방식이 적합.
             *      Configure 함수에 매개변수로 전달.
             * AddScoped : HTTP 요청이 들어 올 경우, 해당 HTTP 내에서 계속 재사용. 
                    데이터 접근 컴포넌트에서 많이 사용.
             * AddSingleton : Web App 생명 주기 중 단 한번만 생성, HTTP 요청이 올 때마다 같은 인스턴스 사용.
                    정적 데이터 메모리 저장이 필요할 경우 사용.
             
            services.AddTransient<DbSeeder>();
            */
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            

            /*
             * Identity 관리
             * Identity<IUser, IRole>
             
            services.AddIdentity<ApplicationUser, IdentityRole>(options => 
            {
                // Password, 계정 잠금 등 옵션 설정 가능
                options.Password.RequriedLength = 6;
            })
            .AddEntityFramwork<Stores<ProjectNC01Context>();
            */

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /*
         * HTTP Web 요청 수신 시 어떻게 처리 할 지 정의
         */
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) //, DbSeeder seeder)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            /*
             * App 실행 시 .NET Core 에서 정적 파일을 자동으로 읽은 뒤 index.html 이 실행되도록 해주는 미들웨어
             */
            app.UseStaticFiles(); 

            app.UseRouting();

            /*
             * 인증 기능 활성화. 반드시 MVC 환경설정 보다 위에 위치해야 함.
             */
            app.UseAuthorization();

            /*
             * MVC 환경설정 - URL 패턴 설정
             * {controller=[ControllerName]}/{action=Index} : Web 도메인으로 접속 시 첫 화면 설정. HomeController의 Index View
             * {id?} : 접미어에 ? 를 붙여 선택적 파라미터로 설정.
             */
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");
            });

            // seeder.SeedDatabase().Wait();
        }
    }
}
