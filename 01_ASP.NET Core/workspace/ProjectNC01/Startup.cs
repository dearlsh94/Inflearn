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

namespace ProjectNC01
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /**
        * IServiceCollection is Container. 의존성 주입. 
        **/
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /**
        * HTTP Web 요청 수신 시 어떻게 처리 할 지 정의
        **/
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            /**
            * App 실행 시 .NET Core 에서 정적 파일을 자동으로 읽은 뒤 index.html 이 실행되도록 해주는 미들웨어
            **/
            app.UseStaticFiles(); 

            app.UseRouting();

            app.UseAuthorization();

            /**
            * MVC 환경설정 - URL 패턴 설정
            * {controller=[ControllerName]}/{action=Index} : Web 도메인으로 접속 시 첫 화면 설정. HomeController의 Index View
            * {id?} : 접미어에 ? 를 붙여 선택적 파라미터로 설정.
            **/
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Student}/{action=Index}/{id?}");
            });
        }
    }
}
